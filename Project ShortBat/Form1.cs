using OfficeOpenXml;
using Project_ShortBat.Models;
using System.IO;
using System.Windows.Forms.VisualStyles;
using Project_ShortBat.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Reflection;
using MethodInvoker = System.Windows.Forms.MethodInvoker;

namespace Project_ShortBat
{
    public partial class Form1 : MaterialForm
    {
        private string destinationFolderPath;
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple900, Primary.Grey900, Primary.Purple700, Accent.Purple700, TextShade.WHITE);
            cantEspecies.Enabled = false;
            enableLimit.Enabled = false;

            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            versionLabel.Text = $"Ver. {version}";

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            destinationFolderPath = Path.Combine(desktopPath, "Output");
        }
        private void buttonSelectDestinationFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                destinationFolderPath = folderBrowserDialog.SelectedPath;
                MessageBox.Show($"Carpeta de destino seleccionada: {destinationFolderPath}");
            }
        }
        private void buttonLoadExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                matrix.Clear();
                ProcessExcelFile(filePath);
            }
        }
        private void ProcessExcelFile(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            List<Murcielago> murcielagos = new List<Murcielago>();

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();

                if (worksheet != null)
                {
                    int rowCount = worksheet.Dimension.Rows;
                    int colCount = worksheet.Dimension.Columns;
                    int carpetaColumnIndex = -1;
                    int especieColumnIndex = -1;
                    int audioColumnIndex = -1;

                    // Encuentra los índices de columna para "PUNTO", "AUTO ID*" y "IN FILE"
                    for (int col = 1; col <= colCount; col++)
                    {
                        string columnName = worksheet.Cells[1, col].Text.Trim(); // Suponiendo que los encabezados están en la primera fila
                        if (columnName == "PUNTO")
                        {
                            carpetaColumnIndex = col;
                        }
                        else if (columnName == "AUTO ID*")
                        {
                            especieColumnIndex = col;
                        }
                        else if (columnName == "IN FILE")
                        {
                            audioColumnIndex = col;
                        }
                    }

                    if (carpetaColumnIndex == -1 || especieColumnIndex == -1 || audioColumnIndex == -1)
                    {
                        MessageBox.Show("No se encontraron columnas necesarias (PUNTO, AUTO ID* o IN FILE) en el archivo Excel.");
                        return;
                    }

                    // Procesar las filas y crear instancias de Murcielago
                    for (int row = 2; row <= rowCount; row++) // Comenzamos desde la fila 2, asumiendo que la fila 1 son los encabezados
                    {
                        string carpeta = worksheet.Cells[row, carpetaColumnIndex].Text.Trim();
                        string especie = worksheet.Cells[row, especieColumnIndex].Text.Trim();
                        string audio = worksheet.Cells[row, audioColumnIndex].Text.Trim();

                        if (!string.IsNullOrWhiteSpace(audio) && especie != "Noise")
                        {
                            murcielagos.Add(new Murcielago
                            {
                                Carpeta = carpeta,
                                Especie = especie,
                                Audio = audio
                            });
                        }
                    }
                }
            }

            // Llamar a método para copiar archivos
            CopyFilesToFolder(murcielagos);
        }



        private void CopyFilesToFolder(List<Murcielago> murcielagos)
        {
            string sourceFolderPath = SelectSourceFolder();
            if (sourceFolderPath == null)
            {
                return; // Salir si no se seleccionó una carpeta de origen
            }

            CreateDestinationFolder();

            PrepareProgressBar(murcielagos.Count);

            Dictionary<string, int> especiesCount = new Dictionary<string, int>();

            int copiedFiles = 0;

            foreach (Murcielago murcielago in murcielagos)
            {
                string[] foundFiles = Directory.GetFiles(sourceFolderPath, murcielago.Audio, SearchOption.AllDirectories);
                if (foundFiles.Length > 0)
                {
                    foreach (string foundFile in foundFiles)
                    {
                        string subFolderPath = GetSubFolderPath(murcielago);

                        if (IsExceedingSpeciesLimit(murcielago, especiesCount))
                        {
                            UpdateStatusRichTextBox(murcielago.Audio, true, true, true);
                            continue;
                        }

                        string destinationFilePath = Path.Combine(subFolderPath, Path.GetFileName(foundFile));

                        try
                        {
                            File.Copy(foundFile, destinationFilePath, true);
                            UpdateSpeciesCount(murcielago, especiesCount);
                            UpdateStatusRichTextBox(murcielago.Audio, true, true);
                            copiedFiles++;
                        }
                        catch (Exception)
                        {
                            UpdateStatusRichTextBox(murcielago.Audio, true, false);
                        }
                    }
                }
                else
                {
                    UpdateStatusRichTextBox(murcielago.Audio, false, false);
                }

                materialProgressBar1.Value = Math.Min(materialProgressBar1.Value + 1, materialProgressBar1.Maximum);
            }

            MessageBox.Show(copiedFiles > 0 ? $"Se han copiado {copiedFiles} archivos de {murcielagos.Count}." : "No se han encontrado archivos.");
        }

        private string SelectSourceFolder()
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    return folderBrowserDialog.SelectedPath;
                }
            }
            return null;
        }

        private void CreateDestinationFolder()
        {
            if (!Directory.Exists(destinationFolderPath))
            {
                Directory.CreateDirectory(destinationFolderPath);
            }
        }

        private void PrepareProgressBar(int itemCount)
        {
            materialProgressBar1.Minimum = 0;
            materialProgressBar1.Maximum = itemCount;
            materialProgressBar1.Value = 0;
        }

        private string GetSubFolderPath(Murcielago murcielago)
        {
            string subFolderPath = destinationFolderPath;

            if (subFileSwitch.Checked)
            {
                subFolderPath = Path.Combine(destinationFolderPath, murcielago.Carpeta);
                if (!Directory.Exists(subFolderPath))
                {
                    Directory.CreateDirectory(subFolderPath);
                }
            }

            if (especiesSwitch.Checked)
            {
                subFolderPath = Path.Combine(subFolderPath, murcielago.Especie);
                if (!Directory.Exists(subFolderPath))
                {
                    Directory.CreateDirectory(subFolderPath);
                }
            }

            return subFolderPath;
        }

        private bool IsExceedingSpeciesLimit(Murcielago murcielago, Dictionary<string, int> especiesCount)
        {
            if (!especiesSwitch.Checked || !enableLimit.Checked)
            {
                return false;
            }

            string key = subFileSwitch.Checked ? $"{murcielago.Especie}-{murcielago.Carpeta}" : murcielago.Especie;

            if (!especiesCount.ContainsKey(key))
            {
                especiesCount[key] = 0;
            }

            if (especiesCount[key] >= cantEspecies.Value)
            {
                return true;
            }

            return false;
        }

        private void UpdateSpeciesCount(Murcielago murcielago, Dictionary<string, int> especiesCount)
        {
            if (!especiesSwitch.Checked || !enableLimit.Checked)
            {
                return;
            }

            string key = subFileSwitch.Checked ? $"{murcielago.Especie}-{murcielago.Carpeta}" : murcielago.Especie;

            especiesCount[key]++;
        }


        private void UpdateStatusRichTextBox(string fileName, bool found, bool success, bool limit = false)
        {
            matrix.Invoke((MethodInvoker)delegate
            {
                matrix.SelectionStart = matrix.TextLength;
                matrix.SelectionLength = 0;
                matrix.SelectionFont = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);

                // Configuración de colores predeterminada
                Color fileNameColor = Color.FromArgb(165, 127, 248);
                Color arrowColor = Color.FromArgb(165, 107, 196);
                Color messageColor;
                string message;

                if (limit)
                {
                    messageColor = Color.FromArgb(255, 165, 0);
                    message = " Límite de especie alcanzado";
                }
                else if (found)
                {
                    if (success)
                    {
                        messageColor = Color.FromArgb(0, 255, 127);
                        message = " Archivo copiado con éxito";
                    }
                    else
                    {
                        messageColor = Color.FromArgb(217, 108, 104);
                        message = " Error al copiar el archivo \u2715";
                    }
                }
                else
                {
                    messageColor = Color.FromArgb(255, 99, 71);
                    message = " Archivo no encontrado";
                }

                // Aplicar colores y texto
                matrix.SelectionColor = fileNameColor;
                matrix.AppendText(fileName);
                matrix.SelectionColor = arrowColor;
                matrix.AppendText(" \u2192");
                matrix.SelectionColor = messageColor;
                matrix.AppendText(message + Environment.NewLine);

                // Restablecer color y desplazar caret
                matrix.SelectionColor = matrix.ForeColor;
                matrix.SelectionStart = matrix.Text.Length;
                matrix.ScrollToCaret();
            });
        }


        private void especiesSwitch_CheckedChanged(object sender, EventArgs e)
        {
            enableLimit.Enabled = !enableLimit.Enabled;
            enableLimit.Checked = false;
        }

        private void enableLimit_CheckedChanged(object sender, EventArgs e)
        {
            cantEspecies.Enabled = !cantEspecies.Enabled;
        }
    }
}

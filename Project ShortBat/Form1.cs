using OfficeOpenXml;
using Project_ShortBat.Models;
using System.IO;
using System.Windows.Forms.VisualStyles;
using Project_ShortBat.Models;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Project_ShortBat
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple900, Primary.Grey900, Primary.Purple700, Accent.Purple700, TextShade.WHITE);
        }

        private void buttonLoadExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ProcessExcelFile(filePath);
                if (checkSubCarpetas.Checked)
                {

                }
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
            // Seleccionar la carpeta de origen
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceFolderPath = folderBrowserDialog.SelectedPath;

                // Carpeta de destino (en el escritorio, por ejemplo)
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string destinationFolderPath = Path.Combine(desktopPath, "patata");

                // Crear la carpeta de destino si no existe
                if (!Directory.Exists(destinationFolderPath))
                {
                    Directory.CreateDirectory(destinationFolderPath);
                }

                // Actualizar visualmente el estado inicial en el RichTextBox para todos los murcielagos
                int copiedFiles = 0;
                int totalFiles = 0;
                foreach (Murcielago murcielago in murcielagos)
                {
                    totalFiles++;
                    string[] foundFiles = Directory.GetFiles(sourceFolderPath, murcielago.Audio, SearchOption.AllDirectories);
                    if (foundFiles.Length > 0)
                    {
                        foreach (string foundFile in foundFiles)
                        {
                            string destinationFilePath = Path.Combine(destinationFolderPath, Path.GetFileName(foundFile));

                            try
                            {
                                File.Copy(foundFile, destinationFilePath, true);
                                UpdateStatusRichTextBox(murcielago.Audio, true, true); // Marcar como encontrado (verde)
                                copiedFiles++;
                            }
                            catch (Exception ex)
                            {
                                UpdateStatusRichTextBox(murcielago.Audio, true, false); // Marcar como error (rojo)
                            }
                        }
                    }
                    else
                    {
                        UpdateStatusRichTextBox(murcielago.Audio, false, false); // Marcar como no encontrado (gris)
                    }
                }
                MessageBox.Show(copiedFiles > 0 ? $"Se han copiado {copiedFiles} archivos de {totalFiles}." : "No se han encontrado archivos.");
            }
        }

        private void UpdateStatusRichTextBox(string fileName, bool found, bool success)
        {
            matrix.Invoke((MethodInvoker)delegate
            {
                matrix.SelectionStart = matrix.TextLength;
                matrix.SelectionLength = 0;
                matrix.SelectionFont = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);

                if (found)
                {
                    if (success)
                    {
                        matrix.SelectionColor = Color.FromArgb(165, 127, 248);
                        matrix.AppendText(fileName);
                        matrix.SelectionColor = Color.FromArgb(165, 107, 196);
                        matrix.AppendText(" \u2192");
                        matrix.SelectionColor = Color.FromArgb(0, 255, 127);
                        matrix.AppendText(" Archivo copiado con éxito" + Environment.NewLine);
                    }
                    else
                    {
                        matrix.SelectionColor = Color.FromArgb(165, 127, 248);
                        matrix.AppendText(fileName);
                        matrix.SelectionColor = Color.FromArgb(165, 107, 196);
                        matrix.AppendText(" \u2192");
                        matrix.SelectionColor = Color.FromArgb(217, 108, 104);
                        matrix.AppendText(" KO \u2715" + Environment.NewLine);
                    }
                }
                else
                {
                    matrix.SelectionColor = Color.FromArgb(165, 127, 248);
                    matrix.AppendText(fileName);
                    matrix.SelectionColor = Color.FromArgb(165, 107, 196);
                    matrix.AppendText(" \u2192");
                    matrix.SelectionColor = Color.FromArgb(255, 99, 71);
                    matrix.AppendText(" Archivo no encontrado" + Environment.NewLine);
                }

                matrix.SelectionColor = matrix.ForeColor; // Reset color
                matrix.SelectionStart = matrix.Text.Length;
                matrix.ScrollToCaret();
            });
        }
    }
}

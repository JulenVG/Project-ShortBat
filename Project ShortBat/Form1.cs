using OfficeOpenXml;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace Project_ShortBat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoadExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ProcessExcelFile(filePath);
            }
        }
        private void ProcessExcelFile(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            List<string> fileNamesToCopy = new List<string>();

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();

                if (worksheet != null)
                {
                    int rowCount = worksheet.Dimension.Rows;
                    int colCount = worksheet.Dimension.Columns;
                    int autoIdColumnIndex = -1;
                    int inFileColumnIndex = -1;

                    // Encuentra los índices de columna para "AUTO ID" y "IN FILE"
                    for (int col = 1; col <= colCount; col++)
                    {
                        string columnName = worksheet.Cells[1, col].Text.Trim(); // Suponiendo que los encabezados están en la primera fila
                        if (columnName == "AUTO ID*")
                        {
                            autoIdColumnIndex = col;
                        }
                        else if (columnName == "IN FILE")
                        {
                            inFileColumnIndex = col;
                        }
                    }

                    if (autoIdColumnIndex == -1 || inFileColumnIndex == -1)
                    {
                        MessageBox.Show("No se encontraron columnas necesarias (AUTO ID o IN FILE) en el archivo Excel.");
                        return;
                    }

                    // Procesar las filas y filtrar según los criterios
                    for (int row = 2; row <= rowCount; row++) // Comenzamos desde la fila 2, asumiendo que la fila 1 son los encabezados
                    {
                        string autoId = worksheet.Cells[row, autoIdColumnIndex].Text.Trim();
                        string inFile = worksheet.Cells[row, inFileColumnIndex].Text.Trim();

                        if (!string.IsNullOrWhiteSpace(inFile) && autoId != "Noise")
                        {
                            fileNamesToCopy.Add(inFile);
                        }
                    }
                }
            }

            // Llamar a método para copiar archivos
            CopyFilesToFolder(fileNamesToCopy);
        }

        private void CopyFilesToFolder(List<string> fileNames)
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

                // Iterar sobre cada archivo en fileNames
                foreach (string fileName in fileNames)
                {
                    string[] foundFiles = Directory.GetFiles(sourceFolderPath, fileName, SearchOption.AllDirectories);

                    // Actualizar visualmente el estado en el TextBox
                    UpdateStatusRichTextBox(fileName, foundFiles.Length > 0);

                    foreach (string foundFile in foundFiles)
                    {
                        string destinationFilePath = Path.Combine(destinationFolderPath, Path.GetFileName(foundFile));

                        // Verificar si el archivo existe antes de copiarlo
                        if (File.Exists(foundFile))
                        {
                            try
                            {
                                File.Copy(foundFile, destinationFilePath, true);
                                UpdateStatusRichTextBox(fileName, true, true); // Marcar como encontrado (verde)
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error al copiar el archivo '{foundFile}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                UpdateStatusRichTextBox(fileName, true, false); // Marcar como error (rojo)
                            }
                        }
                        else
                        {
                            UpdateStatusRichTextBox(fileName, false, false); // Marcar como no encontrado (rojo)
                        }
                    }
                }

                MessageBox.Show("Archivos copiados correctamente a la carpeta 'patata' en el escritorio.");
            }
        }
        private void UpdateStatusRichTextBox(string fileName, bool found, bool success = false)
        {
            matrix.Invoke((MethodInvoker)delegate {
                matrix.SelectionStart = matrix.TextLength;
                matrix.SelectionLength = 0;

                if (found)
                {
                    if (success)
                    {
                        matrix.SelectionColor = Color.Green;
                        matrix.AppendText(fileName + " OK" + Environment.NewLine);
                    }
                    else
                    {
                        matrix.SelectionColor = Color.Red;
                        matrix.AppendText(fileName + " KO" + Environment.NewLine);
                    }
                }
                else
                {
                    matrix.SelectionColor = Color.Gray;
                    matrix.AppendText(fileName + " No encontrado" + Environment.NewLine);
                }

                matrix.SelectionColor = matrix.ForeColor; // Reset color
                matrix.SelectionStart = matrix.Text.Length;
                matrix.ScrollToCaret();
            });
        }

    }
}

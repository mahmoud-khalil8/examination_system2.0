using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.UserControls;

namespace WindowsFormsApp1.BusinessLogic
{
    public class SaveExcel
    {
        public static void SaveDataTableToExcel(DataTable dataTable, string filePath)
        {
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                FileInfo fileInfo = new FileInfo(filePath);
                using (ExcelPackage package = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                    int colIndex = 1;
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        worksheet.Cells[1, colIndex].Value = column.ColumnName;
                        colIndex++;
                    }

                    int rowIndex = 2;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        colIndex = 1;
                        foreach (var item in row.ItemArray)
                        {
                            worksheet.Cells[rowIndex, colIndex].Value = item?.ToString() ?? "";
                            colIndex++;
                        }
                        rowIndex++;
                    }

                    worksheet.Cells.AutoFitColumns();

                    package.Save();
                }

                MessageBox.Show("Excel file saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving to Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}

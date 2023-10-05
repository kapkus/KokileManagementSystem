using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Kokile.Database
{
    public class KokilaDataGridView
    {
        private DataGridView dataGridView;
        private string dbFilePath;
        private SQLiteManager sqliteManager;
        private DataTable originalDataTable;

        public KokilaDataGridView(DataGridView dataGridView, string dbFilePath)
        {
            this.dataGridView = dataGridView;
            this.dbFilePath = dbFilePath;

            dataGridView.AutoGenerateColumns = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;

            sqliteManager = new SQLiteManager(dbFilePath);
        }

        public bool LoadDataFromDatabase()
        {

            try
            {
                originalDataTable = sqliteManager.GetAllKokilaRecords();

                originalDataTable.Columns.Add("previewId", typeof(int));

                int idCounter = 1;
                foreach (DataRow row in originalDataTable.Rows)
                {
                    row["previewId"] = idCounter++;
                }

                originalDataTable.DefaultView.Sort = "id DESC";
                dataGridView.DataSource = originalDataTable;
                dataGridView.Columns["previewId"].DisplayIndex = 0;
                dataGridView.Columns["id"].Visible = false;
                return true;
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void AddRecord(string[] data)
        {
            try
            {
                sqliteManager.InsertKokilaRecord(data);
                LoadDataFromDatabase();
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ModifyRecord(string[] data)
        {
            try
            {
                sqliteManager.UpdateKokilaRecord(data);
                LoadDataFromDatabase();
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteRecord(int rowIndex)
        {
            try
            {
                sqliteManager.DeleteKokilaRecord(rowIndex);
                LoadDataFromDatabase();
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ApplyFilter(string filterText)
        {
            if (originalDataTable != null)
            {
                DataTable filteredDataTable = originalDataTable.Clone();

                filterText = filterText.ToLower();

                foreach (DataRow row in originalDataTable.Rows)
                {
                    bool found = false;

                    foreach (var item in row.ItemArray)
                    {
                        string cellValue = item.ToString().ToLower();

                        if (cellValue.Contains(filterText))
                        {
                            found = true;
                            break;
                        }
                    }

                    if (found)
                    {
                        filteredDataTable.ImportRow(row);
                    }
                }
                dataGridView.DataSource = filteredDataTable;
            }
        }
    }
}

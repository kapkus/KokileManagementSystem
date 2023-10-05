using System;
using System.Data;
using System.Windows.Forms;

namespace Kokile.Forms
{
    public partial class RadlistForm : Form
    {
        private DataTable originalDataTable;
        private SQLiteManager sqliteManager;
        public RadlistForm(string databasePath)
        {
            InitializeComponent();
            sqliteManager = new SQLiteManager(databasePath);
            LoadDataToRadlist();
        }

        public void LoadDataToRadlist() 
        {
            try
            {
                originalDataTable = sqliteManager.GetAllRadlistRecords();
                originalDataTable.DefaultView.Sort = "barcodeId ASC";
                dataGridView.DataSource = originalDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                string barcodeId = selectedRow.Cells["barcodeId"].Value.ToString();
                string kokilaName = selectedRow.Cells["kokila"].Value.ToString();
      
                string[] rowValues = { barcodeId, kokilaName };
                string currentBarcodeId = barcodeId;

                using (EditRadlistRow editRadlistRow = new EditRadlistRow(rowValues))
                {
                    if (editRadlistRow.ShowDialog() == DialogResult.OK)
                    {
                        string[] editedData = editRadlistRow.EditedData;

                        try
                        {
                            sqliteManager.UpdateRadlistRecord(currentBarcodeId, editedData); 
                            LoadDataToRadlist();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                int barcodeId = Convert.ToInt32(selectedRow.Cells["barcodeId"].Value);
                string kokilaName = selectedRow.Cells["kokila"].Value.ToString();
                DialogResult result = MessageBox.Show($"Czy na pewno chcesz usunąć barcode {barcodeId}?", "Potwierdzenie", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    try
                    {
                        sqliteManager.DeleteRadlistRecord(barcodeId, kokilaName);
                        LoadDataToRadlist();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void filterInput_TextChanged(object sender, EventArgs e)
        {
            string searchCriteria = filterInput.Text;
            ApplyFilter(searchCriteria);
        }

        private void ApplyFilter(string filterText)
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

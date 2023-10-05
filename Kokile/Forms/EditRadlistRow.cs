using System;
using System.Windows.Forms;

namespace Kokile.Forms
{
    public partial class EditRadlistRow : Form
    {
        public string[] EditedData { get; internal set; }

        public EditRadlistRow(string[] rowValues)
        {
            InitializeComponent();
            FillForm(rowValues);

        }

        private void FillForm(string[] rowValues)
        {
            barcodeIdNumeric.Text = rowIndexLabel.Text = rowValues[0];
            kokilaInput.Text = rowValues[1];
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            EditedData = new string[] { barcodeIdNumeric.Text, kokilaInput.Text };
            DialogResult = DialogResult.OK;
            Close();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

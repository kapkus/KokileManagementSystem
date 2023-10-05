
namespace Kokile.Forms
{
    partial class EditRadlistRow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rowIndexLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kokilaInput = new System.Windows.Forms.TextBox();
            this.barcodeIdLabel = new System.Windows.Forms.Label();
            this.kokilaLabel = new System.Windows.Forms.Label();
            this.barcodeIdNumeric = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeIdNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // rowIndexLabel
            // 
            this.rowIndexLabel.AutoSize = true;
            this.rowIndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rowIndexLabel.Location = new System.Drawing.Point(121, 9);
            this.rowIndexLabel.Name = "rowIndexLabel";
            this.rowIndexLabel.Size = new System.Drawing.Size(73, 20);
            this.rowIndexLabel.TabIndex = 15;
            this.rowIndexLabel.Text = "rowIndex";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Edycja wiersza ";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(276, 97);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Anuluj";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(195, 97);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Zapisz";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.53392F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.46608F));
            this.tableLayoutPanel1.Controls.Add(this.kokilaInput, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.barcodeIdLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kokilaLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.barcodeIdNumeric, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(339, 59);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // kokilaInput
            // 
            this.kokilaInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.kokilaInput.Location = new System.Drawing.Point(75, 34);
            this.kokilaInput.Name = "kokilaInput";
            this.kokilaInput.Size = new System.Drawing.Size(261, 20);
            this.kokilaInput.TabIndex = 6;
            // 
            // barcodeIdLabel
            // 
            this.barcodeIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.barcodeIdLabel.AutoSize = true;
            this.barcodeIdLabel.Location = new System.Drawing.Point(3, 8);
            this.barcodeIdLabel.Name = "barcodeIdLabel";
            this.barcodeIdLabel.Size = new System.Drawing.Size(66, 13);
            this.barcodeIdLabel.TabIndex = 0;
            this.barcodeIdLabel.Text = "Barcode Id:";
            // 
            // kokilaLabel
            // 
            this.kokilaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.kokilaLabel.AutoSize = true;
            this.kokilaLabel.Location = new System.Drawing.Point(3, 37);
            this.kokilaLabel.Name = "kokilaLabel";
            this.kokilaLabel.Size = new System.Drawing.Size(66, 13);
            this.kokilaLabel.TabIndex = 1;
            this.kokilaLabel.Text = "Kokila:";
            // 
            // barcodeIdNumeric
            // 
            this.barcodeIdNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodeIdNumeric.Location = new System.Drawing.Point(75, 3);
            this.barcodeIdNumeric.Maximum = new decimal(new int[] {
            2147483646,
            0,
            0,
            0});
            this.barcodeIdNumeric.Name = "barcodeIdNumeric";
            this.barcodeIdNumeric.Size = new System.Drawing.Size(261, 20);
            this.barcodeIdNumeric.TabIndex = 7;
            // 
            // EditRadlistRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 125);
            this.Controls.Add(this.rowIndexLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditRadlistRow";
            this.Text = "Edycja wiersza";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeIdNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rowIndexLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox kokilaInput;
        private System.Windows.Forms.Label barcodeIdLabel;
        private System.Windows.Forms.Label kokilaLabel;
        private System.Windows.Forms.NumericUpDown barcodeIdNumeric;
    }
}
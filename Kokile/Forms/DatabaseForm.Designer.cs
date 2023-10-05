
namespace Kokile.Forms
{
    partial class DatabaseForm
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
            this.databaseGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.changeDbBtn = new System.Windows.Forms.Button();
            this.dbPathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.createDatabaseBtn = new System.Windows.Forms.Button();
            this.statusTxt = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.filterInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backupDatabaseBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.databaseGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // databaseGridView
            // 
            this.databaseGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.databaseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databaseGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.databaseGridView.Location = new System.Drawing.Point(3, 50);
            this.databaseGridView.MultiSelect = false;
            this.databaseGridView.Name = "databaseGridView";
            this.databaseGridView.ReadOnly = true;
            this.databaseGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.databaseGridView.Size = new System.Drawing.Size(837, 428);
            this.databaseGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.statusTxt);
            this.panel1.Controls.Add(this.statusLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 41);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.Controls.Add(this.changeDbBtn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.dbPathTextBox, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.refreshBtn, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.createDatabaseBtn, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(837, 29);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // changeDbBtn
            // 
            this.changeDbBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changeDbBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeDbBtn.Location = new System.Drawing.Point(630, 4);
            this.changeDbBtn.Name = "changeDbBtn";
            this.changeDbBtn.Size = new System.Drawing.Size(34, 21);
            this.changeDbBtn.TabIndex = 6;
            this.changeDbBtn.Text = "…";
            this.changeDbBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.changeDbBtn.UseVisualStyleBackColor = true;
            this.changeDbBtn.Click += new System.EventHandler(this.changeDbBtn_Click);
            // 
            // dbPathTextBox
            // 
            this.dbPathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbPathTextBox.Location = new System.Drawing.Point(75, 4);
            this.dbPathTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.dbPathTextBox.Name = "dbPathTextBox";
            this.dbPathTextBox.ReadOnly = true;
            this.dbPathTextBox.Size = new System.Drawing.Size(548, 20);
            this.dbPathTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Baza danych:";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshBtn.Location = new System.Drawing.Point(673, 3);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.Text = "Odśwież";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // createDatabaseBtn
            // 
            this.createDatabaseBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createDatabaseBtn.Location = new System.Drawing.Point(757, 3);
            this.createDatabaseBtn.Name = "createDatabaseBtn";
            this.createDatabaseBtn.Size = new System.Drawing.Size(75, 23);
            this.createDatabaseBtn.TabIndex = 0;
            this.createDatabaseBtn.Text = "Stwórz bazę";
            this.createDatabaseBtn.UseVisualStyleBackColor = true;
            this.createDatabaseBtn.Click += new System.EventHandler(this.createDatabaseBtn_Click);
            // 
            // statusTxt
            // 
            this.statusTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.statusTxt.AutoSize = true;
            this.statusTxt.Location = new System.Drawing.Point(37, 28);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(35, 13);
            this.statusTxt.TabIndex = 2;
            this.statusTxt.Text = "status";
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(0, 28);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Status:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.filterInput);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.backupDatabaseBtn);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.modifyBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 484);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 30);
            this.panel2.TabIndex = 2;
            // 
            // filterInput
            // 
            this.filterInput.Location = new System.Drawing.Point(214, 6);
            this.filterInput.Name = "filterInput";
            this.filterInput.Size = new System.Drawing.Size(184, 20);
            this.filterInput.TabIndex = 6;
            this.filterInput.TextChanged += new System.EventHandler(this.filterInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Szukaj:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backupDatabaseBtn
            // 
            this.backupDatabaseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backupDatabaseBtn.Location = new System.Drawing.Point(711, 4);
            this.backupDatabaseBtn.Name = "backupDatabaseBtn";
            this.backupDatabaseBtn.Size = new System.Drawing.Size(123, 23);
            this.backupDatabaseBtn.TabIndex = 2;
            this.backupDatabaseBtn.Text = "Kopia zapasowa bazy";
            this.backupDatabaseBtn.UseVisualStyleBackColor = true;
            this.backupDatabaseBtn.Click += new System.EventHandler(this.backupDatabaseBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(85, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Usuń";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.modifyBtn.Location = new System.Drawing.Point(4, 4);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(75, 23);
            this.modifyBtn.TabIndex = 0;
            this.modifyBtn.Text = "Modyfikuj";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.databaseGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(843, 517);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 517);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DatabaseForm";
            this.Text = "DatabaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.databaseGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView databaseGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button createDatabaseBtn;
        private System.Windows.Forms.Label statusTxt;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeDbBtn;
        private System.Windows.Forms.TextBox dbPathTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button backupDatabaseBtn;
        private System.Windows.Forms.TextBox filterInput;
        private System.Windows.Forms.Label label2;
    }
}
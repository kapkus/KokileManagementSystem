
namespace Kokile.Forms
{
    partial class KokilaForm
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
            this.openBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kodKreskowyInput = new System.Windows.Forms.TextBox();
            this.selekcjaInput = new System.Windows.Forms.TextBox();
            this.typFelgiTxt = new System.Windows.Forms.Label();
            this.selekcjaTxt = new System.Windows.Forms.Label();
            this.kodKreskowyTxt = new System.Windows.Forms.Label();
            this.zmianaTxt = new System.Windows.Forms.Label();
            this.brygadaTxt = new System.Windows.Forms.Label();
            this.typFelgiInput = new System.Windows.Forms.TextBox();
            this.zmianaComboBox = new System.Windows.Forms.ComboBox();
            this.brygadaComboBox = new System.Windows.Forms.ComboBox();
            this.loadKokilaBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addToRadlistBtn = new System.Windows.Forms.Button();
            this.editRadlistBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(87, 179);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 6;
            this.openBtn.Text = "Otwórz docx";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(6, 179);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Zapisz docx";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(168, 179);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Dodaj kokile";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.12137F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.87863F));
            this.tableLayoutPanel1.Controls.Add(this.kodKreskowyInput, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.selekcjaInput, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.typFelgiTxt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.selekcjaTxt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.kodKreskowyTxt, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.zmianaTxt, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.brygadaTxt, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.typFelgiInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.zmianaComboBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.brygadaComboBox, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(379, 154);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // kodKreskowyInput
            // 
            this.kodKreskowyInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.kodKreskowyInput.Location = new System.Drawing.Point(101, 65);
            this.kodKreskowyInput.Name = "kodKreskowyInput";
            this.kodKreskowyInput.Size = new System.Drawing.Size(275, 20);
            this.kodKreskowyInput.TabIndex = 7;
            // 
            // selekcjaInput
            // 
            this.selekcjaInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selekcjaInput.Location = new System.Drawing.Point(101, 35);
            this.selekcjaInput.Name = "selekcjaInput";
            this.selekcjaInput.Size = new System.Drawing.Size(275, 20);
            this.selekcjaInput.TabIndex = 6;
            // 
            // typFelgiTxt
            // 
            this.typFelgiTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.typFelgiTxt.AutoSize = true;
            this.typFelgiTxt.Location = new System.Drawing.Point(3, 8);
            this.typFelgiTxt.Name = "typFelgiTxt";
            this.typFelgiTxt.Size = new System.Drawing.Size(92, 13);
            this.typFelgiTxt.TabIndex = 0;
            this.typFelgiTxt.Text = "Typ felgi:";
            // 
            // selekcjaTxt
            // 
            this.selekcjaTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selekcjaTxt.AutoSize = true;
            this.selekcjaTxt.Location = new System.Drawing.Point(3, 38);
            this.selekcjaTxt.Name = "selekcjaTxt";
            this.selekcjaTxt.Size = new System.Drawing.Size(92, 13);
            this.selekcjaTxt.TabIndex = 1;
            this.selekcjaTxt.Text = "Selekcja:";
            // 
            // kodKreskowyTxt
            // 
            this.kodKreskowyTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.kodKreskowyTxt.AutoSize = true;
            this.kodKreskowyTxt.Location = new System.Drawing.Point(3, 68);
            this.kodKreskowyTxt.Name = "kodKreskowyTxt";
            this.kodKreskowyTxt.Size = new System.Drawing.Size(92, 13);
            this.kodKreskowyTxt.TabIndex = 2;
            this.kodKreskowyTxt.Text = "Kod kreskowy:";
            // 
            // zmianaTxt
            // 
            this.zmianaTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.zmianaTxt.AutoSize = true;
            this.zmianaTxt.Location = new System.Drawing.Point(3, 98);
            this.zmianaTxt.Name = "zmianaTxt";
            this.zmianaTxt.Size = new System.Drawing.Size(92, 13);
            this.zmianaTxt.TabIndex = 3;
            this.zmianaTxt.Text = "Zmiana:";
            // 
            // brygadaTxt
            // 
            this.brygadaTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.brygadaTxt.AutoSize = true;
            this.brygadaTxt.Location = new System.Drawing.Point(3, 130);
            this.brygadaTxt.Name = "brygadaTxt";
            this.brygadaTxt.Size = new System.Drawing.Size(92, 13);
            this.brygadaTxt.TabIndex = 4;
            this.brygadaTxt.Text = "Brygada:";
            // 
            // typFelgiInput
            // 
            this.typFelgiInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.typFelgiInput.Location = new System.Drawing.Point(101, 5);
            this.typFelgiInput.Name = "typFelgiInput";
            this.typFelgiInput.Size = new System.Drawing.Size(275, 20);
            this.typFelgiInput.TabIndex = 5;
            // 
            // zmianaComboBox
            // 
            this.zmianaComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.zmianaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zmianaComboBox.FormattingEnabled = true;
            this.zmianaComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.zmianaComboBox.Location = new System.Drawing.Point(101, 94);
            this.zmianaComboBox.Name = "zmianaComboBox";
            this.zmianaComboBox.Size = new System.Drawing.Size(275, 21);
            this.zmianaComboBox.TabIndex = 8;
            // 
            // brygadaComboBox
            // 
            this.brygadaComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.brygadaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brygadaComboBox.FormattingEnabled = true;
            this.brygadaComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.brygadaComboBox.Location = new System.Drawing.Point(101, 126);
            this.brygadaComboBox.Name = "brygadaComboBox";
            this.brygadaComboBox.Size = new System.Drawing.Size(275, 21);
            this.brygadaComboBox.TabIndex = 9;
            // 
            // loadKokilaBtn
            // 
            this.loadKokilaBtn.Location = new System.Drawing.Point(391, 82);
            this.loadKokilaBtn.Name = "loadKokilaBtn";
            this.loadKokilaBtn.Size = new System.Drawing.Size(75, 23);
            this.loadKokilaBtn.TabIndex = 8;
            this.loadKokilaBtn.Text = "Wczytaj";
            this.loadKokilaBtn.UseVisualStyleBackColor = true;
            this.loadKokilaBtn.Click += new System.EventHandler(this.loadKokilaBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.loadKokilaBtn);
            this.groupBox1.Controls.Add(this.openBtn);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 209);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj kokile";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addToRadlistBtn);
            this.groupBox2.Controls.Add(this.editRadlistBtn);
            this.groupBox2.Location = new System.Drawing.Point(489, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 209);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edytuj radliste";
            // 
            // addToRadlistBtn
            // 
            this.addToRadlistBtn.Location = new System.Drawing.Point(6, 47);
            this.addToRadlistBtn.Name = "addToRadlistBtn";
            this.addToRadlistBtn.Size = new System.Drawing.Size(118, 23);
            this.addToRadlistBtn.TabIndex = 1;
            this.addToRadlistBtn.Text = "Dodaj konfiguracje";
            this.addToRadlistBtn.UseVisualStyleBackColor = true;
            this.addToRadlistBtn.Click += new System.EventHandler(this.addToRadlistBtn_Click);
            // 
            // editRadlistBtn
            // 
            this.editRadlistBtn.Location = new System.Drawing.Point(6, 19);
            this.editRadlistBtn.Name = "editRadlistBtn";
            this.editRadlistBtn.Size = new System.Drawing.Size(118, 23);
            this.editRadlistBtn.TabIndex = 0;
            this.editRadlistBtn.Text = "Edytuj baze";
            this.editRadlistBtn.UseVisualStyleBackColor = true;
            this.editRadlistBtn.Click += new System.EventHandler(this.editRadlistBtn_Click);
            // 
            // KokilaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KokilaForm";
            this.Text = "KokilaForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox kodKreskowyInput;
        private System.Windows.Forms.TextBox selekcjaInput;
        private System.Windows.Forms.Label typFelgiTxt;
        private System.Windows.Forms.Label selekcjaTxt;
        private System.Windows.Forms.Label kodKreskowyTxt;
        private System.Windows.Forms.Label zmianaTxt;
        private System.Windows.Forms.Label brygadaTxt;
        private System.Windows.Forms.TextBox typFelgiInput;
        private System.Windows.Forms.ComboBox zmianaComboBox;
        private System.Windows.Forms.ComboBox brygadaComboBox;
        private System.Windows.Forms.Button loadKokilaBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addToRadlistBtn;
        private System.Windows.Forms.Button editRadlistBtn;
    }
}
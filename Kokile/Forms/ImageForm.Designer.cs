
namespace Kokile.Forms
{
    partial class ImageForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.longRadioBtn = new System.Windows.Forms.RadioButton();
            this.shortRadioBtn = new System.Windows.Forms.RadioButton();
            this.barcodePictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.barcodeLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.longRadioBtn);
            this.panel3.Controls.Add(this.shortRadioBtn);
            this.panel3.Location = new System.Drawing.Point(19, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(147, 25);
            this.panel3.TabIndex = 13;
            // 
            // longRadioBtn
            // 
            this.longRadioBtn.AutoSize = true;
            this.longRadioBtn.Checked = true;
            this.longRadioBtn.Location = new System.Drawing.Point(3, 3);
            this.longRadioBtn.Name = "longRadioBtn";
            this.longRadioBtn.Size = new System.Drawing.Size(51, 17);
            this.longRadioBtn.TabIndex = 9;
            this.longRadioBtn.TabStop = true;
            this.longRadioBtn.Text = "Długi";
            this.longRadioBtn.UseVisualStyleBackColor = true;
            this.longRadioBtn.CheckedChanged += new System.EventHandler(this.longRadioBtn_CheckedChanged);
            // 
            // shortRadioBtn
            // 
            this.shortRadioBtn.AutoSize = true;
            this.shortRadioBtn.Location = new System.Drawing.Point(60, 3);
            this.shortRadioBtn.Name = "shortRadioBtn";
            this.shortRadioBtn.Size = new System.Drawing.Size(52, 17);
            this.shortRadioBtn.TabIndex = 8;
            this.shortRadioBtn.Text = "Krótki";
            this.shortRadioBtn.UseVisualStyleBackColor = true;
            this.shortRadioBtn.CheckedChanged += new System.EventHandler(this.shortRadioBtn_CheckedChanged);
            // 
            // barcodePictureBox
            // 
            this.barcodePictureBox.Location = new System.Drawing.Point(12, 12);
            this.barcodePictureBox.Name = "barcodePictureBox";
            this.barcodePictureBox.Size = new System.Drawing.Size(154, 80);
            this.barcodePictureBox.TabIndex = 10;
            this.barcodePictureBox.TabStop = false;
            this.barcodePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarcodePictureBox_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kod kreskowy:";
            // 
            // barcodeLabel
            // 
            this.barcodeLabel.AutoSize = true;
            this.barcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.barcodeLabel.Location = new System.Drawing.Point(116, 95);
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.Size = new System.Drawing.Size(99, 18);
            this.barcodeLabel.TabIndex = 12;
            this.barcodeLabel.Text = "kodKreskowy";
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.barcodePictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barcodeLabel);
            this.Name = "ImageForm";
            this.Text = "ImageForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton longRadioBtn;
        private System.Windows.Forms.RadioButton shortRadioBtn;
        private System.Windows.Forms.PictureBox barcodePictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label barcodeLabel;
    }
}
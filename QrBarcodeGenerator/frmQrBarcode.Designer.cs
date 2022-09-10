namespace QrBarcodeGenerator
{
    partial class frmQrBarcode
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
            this.picQrBarcode = new System.Windows.Forms.PictureBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtQrBarcode = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpFooter = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picQrBarcode)).BeginInit();
            this.grpFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // picQrBarcode
            // 
            this.picQrBarcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picQrBarcode.Location = new System.Drawing.Point(8, 48);
            this.picQrBarcode.Name = "picQrBarcode";
            this.picQrBarcode.Padding = new System.Windows.Forms.Padding(20);
            this.picQrBarcode.Size = new System.Drawing.Size(624, 376);
            this.picQrBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picQrBarcode.TabIndex = 5;
            this.picQrBarcode.TabStop = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Gray;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Location = new System.Drawing.Point(560, 8);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(72, 32);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Oluştur";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtQrBarcode
            // 
            this.txtQrBarcode.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQrBarcode.Location = new System.Drawing.Point(8, 8);
            this.txtQrBarcode.Multiline = true;
            this.txtQrBarcode.Name = "txtQrBarcode";
            this.txtQrBarcode.Size = new System.Drawing.Size(552, 32);
            this.txtQrBarcode.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(536, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpFooter
            // 
            this.grpFooter.Controls.Add(this.btnSave);
            this.grpFooter.Location = new System.Drawing.Point(8, 424);
            this.grpFooter.Name = "grpFooter";
            this.grpFooter.Size = new System.Drawing.Size(624, 72);
            this.grpFooter.TabIndex = 7;
            this.grpFooter.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // frmQrBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 503);
            this.Controls.Add(this.grpFooter);
            this.Controls.Add(this.picQrBarcode);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtQrBarcode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQrBarcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qr Barkod Oluşturucu";
         
            ((System.ComponentModel.ISupportInitialize)(this.picQrBarcode)).EndInit();
            this.grpFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picQrBarcode;
        private Button btnGenerate;
        private TextBox txtQrBarcode;
        private Button btnSave;
        private GroupBox grpFooter;
        private OpenFileDialog openFileDialog;
    }
}
using QRCoder;

namespace QrBarcodeGenerator
{
    public partial class frmQrBarcode : Form
    {
        #region CTOR
        public frmQrBarcode()
        {
            InitializeComponent();
            InitApplication();
 
        }
        #endregion

        #region METHODS
        private void GenerateQrBarcode(string strText)
        {

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(strText, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(10);
            picQrBarcode.Image = qrCodeImage;
        }
        #endregion

        #region EVENTS
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picQrBarcode.Image.Save(saveFileDialog.FileName);
                }
            }
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var strText = txtQrBarcode.Text;

            if (!String.IsNullOrEmpty(strText))
            {
                GenerateQrBarcode(strText);
                btnSave.Enabled = true;
                return;
            }

            MessageBox.Show("Lütfen Geçerli Bir URL Yazınız..");


        }

        public void InitApplication()
        {
            btnSave.Enabled = false;

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                btnSave.PerformClick();


                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

    }
}

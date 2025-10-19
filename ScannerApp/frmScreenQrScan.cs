using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing.Windows.Compatibility;

namespace ScannerApp
{
    public partial class frmScreenQrScan : Form
    {
        public frmScreenQrScan()
        {
            InitializeComponent();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            tmrScan.Enabled = true;
            doCapture(); // Do first scan without delay
        }
        private void doCapture()
        {
            lblResult.Text = "...";
            // Find picture coordinates
            Point formLocation = this.PointToScreen(Point.Empty);
            int captureX = formLocation.X + picImg.Left;
            int captureY = formLocation.Y + picImg.Top;
            int width = picImg.Width;
            int height = picImg.Height;

            using (Bitmap screenshot = new Bitmap(width, height))
            {
                using (Graphics graphics = Graphics.FromImage(screenshot))
                {
                    // Hide form and capture coordinates
                    try
                    {
                        picImg.Visible = false;
                        TransparencyKey = BackColor = Color.Green;
                        Application.DoEvents();
                        graphics.CopyFromScreen(captureX, captureY, 0, 0, new Size(width, height));
                    }
                    finally
                    {
                        this.BackColor = SystemColors.Control;
                        picImg.Visible = true;
                        Application.DoEvents();
                    }
                }

                picImg.Image?.Dispose();
                picImg.Image = (Bitmap)screenshot.Clone();

                ScanBarcodeInImage((Bitmap)screenshot.Clone());
            }
        }
        private void ScanBarcodeInImage(Bitmap image)
        {
            if (image == null) return;

            try
            {
                var reader = new BarcodeReader();
                var result = reader.Decode(image);

                if (result != null)
                {
                    string barcodeValue = result.Text;
                    string barcodeFormat = result.BarcodeFormat.ToString();
                    lblResult.Text = barcodeValue;
                    Clipboard.SetText(barcodeValue);
                    tmrScan.Enabled = false; // Found: Disable scan timer
                }
                else
                {
                    lblResult.Text = "[N/A]";
                }
            }
            catch (Exception ex)
            {
                tmrScan.Enabled = false; // Error: Disable scan timer
                MessageBox.Show($"Fail to scan: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                image.Dispose();
            }
        }

        private void tmrScan_Tick(object sender, EventArgs e)
        {
            try
            {
                doCapture();
            }
            catch
            {
                tmrScan.Enabled = false; // Error: Disable scan timer
                throw;
            }
        }
    }
}

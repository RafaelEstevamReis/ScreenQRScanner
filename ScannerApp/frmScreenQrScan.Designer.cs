using System.Drawing;
using System.Windows.Forms;

namespace ScannerApp
{
    partial class frmScreenQrScan
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScreenQrScan));
            picImg = new PictureBox();
            btnCapture = new Button();
            lblResult = new TextBox();
            chkSaveDB = new CheckBox();
            panel1 = new Panel();
            tmrScan = new Timer(components);
            ((System.ComponentModel.ISupportInitialize)picImg).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // picImg
            // 
            picImg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picImg.Location = new Point(1, 22);
            picImg.Name = "picImg";
            picImg.Size = new Size(307, 256);
            picImg.TabIndex = 1;
            picImg.TabStop = false;
            // 
            // btnCapture
            // 
            btnCapture.Location = new Point(2, 2);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(75, 22);
            btnCapture.TabIndex = 3;
            btnCapture.Text = "Start Scan";
            btnCapture.UseVisualStyleBackColor = true;
            btnCapture.Click += btnCapture_Click;
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblResult.Location = new Point(1, 277);
            lblResult.Multiline = true;
            lblResult.Name = "lblResult";
            lblResult.ReadOnly = true;
            lblResult.ScrollBars = ScrollBars.Vertical;
            lblResult.Size = new Size(306, 34);
            lblResult.TabIndex = 4;
            // 
            // chkSaveDB
            // 
            chkSaveDB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkSaveDB.AutoSize = true;
            chkSaveDB.Checked = true;
            chkSaveDB.CheckState = CheckState.Checked;
            chkSaveDB.Location = new Point(188, 3);
            chkSaveDB.Name = "chkSaveDB";
            chkSaveDB.Size = new Size(119, 19);
            chkSaveDB.TabIndex = 5;
            chkSaveDB.Text = "Save to Clipboard";
            chkSaveDB.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(btnCapture);
            panel1.Controls.Add(chkSaveDB);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 25);
            panel1.TabIndex = 6;
            // 
            // tmrScan
            // 
            tmrScan.Interval = 500;
            tmrScan.Tick += tmrScan_Tick;
            // 
            // frmScreenQrScan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 311);
            Controls.Add(panel1);
            Controls.Add(lblResult);
            Controls.Add(picImg);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(250, 200);
            Name = "frmScreenQrScan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Screen QR Scanner";
            TransparencyKey = Color.Green;
            ((System.ComponentModel.ISupportInitialize)picImg).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picImg;
        private Button btnCapture;
        private TextBox lblResult;
        private CheckBox chkSaveDB;
        private Panel panel1;
        private Timer tmrScan;
    }
}

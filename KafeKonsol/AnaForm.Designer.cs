namespace KafeKonsol
{
    partial class AnaForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            menuStrip1 = new MenuStrip();
            tsmiUrunler = new ToolStripMenuItem();
            tsmiGecmisSiparisler = new ToolStripMenuItem();
            lvwMasalar = new ListView();
            iMasalar = new ImageList(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiUrunler, tsmiGecmisSiparisler });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(720, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiUrunler
            // 
            tsmiUrunler.Name = "tsmiUrunler";
            tsmiUrunler.Size = new Size(58, 19);
            tsmiUrunler.Text = "Ürünler";
            tsmiUrunler.Click += tsmiUrunler_Click;
            // 
            // tsmiGecmisSiparisler
            // 
            tsmiGecmisSiparisler.Name = "tsmiGecmisSiparisler";
            tsmiGecmisSiparisler.Size = new Size(108, 19);
            tsmiGecmisSiparisler.Text = "Geçmiş Siparişler";
            tsmiGecmisSiparisler.Click += tsmiGecmisSiparisler_Click;
            // 
            // lvwMasalar
            // 
            lvwMasalar.Dock = DockStyle.Fill;
            lvwMasalar.LargeImageList = iMasalar;
            lvwMasalar.Location = new Point(0, 25);
            lvwMasalar.Margin = new Padding(4);
            lvwMasalar.Name = "lvwMasalar";
            lvwMasalar.Size = new Size(720, 427);
            lvwMasalar.TabIndex = 1;
            lvwMasalar.UseCompatibleStateImageBehavior = false;
            lvwMasalar.DoubleClick += lvwMasalar_DoubleClick;
            // 
            // iMasalar
            // 
            iMasalar.ColorDepth = ColorDepth.Depth8Bit;
            iMasalar.ImageStream = (ImageListStreamer)resources.GetObject("iMasalar.ImageStream");
            iMasalar.TransparentColor = Color.Transparent;
            iMasalar.Images.SetKeyName(0, "bos");
            iMasalar.Images.SetKeyName(1, "dolu");
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 452);
            Controls.Add(lvwMasalar);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "AnaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kafe Konsol";
            FormClosing += AnaForm_FormClosing;
            DoubleClick += AnaForm_DoubleClick;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiUrunler;
        private ToolStripMenuItem tsmiGecmisSiparisler;
        private ListView lvwMasalar;
        private ImageList iMasalar;
    }
}
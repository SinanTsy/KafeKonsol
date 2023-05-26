namespace KafeKonsol
{
    partial class UrunlerForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            nudBirimFiyat = new NumericUpDown();
            btnEkle = new Button();
            dgvUrunler = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            txtUrunAd = new TextBox();
            btnIptal = new Button();
            btnDuzenle = new Button();
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 9;
            label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(198, 19);
            label2.Name = "label2";
            label2.Size = new Size(122, 21);
            label2.TabIndex = 10;
            label2.Text = "Birim Fiyatı (₺)";
            // 
            // nudBirimFiyat
            // 
            nudBirimFiyat.DecimalPlaces = 2;
            nudBirimFiyat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudBirimFiyat.Location = new Point(200, 43);
            nudBirimFiyat.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudBirimFiyat.Name = "nudBirimFiyat";
            nudBirimFiyat.Size = new Size(120, 29);
            nudBirimFiyat.TabIndex = 12;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Location = new Point(333, 43);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(86, 29);
            btnEkle.TabIndex = 13;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvUrunler
            // 
            dgvUrunler.AllowUserToAddRows = false;
            dgvUrunler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUrunler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvUrunler.Location = new Point(12, 88);
            dgvUrunler.MultiSelect = false;
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.ReadOnly = true;
            dgvUrunler.RowHeadersVisible = false;
            dgvUrunler.RowTemplate.Height = 25;
            dgvUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUrunler.Size = new Size(499, 388);
            dgvUrunler.TabIndex = 14;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "UrunAd";
            Column1.HeaderText = "Ürün Adı";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 79;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "BirimFiyat";
            dataGridViewCellStyle1.Format = "c2";
            Column2.DefaultCellStyle = dataGridViewCellStyle1;
            Column2.HeaderText = "Birim Fiyatı";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 91;
            // 
            // txtUrunAd
            // 
            txtUrunAd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUrunAd.Location = new Point(12, 43);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(162, 29);
            txtUrunAd.TabIndex = 15;
            // 
            // btnIptal
            // 
            btnIptal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIptal.Location = new Point(425, 43);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(86, 29);
            btnIptal.TabIndex = 16;
            btnIptal.Text = "İPTAL";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Visible = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDuzenle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDuzenle.Location = new Point(412, 482);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(99, 44);
            btnDuzenle.TabIndex = 17;
            btnDuzenle.Text = "DÜZENLE";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // UrunlerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 534);
            Controls.Add(btnDuzenle);
            Controls.Add(btnIptal);
            Controls.Add(txtUrunAd);
            Controls.Add(dgvUrunler);
            Controls.Add(btnEkle);
            Controls.Add(nudBirimFiyat);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UrunlerForm";
            Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown nudBirimFiyat;
        private Button btnEkle;
        private DataGridView dgvUrunler;
        private TextBox txtUrunAd;
        private Button btnIptal;
        private Button btnDuzenle;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
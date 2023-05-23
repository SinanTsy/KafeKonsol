namespace KafeKonsol
{
    partial class SiparisForm
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
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.comboBox1 = new ComboBox();
            this.numericUpDown1 = new NumericUpDown();
            this.button1 = new Button();
            this.comboBox2 = new ComboBox();
            this.button2 = new Button();
            this.dataGridView1 = new DataGridView();
            this.button3 = new Button();
            this.button4 = new Button();
            this.button5 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.label1.Location = new Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new Size(48, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.label2.Location = new Point(205, 24);
            this.label2.Name = "label2";
            this.label2.Size = new Size(46, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adet";
            // 
            // label3
            // 
            this.label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.label3.Location = new Point(467, 24);
            this.label3.Name = "label3";
            this.label3.Size = new Size(81, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Masa No:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new Point(19, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(162, 29);
            this.comboBox1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.numericUpDown1.Location = new Point(205, 48);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new Size(120, 29);
            this.numericUpDown1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.button1.Location = new Point(340, 48);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new Point(467, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new Size(99, 29);
            this.comboBox2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.button2.Location = new Point(572, 49);
            this.button2.Name = "button2";
            this.button2.Size = new Size(87, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "TAŞI";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new Size(401, 330);
            this.dataGridView1.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.button3.BackColor = Color.Red;
            this.button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.button3.ForeColor = Color.White;
            this.button3.Location = new Point(449, 287);
            this.button3.Name = "button3";
            this.button3.Size = new Size(117, 52);
            this.button3.TabIndex = 9;
            this.button3.Text = "SİPARİŞ İPTAL";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.button4.BackColor = Color.LimeGreen;
            this.button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.button4.ForeColor = Color.White;
            this.button4.Location = new Point(572, 287);
            this.button4.Name = "button4";
            this.button4.Size = new Size(117, 52);
            this.button4.TabIndex = 10;
            this.button4.Text = "ÖDEME AL";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.button5.BackColor = Color.Yellow;
            this.button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.button5.Location = new Point(449, 355);
            this.button5.Name = "button5";
            this.button5.Size = new Size(240, 52);
            this.button5.TabIndex = 11;
            this.button5.Text = "ANASAYFAYA DÖN";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.BackColor = Color.Tomato;
            label4.Font = new Font("Arial Black", 60F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(449, 93);
            label4.Name = "label4";
            label4.Size = new Size(240, 164);
            label4.TabIndex = 12;
            label4.Text = "00";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(474, 261);
            label5.Name = "label5";
            label5.Size = new Size(112, 21);
            label5.TabIndex = 13;
            label5.Text = "Ödeme Tutarı: ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(592, 261);
            label6.Name = "label6";
            label6.Size = new Size(54, 21);
            label6.TabIndex = 14;
            label6.Text = "0,00 ₺";
            // 
            // SiparisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 435);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(this.button5);
            Controls.Add(this.button4);
            Controls.Add(this.button3);
            Controls.Add(this.dataGridView1);
            Controls.Add(this.button2);
            Controls.Add(this.comboBox2);
            Controls.Add(this.button1);
            Controls.Add(this.numericUpDown1);
            Controls.Add(this.comboBox1);
            Controls.Add(this.label3);
            Controls.Add(this.label2);
            Controls.Add(this.label1);
            MinimumSize = new Size(760, 474);
            Name = "SiparisForm";
            Text = "Masa 0";
            ((System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label5;
        private Label label6;
    }
}
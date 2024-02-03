namespace SekillerDunyasi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lstSekiller = new ListBox();
            nudX = new NumericUpDown();
            nudY = new NumericUpDown();
            nudGenislik = new NumericUpDown();
            nudYukseklik = new NumericUpDown();
            cboTur = new ComboBox();
            pboRenk = new PictureBox();
            btnRastgeleEkle = new Button();
            btnEkle = new Button();
            btnYukari = new Button();
            btnSil = new Button();
            btnAsagi = new Button();
            pnlCizim = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnTemizle = new Button();
            btnKaydet = new Button();
            colorDialog1 = new ColorDialog();
            btnMetinEkle = new Button();
            label7 = new Label();
            txtMetin = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGenislik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudYukseklik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboRenk).BeginInit();
            SuspendLayout();
            // 
            // lstSekiller
            // 
            lstSekiller.FormattingEnabled = true;
            lstSekiller.ItemHeight = 20;
            lstSekiller.Location = new Point(55, 156);
            lstSekiller.Name = "lstSekiller";
            lstSekiller.Size = new Size(684, 144);
            lstSekiller.TabIndex = 0;
            // 
            // nudX
            // 
            nudX.Location = new Point(55, 47);
            nudX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudX.Name = "nudX";
            nudX.Size = new Size(69, 27);
            nudX.TabIndex = 1;
            // 
            // nudY
            // 
            nudY.Location = new Point(150, 47);
            nudY.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudY.Name = "nudY";
            nudY.Size = new Size(69, 27);
            nudY.TabIndex = 1;
            // 
            // nudGenislik
            // 
            nudGenislik.Location = new Point(302, 47);
            nudGenislik.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudGenislik.Name = "nudGenislik";
            nudGenislik.Size = new Size(69, 27);
            nudGenislik.TabIndex = 1;
            nudGenislik.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // nudYukseklik
            // 
            nudYukseklik.Location = new Point(397, 47);
            nudYukseklik.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudYukseklik.Name = "nudYukseklik";
            nudYukseklik.Size = new Size(77, 27);
            nudYukseklik.TabIndex = 1;
            nudYukseklik.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // cboTur
            // 
            cboTur.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTur.FormattingEnabled = true;
            cboTur.Items.AddRange(new object[] { "Dikdortgen", "Elips" });
            cboTur.Location = new Point(500, 46);
            cboTur.Name = "cboTur";
            cboTur.Size = new Size(124, 28);
            cboTur.TabIndex = 2;
            // 
            // pboRenk
            // 
            pboRenk.BackColor = Color.Black;
            pboRenk.BorderStyle = BorderStyle.FixedSingle;
            pboRenk.Location = new Point(245, 43);
            pboRenk.Name = "pboRenk";
            pboRenk.Size = new Size(31, 31);
            pboRenk.TabIndex = 3;
            pboRenk.TabStop = false;
            pboRenk.Click += pboRenk_Click;
            // 
            // btnRastgeleEkle
            // 
            btnRastgeleEkle.BackColor = SystemColors.Control;
            btnRastgeleEkle.Location = new Point(635, 43);
            btnRastgeleEkle.Name = "btnRastgeleEkle";
            btnRastgeleEkle.Size = new Size(31, 31);
            btnRastgeleEkle.TabIndex = 4;
            btnRastgeleEkle.Text = "?";
            btnRastgeleEkle.UseVisualStyleBackColor = false;
            btnRastgeleEkle.Click += btnRastgeleEkle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(688, 43);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(114, 31);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Sekil Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnYukari
            // 
            btnYukari.Image = (Image)resources.GetObject("btnYukari.Image");
            btnYukari.Location = new Point(760, 156);
            btnYukari.Name = "btnYukari";
            btnYukari.Size = new Size(42, 42);
            btnYukari.TabIndex = 4;
            btnYukari.UseVisualStyleBackColor = true;
            btnYukari.Click += btnYukari_Click;
            // 
            // btnSil
            // 
            btnSil.Image = (Image)resources.GetObject("btnSil.Image");
            btnSil.Location = new Point(760, 207);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(42, 42);
            btnSil.TabIndex = 4;
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnAsagi
            // 
            btnAsagi.Image = (Image)resources.GetObject("btnAsagi.Image");
            btnAsagi.Location = new Point(760, 258);
            btnAsagi.Name = "btnAsagi";
            btnAsagi.Size = new Size(42, 42);
            btnAsagi.TabIndex = 4;
            btnAsagi.UseVisualStyleBackColor = true;
            btnAsagi.Click += btnAsagi_Click;
            // 
            // pnlCizim
            // 
            pnlCizim.BackColor = Color.White;
            pnlCizim.Location = new Point(55, 306);
            pnlCizim.Name = "pnlCizim";
            pnlCizim.Size = new Size(747, 382);
            pnlCizim.TabIndex = 5;
            pnlCizim.Paint += pnlCizim_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 22);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 6;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 22);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 6;
            label2.Text = "Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 24);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 6;
            label3.Text = "Genislik";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 24);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 6;
            label4.Text = "Yukseklik";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(500, 22);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 6;
            label5.Text = "Sekil Turu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(236, 20);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 6;
            label6.Text = " Renk";
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(55, 695);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(94, 29);
            btnTemizle.TabIndex = 7;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(176, 695);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnMetinEkle
            // 
            btnMetinEkle.Location = new Point(688, 98);
            btnMetinEkle.Name = "btnMetinEkle";
            btnMetinEkle.Size = new Size(114, 31);
            btnMetinEkle.TabIndex = 4;
            btnMetinEkle.Text = "Metin Ekle";
            btnMetinEkle.UseVisualStyleBackColor = true;
            btnMetinEkle.Click += btnMetinEkle_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 105);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 6;
            label7.Text = "Metin";
            // 
            // txtMetin
            // 
            txtMetin.Location = new Point(152, 98);
            txtMetin.Name = "txtMetin";
            txtMetin.Size = new Size(514, 27);
            txtMetin.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 735);
            Controls.Add(txtMetin);
            Controls.Add(btnKaydet);
            Controls.Add(btnTemizle);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(pnlCizim);
            Controls.Add(btnMetinEkle);
            Controls.Add(btnEkle);
            Controls.Add(btnAsagi);
            Controls.Add(btnSil);
            Controls.Add(btnYukari);
            Controls.Add(btnRastgeleEkle);
            Controls.Add(pboRenk);
            Controls.Add(cboTur);
            Controls.Add(nudYukseklik);
            Controls.Add(nudGenislik);
            Controls.Add(nudY);
            Controls.Add(nudX);
            Controls.Add(lstSekiller);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudX).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGenislik).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudYukseklik).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboRenk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSekiller;
        private NumericUpDown nudX;
        private NumericUpDown nudY;
        private NumericUpDown nudGenislik;
        private NumericUpDown nudYukseklik;
        private ComboBox cboTur;
        private PictureBox pboRenk;
        private Button btnRastgeleEkle;
        private Button btnEkle;
        private Button btnYukari;
        private Button btnSil;
        private Button btnAsagi;
        private Panel pnlCizim;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnTemizle;
        private Button btnKaydet;
        private ColorDialog colorDialog1;
        private Button btnMetinEkle;
        private Label label7;
        private TextBox txtMetin;
    }
}
namespace EntityPractise
{
    partial class Form1
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
            this.txtOgrAdi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.groupOgrenci = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOgrenciFotograf = new System.Windows.Forms.TextBox();
            this.txtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrenciId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupDers = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.txtDersId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupNotlar = new System.Windows.Forms.GroupBox();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSinav3 = new System.Windows.Forms.TextBox();
            this.txtSinav2 = new System.Windows.Forms.TextBox();
            this.txtSinav1 = new System.Windows.Forms.TextBox();
            this.btnDersListesi = new System.Windows.Forms.Button();
            this.btnNotListesi = new System.Windows.Forms.Button();
            this.radioBtnOgrenci = new System.Windows.Forms.RadioButton();
            this.radioButtonDers = new System.Windows.Forms.RadioButton();
            this.btnProcedure = new System.Windows.Forms.Button();
            this.radioSirala = new System.Windows.Forms.RadioButton();
            this.btnLinqEntity = new System.Windows.Forms.Button();
            this.radioTersSirala = new System.Windows.Forms.RadioButton();
            this.radioFirstThree = new System.Windows.Forms.RadioButton();
            this.radioDegerVarMi = new System.Windows.Forms.RadioButton();
            this.radioSinav1 = new System.Windows.Forms.RadioButton();
            this.radioSinav1Ortalama = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupOgrenci.SuspendLayout();
            this.groupDers.SuspendLayout();
            this.groupNotlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOgrAdi
            // 
            this.txtOgrAdi.Location = new System.Drawing.Point(113, 67);
            this.txtOgrAdi.Name = "txtOgrAdi";
            this.txtOgrAdi.Size = new System.Drawing.Size(150, 22);
            this.txtOgrAdi.TabIndex = 16;
            this.txtOgrAdi.TextChanged += new System.EventHandler(this.txtOgrAdi_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(78, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(710, 193);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(12, 199);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(104, 33);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Öğrenci Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(12, 238);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(104, 33);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(12, 277);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(104, 33);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(12, 316);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(104, 33);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(12, 355);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(104, 33);
            this.btnBul.TabIndex = 5;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // groupOgrenci
            // 
            this.groupOgrenci.Controls.Add(this.label4);
            this.groupOgrenci.Controls.Add(this.label3);
            this.groupOgrenci.Controls.Add(this.label2);
            this.groupOgrenci.Controls.Add(this.txtOgrenciFotograf);
            this.groupOgrenci.Controls.Add(this.txtOgrenciSoyad);
            this.groupOgrenci.Controls.Add(this.txtOgrAdi);
            this.groupOgrenci.Controls.Add(this.txtOgrenciId);
            this.groupOgrenci.Controls.Add(this.label1);
            this.groupOgrenci.Location = new System.Drawing.Point(136, 199);
            this.groupOgrenci.Name = "groupOgrenci";
            this.groupOgrenci.Size = new System.Drawing.Size(311, 189);
            this.groupOgrenci.TabIndex = 6;
            this.groupOgrenci.TabStop = false;
            this.groupOgrenci.Text = "Öğrenci";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "FOTOĞRAF :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "SOYAD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "AD :";
            // 
            // txtOgrenciFotograf
            // 
            this.txtOgrenciFotograf.Location = new System.Drawing.Point(113, 148);
            this.txtOgrenciFotograf.Name = "txtOgrenciFotograf";
            this.txtOgrenciFotograf.Size = new System.Drawing.Size(150, 22);
            this.txtOgrenciFotograf.TabIndex = 18;
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(113, 106);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(150, 22);
            this.txtOgrenciSoyad.TabIndex = 17;
            // 
            // txtOgrenciId
            // 
            this.txtOgrenciId.Location = new System.Drawing.Point(113, 30);
            this.txtOgrenciId.Name = "txtOgrenciId";
            this.txtOgrenciId.Size = new System.Drawing.Size(150, 22);
            this.txtOgrenciId.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID :";
            // 
            // groupDers
            // 
            this.groupDers.Controls.Add(this.label7);
            this.groupDers.Controls.Add(this.txtDersAdi);
            this.groupDers.Controls.Add(this.txtDersId);
            this.groupDers.Controls.Add(this.label8);
            this.groupDers.Location = new System.Drawing.Point(136, 394);
            this.groupDers.Name = "groupDers";
            this.groupDers.Size = new System.Drawing.Size(311, 109);
            this.groupDers.TabIndex = 7;
            this.groupDers.TabStop = false;
            this.groupDers.Text = "Ders";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "DERS ADI :";
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(113, 64);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(150, 22);
            this.txtDersAdi.TabIndex = 16;
            // 
            // txtDersId
            // 
            this.txtDersId.Location = new System.Drawing.Point(113, 30);
            this.txtDersId.Name = "txtDersId";
            this.txtDersId.Size = new System.Drawing.Size(150, 22);
            this.txtDersId.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "ID :";
            // 
            // groupNotlar
            // 
            this.groupNotlar.Controls.Add(this.btnJoin);
            this.groupNotlar.Controls.Add(this.btnHesapla);
            this.groupNotlar.Controls.Add(this.label11);
            this.groupNotlar.Controls.Add(this.txtDurum);
            this.groupNotlar.Controls.Add(this.label10);
            this.groupNotlar.Controls.Add(this.txtOrtalama);
            this.groupNotlar.Controls.Add(this.label5);
            this.groupNotlar.Controls.Add(this.label6);
            this.groupNotlar.Controls.Add(this.label9);
            this.groupNotlar.Controls.Add(this.txtSinav3);
            this.groupNotlar.Controls.Add(this.txtSinav2);
            this.groupNotlar.Controls.Add(this.txtSinav1);
            this.groupNotlar.Location = new System.Drawing.Point(477, 199);
            this.groupNotlar.Name = "groupNotlar";
            this.groupNotlar.Size = new System.Drawing.Size(311, 304);
            this.groupNotlar.TabIndex = 8;
            this.groupNotlar.TabStop = false;
            this.groupNotlar.Text = "Notlar";
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(41, 262);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(231, 30);
            this.btnJoin.TabIndex = 27;
            this.btnJoin.Text = "Join ile Getir";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(41, 226);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(231, 30);
            this.btnHesapla.TabIndex = 26;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "DURUM :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(122, 190);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(150, 22);
            this.txtDurum.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "ORTALAMA :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(122, 152);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(150, 22);
            this.txtOrtalama.TabIndex = 22;
            this.txtOrtalama.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "SINAV 3 :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "SINAV 2 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "SINAV 1 :";
            // 
            // txtSinav3
            // 
            this.txtSinav3.Location = new System.Drawing.Point(122, 114);
            this.txtSinav3.Name = "txtSinav3";
            this.txtSinav3.Size = new System.Drawing.Size(150, 22);
            this.txtSinav3.TabIndex = 18;
            // 
            // txtSinav2
            // 
            this.txtSinav2.Location = new System.Drawing.Point(122, 72);
            this.txtSinav2.Name = "txtSinav2";
            this.txtSinav2.Size = new System.Drawing.Size(150, 22);
            this.txtSinav2.TabIndex = 17;
            // 
            // txtSinav1
            // 
            this.txtSinav1.Location = new System.Drawing.Point(122, 33);
            this.txtSinav1.Name = "txtSinav1";
            this.txtSinav1.Size = new System.Drawing.Size(150, 22);
            this.txtSinav1.TabIndex = 16;
            // 
            // btnDersListesi
            // 
            this.btnDersListesi.Location = new System.Drawing.Point(12, 394);
            this.btnDersListesi.Name = "btnDersListesi";
            this.btnDersListesi.Size = new System.Drawing.Size(104, 33);
            this.btnDersListesi.TabIndex = 9;
            this.btnDersListesi.Text = "Ders Listesi";
            this.btnDersListesi.UseVisualStyleBackColor = true;
            this.btnDersListesi.Click += new System.EventHandler(this.btnDersListesi_Click);
            // 
            // btnNotListesi
            // 
            this.btnNotListesi.Location = new System.Drawing.Point(12, 433);
            this.btnNotListesi.Name = "btnNotListesi";
            this.btnNotListesi.Size = new System.Drawing.Size(104, 33);
            this.btnNotListesi.TabIndex = 10;
            this.btnNotListesi.Text = "Not Listesi";
            this.btnNotListesi.UseVisualStyleBackColor = true;
            this.btnNotListesi.Click += new System.EventHandler(this.btnNotListesi_Click);
            // 
            // radioBtnOgrenci
            // 
            this.radioBtnOgrenci.AutoSize = true;
            this.radioBtnOgrenci.Location = new System.Drawing.Point(12, 520);
            this.radioBtnOgrenci.Name = "radioBtnOgrenci";
            this.radioBtnOgrenci.Size = new System.Drawing.Size(75, 20);
            this.radioBtnOgrenci.TabIndex = 11;
            this.radioBtnOgrenci.TabStop = true;
            this.radioBtnOgrenci.Text = "Öğrenci";
            this.radioBtnOgrenci.UseVisualStyleBackColor = true;
            // 
            // radioButtonDers
            // 
            this.radioButtonDers.AutoSize = true;
            this.radioButtonDers.Location = new System.Drawing.Point(12, 546);
            this.radioButtonDers.Name = "radioButtonDers";
            this.radioButtonDers.Size = new System.Drawing.Size(57, 20);
            this.radioButtonDers.TabIndex = 12;
            this.radioButtonDers.TabStop = true;
            this.radioButtonDers.Text = "Ders";
            this.radioButtonDers.UseVisualStyleBackColor = true;
            // 
            // btnProcedure
            // 
            this.btnProcedure.Location = new System.Drawing.Point(12, 472);
            this.btnProcedure.Name = "btnProcedure";
            this.btnProcedure.Size = new System.Drawing.Size(104, 33);
            this.btnProcedure.TabIndex = 13;
            this.btnProcedure.Text = "Prosedür";
            this.btnProcedure.UseVisualStyleBackColor = true;
            this.btnProcedure.Click += new System.EventHandler(this.btnProcedure_Click);
            // 
            // radioSirala
            // 
            this.radioSirala.AutoSize = true;
            this.radioSirala.Location = new System.Drawing.Point(136, 520);
            this.radioSirala.Name = "radioSirala";
            this.radioSirala.Size = new System.Drawing.Size(156, 20);
            this.radioSirala.TabIndex = 14;
            this.radioSirala.TabStop = true;
            this.radioSirala.Text = "Ada Göre Sırala (A-Z)";
            this.radioSirala.UseVisualStyleBackColor = true;
            // 
            // btnLinqEntity
            // 
            this.btnLinqEntity.Location = new System.Drawing.Point(477, 514);
            this.btnLinqEntity.Name = "btnLinqEntity";
            this.btnLinqEntity.Size = new System.Drawing.Size(104, 33);
            this.btnLinqEntity.TabIndex = 15;
            this.btnLinqEntity.Text = "Linq Entity";
            this.btnLinqEntity.UseVisualStyleBackColor = true;
            this.btnLinqEntity.Click += new System.EventHandler(this.btnLinqEntity_Click);
            // 
            // radioTersSirala
            // 
            this.radioTersSirala.AutoSize = true;
            this.radioTersSirala.Location = new System.Drawing.Point(136, 546);
            this.radioTersSirala.Name = "radioTersSirala";
            this.radioTersSirala.Size = new System.Drawing.Size(156, 20);
            this.radioTersSirala.TabIndex = 16;
            this.radioTersSirala.TabStop = true;
            this.radioTersSirala.Text = "Ada Göre Sırala (Z-A)";
            this.radioTersSirala.UseVisualStyleBackColor = true;
            // 
            // radioFirstThree
            // 
            this.radioFirstThree.AutoSize = true;
            this.radioFirstThree.Location = new System.Drawing.Point(136, 572);
            this.radioFirstThree.Name = "radioFirstThree";
            this.radioFirstThree.Size = new System.Drawing.Size(83, 20);
            this.radioFirstThree.TabIndex = 17;
            this.radioFirstThree.TabStop = true;
            this.radioFirstThree.Text = "İlk 3 Kayıt";
            this.radioFirstThree.UseVisualStyleBackColor = true;
            // 
            // radioDegerVarMi
            // 
            this.radioDegerVarMi.AutoSize = true;
            this.radioDegerVarMi.Location = new System.Drawing.Point(136, 598);
            this.radioDegerVarMi.Name = "radioDegerVarMi";
            this.radioDegerVarMi.Size = new System.Drawing.Size(108, 20);
            this.radioDegerVarMi.TabIndex = 18;
            this.radioDegerVarMi.TabStop = true;
            this.radioDegerVarMi.Text = "Kayıt Var Mı ?";
            this.radioDegerVarMi.UseVisualStyleBackColor = true;
            // 
            // radioSinav1
            // 
            this.radioSinav1.AutoSize = true;
            this.radioSinav1.Location = new System.Drawing.Point(136, 624);
            this.radioSinav1.Name = "radioSinav1";
            this.radioSinav1.Size = new System.Drawing.Size(156, 20);
            this.radioSinav1.TabIndex = 19;
            this.radioSinav1.TabStop = true;
            this.radioSinav1.Text = "Sınav 1 Toplam Puan";
            this.radioSinav1.UseVisualStyleBackColor = true;
            // 
            // radioSinav1Ortalama
            // 
            this.radioSinav1Ortalama.AutoSize = true;
            this.radioSinav1Ortalama.Location = new System.Drawing.Point(136, 650);
            this.radioSinav1Ortalama.Name = "radioSinav1Ortalama";
            this.radioSinav1Ortalama.Size = new System.Drawing.Size(130, 20);
            this.radioSinav1Ortalama.TabIndex = 20;
            this.radioSinav1Ortalama.TabStop = true;
            this.radioSinav1Ortalama.Text = "Sınav 1 Ortalama";
            this.radioSinav1Ortalama.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 696);
            this.Controls.Add(this.radioSinav1Ortalama);
            this.Controls.Add(this.radioSinav1);
            this.Controls.Add(this.radioDegerVarMi);
            this.Controls.Add(this.radioFirstThree);
            this.Controls.Add(this.radioTersSirala);
            this.Controls.Add(this.btnLinqEntity);
            this.Controls.Add(this.radioSirala);
            this.Controls.Add(this.btnProcedure);
            this.Controls.Add(this.radioButtonDers);
            this.Controls.Add(this.radioBtnOgrenci);
            this.Controls.Add(this.btnNotListesi);
            this.Controls.Add(this.btnDersListesi);
            this.Controls.Add(this.groupNotlar);
            this.Controls.Add(this.groupDers);
            this.Controls.Add(this.groupOgrenci);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupOgrenci.ResumeLayout(false);
            this.groupOgrenci.PerformLayout();
            this.groupDers.ResumeLayout(false);
            this.groupDers.PerformLayout();
            this.groupNotlar.ResumeLayout(false);
            this.groupNotlar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.GroupBox groupOgrenci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOgrenciFotograf;
        private System.Windows.Forms.TextBox txtOgrenciSoyad;
        private System.Windows.Forms.TextBox txtOgrenciId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupDers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.TextBox txtDersId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupNotlar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSinav3;
        private System.Windows.Forms.TextBox txtSinav2;
        private System.Windows.Forms.TextBox txtSinav1;
        private System.Windows.Forms.Button btnDersListesi;
        private System.Windows.Forms.Button btnNotListesi;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtOgrAdi;
        private System.Windows.Forms.RadioButton radioBtnOgrenci;
        private System.Windows.Forms.RadioButton radioButtonDers;
        private System.Windows.Forms.Button btnProcedure;
        private System.Windows.Forms.RadioButton radioSirala;
        private System.Windows.Forms.Button btnLinqEntity;
        private System.Windows.Forms.RadioButton radioTersSirala;
        private System.Windows.Forms.RadioButton radioFirstThree;
        private System.Windows.Forms.RadioButton radioDegerVarMi;
        private System.Windows.Forms.RadioButton radioSinav1;
        private System.Windows.Forms.RadioButton radioSinav1Ortalama;
    }
}


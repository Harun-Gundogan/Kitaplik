using System.Drawing;
using System.Windows.Forms;

namespace Kitaplik
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_Yazar = new System.Windows.Forms.TextBox();
            this.lbl_Yazar = new System.Windows.Forms.Label();
            this.txt_Sayfa = new System.Windows.Forms.TextBox();
            this.lbl_Sayfa = new System.Windows.Forms.Label();
            this.cmb_Tur = new System.Windows.Forms.ComboBox();
            this.lbl_Tur = new System.Windows.Forms.Label();
            this.rdb_Kullanilmis = new System.Windows.Forms.RadioButton();
            this.rdb_Kullanilmamis = new System.Windows.Forms.RadioButton();
            this.lbl_Durum = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.txt_Bul = new System.Windows.Forms.TextBox();
            this.lbl_Bul = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1013, 298);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Location = new System.Drawing.Point(58, 71);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(92, 28);
            this.lbl_Ad.TabIndex = 14;
            this.lbl_Ad.Text = "Kitap Ad:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(157, 68);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(196, 34);
            this.txt_Ad.TabIndex = 2;
            // 
            // txt_Yazar
            // 
            this.txt_Yazar.Location = new System.Drawing.Point(157, 108);
            this.txt_Yazar.Name = "txt_Yazar";
            this.txt_Yazar.Size = new System.Drawing.Size(196, 34);
            this.txt_Yazar.TabIndex = 3;
            // 
            // lbl_Yazar
            // 
            this.lbl_Yazar.AutoSize = true;
            this.lbl_Yazar.Location = new System.Drawing.Point(59, 111);
            this.lbl_Yazar.Name = "lbl_Yazar";
            this.lbl_Yazar.Size = new System.Drawing.Size(91, 28);
            this.lbl_Yazar.TabIndex = 15;
            this.lbl_Yazar.Text = "Yazar Ad:";
            // 
            // txt_Sayfa
            // 
            this.txt_Sayfa.Location = new System.Drawing.Point(157, 148);
            this.txt_Sayfa.Name = "txt_Sayfa";
            this.txt_Sayfa.Size = new System.Drawing.Size(196, 34);
            this.txt_Sayfa.TabIndex = 4;
            // 
            // lbl_Sayfa
            // 
            this.lbl_Sayfa.AutoSize = true;
            this.lbl_Sayfa.Location = new System.Drawing.Point(33, 154);
            this.lbl_Sayfa.Name = "lbl_Sayfa";
            this.lbl_Sayfa.Size = new System.Drawing.Size(117, 28);
            this.lbl_Sayfa.TabIndex = 16;
            this.lbl_Sayfa.Text = "Sayfa Sayisi:";
            // 
            // cmb_Tur
            // 
            this.cmb_Tur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tur.FormattingEnabled = true;
            this.cmb_Tur.Items.AddRange(new object[] {
            "Hikaye",
            "Şiir",
            "Roman",
            "Tiyatro"});
            this.cmb_Tur.Location = new System.Drawing.Point(157, 188);
            this.cmb_Tur.Name = "cmb_Tur";
            this.cmb_Tur.Size = new System.Drawing.Size(196, 36);
            this.cmb_Tur.TabIndex = 5;
            // 
            // lbl_Tur
            // 
            this.lbl_Tur.AutoSize = true;
            this.lbl_Tur.Location = new System.Drawing.Point(106, 196);
            this.lbl_Tur.Name = "lbl_Tur";
            this.lbl_Tur.Size = new System.Drawing.Size(44, 28);
            this.lbl_Tur.TabIndex = 17;
            this.lbl_Tur.Text = "Tür:";
            // 
            // rdb_Kullanilmis
            // 
            this.rdb_Kullanilmis.AutoSize = true;
            this.rdb_Kullanilmis.Location = new System.Drawing.Point(156, 230);
            this.rdb_Kullanilmis.Name = "rdb_Kullanilmis";
            this.rdb_Kullanilmis.Size = new System.Drawing.Size(127, 32);
            this.rdb_Kullanilmis.TabIndex = 6;
            this.rdb_Kullanilmis.TabStop = true;
            this.rdb_Kullanilmis.Text = "Kullanılmış";
            this.rdb_Kullanilmis.UseVisualStyleBackColor = true;
            this.rdb_Kullanilmis.CheckedChanged += new System.EventHandler(this.rdb_Kullanilmis_CheckedChanged);
            // 
            // rdb_Kullanilmamis
            // 
            this.rdb_Kullanilmamis.AutoSize = true;
            this.rdb_Kullanilmamis.Location = new System.Drawing.Point(156, 268);
            this.rdb_Kullanilmamis.Name = "rdb_Kullanilmamis";
            this.rdb_Kullanilmamis.Size = new System.Drawing.Size(154, 32);
            this.rdb_Kullanilmamis.TabIndex = 7;
            this.rdb_Kullanilmamis.TabStop = true;
            this.rdb_Kullanilmamis.Text = "Kullanılmamış";
            this.rdb_Kullanilmamis.UseVisualStyleBackColor = true;
            this.rdb_Kullanilmamis.CheckedChanged += new System.EventHandler(this.rdb_Kullanilmamis_CheckedChanged);
            // 
            // lbl_Durum
            // 
            this.lbl_Durum.AutoSize = true;
            this.lbl_Durum.Location = new System.Drawing.Point(74, 230);
            this.lbl_Durum.Name = "lbl_Durum";
            this.lbl_Durum.Size = new System.Drawing.Size(76, 28);
            this.lbl_Durum.TabIndex = 18;
            this.lbl_Durum.Text = "Durum:";
            // 
            // txt_Id
            // 
            this.txt_Id.Enabled = false;
            this.txt_Id.Location = new System.Drawing.Point(157, 28);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(196, 34);
            this.txt_Id.TabIndex = 1;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(66, 34);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(84, 28);
            this.lbl_Id.TabIndex = 13;
            this.lbl_Id.Text = "Kitap Id:";
            // 
            // btn_Listele
            // 
            this.btn_Listele.Location = new System.Drawing.Point(432, 28);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(143, 34);
            this.btn_Listele.TabIndex = 8;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(432, 68);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(143, 34);
            this.btn_Kaydet.TabIndex = 9;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(432, 108);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(143, 34);
            this.btn_Guncelle.TabIndex = 10;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(432, 148);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(143, 34);
            this.btn_Sil.TabIndex = 11;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // txt_Bul
            // 
            this.txt_Bul.Location = new System.Drawing.Point(432, 222);
            this.txt_Bul.Name = "txt_Bul";
            this.txt_Bul.Size = new System.Drawing.Size(143, 34);
            this.txt_Bul.TabIndex = 20;
            this.txt_Bul.Text = "Kitap Bul";
            this.txt_Bul.TextChanged += new System.EventHandler(this.txt_Bul_TextChanged);
            // 
            // lbl_Bul
            // 
            this.lbl_Bul.AutoSize = true;
            this.lbl_Bul.Location = new System.Drawing.Point(455, 191);
            this.lbl_Bul.Name = "lbl_Bul";
            this.lbl_Bul.Size = new System.Drawing.Size(97, 28);
            this.lbl_Bul.TabIndex = 19;
            this.lbl_Bul.Text = "Kitap Adı:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(602, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 224);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1037, 630);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Bul);
            this.Controls.Add(this.lbl_Bul);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Durum);
            this.Controls.Add(this.rdb_Kullanilmamis);
            this.Controls.Add(this.rdb_Kullanilmis);
            this.Controls.Add(this.lbl_Tur);
            this.Controls.Add(this.cmb_Tur);
            this.Controls.Add(this.txt_Sayfa);
            this.Controls.Add(this.lbl_Sayfa);
            this.Controls.Add(this.txt_Yazar);
            this.Controls.Add(this.lbl_Yazar);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.lbl_Ad);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label lbl_Ad;
        private TextBox txt_Ad;
        private TextBox txt_Yazar;
        private Label lbl_Yazar;
        private TextBox txt_Sayfa;
        private Label lbl_Sayfa;
        private ComboBox cmb_Tur;
        private Label lbl_Tur;
        private RadioButton rdb_Kullanilmis;
        private RadioButton rdb_Kullanilmamis;
        private Label lbl_Durum;
        private TextBox txt_Id;
        private Label lbl_Id;
        private Button btn_Listele;
        private Button btn_Kaydet;
        private Button btn_Guncelle;
        private Button btn_Sil;
        private TextBox txt_Bul;
        private Label lbl_Bul;
        private PictureBox pictureBox1;
    }
}

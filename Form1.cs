using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kitaplik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\harun\\OneDrive\\Masaüstü\\Kitaplik.accdb");

        void listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from Kitaplar",baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        void temizle()
        {
            txt_Id.Text = "";
            txt_Ad.Text = "";
            txt_Yazar.Text = "";
            txt_Sayfa.Text = "";
            cmb_Tur.Items.Clear();
            rdb_Kullanilmamis.Checked = false;
            rdb_Kullanilmis.Checked = false;
            txt_Ad.Focus();
        }
            private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            listele();
        }

        string durum = "";
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (txt_Ad.Text == "" || txt_Yazar.Text == "" || cmb_Tur.Text == "" || txt_Sayfa.Text == "" || durum == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("Insert into Kitaplar (Ad, Yazar, Tur, Sayfa, Durum) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
                    komut.Parameters.AddWithValue("@p1", txt_Ad.Text);
                    komut.Parameters.AddWithValue("@p2", txt_Yazar.Text);
                    komut.Parameters.AddWithValue("@p3", cmb_Tur.Text);
                    komut.Parameters.AddWithValue("@p4", txt_Sayfa.Text);
                    komut.Parameters.AddWithValue("@p5", durum);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kitap Eklendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                    temizle();
                }
                catch (Exception)
                {

                    MessageBox.Show("Bir hata oluştu.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            }
                
        }

        private void rdb_Kullanilmis_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void rdb_Kullanilmamis_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_Id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_Yazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmb_Tur.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_Sayfa.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "True")
            {
                rdb_Kullanilmamis.Checked = true;
            }
            else
            {
                rdb_Kullanilmis.Checked = true;
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (txt_Id.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("Delete from Kitaplar where Id=@p1", baglanti);
                    komut.Parameters.AddWithValue("@p1", txt_Id.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kitap Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    listele();
                    temizle();
                }
                catch (Exception)
                {

                    MessageBox.Show("Bir Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                
           

        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (txt_Ad.Text == "" || txt_Yazar.Text == "" || cmb_Tur.Text == "" || txt_Sayfa.Text == "" || durum == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("Update Kitaplar set Ad=@p1, Yazar=@p2, Tur=@p3, Sayfa=@p4, Durum=@p5 where Id=@p6", baglanti);
                    komut.Parameters.AddWithValue("@p1", txt_Ad.Text);
                    komut.Parameters.AddWithValue("@p2", txt_Yazar.Text);
                    komut.Parameters.AddWithValue("@p3", cmb_Tur.Text);
                    komut.Parameters.AddWithValue("@p4", txt_Sayfa.Text);
                    komut.Parameters.AddWithValue("@p5", durum);
                    komut.Parameters.AddWithValue("@p6", txt_Id.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kitap Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    listele();
                    temizle();
                }
                catch (Exception)
                {

                    MessageBox.Show("Bir Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }
              
        private void txt_Bul_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand komut = new OleDbCommand("Select * from Kitaplar where ad like '%" + txt_Bul.Text + "%'", baglanti);

                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(komut);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}

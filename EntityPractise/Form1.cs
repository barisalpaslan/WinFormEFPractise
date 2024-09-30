using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityPractise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        //ado.net sql komutları
        private void btnDersListesi_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-UEP6LN2;Initial Catalog=DbSinavOgrenci;Integrated Security=True;");
            SqlCommand komut = new SqlCommand("Select * From TBL_DERSLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable  dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //entityframework linq ile listeleme
        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBL_OGRENCI.ToList();

            //yöntem 1
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void btnNotListesi_Click(object sender, EventArgs e)
        {
            var query = from item in db.TBL_NOTLAR
                        select new
                        {
                            item.ID,
                            item.TBL_OGRENCI.ADI,
                            item.TBL_DERSLER.DERSADI,
                            item.SINAV1,
                            item.SINAV2,
                            item.SINAV3,
                            item.ORTALAMA,
                            item.DURUM
                        };
            dataGridView1.DataSource = query.ToList();

            //dataGridView1.DataSource = db.TBL_NOTLAR.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(radioBtnOgrenci.Checked)
            {
                TBL_OGRENCI t = new TBL_OGRENCI();
                t.ADI = txtOgrAdi.Text;
                t.SOYAD = txtOgrenciSoyad.Text;
                db.TBL_OGRENCI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Öğrenci Listeye Eklenmiştir.");
            }
            else if(radioButtonDers.Checked)
            {
                TBL_DERSLER d = new TBL_DERSLER();
                d.DERSADI = txtDersAdi.Text;
                db.TBL_DERSLER.Add(d);
                db.SaveChanges();
                MessageBox.Show("Ders Listeye Eklenmiştir.");
            }
            else 
            {
                MessageBox.Show("Lütfen bir işlem seçiniz !");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (radioBtnOgrenci.Checked)
            {
                int id = Convert.ToInt32(txtOgrenciId.Text);
                var x = db.TBL_OGRENCI.Find(id);
                db.TBL_OGRENCI.Remove(x);
                db.SaveChanges();
                MessageBox.Show("Öğrenci Sistemden Silinmiştir.");
            }
            else if (radioButtonDers.Checked)
            {
                int id = Convert.ToInt32(txtDersId.Text);
                var x = db.TBL_DERSLER.Find(id);
                db.TBL_DERSLER.Remove(x);
                db.SaveChanges();
                MessageBox.Show("Ders Sistemden Silinmiştir.");
            }
            else
            {
                MessageBox.Show("Lütfen bir işlem seçiniz !");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (radioBtnOgrenci.Checked)
            {
                int id = Convert.ToInt32(txtOgrenciId.Text);
                var x = db.TBL_OGRENCI.Find(id);
                x.ADI = txtOgrAdi.Text;
                x.SOYAD = txtOgrenciSoyad.Text;
                x.FOTOGRAF = txtOgrenciFotograf.Text;
                db.SaveChanges();
                MessageBox.Show("Öğrenci Bilgileri Başarıyla Güncellendi.");

            }
            else if (radioButtonDers.Checked)
            {
                int id = Convert.ToInt32(txtDersId.Text);
                var x = db.TBL_DERSLER.Find(id);
                x.DERSADI = txtDersAdi.Text;
                db.SaveChanges();
                MessageBox.Show("Ders Bilgileri Başarıyla Güncellendi.");
            }
            else
            {
                MessageBox.Show("Lütfen bir işlem seçiniz !");
            }
        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.NOTLISTESI();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBL_OGRENCI.Where(x => x.ADI == txtOgrAdi.Text || x.SOYAD == txtOgrenciSoyad.Text).ToList();
        }

        //ad kutusuna değer yazıldığı anda o değeri getirme.
        //bul butonu kullanılmak istenirse yukarıdaki method(şu an gereksiz)
        private void txtOgrAdi_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtOgrAdi.Text;
            var degerler = from x in db.TBL_OGRENCI
                           where x.ADI.Contains(aranan)
                           select x;

            dataGridView1.DataSource = degerler.ToList();
        }

        private void btnLinqEntity_Click(object sender, EventArgs e)
        {
            if(radioSirala.Checked == true) 
            {
                List<TBL_OGRENCI> liste1 = db.TBL_OGRENCI.OrderBy(x => x.ADI).ToList();
                dataGridView1.DataSource = liste1;
            }
            if(radioTersSirala.Checked == true)
            {
                List<TBL_OGRENCI> liste2 = db.TBL_OGRENCI.OrderByDescending(x => x.ADI).ToList();
                dataGridView1.DataSource = liste2;
            }
            if(radioFirstThree.Checked == true)
            {
                List<TBL_OGRENCI> liste3 = db.TBL_OGRENCI.Take(3).ToList();
                dataGridView1.DataSource = liste3;
            }
            if(radioDegerVarMi.Checked == true)
            {
                bool deger = db.TBL_OGRENCI.Any();
                MessageBox.Show(deger.ToString(),"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (radioSinav1.Checked == true)
            {
                var toplam = db.TBL_NOTLAR.Sum(x => x.SINAV1);
                MessageBox.Show(toplam.ToString(), "1. Sınavların Toplamı : ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioSinav1Ortalama.Checked == true)
            {
                var ortalama = db.TBL_NOTLAR.Average(x => x.SINAV1);
                MessageBox.Show(ortalama.ToString(), "1. Sınavların Ortalaması : ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //btnNotListesi_Click methodunun alternatifi, joinli hali
        private void btnJoin_Click(object sender, EventArgs e)
        {
            var sorgu = from d1 in db.TBL_NOTLAR
                        join d2 in db.TBL_OGRENCI
                        on d1.OGRID equals d2.ID
                        join d3 in db.TBL_DERSLER
                        on d1.DERS equals d3.ID
                        select new
                        {
                             OGRENCI = d2.ADI + " " + d2.SOYAD,
                             //SOYADI = d2.SOYAD,
                             DERS = d3.DERSADI,
                             SINAV1 = d1.SINAV1,
                             SINAV2 = d1.SINAV2,
                             SINAV3 = d1.SINAV3,
                             ORTALAMA = d1.ORTALAMA,
                        };
            dataGridView1.DataSource = sorgu.ToList();
        }
    }
}

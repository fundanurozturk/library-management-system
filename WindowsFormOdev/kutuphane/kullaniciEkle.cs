using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormOdev.kutuphane
{
  public partial class kullaniciEkle : UserControl
  {
    Tumkodlar kodlar = new Tumkodlar();
    public kullaniciEkle()
    {
      InitializeComponent();
    }
      void yeniler()
    {
        dtKullanicilar.DataSource = kodlar.TumKullanicilar();
        dtKullanicilar.Columns[0].Visible = false;
        dtKullanicilar.Columns[1].HeaderText = "ID";
        dtKullanicilar.Columns[1].Width = 100;
        dtKullanicilar.Columns[2].HeaderText = "Password";
        dtKullanicilar.Columns[2].Width = 60;
        dtKullanicilar.Columns[3].HeaderText = "Full Name";
        dtKullanicilar.Columns[3].Width = 100;
        dtKullanicilar.Columns[4].HeaderText = "Authority";
        dtKullanicilar.Columns[4].Width = 60;
        dtKullanicilar.Columns[5].HeaderText = "Class";
        dtKullanicilar.Columns[5].Width = 60;
        dtKullanicilar.Columns[6].HeaderText = "School Number";
        dtKullanicilar.Columns[6].Width = 60;
        dtKullanicilar.Columns[7].HeaderText = "Date of Birth";
        dtKullanicilar.Columns[7].Width = 100;
        dtKullanicilar.Columns[8].HeaderText = "Place of Birth";
        dtKullanicilar.Columns[8].Width = 100;
        dtKullanicilar.Columns[9].HeaderText = "Phone Number";
        dtKullanicilar.Columns[9].Width = 50;
        dtKullanicilar.Columns[10].HeaderText = "Email";
        dtKullanicilar.Columns[10].Width = 50;
        dtKullanicilar.Columns[11].HeaderText = "Join History";
        dtKullanicilar.Columns[11].Width = 110;
        dtKullanicilar.Columns[12].HeaderText = "Gender";
        dtKullanicilar.Columns[12].Width = 80;
        dtKullanicilar.Columns[13].HeaderText = "Address";
        dtKullanicilar.Columns[13].Width = 80;
    }
    void Yukle()
    {
      btnGuncelle.Visible = false;
      btnSil.Visible = false;
      rTc.Checked = true;
      cmbCinsiyet.SelectedIndex = 0;
      txtYetki.SelectedIndex = 0;
      yeniler();
    }

    private void kullaniciEkle_Load(object sender, EventArgs e)
    {
      Yukle();
    }

    private void txtAra_TextChanged(object sender, EventArgs e)
    {
      if (rTc.Checked == true)
      {
          dtKullanicilar.DataSource = kodlar.KullaniciArama1(txtAra.Text.ToString());
      }
      else if (rİsim.Checked == true)
      {
          dtKullanicilar.DataSource = kodlar.KullaniciArama2(txtAra.Text.ToString());
      }
      else if (rSinif.Checked == true)
      {
          dtKullanicilar.DataSource = kodlar.KullaniciArama3(txtAra.Text.ToString());
      }
   }

    private void btnGetir_Click(object sender, EventArgs e)
    {
      DataTable kutuphane = kodlar.KullaniciBul(txtTc.Text);
      if (kutuphane.Rows.Count == 0)
      {
        MessageBox.Show("No users found. Please Enter the ID of the Person You Want to Call...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        txtSifre.Text = kutuphane.Rows[0]["Sifre"].ToString();
        txtAd.Text = kutuphane.Rows[0]["Adsoyad"].ToString();
        txtYetki.Text = kutuphane.Rows[0]["Yetki"].ToString();
        txtSinif.Text = kutuphane.Rows[0]["Sinif"].ToString();
        txtNo.Text = kutuphane.Rows[0]["Numara"].ToString();
        cmbDtarih.Text = kutuphane.Rows[0]["DogumT"].ToString();
        txtDyeri.Text = kutuphane.Rows[0]["DogumY"].ToString();
        txtTel.Text = kutuphane.Rows[0]["Telefon"].ToString();
        txtEposta.Text = kutuphane.Rows[0]["Eposta"].ToString();
        cmbUtarih.Text = kutuphane.Rows[0]["UyelikT"].ToString();
        cmbCinsiyet.Text = kutuphane.Rows[0]["Cinsiyet"].ToString();
        txtAdres.Text = kutuphane.Rows[0]["Adres"].ToString();
        btnEkle.Visible = false;
        btnGetir.Enabled = false;
        btnGuncelle.Visible = true;
        btnSil.Visible = true;
        txtTc.Enabled = false;
      }
    }

    private void label9_Click(object sender, EventArgs e)
    {
      Yeni();
    }

    private void btnYeni_Click(object sender, EventArgs e)
    {
      Yeni();
    }
    void Yeni()
    {
      txtTc.Text = "";
      txtSifre.Text = "";
      txtAd.Text = "";
      txtSinif.Text = "";
      txtNo.Text = "";
      cmbDtarih.Text = "";
      txtDyeri.Text = "";
      txtTel.Text = "";
      txtEposta.Text = "";
      cmbUtarih.Text = "";
      txtAdres.Text = "";
      cmbCinsiyet.SelectedIndex = 0;
      txtYetki.SelectedIndex = 0;
      btnEkle.Visible = true;
      btnGetir.Enabled = true;
      btnGuncelle.Visible = false;
      btnSil.Visible = false;
      txtTc.Enabled = true;
    }
    private void btnEkle_Click(object sender, EventArgs e)
    {
      if (txtTc.Text.Length == 0 || txtSifre.Text.Length == 0 || txtSinif.Text.Length == 0 || txtYetki.Text.Length == 0 || txtEposta.Text.Length == 0 || txtTel.Text.Length == 0 || txtAdres.Text.Length == 0 || txtAd.Text.Length == 0)
      {
        MessageBox.Show("There are missing fields, please fill them in...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        if(txtTc.Text.Length<11)
        {
          MessageBox.Show("Please enter your TR ID number in full (11 DIGITS)");
        }
        else
        {
          if (kodlar.KullaniciKontrol(txtTc.Text) == true)
          {
            kodlar.KullaniciEkle(txtTc.Text, txtSifre.Text, txtAd.Text, txtYetki.Text, txtSinif.Text, txtNo.Text, cmbDtarih.Text, txtDyeri.Text, txtTel.Text, txtEposta.Text, cmbUtarih.Text, cmbCinsiyet.Text, txtAdres.Text);
            yeniler();
            MessageBox.Show("Registration Completed...");
          }
          else
          {
            MessageBox.Show("User ID number has been added before.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
        }
      }
    }

    private void btnGuncelle_Click(object sender, EventArgs e)
    {
      if (txtSifre.Text.Length == 0 || txtSinif.Text.Length == 0 || txtYetki.Text.Length == 0 || txtEposta.Text.Length == 0 || txtTel.Text.Length == 0 || txtAdres.Text.Length == 0 || txtAd.Text.Length == 0)
      {
        MessageBox.Show("There are missing fields, please fill them in...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        kodlar.KullaniciGuncelle(txtTc.Text, txtSifre.Text, txtAd.Text, txtYetki.Text, txtSinif.Text, txtNo.Text, cmbDtarih.Text, txtDyeri.Text, txtTel.Text, txtEposta.Text, cmbUtarih.Text, cmbCinsiyet.Text, txtAdres.Text);
        yeniler();
        MessageBox.Show("Update Completed...");
      }
    }

    private void btnSil_Click(object sender, EventArgs e)
    {
      DialogResult dr = MessageBox.Show("Are You Sure You Want to Deregister", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (dr == DialogResult.Yes)
      {
        kodlar.KullaniciSil(txtTc.Text);
        MessageBox.Show("Deletion Process Completed.");
        yeniler();
        Yeni();
      }
    }
  }
}

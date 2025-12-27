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
  public partial class emanetver : UserControl
  {
    Tumkodlar kodlar = new Tumkodlar();
    public emanetver()
    {
      InitializeComponent();
    }
    private void emanet_Load(object sender, EventArgs e)
    {
      yeniler();
    }
    void random()
    {
      Random rastgele = new Random();
      int sayi = rastgele.Next(100000, 999999);
      txtEmanetNo.Text = sayi.ToString();
    }
    void yeniler()
    {
      random();
      txtDurum.Text = "Borrowed";

      

      dtUyeler.DataSource = kodlar.EmanetVer2();
      dtUyeler.Columns[0].Visible = false;
      dtUyeler.Columns[1].Width = 114;
      dtUyeler.Columns[1].HeaderText = "ID Number";
      dtUyeler.Columns[2].Visible = false;
      dtUyeler.Columns[3].Width = 130;
      dtUyeler.Columns[3].HeaderText = "Full Name";
      dtUyeler.Columns[4].Visible = false;
      dtUyeler.Columns[5].Visible = false;
      dtUyeler.Columns[6].Visible = false;
      dtUyeler.Columns[7].Visible = false;
      dtUyeler.Columns[8].Visible = false;
      dtUyeler.Columns[9].HeaderText = "Phone Number";
      dtUyeler.Columns[9].Width = 120;
      dtUyeler.Columns[10].HeaderText = "Email Address";
      dtUyeler.Columns[10].Width = 180;
      dtUyeler.Columns[11].Visible = false;
      dtUyeler.Columns[12].Visible = false;
      dtUyeler.Columns[13].Visible = false;
      

      dtKitaplar.DataSource = kodlar.EmanetVer3(); 
      dtKitaplar.Columns[0].Visible = false;
      dtKitaplar.Columns[1].Width = 92;
      dtKitaplar.Columns[1].HeaderText = "Barcode Number";
      dtKitaplar.Columns[2].Width = 176;
      dtKitaplar.Columns[2].HeaderText = "Book Name";
      dtKitaplar.Columns[3].Visible = false;
      dtKitaplar.Columns[4].Visible = false;
      dtKitaplar.Columns[5].HeaderText = "Book Type";
      dtKitaplar.Columns[6].Visible = false;
      dtKitaplar.Columns[7].HeaderText = "Stock Number";
      dtKitaplar.Columns[8].Visible = false;
    }
    private void textBox5_TextChanged(object sender, EventArgs e)
    {
        dtUyeler.DataSource = kodlar.emanetAramaUye(uyeArama.Text);
    }

    private void kitapArama_TextChanged(object sender, EventArgs e)
    {
        dtKitaplar.DataSource = kodlar.emanetAramaKitap(kitapArama.Text);
    }

    private void tcCek_Click(object sender, EventArgs e)
    {
      DataTable kutuphane = kodlar.UyeBul(txtTc.Text);
      if (kutuphane.Rows.Count == 0)
      {
        MessageBox.Show("ID No users found. Please Enter the ID of the Person You Want to Call....", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        
        txtAd.Text = kutuphane.Rows[0]["Adsoyad"].ToString();
        txtSinif.Text = kutuphane.Rows[0]["Sinif"].ToString();
        txtNo.Text = kutuphane.Rows[0]["Numara"].ToString();
        tcCek.Enabled = false;
        txtTc.Enabled = false;
      }
    }
    void Temizle()
    {
      random();
      txtDurum.Text = "Borrowed";
      txtAd.Text = "";
      txtBarkod.Text = "";
      txtHasar.Text = "";
      txtKitapAdi.Text = "";
      txtNo.Text = "";
      txtSinif.Text = "";
      txtTc.Text = "";
      txtTur.Text = "";
      txtVerilis.Text = "";
      txtTeslim.Text = "";
      tcCek.Enabled = true;
      barkodCek.Enabled = true;
      txtBarkod.Enabled = true;
      txtTc.Enabled = true;
    }
    private void button2_Click(object sender, EventArgs e)
    {
      Temizle();
    }

    private void barkodCek_Click(object sender, EventArgs e)
    {
      DataTable kutuphane = kodlar.KitapBul2(txtBarkod.Text);
      if (kutuphane.Rows.Count == 0)
      {
        MessageBox.Show("No books found. Please Enter the Barcode Code of the Book You Want to Search...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        txtKitapAdi.Text = kutuphane.Rows[0]["KitapAdi"].ToString();
        txtBarkod.Text = kutuphane.Rows[0]["Barkod"].ToString();
        txtTur.Text = kutuphane.Rows[0]["KitapTuru"].ToString();
        txtHasar.Text = kutuphane.Rows[0]["Hasar"].ToString();
        txtStok.Text = kutuphane.Rows[0]["StokSayisi"].ToString();
        txtBarkod.Enabled = false;
        barkodCek.Enabled = false;
        int i = int.Parse(txtStok.Text.ToString());
        int sayi = 1;
        i = i - sayi;
        txtStok.Text = i.ToString();
      }
      

    }
    private void button1_Click(object sender, EventArgs e)
    {
      
      if(txtAd.Text.Length==0 || txtKitapAdi.Text.Length==0)
      {
        MessageBox.Show("There is Empty Space Please Fill It...");
      }
      else
      {
        if(kodlar.EmanetKontrol(txtEmanetNo.Text)==false)
        {
          MessageBox.Show("Escrow Number Added Earlier. Please make a new Login.");
        }
        else
        {
          int i = int.Parse(txtStok.Text);
          if (i==0 || i<0)
          {
            MessageBox.Show("The book to be entrusted is not in stock at the moment.");
          }
          else
          {
            kodlar.KitapGuncelle2(txtKitapAdi.Text, txtStok.Text);
            kodlar.EmanetVer(txtEmanetNo.Text, txtAd.Text, txtTc.Text, txtNo.Text, txtSinif.Text, txtBarkod.Text, txtKitapAdi.Text, txtTur.Text, txtHasar.Text, txtVerilis.Text, txtTeslim.Text, txtDurum.Text);
            MessageBox.Show("The Escrow Process has been completed... " + txtKitapAdi.Text.ToString() + " New Stock Number of the Book = " + txtStok.Text.ToString(), "Loan Created", MessageBoxButtons.OK, MessageBoxIcon.None);
            Temizle();
            yeniler();
          }
         
        }
      }
    }
  }
}

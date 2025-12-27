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
    public partial class emanetal : UserControl
    {
    Tumkodlar kodlar = new Tumkodlar();
    public emanetal()
    {
      InitializeComponent();
    }

    public static string durum;
    void yeniler()
    {
      dataGridView1.DataSource = kodlar.EmanetAl();
      dataGridView1.Columns[0].Visible = false;
      dataGridView1.Columns[1].HeaderText = "Loan No";
      dataGridView1.Columns[2].HeaderText = "Full Name";
      dataGridView1.Columns[3].HeaderText = "ID Number";
      dataGridView1.Columns[4].HeaderText = "School Number";
      dataGridView1.Columns[5].HeaderText = "Class";
      dataGridView1.Columns[6].HeaderText = "Barcode Code";
      dataGridView1.Columns[7].HeaderText = "Book Name";
      dataGridView1.Columns[8].HeaderText = "Book Type";
      dataGridView1.Columns[9].HeaderText = "Damage Condition";
      dataGridView1.Columns[10].HeaderText = "Date of Issue";
      dataGridView1.Columns[11].HeaderText = "Delivery Date";
      dataGridView1.Columns[12].HeaderText = "Status";
        }
        void Temizle()
    {
      txtİptal.Text = "";
      txtEmanetAl.Text = "";
    }
    private void emanetal_Load_1(object sender, EventArgs e)
    {
        yeniler();
    }

    private void txtAd_TextChanged(object sender, EventArgs e)
    {
        dataGridView1.DataSource = kodlar.emanetArama1(txtAd.Text.ToString());
    }

    private void txtTc_TextChanged(object sender, EventArgs e)
    {
      dataGridView1.DataSource = kodlar.emanetArama2(txtTc.Text.ToString());
    }

    private void txtKitapAdi_TextChanged(object sender, EventArgs e)
    {
      dataGridView1.DataSource = kodlar.emanetArama3(txtKitapAdi.Text.ToString());
    }

    private void btnEmanetAl_Click_1(object sender, EventArgs e)
    {
        if (kodlar.EmanetKontrol(txtEmanetAl.Text) == true || txtEmanetAl.Text == "")
        {
            MessageBox.Show("There is no such Escrow Number or there is free space. Please make sure you enter correctly.", "ERROR");
        }
        else
        {
            DataTable kutuphane = kodlar.EmanetGetir(txtEmanetAl.Text);
            textBox2.Text= kutuphane.Rows[0]["KitapAdi"].ToString();
            DataTable kutuphane1 = kodlar.KitapBul(textBox2.Text);
            textBox1.Text = kutuphane1.Rows[0]["StokSayisi"].ToString();
            int i = int.Parse(textBox1.Text.ToString());
            int sayi = 1;
            i = i + sayi;
            textBox1.Text = i.ToString();
            kodlar.KitapGuncelle2(textBox2.Text, textBox1.Text);
            kodlar.DurumGuncelle(txtEmanetAl.Text, durum = "Returned".ToString());
            MessageBox.Show("Escrow returned... " + textBox2.Text.ToString()+ " New Stock Number of the Book = " + textBox1.Text.ToString());
            yeniler();
            Temizle();
        }
    }
    private void btnİptal_Click(object sender, EventArgs e)
    {
        if (kodlar.EmanetKontrol(txtİptal.Text) == true || txtİptal.Text == "")
        {
            MessageBox.Show("There is no such Escrow Number or there is free space. Please make sure you enter it correctly.", "ERROR");
        }
        else
        {
            DialogResult dr = MessageBox.Show("Cancel the escrow process?", "CANCEL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
          DataTable kutuphane = kodlar.EmanetGetir(txtİptal.Text);
          textBox2.Text = kutuphane.Rows[0]["KitapAdi"].ToString();
          DataTable kutuphane1 = kodlar.KitapBul(textBox2.Text);
          textBox1.Text = kutuphane1.Rows[0]["StokSayisi"].ToString();
          int i = int.Parse(textBox1.Text.ToString());
          int sayi = 1;
          i = i + sayi;
          textBox1.Text = i.ToString();
          kodlar.KitapGuncelle2(textBox2.Text, textBox1.Text);
          kodlar.EmanetSil(txtİptal.Text);
                MessageBox.Show("Escrow Canceled... " + textBox2.Text.ToString() + " New Stock Number of the Book = " + textBox1.Text.ToString());
                yeniler();
                Temizle();
            }
        }
    }

    private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        foreach (DataGridViewRow satir in dataGridView1.Rows)
        {
            if (satir.Cells["Durum"].Value.ToString() == "Returned")
            {
                satir.DefaultCellStyle.BackColor = Color.Green;
            }
            else
            {
                satir.DefaultCellStyle.BackColor = Color.Red;
            }
        }
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (kodlar.EmanetKontrol(textBox3.Text) == true || textBox3.Text == "")
      {
        MessageBox.Show("There is no such Escrow Number or there is free space. Please make sure you enter it correctly.", "ERROR");
      }
      else
      {
        DialogResult dr = MessageBox.Show("Should the Escrow Be Deleted?", "Escrow Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dr == DialogResult.Yes)
        {
          DataTable kutuphane = kodlar.EmanetGetir(textBox3.Text);
          textBox2.Text = kutuphane.Rows[0]["KitapAdi"].ToString();
          DataTable kutuphane1 = kodlar.KitapBul(textBox2.Text);
          textBox1.Text = kutuphane1.Rows[0]["StokSayisi"].ToString();
          kodlar.EmanetSil(textBox3.Text);
          MessageBox.Show("You want to delete " + textBox2.Text.ToString()+ " The Book Named Was Deleted From The Escrow History..");
          yeniler();
          Temizle();
        }
      }
    }
  }
}

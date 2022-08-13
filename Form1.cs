using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;//www.gorselprogramlama.com/
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form2 frm2;
        public Form3 frm3;

        public Form1()
        {
            InitializeComponent();
            frm2 = new Form2();
            frm3 = new Form3();

            frm2.frm1 = this;
            frm3.frm1 = this;

        }
        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ace.Oledb.12.0;Data Source=data.accdb");
        public OleDbConnection bag1 = new OleDbConnection("Provider=Microsoft.ace.Oledb.12.0;Data Source=data.accdb");
        public OleDbCommand kmt = new OleDbCommand();
        public OleDbCommand kmt1 = new OleDbCommand();
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public DataSet dtst = new DataSet();

        public void combo()
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from bos";
            OleDbDataReader Parsel;
            Parsel = kmt.ExecuteReader();
            while (Parsel.Read())
            {
                comboBox1.Items.Add(Parsel[0].ToString());
            }
            bag.Close();
            Parsel.Dispose();
            comboBox1.Sorted = true;
        }
        public void combo2()
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from dolu";
            OleDbDataReader Parsel;
            Parsel = kmt.ExecuteReader();
            while (Parsel.Read())
            {
                frm3.comboBox1.Items.Add(Parsel[0].ToString());
            }
            bag.Close();
            Parsel.Dispose();
            frm3.comboBox1.Sorted = true;

        }
        public void listele()
        {
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From musbil", bag);
            adtr.Fill(dtst, "musbil");
            frm3.dataView1.Table = dtst.Tables[0];
            frm3.dataGrid1.DataSource = frm3.dataView1;
            adtr.Dispose();
            bag.Close();

        }//alionurulker@gmail.com
        public void sahayaz()
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from musbil";
            OleDbDataReader Parsel;
            Parsel = kmt.ExecuteReader();
            while (Parsel.Read())
            {
                switch (Parsel[11].ToString())
                {
                    case "PARSEL1":
                        {
                            frm2.btn1.Text = Parsel[1].ToString();
                            frm2.btn1.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL2":
                        {
                            frm2.btn2.Text = Parsel[1].ToString();
                            frm2.btn2.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL3":
                        {
                            frm2.btn3.Text = Parsel[1].ToString();
                            frm2.btn3.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL4":
                        {
                            frm2.btn4.Text = Parsel[1].ToString();
                            frm2.btn4.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL5":
                        {
                            frm2.btn5.Text = Parsel[1].ToString();
                            frm2.btn5.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL6":
                        {
                            frm2.btn6.Text = Parsel[1].ToString();
                            frm2.btn6.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL7":
                        {
                            frm2.btn7.Text = Parsel[1].ToString();
                            frm2.btn7.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL8":
                        {
                            frm2.btn8.Text = Parsel[1].ToString();
                            frm2.btn8.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL9":
                        {
                            frm2.btn9.Text = Parsel[1].ToString();
                            frm2.btn9.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL10":
                        {
                            frm2.btn10.Text = Parsel[1].ToString();
                            frm2.btn10.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL11":
                        {
                            frm2.btn11.Text = Parsel[1].ToString();
                            frm2.btn11.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL12":
                        {
                            frm2.btn12.Text = Parsel[1].ToString();
                            frm2.btn12.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL13":
                        {
                            frm2.btn13.Text = Parsel[1].ToString();
                            frm2.btn13.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL14":
                        {
                            frm2.btn14.Text = Parsel[1].ToString();
                            frm2.btn14.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL15":
                        {
                            frm2.btn15.Text = Parsel[1].ToString();
                            frm2.btn15.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL16":
                        {
                            frm2.btn16.Text = Parsel[1].ToString();
                            frm2.btn16.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL17":
                        {
                            frm2.btn17.Text = Parsel[1].ToString();
                            frm2.btn17.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL18":
                        {
                            frm2.btn18.Text = Parsel[1].ToString();
                            frm2.btn18.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL19":
                        {
                            frm2.btn19.Text = Parsel[1].ToString();
                            frm2.btn19.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL20":
                        {
                            frm2.btn20.Text = Parsel[1].ToString();
                            frm2.btn20.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL21":
                        {
                            frm2.btn21.Text = Parsel[1].ToString();
                            frm2.btn21.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL22":
                        {
                            frm2.btn22.Text = Parsel[1].ToString();
                            frm2.btn22.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL23":
                        {
                            frm2.btn23.Text = Parsel[1].ToString();
                            frm2.btn23.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL24":
                        {
                            frm2.btn24.Text = Parsel[1].ToString();
                            frm2.btn24.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL25":
                        {
                            frm2.btn25.Text = Parsel[1].ToString();
                            frm2.btn25.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL26":
                        {
                            frm2.btn26.Text = Parsel[1].ToString();
                            frm2.btn26.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL27":
                        {
                            frm2.btn27.Text = Parsel[1].ToString();
                            frm2.btn27.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL28":
                        {
                            frm2.btn28.Text = Parsel[1].ToString();
                            frm2.btn28.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL29":
                        {
                            frm2.btn29.Text = Parsel[1].ToString();
                            frm2.btn29.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL30":
                        {
                            frm2.btn30.Text = Parsel[1].ToString();
                            frm2.btn30.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL31":
                        {
                            frm2.btn31.Text = Parsel[1].ToString();
                            frm2.btn31.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL32":
                        {
                            frm2.btn32.Text = Parsel[1].ToString();
                            frm2.btn32.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL33":
                        {
                            frm2.btn33.Text = Parsel[1].ToString();
                            frm2.btn33.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL34":
                        {
                            frm2.btn34.Text = Parsel[1].ToString();
                            frm2.btn34.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL35":
                        {
                            frm2.btn35.Text = Parsel[1].ToString();
                            frm2.btn35.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL36":
                        {
                            frm2.btn36.Text = Parsel[1].ToString();
                            frm2.btn36.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL37":
                        {
                            frm2.btn37.Text = Parsel[1].ToString();
                            frm2.btn37.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL38":
                        {
                            frm2.btn38.Text = Parsel[1].ToString();
                            frm2.btn38.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL39":
                        {
                            frm2.btn39.Text = Parsel[1].ToString();
                            frm2.btn39.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL40":
                        {
                            frm2.btn40.Text = Parsel[1].ToString();
                            frm2.btn40.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL41":
                        {
                            frm2.btn41.Text = Parsel[1].ToString();
                            frm2.btn41.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL42":
                        {
                            frm2.btn42.Text = Parsel[1].ToString();
                            frm2.btn42.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL43":
                        {
                            frm2.btn43.Text = Parsel[1].ToString();
                            frm2.btn43.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL44":
                        {
                            frm2.btn44.Text = Parsel[1].ToString();
                            frm2.btn44.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL45":
                        {
                            frm2.btn45.Text = Parsel[1].ToString();
                            frm2.btn45.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL46":
                        {
                            frm2.btn46.Text = Parsel[1].ToString();
                            frm2.btn46.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL47":
                        {
                            frm2.btn47.Text = Parsel[1].ToString();
                            frm2.btn47.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL48":
                        {
                            frm2.btn48.Text = Parsel[1].ToString();
                            frm2.btn48.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL49":
                        {
                            frm2.btn49.Text = Parsel[1].ToString();
                            frm2.btn49.BackColor = System.Drawing.Color.Green;
                            break;
                        }
                    case "PARSEL50":
                        {
                            frm2.btn50.Text = Parsel[1].ToString();
                            frm2.btn50.BackColor = System.Drawing.Color.Green;
                            break;
                        }

                }
            }
            bag.Close();
            Parsel.Dispose();

        }
        public void sahasil()
        {

            switch (frm3.comboBox1.Text)
            {

                case "PARSEL1":
                    {
                        frm2.btn1.Text = "Parsel 1  ";
                        frm2.btn1.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL2":
                    {
                        frm2.btn2.Text = "Parsel 2  ";
                        frm2.btn2.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL3":
                    {
                        frm2.btn3.Text = "Parsel 3  ";
                        frm2.btn3.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL4":
                    {
                        frm2.btn4.Text = "Parsel 4  ";
                        frm2.btn4.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL5":
                    {
                        frm2.btn5.Text = "Parsel 5  ";
                        frm2.btn5.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }

                case "PARSEL6":
                    {//alionurulker@gmail.com
                        frm2.btn6.Text = "Parsel 6  ";
                        frm2.btn6.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL7":
                    {
                        frm2.btn7.Text = "Parsel 7  ";
                        frm2.btn7.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL8":
                    {
                        frm2.btn8.Text = "Parsel 8  ";
                        frm2.btn8.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL9":
                    {
                        frm2.btn9.Text = "Parsel 9  ";
                        frm2.btn9.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL10":
                    {
                        frm2.btn10.Text = "Parsel 10  ";
                        frm2.btn10.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL11":
                    {
                        frm2.btn11.Text = "Parsel 11  ";
                        frm2.btn11.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL12":
                    {
                        frm2.btn12.Text = "Parsel 12  ";
                        frm2.btn12.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL13":
                    {
                        frm2.btn13.Text = "Parsel 13  ";
                        frm2.btn13.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL14":
                    {
                        frm2.btn14.Text = "Parsel 14  ";
                        frm2.btn14.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL15":
                    {
                        frm2.btn15.Text = "Parsel 15  ";
                        frm2.btn15.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL16":
                    {
                        frm2.btn16.Text = "Parsel 16  ";
                        frm2.btn16.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL17":
                    {
                        frm2.btn17.Text = "Parsel 17  ";
                        frm2.btn17.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL18":
                    {
                        frm2.btn18.Text = "Parsel 18  ";
                        frm2.btn18.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL19":
                    {
                        frm2.btn19.Text = "Parsel 19  ";
                        frm2.btn19.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL20":
                    {
                        frm2.btn20.Text = "Parsel 20  ";
                        frm2.btn20.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL21":
                    {
                        frm2.btn21.Text = "Parsel 21  ";
                        frm2.btn21.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL22":
                    {
                        frm2.btn22.Text = "Parsel 22  ";
                        frm2.btn22.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL23":
                    {
                        frm2.btn23.Text = "Parsel 23  ";
                        frm2.btn23.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL24":
                    {
                        frm2.btn24.Text = "Parsel 24  ";
                        frm2.btn24.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL25":
                    {
                        frm2.btn25.Text = "Parsel 25  ";
                        frm2.btn25.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL26":
                    {
                        frm2.btn26.Text = "Parsel 26  ";
                        frm2.btn26.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL27":
                    {
                        frm2.btn27.Text = "Parsel 27  ";
                        frm2.btn27.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL28":
                    {
                        frm2.btn28.Text = "Parsel 28  ";
                        frm2.btn28.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL29":
                    {
                        frm2.btn29.Text = "Parsel 29  ";
                        frm2.btn29.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL30":
                    {
                        frm2.btn30.Text = "Parsel 30  ";
                        frm2.btn30.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL31":
                    {
                        frm2.btn31.Text = "Parsel 31  ";
                        frm2.btn31.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL32":
                    {
                        frm2.btn32.Text = "Parsel 32  ";
                        frm2.btn32.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL33":
                    {
                        frm2.btn33.Text = "Parsel 33  ";
                        frm2.btn33.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL34":
                    {
                        frm2.btn34.Text = "Parsel 34  ";
                        frm2.btn34.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL35":
                    {
                        frm2.btn35.Text = "Parsel 35  ";
                        frm2.btn35.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL36":
                    {
                        frm2.btn36.Text = "Parsel 36  ";
                        frm2.btn36.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL37":
                    {
                        frm2.btn37.Text = "Parsel 37  ";
                        frm2.btn37.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL38":
                    {
                        frm2.btn38.Text = "Parsel 38  ";
                        frm2.btn38.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL39":
                    {
                        frm2.btn39.Text = "Parsel 39  ";
                        frm2.btn39.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL40":
                    {
                        frm2.btn40.Text = "Parsel 40  ";
                        frm2.btn40.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL41":
                    {
                        frm2.btn41.Text = "Parsel 41  ";
                        frm2.btn41.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL42":
                    {
                        frm2.btn42.Text = "Parsel 42  ";
                        frm2.btn42.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL43":
                    {
                        frm2.btn43.Text = "Parsel 43  ";
                        frm2.btn43.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL44":
                    {
                        frm2.btn44.Text = "Parsel 44  ";
                        frm2.btn44.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL45":
                    {
                        frm2.btn45.Text = "Parsel 45  ";
                        frm2.btn45.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL46":
                    {
                        frm2.btn46.Text = "Parsel 46  ";
                        frm2.btn46.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL47":
                    {
                        frm2.btn47.Text = "Parsel 47  ";
                        frm2.btn47.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL48":
                    {
                        frm2.btn48.Text = "Parsel 48  ";
                        frm2.btn48.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL49":
                    {
                        frm2.btn49.Text = "Parsel 49  ";
                        frm2.btn49.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
                case "PARSEL50":
                    {
                        frm2.btn50.Text = "Parsel 50  ";
                        frm2.btn50.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    }
            }


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            combo();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            bag1.Open();
            kmt.Connection = bag1;
            kmt.CommandText = "Select * from musbil ";
            OleDbDataReader Parsel;
            Parsel = kmt.ExecuteReader();
            int i = 0;
            while (Parsel.Read())
            {
                i++;
                if (textBox1.Text == Parsel[0].ToString())
                {
                    MessageBox.Show("Daha önce " + textBox1.Text + " TC kimlik numarasından kayıt girilmiştir. Lütfen başka bir TC Kimlik Numarası giriniz!");
                }
                else
                {
                    if (textBox3.Text != "" && textBox1.Text != "" && comboBox1.Text != "")
                    {
                        bag.Open();
                        kmt.Connection = bag;
                        kmt1.Connection = bag;
                        kmt.CommandText = "INSERT INTO musbil(TcKimlik,Ad,Soyad,CepTel,Parsel,KisiSayisi,Konumu,GirisTarih,CikisTarih,Plaka,MailAdres,DogumTarihi) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + textBox5.Text + "','" + textBox7.Text + "','" + dateTimePicker3.Text + "') ";
                        kmt1.CommandText = "INSERT INTO MusbilYedek(TcKimlik,Ad,Soyad,CepTel,Parsel,KisiSayisi,Konumu,GirisTarih,CikisTarih,Plaka,MailAdres,DogumTarihi) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + textBox5.Text + "','" + textBox7.Text + "','" + dateTimePicker3.Text + "') ";
                        kmt.ExecuteNonQuery();
                        kmt1.ExecuteNonQuery();
                        kmt.CommandText = "INSERT INTO dolu(doluyerler) VALUES ('" + comboBox1.Text + "') ";
                        kmt.ExecuteNonQuery();
                        kmt.CommandText = "DELETE from bos WHERE bosyerler='" + comboBox1.Text + "'";
                        kmt.ExecuteNonQuery();
                        kmt.Dispose();
                        kmt1.Dispose();
                        bag.Close();
                        comboBox1.Items.Clear();
                        textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
                        textBox2.Clear();
                        comboBox1.Text = "";
                        combo();
                        sahayaz();

                        MessageBox.Show("Parseliniz Ayrılmıştır! ");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Boş Alanları Doldurunuz!");
                    }
                }
            }
            bag1.Close();
            Parsel.Dispose();
            if (textBox3.Text != "" && textBox1.Text != "" && comboBox1.Text != "" && i == 0)
            {
                bag.Open();
                kmt.Connection = bag;
                kmt1.Connection = bag;
                kmt.CommandText = "INSERT INTO musbil(TcKimlik,Ad,Soyad,CepTel,Parsel,KisiSayisi,Konumu,GirisTarih,CikisTarih,Plaka,MailAdres,DogumTarihi) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + textBox5.Text + "','" + textBox7.Text + "','" + dateTimePicker3.Text + "') ";
                kmt1.CommandText = "INSERT INTO MusbilYedek(TcKimlik,Ad,Soyad,CepTel,Parsel,KisiSayisi,Konumu,GirisTarih,CikisTarih,Plaka,MailAdres,DogumTarihi) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + textBox5.Text + "','" + textBox7.Text + "','" + dateTimePicker3.Text + "') ";
                kmt.ExecuteNonQuery();
                kmt1.ExecuteNonQuery();
                kmt.CommandText = "INSERT INTO dolu(doluyerler) VALUES ('" + comboBox1.Text + "') ";
                kmt.ExecuteNonQuery();
                kmt.CommandText = "DELETE from bos WHERE bosyerler='" + comboBox1.Text + "'";
                kmt.ExecuteNonQuery();
                kmt.Dispose();
                kmt1.Dispose();
                bag.Close();
                comboBox1.Items.Clear();
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
                textBox2.Clear();
                comboBox1.Text = "";
                combo();
                sahayaz();

                MessageBox.Show("Parseliniz Ayrılmıştır! ");
            }
            else if(i == 0)
            {
                MessageBox.Show("Boş Alanları Doldurunuz!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dtst.Clear();
            listele();
            frm3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtst.Clear();
            listele();
            frm2.Show();
            this.Hide();
        }

    }
}

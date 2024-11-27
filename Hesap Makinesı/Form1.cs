using System;
using System.Data;
using System.Windows.Forms;

namespace Hesap_Makinesı
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekranTemizlenecekMi;
        private decimal _ilkSayi;
        private string _parantezIslemi = ""; // Parantez işlemi için bir değişken

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rakam1button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "1";
        }

        private void rakam2button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "2";
        }

        private void rakam3button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "3";
        }



        private void rakam4button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "4";
        }

        private void rakam5button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "5";
        }

        private void rakam6button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "6";
        }

        private void rakam7button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "7";
        }

        private void rakam8button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "8";
        }

        private void rakam9button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "9";
        }

        private void rakam0button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "0";
        }

        private void toplabutton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            // Eğer ekranlabel boş değilse ve geçerli bir sayıysa işlemi yapalım
            if (ekranlabel.Text != "" && decimal.TryParse(ekranlabel.Text, out decimal sayi))
            {
                if (ekranlabel.Text != "" && !ekranlabel.Text.Contains("+"))
                {
                    ekranlabel.Text += " +";
                }

                _islem = '+'; // İşlem tipi belirleniyor
                _ekranTemizlenecekMi = true;
                _ilkSayi = sayi; // İlk sayıyı alıyoruz
            }
            else
            {
                // Hata mesajı verebiliriz ya da ekranda geçerli bir sayı olmadığını belirtebiliriz
                MessageBox.Show("Lütfen geçerli bir sayı girin.");
            }
        }


        private void cıkartbutton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            // Eğer ekranlabel boş değilse ve geçerli bir sayıysa işlemi yapalım
            if (ekranlabel.Text != "" && decimal.TryParse(ekranlabel.Text, out decimal sayi))
            {
                if (ekranlabel.Text != "" && !ekranlabel.Text.Contains("-"))
                {
                    ekranlabel.Text += " -";
                }

                _islem = '-'; // İşlem tipi belirleniyor
                _ekranTemizlenecekMi = true;
                _ilkSayi = sayi; // İlk sayıyı alıyoruz
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.");
            }
        }

        private void carpbutton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            // Eğer ekranlabel boş değilse ve geçerli bir sayıysa işlemi yapalım
            if (ekranlabel.Text != "" && decimal.TryParse(ekranlabel.Text, out decimal sayi))
            {
                if (ekranlabel.Text != "" && !ekranlabel.Text.Contains("*"))
                {
                    ekranlabel.Text += "*";
                }

                _islem = '*'; // İşlem tipi belirleniyor
                _ekranTemizlenecekMi = true;
                _ilkSayi = sayi; // İlk sayıyı alıyoruz
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.");
            }
        }

        private void bolbutton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            // Eğer ekranlabel boş değilse ve geçerli bir sayıysa işlemi yapalım
            if (ekranlabel.Text != "" && decimal.TryParse(ekranlabel.Text, out decimal sayi))
            {
                if (ekranlabel.Text != "" && !ekranlabel.Text.Contains("/"))
                {
                    ekranlabel.Text += " /";
                }

                _islem = '/'; // İşlem tipi belirleniyor
                _ekranTemizlenecekMi = true;
                _ilkSayi = sayi; // İlk sayıyı alıyoruz
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.");
            }
           
        }
        private void esittirbutton_Click(object sender, EventArgs e)
        {
            string girilenDeger = ekranlabel.Text;
            decimal ikincisayi;
            decimal sonuc; // "sonuc" değişkenini bir kez tanımlıyoruz.

            // Girilen değeri sayıya dönüştürmeyi dene
            if (!decimal.TryParse(girilenDeger, out ikincisayi))
            {
                MessageBox.Show("Geçersiz giriş! Lütfen bir sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_islem == '%') // Yüzde işlemi yapılmışsa
            {
                // İlk sayıyı alıyoruz
                if (decimal.TryParse(ekranlabel.Text, out decimal sayi))
                {
                    decimal toplamSonuc = _ilkSayi + sayi; // Yüzdeyi hesapla ve ilk sayıyı ekle
                    ekranlabel.Text = toplamSonuc.ToString("0.##"); // Sonucu ekranda göster
                    return; // İşlem tamam, metottan çıkıyoruz.
                }
            }
            else
            {
                // Normal toplama veya diğer işlemleri burada yapabilirsiniz
            }

            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikincisayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikincisayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikincisayi;
                    break;
                case '/':
                    if (ikincisayi == 0)
                    {
                        MessageBox.Show("Bir sayı sıfıra bölünemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sonuc = 0; // veya istediğiniz bir hata değeri
                    }
                    else
                    {
                        sonuc = _ilkSayi / ikincisayi;
                    }
                    break;
                default:
                    sonuc = 0;
                    break;
            }

            ekranlabel.Text = sonuc.ToString();
        }
        private void temizlebutton_Click(object sender, EventArgs e)
        {
            ekranlabel.Text = "0";
        }

        private void yuzdebutton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(ekranlabel.Text, out decimal sayi))
            {
                decimal sonuc = sayi / 100;  // Yüzdeyi hesaplamak için 100'e bölüyoruz
                ekranlabel.Text = sonuc.ToString();  // Sonucu ekranda gösteriyoruz
            }
            else if (_islem == '%') // Yüzde işlemi yapılmışsa
            {
                decimal sonuc = _ilkSayi * sayi / 100; // Yüzdeyi hesapla
                ekranlabel.Text = sonuc.ToString("0.##"); // Sonucu ekranda göster
            }
            else
            {
                // Eğer geçerli bir sayı girilmediyse kullanıcıyı bilgilendir
                MessageBox.Show("Geçerli bir sayı giriniz.");
            }
        }

        private void parantezacbutton_Click(object sender, EventArgs e)
        {
            _parantezIslemi = "(";
            ekranlabel.Text += "(";
        }

        private void parantezkapatbutton_Click(object sender, EventArgs e)
        {
            _parantezIslemi = ")";
            ekranlabel.Text += ")";
        }

        private void virgulbutton_Click(object sender, EventArgs e)
        {

            // Eğer ekranda zaten bir virgül varsa, başka virgül eklenmesine izin vermeyelim
            if (!_ekranTemizlenecekMi)
            {
                if (!ekranlabel.Text.Contains(","))
                {
                    ekranlabel.Text += ",";
                }
            }
        }
        private decimal EvaluateExpression(string expression)
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("expression", typeof(string), expression);
                DataRow row = table.NewRow();
                table.Rows.Add(row);
                decimal result = decimal.Parse((string)row["expression"]);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
                return 0;
            }
        }
    }
}

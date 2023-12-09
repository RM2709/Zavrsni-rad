using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Zavrsni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonDesifriraj.Enabled = false;
            buttonBruteForce.Enabled = false;
            comboBoxSifriranje.SelectedIndex = 0;
        }

        private void buttonOcisti_Click(object sender, EventArgs e)
        {
            textBoxJasniTekst.Clear();
            textBoxSifriraniTekst.Clear();
            textBoxKljuc.Clear();
            buttonSifriraj.Enabled = true;
            buttonDesifriraj.Enabled = false;
            buttonBruteForce.Enabled = false;
        }

        /*
        Funkcija koja pri pritisku na gumb "Šifriraj" uzima jasni tekst iz kućice na formi, generira ključ i IV uz pomoć kojih šifrira jasni tekst
        te postavlja ključ i šifrirani tekst u Base64 obliku u kućice na formi
        */
        private void buttonSifriraj_Click(object sender, EventArgs e)
        {
            using (Aes aes = Aes.Create())
            {
                byte[] sifriraniTekstBajtovi = null;

                // Ako je odabran testni način šifriranja
                if(comboBoxSifriranje.SelectedIndex == 1)
                {
                    Random rand = new Random();
                    int b1 = rand.Next(0, 255);
                    int b2 = rand.Next(0, 63);
                    byte[] kljuc = {(byte)b1, (byte)b2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    aes.Key = kljuc;
                }

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (MemoryStream mse = new MemoryStream())
                {
                    using (CryptoStream cse = new CryptoStream(mse, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swe = new StreamWriter(cse))
                        {
                            swe.Write(textBoxJasniTekst.Text);
                        }
                        sifriraniTekstBajtovi = mse.ToArray();
                    }
                }

                // Inicijacijski vektor nam je potreban za dešifriranje pa ga stoga dodajemo na početak šifriranog teksta prije nego tekst pošaljemo na formu
                textBoxSifriraniTekst.Text = Convert.ToBase64String(aes.IV) + Convert.ToBase64String(sifriraniTekstBajtovi);
                textBoxKljuc.Text = Convert.ToBase64String(aes.Key);
                buttonSifriraj.Enabled = false;
                buttonDesifriraj.Enabled = true;
                buttonBruteForce.Enabled = true;
            }
        }

        private void buttonDesifriraj_Click(object sender, EventArgs e)
        {
            FrmDesifriraj form = new FrmDesifriraj(textBoxSifriraniTekst.Text);
            form.Show();
        }

        private void buttonBruteForce_Click(object sender, EventArgs e)
        {
            FrmBruteForce form = new FrmBruteForce(textBoxJasniTekst.Text, textBoxSifriraniTekst.Text);
            form.Show();
        }
    }
}

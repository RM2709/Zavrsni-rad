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
    public partial class FrmDesifriraj : Form
    {
        public FrmDesifriraj(string sifriraniTekst)
        {
            InitializeComponent();
            textBoxSifriraniTekst.Text = sifriraniTekst;
        }

        private void buttonDesifriraj_Click(object sender, EventArgs e)
        {
            if(textBoxKljuc.Text=="")
            {
                MessageBox.Show("Unesite ključ!");
            }
            else
            {
                try
                {
                    byte[] kljuc = Convert.FromBase64String(textBoxKljuc.Text);
                    byte[] inicijaciskiVektor = Convert.FromBase64String(textBoxSifriraniTekst.Text.Substring(0,24));
                    byte[] sifriraniTekst = Convert.FromBase64String(textBoxSifriraniTekst.Text.Substring(24));
                    using (Aes aes = Aes.Create())
                    {
                        ICryptoTransform decryptor = aes.CreateDecryptor(kljuc, inicijaciskiVektor);
                        using (MemoryStream msd = new MemoryStream(sifriraniTekst))
                        {
                            using (CryptoStream csd = new CryptoStream(msd, decryptor, CryptoStreamMode.Read))
                            {
                                using (StreamReader srd = new StreamReader(csd))
                                {
                                    textBoxJasniTekst.Text = srd.ReadToEnd();
                                }
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Greška!");
                }
                
            }
        }
    }
}

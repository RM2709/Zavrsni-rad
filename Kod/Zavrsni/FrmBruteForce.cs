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
using System.Diagnostics;
using System.Threading;

namespace Zavrsni
{
    public partial class FrmBruteForce : Form
    {
        string jasniTekst;
        string desifriraniTekst;
        public FrmBruteForce(string plaintext, string ciphertext)
        {
            InitializeComponent();
            jasniTekst = plaintext;
            textBoxSifriraniTekst.Text = ciphertext;
            comboBoxMode.SelectedIndex = 0;
        }

        public class Rezultat
        {
            public string analiza;
            public string kljuc;
        }

        private void buttonPokreni_Click(object sender, EventArgs e)
        {
            if(!backgroundWorker1.IsBusy)
            {
                textBoxKljuc.Text = "";
                textBoxAnaliza.Text = "Kumulativni broj provjerenih ključeva (u tisućama): " + Environment.NewLine;
                backgroundWorker1.RunWorkerAsync(comboBoxMode.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Proces je već pokrenut!");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int brojKljuceva = 0;
            double protekloVrijeme;
            double prosjecnoVrijeme;
            Rezultat rezultat = new Rezultat();
            Stopwatch stoperica = new Stopwatch();
            void BruteForce()
            {
                for (int b1 = 0; b1 < 256; b1++)
                    for (int b2 = 0; b2 < 256; b2++)
                        for (int b3 = 0; b3 < 256; b3++)
                            for (int b4 = 0; b4 < 256; b4++)
                                for (int b5 = 0; b5 < 256; b5++)
                                    for (int b6 = 0; b6 < 256; b6++)
                                        for (int b7 = 0; b7 < 256; b7++)
                                            for (int b8 = 0; b8 < 256; b8++)
                                                for (int b9 = 0; b9 < 256; b9++)
                                                    for (int b10 = 0; b10 < 256; b10++)
                                                        for (int b11 = 0; b11 < 256; b11++)
                                                            for (int b12 = 0; b12 < 256; b12++)
                                                                for (int b13 = 0; b13 < 256; b13++)
                                                                    for (int b14 = 0; b14 < 256; b14++)
                                                                        for (int b15 = 0; b15 < 256; b15++)
                                                                            for (int b16 = 0; b16 < 256; b16++)
                                                                            {
                                                                                if (backgroundWorker1.CancellationPending)
                                                                                {
                                                                                    stoperica.Stop();
                                                                                    protekloVrijeme = stoperica.ElapsedMilliseconds / 1000;
                                                                                    prosjecnoVrijeme = protekloVrijeme / brojKljuceva;
                                                                                    rezultat.kljuc = "Ključ nije pronađen!";
                                                                                    rezultat.analiza =
                                                                                    $"Broj provjerenih ključeva: {brojKljuceva}" + Environment.NewLine +
                                                                                    $"Vrijeme proteklo u sekundama: {protekloVrijeme} sekundi" + Environment.NewLine +
                                                                                    $"Prosječno vrijeme provjere ključa: {prosjecnoVrijeme} sekundi po ključu" + Environment.NewLine +
                                                                                    $"Procjenjeno vrijeme provjere u najgorem slučaju (2^128 kombinacija): {prosjecnoVrijeme * Math.Pow(2, 128)} sekundi, tj. {(((((prosjecnoVrijeme * Math.Pow(2, 128)) / 60) / 60) / 24) / 365) / 1000} tisućljeća" + Environment.NewLine +
                                                                                    $"Procjenjeno prosječno vrijeme provjere: {((prosjecnoVrijeme * Math.Pow(2, 128)) / 2)} sekundi, tj. {((((((prosjecnoVrijeme * Math.Pow(2, 128)) / 2) / 60) / 60) / 24) / 365) / 1000} tisućljeća";
                                                                                    e.Result = rezultat;
                                                                                    return;
                                                                                }
                                                                                brojKljuceva++;
                                                                                backgroundWorker1.ReportProgress(brojKljuceva);
                                                                                byte[] generiraniKljuc = { (byte)b1, (byte)b2, (byte)b3, (byte)b4,
                                                                                                       (byte)b5, (byte)b6, (byte)b7, (byte)b8,
                                                                                                       (byte)b9, (byte)b11, (byte)b11, (byte)b12,
                                                                                                       (byte)b13, (byte)b14, (byte)b15, (byte)b16};

                                                                                byte[] inicijaciskiVektor = Convert.FromBase64String(textBoxSifriraniTekst.Text.Substring(0, 24));
                                                                                byte[] sifriraniTekst = Convert.FromBase64String(textBoxSifriraniTekst.Text.Substring(24));
                                                                                try
                                                                                {
                                                                                    using (Aes aes = Aes.Create())
                                                                                    {
                                                                                        ICryptoTransform decryptor = aes.CreateDecryptor(generiraniKljuc, inicijaciskiVektor);
                                                                                        using (MemoryStream msd = new MemoryStream(sifriraniTekst))
                                                                                        {
                                                                                            using (CryptoStream csd = new CryptoStream(msd, decryptor, CryptoStreamMode.Read))
                                                                                            {
                                                                                                using (StreamReader srd = new StreamReader(csd))
                                                                                                {
                                                                                                    desifriraniTekst = srd.ReadToEnd();
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                    if (String.Compare(jasniTekst, desifriraniTekst) == 0)
                                                                                    {
                                                                                        rezultat.kljuc = Convert.ToBase64String(generiraniKljuc);
                                                                                        MessageBox.Show("Ključ pronađen!");
                                                                                        return;
                                                                                    }
                                                                                }
                                                                                catch
                                                                                {
                                                                                }
                                                                            }
            }
            void BruteForceTest()
            {
                for (int b1 = 0; b1 < 256; b1++)
                    for (int b2 = 0; b2 < 64; b2++)
                    {
                        if (backgroundWorker1.CancellationPending)
                        {
                            stoperica.Stop();
                            protekloVrijeme = stoperica.ElapsedMilliseconds / 1000;
                            prosjecnoVrijeme = protekloVrijeme / brojKljuceva;
                            rezultat.kljuc = "Ključ nije pronađen!";
                            rezultat.analiza =
                            $"Broj provjerenih ključeva: {brojKljuceva}" + Environment.NewLine +
                            $"Vrijeme proteklo u sekundama: {protekloVrijeme} sekundi" + Environment.NewLine +
                            $"Prosječno vrijeme provjere ključa: {prosjecnoVrijeme} sekundi po ključu" + Environment.NewLine +
                            $"Procjenjeno vrijeme provjere u najgorem slučaju (2^128 kombinacija): {prosjecnoVrijeme * Math.Pow(2, 128)} sekundi, tj. {(((((prosjecnoVrijeme * Math.Pow(2, 128)) / 60) / 60) / 24) / 365) / 1000} tisućljeća" + Environment.NewLine +
                            $"Procjenjeno prosječno vrijeme provjere: {((prosjecnoVrijeme * Math.Pow(2, 128)) / 2)} sekundi, tj. {((((((prosjecnoVrijeme * Math.Pow(2, 128)) / 2) / 60) / 60) / 24) / 365) / 1000} tisućljeća";
                            e.Result = rezultat;
                            return;
                        }
                        brojKljuceva++;
                        backgroundWorker1.ReportProgress(brojKljuceva);
                        byte[] generiraniKljuc = { (byte)b1, (byte)b2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                        byte[] inicijaciskiVektor = Convert.FromBase64String(textBoxSifriraniTekst.Text.Substring(0, 24));
                        byte[] sifriraniTekst = Convert.FromBase64String(textBoxSifriraniTekst.Text.Substring(24));
                        try
                        {
                            using (Aes aes = Aes.Create())
                            {
                                ICryptoTransform decryptor = aes.CreateDecryptor(generiraniKljuc, inicijaciskiVektor);
                                using (MemoryStream msd = new MemoryStream(sifriraniTekst))
                                {
                                    using (CryptoStream csd = new CryptoStream(msd, decryptor, CryptoStreamMode.Read))
                                    {
                                        using (StreamReader srd = new StreamReader(csd))
                                        {
                                            desifriraniTekst = srd.ReadToEnd();
                                        }
                                    }
                                }
                            }
                            if (String.Compare(jasniTekst, desifriraniTekst) == 0)
                            {
                                rezultat.kljuc = Convert.ToBase64String(generiraniKljuc);
                                MessageBox.Show("Ključ pronađen!");
                                return;
                            }
                        }
                        catch
                        {
                        }
                    }
            }
            stoperica.Start();
            if ((int)e.Argument==0)
            {
                BruteForce();
            }
            else if ((int)e.Argument == 1)
            {
                BruteForceTest();
            }
            stoperica.Stop();
            protekloVrijeme = stoperica.ElapsedMilliseconds / 1000;
            prosjecnoVrijeme = protekloVrijeme / brojKljuceva;
            rezultat.analiza =
                $"Broj provjerenih ključeva: {brojKljuceva}" + Environment.NewLine +
                $"Vrijeme proteklo u sekundama: {protekloVrijeme} sekundi" + Environment.NewLine +
                $"Prosječno vrijeme provjere ključa: {prosjecnoVrijeme} sekundi po ključu" + Environment.NewLine +
                $"Procjenjeno vrijeme provjere u najgorem slučaju (2^128 kombinacija): {prosjecnoVrijeme * Math.Pow(2, 128)} sekundi, tj. {(((((prosjecnoVrijeme * Math.Pow(2, 128)) / 60) / 60) / 24) / 365) / 1000} tisućljeća" + Environment.NewLine +
                $"Procjenjeno prosječno vrijeme provjere: {((prosjecnoVrijeme * Math.Pow(2, 128)) / 2)} sekundi, tj. {((((((prosjecnoVrijeme * Math.Pow(2, 128)) / 2) / 60) / 60) / 24) / 365) / 1000} tisućljeća";
            e.Result = rezultat;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage % 1000 == 0 && e.ProgressPercentage != 0)
            {
                textBoxAnaliza.Text += $"{e.ProgressPercentage}" + Environment.NewLine;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Error!=null)
            {
                MessageBox.Show("Greška");
            }
            else
            {
                textBoxAnaliza.Text = ((Rezultat)e.Result).analiza;
                textBoxKljuc.Text = ((Rezultat)e.Result).kljuc;
            }
        }

        private void buttonZaustavi_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
            else
            {
                MessageBox.Show("Proces nije pokrenut.");
            }
        }
    }
}


namespace Zavrsni
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxJasniTekst = new System.Windows.Forms.TextBox();
            this.textBoxSifriraniTekst = new System.Windows.Forms.TextBox();
            this.buttonSifriraj = new System.Windows.Forms.Button();
            this.textBoxKljuc = new System.Windows.Forms.TextBox();
            this.buttonDesifriraj = new System.Windows.Forms.Button();
            this.buttonBruteForce = new System.Windows.Forms.Button();
            this.buttonOcisti = new System.Windows.Forms.Button();
            this.labelKljuc = new System.Windows.Forms.Label();
            this.labelPlaintext = new System.Windows.Forms.Label();
            this.labelCiphertext = new System.Windows.Forms.Label();
            this.comboBoxSifriranje = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxJasniTekst
            // 
            this.textBoxJasniTekst.Location = new System.Drawing.Point(12, 25);
            this.textBoxJasniTekst.Multiline = true;
            this.textBoxJasniTekst.Name = "textBoxJasniTekst";
            this.textBoxJasniTekst.Size = new System.Drawing.Size(200, 191);
            this.textBoxJasniTekst.TabIndex = 0;
            // 
            // textBoxSifriraniTekst
            // 
            this.textBoxSifriraniTekst.Location = new System.Drawing.Point(417, 25);
            this.textBoxSifriraniTekst.Multiline = true;
            this.textBoxSifriraniTekst.Name = "textBoxSifriraniTekst";
            this.textBoxSifriraniTekst.ReadOnly = true;
            this.textBoxSifriraniTekst.Size = new System.Drawing.Size(200, 191);
            this.textBoxSifriraniTekst.TabIndex = 1;
            // 
            // buttonSifriraj
            // 
            this.buttonSifriraj.Location = new System.Drawing.Point(234, 52);
            this.buttonSifriraj.Name = "buttonSifriraj";
            this.buttonSifriraj.Size = new System.Drawing.Size(158, 51);
            this.buttonSifriraj.TabIndex = 2;
            this.buttonSifriraj.Text = "Šifriraj";
            this.buttonSifriraj.UseVisualStyleBackColor = true;
            this.buttonSifriraj.Click += new System.EventHandler(this.buttonSifriraj_Click);
            // 
            // textBoxKljuc
            // 
            this.textBoxKljuc.Location = new System.Drawing.Point(12, 248);
            this.textBoxKljuc.Multiline = true;
            this.textBoxKljuc.Name = "textBoxKljuc";
            this.textBoxKljuc.ReadOnly = true;
            this.textBoxKljuc.Size = new System.Drawing.Size(604, 34);
            this.textBoxKljuc.TabIndex = 3;
            // 
            // buttonDesifriraj
            // 
            this.buttonDesifriraj.Location = new System.Drawing.Point(125, 288);
            this.buttonDesifriraj.Name = "buttonDesifriraj";
            this.buttonDesifriraj.Size = new System.Drawing.Size(189, 56);
            this.buttonDesifriraj.TabIndex = 4;
            this.buttonDesifriraj.Text = "Dešifriraj";
            this.buttonDesifriraj.UseVisualStyleBackColor = true;
            this.buttonDesifriraj.Click += new System.EventHandler(this.buttonDesifriraj_Click);
            // 
            // buttonBruteForce
            // 
            this.buttonBruteForce.Location = new System.Drawing.Point(320, 288);
            this.buttonBruteForce.Name = "buttonBruteForce";
            this.buttonBruteForce.Size = new System.Drawing.Size(189, 56);
            this.buttonBruteForce.TabIndex = 5;
            this.buttonBruteForce.Text = "Brute force";
            this.buttonBruteForce.UseVisualStyleBackColor = true;
            this.buttonBruteForce.Click += new System.EventHandler(this.buttonBruteForce_Click);
            // 
            // buttonOcisti
            // 
            this.buttonOcisti.Location = new System.Drawing.Point(234, 165);
            this.buttonOcisti.Name = "buttonOcisti";
            this.buttonOcisti.Size = new System.Drawing.Size(158, 51);
            this.buttonOcisti.TabIndex = 6;
            this.buttonOcisti.Text = "Očisti";
            this.buttonOcisti.UseVisualStyleBackColor = true;
            this.buttonOcisti.Click += new System.EventHandler(this.buttonOcisti_Click);
            // 
            // labelKljuc
            // 
            this.labelKljuc.AutoSize = true;
            this.labelKljuc.Location = new System.Drawing.Point(12, 232);
            this.labelKljuc.Name = "labelKljuc";
            this.labelKljuc.Size = new System.Drawing.Size(33, 13);
            this.labelKljuc.TabIndex = 7;
            this.labelKljuc.Text = "Ključ:";
            // 
            // labelPlaintext
            // 
            this.labelPlaintext.AutoSize = true;
            this.labelPlaintext.Location = new System.Drawing.Point(12, 9);
            this.labelPlaintext.Name = "labelPlaintext";
            this.labelPlaintext.Size = new System.Drawing.Size(50, 13);
            this.labelPlaintext.TabIndex = 8;
            this.labelPlaintext.Text = "Plaintext:";
            // 
            // labelCiphertext
            // 
            this.labelCiphertext.AutoSize = true;
            this.labelCiphertext.Location = new System.Drawing.Point(414, 9);
            this.labelCiphertext.Name = "labelCiphertext";
            this.labelCiphertext.Size = new System.Drawing.Size(57, 13);
            this.labelCiphertext.TabIndex = 9;
            this.labelCiphertext.Text = "Ciphertext:";
            // 
            // comboBoxSifriranje
            // 
            this.comboBoxSifriranje.FormattingEnabled = true;
            this.comboBoxSifriranje.Items.AddRange(new object[] {
            "Šifriranje generiranim ključem",
            "Testno šifriranje ključem u užem rasponu"});
            this.comboBoxSifriranje.Location = new System.Drawing.Point(218, 25);
            this.comboBoxSifriranje.Name = "comboBoxSifriranje";
            this.comboBoxSifriranje.Size = new System.Drawing.Size(193, 21);
            this.comboBoxSifriranje.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Odabir šifriranja:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSifriranje);
            this.Controls.Add(this.labelCiphertext);
            this.Controls.Add(this.labelPlaintext);
            this.Controls.Add(this.labelKljuc);
            this.Controls.Add(this.buttonOcisti);
            this.Controls.Add(this.buttonBruteForce);
            this.Controls.Add(this.buttonDesifriraj);
            this.Controls.Add(this.textBoxKljuc);
            this.Controls.Add(this.buttonSifriraj);
            this.Controls.Add(this.textBoxSifriraniTekst);
            this.Controls.Add(this.textBoxJasniTekst);
            this.Name = "Form1";
            this.Text = "Šifriranje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxJasniTekst;
        private System.Windows.Forms.TextBox textBoxSifriraniTekst;
        private System.Windows.Forms.Button buttonSifriraj;
        private System.Windows.Forms.TextBox textBoxKljuc;
        private System.Windows.Forms.Button buttonDesifriraj;
        private System.Windows.Forms.Button buttonBruteForce;
        private System.Windows.Forms.Button buttonOcisti;
        private System.Windows.Forms.Label labelKljuc;
        private System.Windows.Forms.Label labelPlaintext;
        private System.Windows.Forms.Label labelCiphertext;
        private System.Windows.Forms.ComboBox comboBoxSifriranje;
        private System.Windows.Forms.Label label1;
    }
}


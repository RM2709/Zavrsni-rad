
namespace Zavrsni
{
    partial class FrmBruteForce
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
            this.labelCiphertext = new System.Windows.Forms.Label();
            this.textBoxSifriraniTekst = new System.Windows.Forms.TextBox();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAnaliza = new System.Windows.Forms.TextBox();
            this.buttonPokreni = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKljuc = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonZaustavi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCiphertext
            // 
            this.labelCiphertext.AutoSize = true;
            this.labelCiphertext.Location = new System.Drawing.Point(9, 9);
            this.labelCiphertext.Name = "labelCiphertext";
            this.labelCiphertext.Size = new System.Drawing.Size(57, 13);
            this.labelCiphertext.TabIndex = 11;
            this.labelCiphertext.Text = "Ciphertext:";
            // 
            // textBoxSifriraniTekst
            // 
            this.textBoxSifriraniTekst.Location = new System.Drawing.Point(12, 25);
            this.textBoxSifriraniTekst.Multiline = true;
            this.textBoxSifriraniTekst.Name = "textBoxSifriraniTekst";
            this.textBoxSifriraniTekst.ReadOnly = true;
            this.textBoxSifriraniTekst.Size = new System.Drawing.Size(776, 95);
            this.textBoxSifriraniTekst.TabIndex = 10;
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "Brute force svih kombinacija",
            "Testni brute force prvih (2^14) kombinacija"});
            this.comboBoxMode.Location = new System.Drawing.Point(362, 126);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(210, 21);
            this.comboBoxMode.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Analiza i vremenska procjena:";
            // 
            // textBoxAnaliza
            // 
            this.textBoxAnaliza.Location = new System.Drawing.Point(12, 235);
            this.textBoxAnaliza.Multiline = true;
            this.textBoxAnaliza.Name = "textBoxAnaliza";
            this.textBoxAnaliza.ReadOnly = true;
            this.textBoxAnaliza.Size = new System.Drawing.Size(776, 203);
            this.textBoxAnaliza.TabIndex = 13;
            // 
            // buttonPokreni
            // 
            this.buttonPokreni.Location = new System.Drawing.Point(362, 159);
            this.buttonPokreni.Name = "buttonPokreni";
            this.buttonPokreni.Size = new System.Drawing.Size(210, 49);
            this.buttonPokreni.TabIndex = 15;
            this.buttonPokreni.Text = "Pokreni";
            this.buttonPokreni.UseVisualStyleBackColor = true;
            this.buttonPokreni.Click += new System.EventHandler(this.buttonPokreni_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ključ:";
            // 
            // textBoxKljuc
            // 
            this.textBoxKljuc.Location = new System.Drawing.Point(12, 148);
            this.textBoxKljuc.Multiline = true;
            this.textBoxKljuc.Name = "textBoxKljuc";
            this.textBoxKljuc.ReadOnly = true;
            this.textBoxKljuc.Size = new System.Drawing.Size(331, 60);
            this.textBoxKljuc.TabIndex = 16;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // buttonZaustavi
            // 
            this.buttonZaustavi.Location = new System.Drawing.Point(578, 159);
            this.buttonZaustavi.Name = "buttonZaustavi";
            this.buttonZaustavi.Size = new System.Drawing.Size(210, 49);
            this.buttonZaustavi.TabIndex = 18;
            this.buttonZaustavi.Text = "Zaustavi";
            this.buttonZaustavi.UseVisualStyleBackColor = true;
            this.buttonZaustavi.Click += new System.EventHandler(this.buttonZaustavi_Click);
            // 
            // FrmBruteForce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonZaustavi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKljuc);
            this.Controls.Add(this.buttonPokreni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAnaliza);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.labelCiphertext);
            this.Controls.Add(this.textBoxSifriraniTekst);
            this.Name = "FrmBruteForce";
            this.Text = "Napad grubom silom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCiphertext;
        private System.Windows.Forms.TextBox textBoxSifriraniTekst;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAnaliza;
        private System.Windows.Forms.Button buttonPokreni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKljuc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonZaustavi;
    }
}
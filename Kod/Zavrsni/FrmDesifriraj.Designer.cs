
namespace Zavrsni
{
    partial class FrmDesifriraj
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
            this.textBoxSifriraniTekst = new System.Windows.Forms.TextBox();
            this.textBoxKljuc = new System.Windows.Forms.TextBox();
            this.textBoxJasniTekst = new System.Windows.Forms.TextBox();
            this.buttonDesifriraj = new System.Windows.Forms.Button();
            this.labelKljuc = new System.Windows.Forms.Label();
            this.labelPlaintext = new System.Windows.Forms.Label();
            this.labelCiphertext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSifriraniTekst
            // 
            this.textBoxSifriraniTekst.Location = new System.Drawing.Point(12, 25);
            this.textBoxSifriraniTekst.Multiline = true;
            this.textBoxSifriraniTekst.Name = "textBoxSifriraniTekst";
            this.textBoxSifriraniTekst.ReadOnly = true;
            this.textBoxSifriraniTekst.Size = new System.Drawing.Size(542, 160);
            this.textBoxSifriraniTekst.TabIndex = 1;
            // 
            // textBoxKljuc
            // 
            this.textBoxKljuc.Location = new System.Drawing.Point(12, 204);
            this.textBoxKljuc.Multiline = true;
            this.textBoxKljuc.Name = "textBoxKljuc";
            this.textBoxKljuc.Size = new System.Drawing.Size(542, 36);
            this.textBoxKljuc.TabIndex = 2;
            // 
            // textBoxJasniTekst
            // 
            this.textBoxJasniTekst.Location = new System.Drawing.Point(12, 335);
            this.textBoxJasniTekst.Multiline = true;
            this.textBoxJasniTekst.Name = "textBoxJasniTekst";
            this.textBoxJasniTekst.ReadOnly = true;
            this.textBoxJasniTekst.Size = new System.Drawing.Size(542, 160);
            this.textBoxJasniTekst.TabIndex = 3;
            // 
            // buttonDesifriraj
            // 
            this.buttonDesifriraj.Location = new System.Drawing.Point(201, 258);
            this.buttonDesifriraj.Name = "buttonDesifriraj";
            this.buttonDesifriraj.Size = new System.Drawing.Size(189, 56);
            this.buttonDesifriraj.TabIndex = 5;
            this.buttonDesifriraj.Text = "Dešifriraj";
            this.buttonDesifriraj.UseVisualStyleBackColor = true;
            this.buttonDesifriraj.Click += new System.EventHandler(this.buttonDesifriraj_Click);
            // 
            // labelKljuc
            // 
            this.labelKljuc.AutoSize = true;
            this.labelKljuc.Location = new System.Drawing.Point(12, 188);
            this.labelKljuc.Name = "labelKljuc";
            this.labelKljuc.Size = new System.Drawing.Size(33, 13);
            this.labelKljuc.TabIndex = 6;
            this.labelKljuc.Text = "Ključ:";
            // 
            // labelPlaintext
            // 
            this.labelPlaintext.AutoSize = true;
            this.labelPlaintext.Location = new System.Drawing.Point(12, 9);
            this.labelPlaintext.Name = "labelPlaintext";
            this.labelPlaintext.Size = new System.Drawing.Size(57, 13);
            this.labelPlaintext.TabIndex = 7;
            this.labelPlaintext.Text = "Ciphertext:";
            // 
            // labelCiphertext
            // 
            this.labelCiphertext.AutoSize = true;
            this.labelCiphertext.Location = new System.Drawing.Point(12, 319);
            this.labelCiphertext.Name = "labelCiphertext";
            this.labelCiphertext.Size = new System.Drawing.Size(50, 13);
            this.labelCiphertext.TabIndex = 8;
            this.labelCiphertext.Text = "Plaintext:";
            // 
            // FrmDesifriraj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 507);
            this.Controls.Add(this.labelCiphertext);
            this.Controls.Add(this.labelPlaintext);
            this.Controls.Add(this.labelKljuc);
            this.Controls.Add(this.buttonDesifriraj);
            this.Controls.Add(this.textBoxJasniTekst);
            this.Controls.Add(this.textBoxKljuc);
            this.Controls.Add(this.textBoxSifriraniTekst);
            this.Name = "FrmDesifriraj";
            this.Text = "Dešifriranje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSifriraniTekst;
        private System.Windows.Forms.TextBox textBoxKljuc;
        private System.Windows.Forms.TextBox textBoxJasniTekst;
        private System.Windows.Forms.Button buttonDesifriraj;
        private System.Windows.Forms.Label labelKljuc;
        private System.Windows.Forms.Label labelPlaintext;
        private System.Windows.Forms.Label labelCiphertext;
    }
}
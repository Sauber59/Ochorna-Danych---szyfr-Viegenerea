namespace Vigener
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.output_TB = new System.Windows.Forms.TextBox();
            this.input_TB = new System.Windows.Forms.TextBox();
            this.decrypt_BTN = new System.Windows.Forms.Button();
            this.encrypt_BTN = new System.Windows.Forms.Button();
            this.keyTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Klucz";
            // 
            // output_TB
            // 
            this.output_TB.Location = new System.Drawing.Point(136, 151);
            this.output_TB.Multiline = true;
            this.output_TB.Name = "output_TB";
            this.output_TB.ReadOnly = true;
            this.output_TB.Size = new System.Drawing.Size(434, 109);
            this.output_TB.TabIndex = 12;
            // 
            // input_TB
            // 
            this.input_TB.Location = new System.Drawing.Point(136, 28);
            this.input_TB.Multiline = true;
            this.input_TB.Name = "input_TB";
            this.input_TB.Size = new System.Drawing.Size(434, 117);
            this.input_TB.TabIndex = 11;
            this.input_TB.TextChanged += new System.EventHandler(this.input_TB_TextChanged);
            this.input_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_TB_KeyPress);
            // 
            // decrypt_BTN
            // 
            this.decrypt_BTN.Location = new System.Drawing.Point(494, 321);
            this.decrypt_BTN.Name = "decrypt_BTN";
            this.decrypt_BTN.Size = new System.Drawing.Size(75, 23);
            this.decrypt_BTN.TabIndex = 10;
            this.decrypt_BTN.Text = "Deszyfruj";
            this.decrypt_BTN.UseVisualStyleBackColor = true;
            this.decrypt_BTN.Click += new System.EventHandler(this.decrypt_BTN_Click);
            // 
            // encrypt_BTN
            // 
            this.encrypt_BTN.Location = new System.Drawing.Point(135, 321);
            this.encrypt_BTN.Name = "encrypt_BTN";
            this.encrypt_BTN.Size = new System.Drawing.Size(75, 23);
            this.encrypt_BTN.TabIndex = 9;
            this.encrypt_BTN.Text = "Szyfruj";
            this.encrypt_BTN.UseVisualStyleBackColor = true;
            this.encrypt_BTN.Click += new System.EventHandler(this.encrypt_BTN_Click);
            // 
            // keyTB
            // 
            this.keyTB.Location = new System.Drawing.Point(202, 278);
            this.keyTB.Name = "keyTB";
            this.keyTB.Size = new System.Drawing.Size(269, 20);
            this.keyTB.TabIndex = 14;
            this.keyTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyTB_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.keyTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output_TB);
            this.Controls.Add(this.input_TB);
            this.Controls.Add(this.decrypt_BTN);
            this.Controls.Add(this.encrypt_BTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox output_TB;
        private System.Windows.Forms.TextBox input_TB;
        private System.Windows.Forms.Button decrypt_BTN;
        private System.Windows.Forms.Button encrypt_BTN;
        private System.Windows.Forms.TextBox keyTB;
    }
}


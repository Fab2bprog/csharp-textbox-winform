﻿namespace WFSaisieExemple
{
    partial class Win_Exemple
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tab_Control = new System.Windows.Forms.TabControl();
            this.Tab_Codes = new System.Windows.Forms.TabPage();
            this.Lab_CodeLower = new System.Windows.Forms.Label();
            this.Txt_CodeLower = new System.Windows.Forms.TextBox();
            this.Lab_Code = new System.Windows.Forms.Label();
            this.Txt_Code = new System.Windows.Forms.TextBox();
            this.Tab_Integer = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lab_NumHexa = new System.Windows.Forms.Label();
            this.Txt_NumHexa = new System.Windows.Forms.TextBox();
            this.Lab_Int = new System.Windows.Forms.Label();
            this.Txt_Int = new System.Windows.Forms.TextBox();
            this.Tab_Decim = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Monetaire = new System.Windows.Forms.TextBox();
            this.Lab_Decim = new System.Windows.Forms.Label();
            this.Txt_Decim = new System.Windows.Forms.TextBox();
            this.Tab_Time = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Heure = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Date = new System.Windows.Forms.MaskedTextBox();
            this.Lab_Date = new System.Windows.Forms.Label();
            this.Lab_Heure = new System.Windows.Forms.Label();
            this.Tab_Email = new System.Windows.Forms.TabPage();
            this.Lab_EMail = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tab_Control.SuspendLayout();
            this.Tab_Codes.SuspendLayout();
            this.Tab_Integer.SuspendLayout();
            this.Tab_Decim.SuspendLayout();
            this.Tab_Time.SuspendLayout();
            this.Tab_Email.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_Control
            // 
            this.Tab_Control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Control.Controls.Add(this.Tab_Codes);
            this.Tab_Control.Controls.Add(this.Tab_Integer);
            this.Tab_Control.Controls.Add(this.Tab_Decim);
            this.Tab_Control.Controls.Add(this.Tab_Time);
            this.Tab_Control.Controls.Add(this.Tab_Email);
            this.Tab_Control.Location = new System.Drawing.Point(12, 12);
            this.Tab_Control.Name = "Tab_Control";
            this.Tab_Control.SelectedIndex = 0;
            this.Tab_Control.Size = new System.Drawing.Size(571, 352);
            this.Tab_Control.TabIndex = 0;
            // 
            // Tab_Codes
            // 
            this.Tab_Codes.Controls.Add(this.Lab_CodeLower);
            this.Tab_Codes.Controls.Add(this.Txt_CodeLower);
            this.Tab_Codes.Controls.Add(this.Lab_Code);
            this.Tab_Codes.Controls.Add(this.Txt_Code);
            this.Tab_Codes.Location = new System.Drawing.Point(4, 22);
            this.Tab_Codes.Name = "Tab_Codes";
            this.Tab_Codes.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Codes.Size = new System.Drawing.Size(563, 326);
            this.Tab_Codes.TabIndex = 0;
            this.Tab_Codes.Text = "Entering codes";
            this.Tab_Codes.UseVisualStyleBackColor = true;
            // 
            // Lab_CodeLower
            // 
            this.Lab_CodeLower.AutoSize = true;
            this.Lab_CodeLower.Location = new System.Drawing.Point(25, 69);
            this.Lab_CodeLower.Name = "Lab_CodeLower";
            this.Lab_CodeLower.Size = new System.Drawing.Size(268, 13);
            this.Lab_CodeLower.TabIndex = 21;
            this.Lab_CodeLower.Text = "Code AlphaNum Lowercase without Esp or punctuation";
            // 
            // Txt_CodeLower
            // 
            this.Txt_CodeLower.Location = new System.Drawing.Point(310, 69);
            this.Txt_CodeLower.Name = "Txt_CodeLower";
            this.Txt_CodeLower.Size = new System.Drawing.Size(169, 20);
            this.Txt_CodeLower.TabIndex = 20;
            this.Txt_CodeLower.TextChanged += new System.EventHandler(this.Txt_CodeLower_TextChanged);
            this.Txt_CodeLower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_CodeLower_KeyPress);
            // 
            // Lab_Code
            // 
            this.Lab_Code.AutoSize = true;
            this.Lab_Code.Location = new System.Drawing.Point(25, 27);
            this.Lab_Code.Name = "Lab_Code";
            this.Lab_Code.Size = new System.Drawing.Size(268, 13);
            this.Lab_Code.TabIndex = 3;
            this.Lab_Code.Text = "AlphaNum Code Uppercase without Esp or punctuation";
            // 
            // Txt_Code
            // 
            this.Txt_Code.Location = new System.Drawing.Point(310, 27);
            this.Txt_Code.Name = "Txt_Code";
            this.Txt_Code.Size = new System.Drawing.Size(169, 20);
            this.Txt_Code.TabIndex = 2;
            this.Txt_Code.TextChanged += new System.EventHandler(this.Txt_Code_TextChanged);
            this.Txt_Code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Code_KeyPress);
            // 
            // Tab_Integer
            // 
            this.Tab_Integer.Controls.Add(this.label2);
            this.Tab_Integer.Controls.Add(this.textBox1);
            this.Tab_Integer.Controls.Add(this.Lab_NumHexa);
            this.Tab_Integer.Controls.Add(this.Txt_NumHexa);
            this.Tab_Integer.Controls.Add(this.Lab_Int);
            this.Tab_Integer.Controls.Add(this.Txt_Int);
            this.Tab_Integer.Location = new System.Drawing.Point(4, 22);
            this.Tab_Integer.Name = "Tab_Integer";
            this.Tab_Integer.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Integer.Size = new System.Drawing.Size(563, 326);
            this.Tab_Integer.TabIndex = 1;
            this.Tab_Integer.Text = "Entering integer numbers.";
            this.Tab_Integer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Integer between 0 and 100:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.Txt_IntLimit_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_IntLimit_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.Txt_IntLimit_Leave);
            // 
            // Lab_NumHexa
            // 
            this.Lab_NumHexa.AutoSize = true;
            this.Lab_NumHexa.Location = new System.Drawing.Point(28, 120);
            this.Lab_NumHexa.Name = "Lab_NumHexa";
            this.Lab_NumHexa.Size = new System.Drawing.Size(106, 13);
            this.Lab_NumHexa.TabIndex = 23;
            this.Lab_NumHexa.Text = "Hexadecimal number";
            // 
            // Txt_NumHexa
            // 
            this.Txt_NumHexa.Location = new System.Drawing.Point(183, 117);
            this.Txt_NumHexa.Name = "Txt_NumHexa";
            this.Txt_NumHexa.Size = new System.Drawing.Size(102, 20);
            this.Txt_NumHexa.TabIndex = 22;
            this.Txt_NumHexa.TextChanged += new System.EventHandler(this.Txt_NumHexa_TextChanged);
            this.Txt_NumHexa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NumHexa_KeyPress);
            // 
            // Lab_Int
            // 
            this.Lab_Int.AutoSize = true;
            this.Lab_Int.Location = new System.Drawing.Point(24, 28);
            this.Lab_Int.Name = "Lab_Int";
            this.Lab_Int.Size = new System.Drawing.Size(84, 13);
            this.Lab_Int.TabIndex = 5;
            this.Lab_Int.Text = "Integer number :";
            // 
            // Txt_Int
            // 
            this.Txt_Int.Location = new System.Drawing.Point(183, 28);
            this.Txt_Int.Name = "Txt_Int";
            this.Txt_Int.Size = new System.Drawing.Size(102, 20);
            this.Txt_Int.TabIndex = 4;
            this.Txt_Int.TextChanged += new System.EventHandler(this.Txt_Int_TextChanged);
            this.Txt_Int.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Int_KeyPress);
            this.Txt_Int.Leave += new System.EventHandler(this.Txt_Int_Leave);
            // 
            // Tab_Decim
            // 
            this.Tab_Decim.Controls.Add(this.label8);
            this.Tab_Decim.Controls.Add(this.label5);
            this.Tab_Decim.Controls.Add(this.label4);
            this.Tab_Decim.Controls.Add(this.label1);
            this.Tab_Decim.Controls.Add(this.Txt_Monetaire);
            this.Tab_Decim.Controls.Add(this.Lab_Decim);
            this.Tab_Decim.Controls.Add(this.Txt_Decim);
            this.Tab_Decim.Location = new System.Drawing.Point(4, 22);
            this.Tab_Decim.Name = "Tab_Decim";
            this.Tab_Decim.Size = new System.Drawing.Size(563, 326);
            this.Tab_Decim.TabIndex = 2;
            this.Tab_Decim.Text = "Entering decimal numbers.";
            this.Tab_Decim.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(414, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "The entry is checked in real time so that you can only enter decimal or integer n" +
    "umbers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "use the nbrdecim property to set the maximum number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Here the number of decimal is limited to 5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Monetary number";
            // 
            // Txt_Monetaire
            // 
            this.Txt_Monetaire.Location = new System.Drawing.Point(158, 127);
            this.Txt_Monetaire.Name = "Txt_Monetaire";
            this.Txt_Monetaire.Size = new System.Drawing.Size(100, 20);
            this.Txt_Monetaire.TabIndex = 26;
            this.Txt_Monetaire.Enter += new System.EventHandler(this.Txt_Monetaire_Enter);
            this.Txt_Monetaire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Monetaire_KeyPress);
            this.Txt_Monetaire.Leave += new System.EventHandler(this.Txt_Monetaire_Leave);
            // 
            // Lab_Decim
            // 
            this.Lab_Decim.AutoSize = true;
            this.Lab_Decim.Location = new System.Drawing.Point(23, 53);
            this.Lab_Decim.Name = "Lab_Decim";
            this.Lab_Decim.Size = new System.Drawing.Size(83, 13);
            this.Lab_Decim.TabIndex = 25;
            this.Lab_Decim.Text = "Decimal number";
            // 
            // Txt_Decim
            // 
            this.Txt_Decim.Location = new System.Drawing.Point(158, 53);
            this.Txt_Decim.Name = "Txt_Decim";
            this.Txt_Decim.Size = new System.Drawing.Size(100, 20);
            this.Txt_Decim.TabIndex = 24;
            this.Txt_Decim.TextChanged += new System.EventHandler(this.Txt_Decim_TextChanged);
            this.Txt_Decim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Decim_KeyPress);
            this.Txt_Decim.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Decim_KeyUp);
            this.Txt_Decim.Leave += new System.EventHandler(this.Txt_Decim_LeaveFocus);
            // 
            // Tab_Time
            // 
            this.Tab_Time.Controls.Add(this.label7);
            this.Tab_Time.Controls.Add(this.label6);
            this.Tab_Time.Controls.Add(this.Txt_Heure);
            this.Tab_Time.Controls.Add(this.Txt_Date);
            this.Tab_Time.Controls.Add(this.Lab_Date);
            this.Tab_Time.Controls.Add(this.Lab_Heure);
            this.Tab_Time.Location = new System.Drawing.Point(4, 22);
            this.Tab_Time.Name = "Tab_Time";
            this.Tab_Time.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Time.Size = new System.Drawing.Size(563, 326);
            this.Tab_Time.TabIndex = 3;
            this.Tab_Time.Text = "Enter Date and Time";
            this.Tab_Time.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(477, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "The date is in French format you will have to modify the code to put it in the fo" +
    "rmat of your language.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Date and time entry controls use maskedtextboxes.";
            // 
            // Txt_Heure
            // 
            this.Txt_Heure.Location = new System.Drawing.Point(203, 53);
            this.Txt_Heure.Mask = "00:00";
            this.Txt_Heure.Name = "Txt_Heure";
            this.Txt_Heure.Size = new System.Drawing.Size(40, 20);
            this.Txt_Heure.TabIndex = 24;
            this.Txt_Heure.ValidatingType = typeof(System.DateTime);
            this.Txt_Heure.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Txt_Heure_MaskInputRejected);
            this.Txt_Heure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Heure_KeyPress);
            this.Txt_Heure.Validated += new System.EventHandler(this.Txt_Heure_Validating);
            // 
            // Txt_Date
            // 
            this.Txt_Date.Location = new System.Drawing.Point(203, 94);
            this.Txt_Date.Mask = "00/00/0000";
            this.Txt_Date.Name = "Txt_Date";
            this.Txt_Date.Size = new System.Drawing.Size(70, 20);
            this.Txt_Date.TabIndex = 23;
            this.Txt_Date.ValidatingType = typeof(System.DateTime);
            this.Txt_Date.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Txt_Date_MaskInputRejected);
            this.Txt_Date.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Date_KeyPress);
            this.Txt_Date.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Date_Validating);
            // 
            // Lab_Date
            // 
            this.Lab_Date.AutoSize = true;
            this.Lab_Date.Location = new System.Drawing.Point(36, 97);
            this.Lab_Date.Name = "Lab_Date";
            this.Lab_Date.Size = new System.Drawing.Size(152, 13);
            this.Lab_Date.TabIndex = 15;
            this.Lab_Date.Text = "Valid Date ( DD/ MM / YYYY):";
            // 
            // Lab_Heure
            // 
            this.Lab_Heure.AutoSize = true;
            this.Lab_Heure.Location = new System.Drawing.Point(36, 56);
            this.Lab_Heure.Name = "Lab_Heure";
            this.Lab_Heure.Size = new System.Drawing.Size(108, 13);
            this.Lab_Heure.TabIndex = 13;
            this.Lab_Heure.Text = "Valid Time (HH: MM):";
            // 
            // Tab_Email
            // 
            this.Tab_Email.Controls.Add(this.Lab_EMail);
            this.Tab_Email.Controls.Add(this.Txt_Email);
            this.Tab_Email.Location = new System.Drawing.Point(4, 22);
            this.Tab_Email.Name = "Tab_Email";
            this.Tab_Email.Size = new System.Drawing.Size(563, 326);
            this.Tab_Email.TabIndex = 4;
            this.Tab_Email.Text = "Enter Email";
            this.Tab_Email.UseVisualStyleBackColor = true;
            // 
            // Lab_EMail
            // 
            this.Lab_EMail.AutoSize = true;
            this.Lab_EMail.Location = new System.Drawing.Point(24, 34);
            this.Lab_EMail.Name = "Lab_EMail";
            this.Lab_EMail.Size = new System.Drawing.Size(102, 13);
            this.Lab_EMail.TabIndex = 9;
            this.Lab_EMail.Text = "Valid Email Address:";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(136, 31);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(240, 20);
            this.Txt_Email.TabIndex = 8;
            this.Txt_Email.Leave += new System.EventHandler(this.Txt_Email_LostFocus);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Copyright Fabrice Garcia, Prog Version 1.2";
            // 
            // Win_Exemple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 399);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tab_Control);
            this.Name = "Win_Exemple";
            this.Text = "Example of data entry control in textbox";
            this.Load += new System.EventHandler(this.Win_Exemple_Load);
            this.Tab_Control.ResumeLayout(false);
            this.Tab_Codes.ResumeLayout(false);
            this.Tab_Codes.PerformLayout();
            this.Tab_Integer.ResumeLayout(false);
            this.Tab_Integer.PerformLayout();
            this.Tab_Decim.ResumeLayout(false);
            this.Tab_Decim.PerformLayout();
            this.Tab_Time.ResumeLayout(false);
            this.Tab_Time.PerformLayout();
            this.Tab_Email.ResumeLayout(false);
            this.Tab_Email.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tab_Control;
        private System.Windows.Forms.TabPage Tab_Codes;
        private System.Windows.Forms.TabPage Tab_Integer;
        private System.Windows.Forms.TabPage Tab_Decim;
        private System.Windows.Forms.TabPage Tab_Time;
        private System.Windows.Forms.TabPage Tab_Email;
        private System.Windows.Forms.Label Lab_Code;
        private System.Windows.Forms.TextBox Txt_Code;
        private System.Windows.Forms.Label Lab_CodeLower;
        private System.Windows.Forms.TextBox Txt_CodeLower;
        private System.Windows.Forms.Label Lab_NumHexa;
        private System.Windows.Forms.TextBox Txt_NumHexa;
        private System.Windows.Forms.Label Lab_Int;
        private System.Windows.Forms.TextBox Txt_Int;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Monetaire;
        private System.Windows.Forms.Label Lab_Decim;
        private System.Windows.Forms.TextBox Txt_Decim;
        private System.Windows.Forms.Label Lab_Date;
        private System.Windows.Forms.Label Lab_Heure;
        private System.Windows.Forms.Label Lab_EMail;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Txt_Date;
        private System.Windows.Forms.MaskedTextBox Txt_Heure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}


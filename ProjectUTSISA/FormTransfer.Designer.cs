﻿
namespace ProjectUTSISA
{
    partial class FormTransfer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRekSumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPesan = new System.Windows.Forms.TextBox();
            this.textBoxNominal = new System.Windows.Forms.TextBox();
            this.textBoxRekTujuan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnKirim = new System.Windows.Forms.Button();
            this.textBoxPIN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBukaPIN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonBukaPIN);
            this.panel1.Controls.Add(this.textBoxPIN);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelRekSumber);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxPesan);
            this.panel1.Controls.Add(this.textBoxNominal);
            this.panel1.Controls.Add(this.textBoxRekTujuan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 228);
            this.panel1.TabIndex = 0;
            // 
            // labelRekSumber
            // 
            this.labelRekSumber.AutoSize = true;
            this.labelRekSumber.Location = new System.Drawing.Point(165, 18);
            this.labelRekSumber.Name = "labelRekSumber";
            this.labelRekSumber.Size = new System.Drawing.Size(139, 16);
            this.labelRekSumber.TabIndex = 1;
            this.labelRekSumber.Text = "No. Rekening Sumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rekening Sumber: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pesan: ";
            // 
            // textBoxPesan
            // 
            this.textBoxPesan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesan.Location = new System.Drawing.Point(168, 116);
            this.textBoxPesan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPesan.Multiline = true;
            this.textBoxPesan.Name = "textBoxPesan";
            this.textBoxPesan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPesan.Size = new System.Drawing.Size(248, 59);
            this.textBoxPesan.TabIndex = 7;
            // 
            // textBoxNominal
            // 
            this.textBoxNominal.Location = new System.Drawing.Point(168, 81);
            this.textBoxNominal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNominal.Name = "textBoxNominal";
            this.textBoxNominal.Size = new System.Drawing.Size(248, 22);
            this.textBoxNominal.TabIndex = 5;
            // 
            // textBoxRekTujuan
            // 
            this.textBoxRekTujuan.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxRekTujuan.Location = new System.Drawing.Point(168, 46);
            this.textBoxRekTujuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRekTujuan.Name = "textBoxRekTujuan";
            this.textBoxRekTujuan.Size = new System.Drawing.Size(248, 22);
            this.textBoxRekTujuan.TabIndex = 3;
            this.textBoxRekTujuan.Enter += new System.EventHandler(this.textBoxRekTujuan_Enter);
            this.textBoxRekTujuan.Leave += new System.EventHandler(this.textBoxRekTujuan_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nominal: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rekening Tujuan: ";
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.Red;
            this.btnBatal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBatal.Location = new System.Drawing.Point(389, 259);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(101, 34);
            this.btnBatal.TabIndex = 2;
            this.btnBatal.Text = "Batalkan";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnKirim
            // 
            this.btnKirim.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnKirim.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKirim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKirim.Location = new System.Drawing.Point(224, 259);
            this.btnKirim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(101, 34);
            this.btnKirim.TabIndex = 1;
            this.btnKirim.Text = "Kirim";
            this.btnKirim.UseVisualStyleBackColor = false;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // textBoxPIN
            // 
            this.textBoxPIN.Location = new System.Drawing.Point(168, 188);
            this.textBoxPIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPIN.Name = "textBoxPIN";
            this.textBoxPIN.Size = new System.Drawing.Size(146, 22);
            this.textBoxPIN.TabIndex = 9;
            this.textBoxPIN.Enter += new System.EventHandler(this.textBoxPIN_Enter);
            this.textBoxPIN.Leave += new System.EventHandler(this.textBoxPIN_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "PIN: ";
            // 
            // buttonBukaPIN
            // 
            this.buttonBukaPIN.Location = new System.Drawing.Point(340, 184);
            this.buttonBukaPIN.Name = "buttonBukaPIN";
            this.buttonBukaPIN.Size = new System.Drawing.Size(76, 30);
            this.buttonBukaPIN.TabIndex = 10;
            this.buttonBukaPIN.Text = "Buka";
            this.buttonBukaPIN.UseVisualStyleBackColor = true;
            this.buttonBukaPIN.Click += new System.EventHandler(this.buttonBukaPIN_Click);
            // 
            // FormTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 304);
            this.Controls.Add(this.btnKirim);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTransfer";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.FormTransfer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxNominal;
        private System.Windows.Forms.TextBox textBoxRekTujuan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPesan;
        private System.Windows.Forms.Label labelRekSumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnKirim;
        private System.Windows.Forms.TextBox textBoxPIN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonBukaPIN;
    }
}
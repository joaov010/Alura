﻿namespace CaixaEletronico
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
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textN = new System.Windows.Forms.TextBox();
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(240, 136);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.ReadOnly = true;
            this.textoTitular.Size = new System.Drawing.Size(301, 20);
            this.textoTitular.TabIndex = 1;
            this.textoTitular.TextChanged += new System.EventHandler(this.textoTitular_TextChanged);
            // 
            // textN
            // 
            this.textN.Location = new System.Drawing.Point(240, 176);
            this.textN.Name = "textN";
            this.textN.ReadOnly = true;
            this.textN.Size = new System.Drawing.Size(301, 20);
            this.textN.TabIndex = 1;
            this.textN.TextChanged += new System.EventHandler(this.textoTitular_TextChanged);
            // 
            // textSaldo
            // 
            this.textSaldo.Location = new System.Drawing.Point(240, 215);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.ReadOnly = true;
            this.textSaldo.Size = new System.Drawing.Size(301, 20);
            this.textSaldo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titular da conta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "N°:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saldo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(236, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = ">>  CAIXA ELETRÔNICO <<";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(240, 252);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(301, 20);
            this.textoValor.TabIndex = 7;
            this.textoValor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Fazer depósito";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 36);
            this.button2.TabIndex = 10;
            this.button2.Text = "Fazer saque";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textoValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSaldo);
            this.Controls.Add(this.textN);
            this.Controls.Add(this.textoTitular);
            this.Name = "Form1";
            this.Text = "Projeto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textN;
        private System.Windows.Forms.TextBox textSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


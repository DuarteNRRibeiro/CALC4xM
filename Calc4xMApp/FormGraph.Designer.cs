using System.Drawing;
using System.Windows.Forms;

namespace Calc4xMApp
{
    partial class GraphLinhas
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
            this.button1CarregarDadosManual = new System.Windows.Forms.Button();
            this.button1CarregarDadosCSV = new System.Windows.Forms.Button();
            this.GraphDispersao = new System.Windows.Forms.Button();
            this.GraphBarras = new System.Windows.Forms.Button();
            this.GraphLinha = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1CarregarDadosManual
            // 
            this.button1CarregarDadosManual.Enabled = false;
            this.button1CarregarDadosManual.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button1CarregarDadosManual.Location = new System.Drawing.Point(326, 93);
            this.button1CarregarDadosManual.Name = "button1CarregarDadosManual";
            this.button1CarregarDadosManual.Size = new System.Drawing.Size(183, 56);
            this.button1CarregarDadosManual.TabIndex = 0;
            this.button1CarregarDadosManual.Text = "Carregar Dados Manual";
            this.button1CarregarDadosManual.UseVisualStyleBackColor = true;
            this.button1CarregarDadosManual.Click += new System.EventHandler(this.button1CarregarDadosManual_Click);
            // 
            // button1CarregarDadosCSV
            // 
            this.button1CarregarDadosCSV.Enabled = false;
            this.button1CarregarDadosCSV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button1CarregarDadosCSV.Location = new System.Drawing.Point(326, 172);
            this.button1CarregarDadosCSV.Name = "button1CarregarDadosCSV";
            this.button1CarregarDadosCSV.Size = new System.Drawing.Size(183, 54);
            this.button1CarregarDadosCSV.TabIndex = 2;
            this.button1CarregarDadosCSV.Text = "Carregar Dados CSV";
            this.button1CarregarDadosCSV.UseVisualStyleBackColor = true;
            this.button1CarregarDadosCSV.Click += new System.EventHandler(this.button1CarregarDadosCSV_Click);
            // 
            // GraphDispersao
            // 
            this.GraphDispersao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GraphDispersao.Location = new System.Drawing.Point(3, 137);
            this.GraphDispersao.Name = "GraphDispersao";
            this.GraphDispersao.Size = new System.Drawing.Size(183, 54);
            this.GraphDispersao.TabIndex = 4;
            this.GraphDispersao.Text = "Gráfico de Dispersão";
            this.GraphDispersao.UseVisualStyleBackColor = true;
            this.GraphDispersao.Click += new System.EventHandler(this.GraphDispersao_Click);
            // 
            // GraphBarras
            // 
            this.GraphBarras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GraphBarras.Location = new System.Drawing.Point(3, 215);
            this.GraphBarras.Name = "GraphBarras";
            this.GraphBarras.Size = new System.Drawing.Size(183, 54);
            this.GraphBarras.TabIndex = 5;
            this.GraphBarras.Text = "Gráfico de Barras";
            this.GraphBarras.UseVisualStyleBackColor = true;
            this.GraphBarras.Click += new System.EventHandler(this.GraphBarras_Click);
            // 
            // GraphLinha
            // 
            this.GraphLinha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GraphLinha.Location = new System.Drawing.Point(3, 60);
            this.GraphLinha.Name = "GraphLinha";
            this.GraphLinha.Size = new System.Drawing.Size(183, 54);
            this.GraphLinha.TabIndex = 6;
            this.GraphLinha.Text = "Gráfico de Linhas";
            this.GraphLinha.UseVisualStyleBackColor = true;
            this.GraphLinha.Click += new System.EventHandler(this.GraphLinha_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.GraphLinha);
            this.panel1.Controls.Add(this.GraphDispersao);
            this.panel1.Controls.Add(this.GraphBarras);
            this.panel1.Location = new System.Drawing.Point(38, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 289);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Escolha o tipo de gráfico";
            // 
            // GraphLinhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 399);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1CarregarDadosCSV);
            this.Controls.Add(this.button1CarregarDadosManual);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GraphLinhas";
            this.Text = "Calc4xM Gráfico";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1CarregarDadosManual;
        private Button button1CarregarDadosCSV;
        private Button GraphDispersao;
        private Button GraphBarras;
        private Button GraphLinha;
        private Panel panel1;
        private Label label1;
    }
}
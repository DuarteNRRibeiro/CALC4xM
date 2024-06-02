using System.Drawing;
using System.Windows.Forms;

namespace Calc4xMApp
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCalculadora = new System.Windows.Forms.Button();
            this.buttonGrafico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCalculadora
            // 
            this.buttonCalculadora.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonCalculadora.Location = new System.Drawing.Point(64, 55);
            this.buttonCalculadora.Name = "buttonCalculadora";
            this.buttonCalculadora.Size = new System.Drawing.Size(132, 42);
            this.buttonCalculadora.TabIndex = 0;
            this.buttonCalculadora.Text = "Calculadora";
            this.buttonCalculadora.UseVisualStyleBackColor = true;
            this.buttonCalculadora.Click += new System.EventHandler(this.buttonCalculadora_Click);
            // 
            // buttonGrafico
            // 
            this.buttonGrafico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrafico.Location = new System.Drawing.Point(64, 124);
            this.buttonGrafico.Name = "buttonGrafico";
            this.buttonGrafico.Size = new System.Drawing.Size(132, 42);
            this.buttonGrafico.TabIndex = 1;
            this.buttonGrafico.Text = "Gráfico";
            this.buttonGrafico.UseVisualStyleBackColor = true;
            this.buttonGrafico.Click += new System.EventHandler(this.buttonGrafico_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 256);
            this.Controls.Add(this.buttonGrafico);
            this.Controls.Add(this.buttonCalculadora);
            this.Name = "FormMain";
            this.Text = "Calc4xM App";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonCalculadora;
        private Button buttonGrafico;
    }
}

using System;

namespace Calc4xMApp
{
    partial class RecolhaDadosManual
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
            this.components = new System.ComponentModel.Container();
            this.textX = new System.Windows.Forms.TextBox();
            this.textY = new System.Windows.Forms.TextBox();
            this.button1Load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRender = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.ClearDados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textX
            // 
            this.textX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textX.Location = new System.Drawing.Point(49, 32);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(135, 26);
            this.textX.TabIndex = 0;
            // 
            // textY
            // 
            this.textY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textY.Location = new System.Drawing.Point(49, 79);
            this.textY.Name = "textY";
            this.textY.Size = new System.Drawing.Size(135, 26);
            this.textY.TabIndex = 1;
            // 
            // button1Load
            // 
            this.button1Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1Load.Location = new System.Drawing.Point(49, 186);
            this.button1Load.Name = "button1Load";
            this.button1Load.Size = new System.Drawing.Size(135, 59);
            this.button1Load.TabIndex = 2;
            this.button1Load.Text = "Load";
            this.button1Load.UseVisualStyleBackColor = true;
            this.button1Load.Click += new System.EventHandler(this.button1Load_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(14, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y1";
            // 
            // buttonRender
            // 
            this.buttonRender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRender.Location = new System.Drawing.Point(49, 270);
            this.buttonRender.Name = "buttonRender";
            this.buttonRender.Size = new System.Drawing.Size(135, 57);
            this.buttonRender.TabIndex = 6;
            this.buttonRender.Text = "Finish";
            this.buttonRender.UseVisualStyleBackColor = true;
            this.buttonRender.Click += new System.EventHandler(this.buttonRender_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(219, 2);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(717, 436);
            this.zedGraphControl1.TabIndex = 7;
            // 
            // ClearDados
            // 
            this.ClearDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearDados.Location = new System.Drawing.Point(49, 348);
            this.ClearDados.Name = "ClearDados";
            this.ClearDados.Size = new System.Drawing.Size(135, 57);
            this.ClearDados.TabIndex = 10;
            this.ClearDados.Text = "Clear Data";
            this.ClearDados.UseVisualStyleBackColor = true;
            this.ClearDados.Click += new System.EventHandler(this.ClearDados_Click);
            // 
            // RecolhaDadosManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.ClearDados);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.buttonRender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1Load);
            this.Controls.Add(this.textY);
            this.Controls.Add(this.textX);
            this.Name = "RecolhaDadosManual";
            this.Text = "RecolhaDadosManual";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox textX;
        private System.Windows.Forms.TextBox textY;
        private System.Windows.Forms.Button button1Load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRender;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button ClearDados;
    }
}
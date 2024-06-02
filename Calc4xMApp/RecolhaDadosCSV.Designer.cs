namespace Calc4xMApp
{
    partial class RecolhaDadosCSV
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
            this.pathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadPath = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.clearData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pathBox
            // 
            this.pathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pathBox.Location = new System.Drawing.Point(36, 70);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(399, 26);
            this.pathBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(112, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Indique o caminho para o ficheiro.";
            // 
            // LoadPath
            // 
            this.LoadPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoadPath.Location = new System.Drawing.Point(52, 113);
            this.LoadPath.Name = "LoadPath";
            this.LoadPath.Size = new System.Drawing.Size(145, 45);
            this.LoadPath.TabIndex = 2;
            this.LoadPath.Text = "Load";
            this.LoadPath.UseVisualStyleBackColor = true;
            this.LoadPath.Click += new System.EventHandler(this.LoadPath_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 176);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(423, 429);
            this.zedGraphControl1.TabIndex = 3;
            // 
            // clearData
            // 
            this.clearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clearData.Location = new System.Drawing.Point(273, 113);
            this.clearData.Name = "clearData";
            this.clearData.Size = new System.Drawing.Size(145, 45);
            this.clearData.TabIndex = 4;
            this.clearData.Text = "Clear Data";
            this.clearData.UseVisualStyleBackColor = true;
            this.clearData.Click += new System.EventHandler(this.clearData_Click);
            // 
            // RecolhaDadosCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 617);
            this.Controls.Add(this.clearData);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.LoadPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathBox);
            this.Name = "RecolhaDadosCSV";
            this.Text = "RecolhaDadosCSV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadPath;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button clearData;
    }
}
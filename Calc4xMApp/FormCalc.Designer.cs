using System.Drawing;
using System.Windows.Forms;

namespace Calc4xMApp
{
    partial class FormCalc
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
            textBoxVisor = new TextBox();
            buttonPerc = new Button();
            buttonRaiz = new Button();
            buttonQuad = new Button();
            buttonInv = new Button();
            buttonCE = new Button();
            buttonC = new Button();
            buttonDelete = new Button();
            buttonDiv = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonMult = new Button();
            buttonSub = new Button();
            buttonAD = new Button();
            buttonSinal = new Button();
            button0 = new Button();
            buttonVirg = new Button();
            buttonIgual = new Button();
            SuspendLayout();
            // 
            // textBoxVisor
            // 
            textBoxVisor.Location = new Point(13, 13);
            textBoxVisor.Margin = new Padding(4);
            textBoxVisor.Name = "textBoxVisor";
            textBoxVisor.ReadOnly = true;
            textBoxVisor.Size = new Size(223, 29);
            textBoxVisor.TabIndex = 1;
            textBoxVisor.Text = "0";
            textBoxVisor.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonPerc
            // 
            buttonPerc.Location = new Point(72, 60);
            buttonPerc.Margin = new Padding(4);
            buttonPerc.Name = "buttonPerc";
            buttonPerc.Size = new Size(47, 41);
            buttonPerc.TabIndex = 1;
            buttonPerc.Text = "%";
            buttonPerc.UseVisualStyleBackColor = true;
            buttonPerc.Click += buttonPerc_Click;
            // 
            // buttonRaiz
            // 
            buttonRaiz.Location = new Point(17, 60);
            buttonRaiz.Margin = new Padding(4);
            buttonRaiz.Name = "buttonRaiz";
            buttonRaiz.Size = new Size(47, 41);
            buttonRaiz.TabIndex = 2;
            buttonRaiz.Text = "√";
            buttonRaiz.UseVisualStyleBackColor = true;
            buttonRaiz.Click += buttonRaiz_Click;
            // 
            // buttonQuad
            // 
            buttonQuad.Location = new Point(128, 60);
            buttonQuad.Margin = new Padding(4);
            buttonQuad.Name = "buttonQuad";
            buttonQuad.Size = new Size(48, 41);
            buttonQuad.TabIndex = 3;
            buttonQuad.Text = "x²";
            buttonQuad.UseVisualStyleBackColor = true;
            buttonQuad.Click += buttonQuad_Click;
            // 
            // buttonInv
            // 
            buttonInv.Location = new Point(184, 60);
            buttonInv.Margin = new Padding(4);
            buttonInv.Name = "buttonInv";
            buttonInv.Size = new Size(45, 41);
            buttonInv.TabIndex = 4;
            buttonInv.Text = "1/x";
            buttonInv.UseVisualStyleBackColor = true;
            buttonInv.Click += buttonInv_Click;
            // 
            // buttonCE
            // 
            buttonCE.Location = new Point(17, 109);
            buttonCE.Margin = new Padding(4);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(47, 41);
            buttonCE.TabIndex = 5;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = true;
            buttonCE.Click += buttonCE_Click;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(72, 109);
            buttonC.Margin = new Padding(4);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(47, 41);
            buttonC.TabIndex = 6;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(128, 109);
            buttonDelete.Margin = new Padding(4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(48, 41);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "⌫";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.Location = new Point(184, 109);
            buttonDiv.Margin = new Padding(4);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(45, 41);
            buttonDiv.TabIndex = 8;
            buttonDiv.Text = "÷";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += buttonDiv_Click;
            // 
            // button1
            // 
            button1.Location = new Point(17, 158);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(47, 39);
            button1.TabIndex = 9;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(72, 158);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(47, 40);
            button2.TabIndex = 10;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(128, 158);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(48, 40);
            button3.TabIndex = 11;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(17, 205);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(47, 40);
            button4.TabIndex = 12;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(72, 206);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(47, 40);
            button5.TabIndex = 13;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(129, 206);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(47, 40);
            button6.TabIndex = 14;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(17, 253);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(47, 40);
            button7.TabIndex = 15;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(72, 253);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(47, 40);
            button8.TabIndex = 16;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(129, 254);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(47, 40);
            button9.TabIndex = 17;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // buttonMult
            // 
            buttonMult.Location = new Point(184, 156);
            buttonMult.Margin = new Padding(4);
            buttonMult.Name = "buttonMult";
            buttonMult.Size = new Size(45, 41);
            buttonMult.TabIndex = 18;
            buttonMult.Text = "x";
            buttonMult.UseVisualStyleBackColor = true;
            buttonMult.Click += buttonMult_Click;
            // 
            // buttonSub
            // 
            buttonSub.Location = new Point(184, 206);
            buttonSub.Margin = new Padding(4);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(45, 41);
            buttonSub.TabIndex = 19;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = true;
            buttonSub.Click += buttonSub_Click;
            // 
            // buttonAD
            // 
            buttonAD.Location = new Point(184, 252);
            buttonAD.Margin = new Padding(4);
            buttonAD.Name = "buttonAD";
            buttonAD.Size = new Size(45, 41);
            buttonAD.TabIndex = 20;
            buttonAD.Text = "+";
            buttonAD.UseVisualStyleBackColor = true;
            buttonAD.Click += buttonAD_Click;
            // 
            // buttonSinal
            // 
            buttonSinal.Location = new Point(17, 301);
            buttonSinal.Margin = new Padding(4);
            buttonSinal.Name = "buttonSinal";
            buttonSinal.Size = new Size(47, 40);
            buttonSinal.TabIndex = 21;
            buttonSinal.Text = "±";
            buttonSinal.UseVisualStyleBackColor = true;
            buttonSinal.Click += buttonSinal_Click;
            // 
            // button0
            // 
            button0.Location = new Point(72, 301);
            button0.Margin = new Padding(4);
            button0.Name = "button0";
            button0.Size = new Size(47, 40);
            button0.TabIndex = 22;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonVirg
            // 
            buttonVirg.Location = new Point(129, 302);
            buttonVirg.Margin = new Padding(4);
            buttonVirg.Name = "buttonVirg";
            buttonVirg.Size = new Size(47, 40);
            buttonVirg.TabIndex = 23;
            buttonVirg.Text = ",";
            buttonVirg.UseVisualStyleBackColor = true;
            buttonVirg.Click += buttonVirg_Click;
            // 
            // buttonIgual
            // 
            buttonIgual.Location = new Point(184, 302);
            buttonIgual.Margin = new Padding(4);
            buttonIgual.Name = "buttonIgual";
            buttonIgual.Size = new Size(47, 40);
            buttonIgual.TabIndex = 24;
            buttonIgual.Text = "=";
            buttonIgual.UseVisualStyleBackColor = true;
            buttonIgual.Click += buttonIgual_Click;
            // 
            // FormCalc
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 349);
            Controls.Add(buttonIgual);
            Controls.Add(buttonVirg);
            Controls.Add(button0);
            Controls.Add(buttonSinal);
            Controls.Add(buttonAD);
            Controls.Add(buttonSub);
            Controls.Add(buttonMult);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonDiv);
            Controls.Add(buttonDelete);
            Controls.Add(buttonC);
            Controls.Add(buttonCE);
            Controls.Add(buttonInv);
            Controls.Add(buttonQuad);
            Controls.Add(buttonRaiz);
            Controls.Add(buttonPerc);
            Controls.Add(textBoxVisor);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormCalc";
            Text = " Calc4xM Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxVisor;
        private Button buttonPerc;
        private Button buttonRaiz;
        private Button buttonQuad;
        private Button buttonInv;
        private Button buttonCE;
        private Button buttonC;
        private Button buttonDelete;
        private Button buttonDiv;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonMult;
        private Button buttonSub;
        private Button buttonAD;
        private Button buttonSinal;
        private Button button0;
        private Button buttonVirg;
        private Button buttonIgual;
    }
}
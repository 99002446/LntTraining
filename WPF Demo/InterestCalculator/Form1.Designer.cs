
namespace InterestCalculator
{
    partial class Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.principalTextBox = new System.Windows.Forms.TextBox();
            this.ratetextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.periodtextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.interesttextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.amounttextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "PrincipalAmount";
            // 
            // principalTextBox
            // 
            this.principalTextBox.Location = new System.Drawing.Point(242, 67);
            this.principalTextBox.Name = "principalTextBox";
            this.principalTextBox.Size = new System.Drawing.Size(166, 23);
            this.principalTextBox.TabIndex = 1;
            this.principalTextBox.Validated += new System.EventHandler(this.button1_Click);
            // 
            // ratetextbox
            // 
            this.ratetextbox.Location = new System.Drawing.Point(242, 119);
            this.ratetextbox.Name = "ratetextbox";
            this.ratetextbox.Size = new System.Drawing.Size(166, 23);
            this.ratetextbox.TabIndex = 3;
            this.ratetextbox.Validated += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rate";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // periodtextbox
            // 
            this.periodtextbox.Location = new System.Drawing.Point(242, 173);
            this.periodtextbox.Name = "periodtextbox";
            this.periodtextbox.Size = new System.Drawing.Size(166, 23);
            this.periodtextbox.TabIndex = 5;
            this.periodtextbox.Validated += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Period(months)";
            // 
            // interesttextbox
            // 
            this.interesttextbox.Enabled = false;
            this.interesttextbox.Location = new System.Drawing.Point(242, 273);
            this.interesttextbox.Name = "interesttextbox";
            this.interesttextbox.Size = new System.Drawing.Size(166, 23);
            this.interesttextbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Interest";
            // 
            // amounttextbox
            // 
            this.amounttextbox.Enabled = false;
            this.amounttextbox.Location = new System.Drawing.Point(242, 336);
            this.amounttextbox.Name = "amounttextbox";
            this.amounttextbox.Size = new System.Drawing.Size(166, 23);
            this.amounttextbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate Interest";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.amounttextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.interesttextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.periodtextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ratetextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.principalTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox principalTextBox;
        private System.Windows.Forms.TextBox ratetextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox periodtextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox interesttextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox amounttextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}


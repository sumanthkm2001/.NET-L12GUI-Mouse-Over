namespace L12GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNumber1 = new System.Windows.Forms.TextBox();
            this.tbxNumber2 = new System.Windows.Forms.TextBox();
            this.tbxNumber3 = new System.Windows.Forms.TextBox();
            this.cmdGo = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            this.label3.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // tbxNumber1
            // 
            this.tbxNumber1.Location = new System.Drawing.Point(245, 53);
            this.tbxNumber1.Name = "tbxNumber1";
            this.tbxNumber1.Size = new System.Drawing.Size(100, 20);
            this.tbxNumber1.TabIndex = 3;
            this.tbxNumber1.Text = "0";
            // 
            // tbxNumber2
            // 
            this.tbxNumber2.Location = new System.Drawing.Point(245, 93);
            this.tbxNumber2.Name = "tbxNumber2";
            this.tbxNumber2.Size = new System.Drawing.Size(100, 20);
            this.tbxNumber2.TabIndex = 4;
            this.tbxNumber2.Text = "0";
            // 
            // tbxNumber3
            // 
            this.tbxNumber3.Location = new System.Drawing.Point(245, 141);
            this.tbxNumber3.Name = "tbxNumber3";
            this.tbxNumber3.Size = new System.Drawing.Size(100, 20);
            this.tbxNumber3.TabIndex = 5;
            this.tbxNumber3.Text = "0";
            // 
            // cmdGo
            // 
            this.cmdGo.Location = new System.Drawing.Point(258, 196);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(75, 23);
            this.cmdGo.TabIndex = 6;
            this.cmdGo.Text = "Go!";
            this.cmdGo.UseVisualStyleBackColor = true;
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            this.cmdGo.MouseEnter += new System.EventHandler(this.cmdGo_MouseEnter);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(258, 251);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 7;
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(1, 295);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(0, 13);
            this.lblEvent.TabIndex = 8;
            // 
            // Form1
            // 
            this.AcceptButton = this.cmdGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 312);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.cmdGo);
            this.Controls.Add(this.tbxNumber3);
            this.Controls.Add(this.tbxNumber2);
            this.Controls.Add(this.tbxNumber1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNumber1;
        private System.Windows.Forms.TextBox tbxNumber2;
        private System.Windows.Forms.TextBox tbxNumber3;
        private System.Windows.Forms.Button cmdGo;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblEvent;
    }
}


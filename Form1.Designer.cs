namespace Ass3C
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
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxVP = new System.Windows.Forms.TextBox();
            this.tbxMod = new System.Windows.Forms.TextBox();
            this.tbxProt = new System.Windows.Forms.TextBox();
            this.tbxFrame = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbOut
            // 
            this.rtbOut.Location = new System.Drawing.Point(12, 12);
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.Size = new System.Drawing.Size(434, 261);
            this.rtbOut.TabIndex = 0;
            this.rtbOut.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(487, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(256, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add heavly used page";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(499, 246);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(231, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show heavily used pages";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Virtual Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modified(y/n)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Protection";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Page Frame";
            // 
            // tbxVP
            // 
            this.tbxVP.Location = new System.Drawing.Point(578, 26);
            this.tbxVP.Name = "tbxVP";
            this.tbxVP.Size = new System.Drawing.Size(100, 20);
            this.tbxVP.TabIndex = 7;
            // 
            // tbxMod
            // 
            this.tbxMod.Location = new System.Drawing.Point(578, 78);
            this.tbxMod.Name = "tbxMod";
            this.tbxMod.Size = new System.Drawing.Size(100, 20);
            this.tbxMod.TabIndex = 8;
            // 
            // tbxProt
            // 
            this.tbxProt.Location = new System.Drawing.Point(578, 122);
            this.tbxProt.Name = "tbxProt";
            this.tbxProt.Size = new System.Drawing.Size(100, 20);
            this.tbxProt.TabIndex = 9;
            // 
            // tbxFrame
            // 
            this.tbxFrame.Location = new System.Drawing.Point(578, 170);
            this.tbxFrame.Name = "tbxFrame";
            this.tbxFrame.Size = new System.Drawing.Size(100, 20);
            this.tbxFrame.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 297);
            this.Controls.Add(this.tbxFrame);
            this.Controls.Add(this.tbxProt);
            this.Controls.Add(this.tbxMod);
            this.Controls.Add(this.tbxVP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rtbOut);
            this.Name = "Form1";
            this.Text = "Protection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOut;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxVP;
        private System.Windows.Forms.TextBox tbxMod;
        private System.Windows.Forms.TextBox tbxProt;
        private System.Windows.Forms.TextBox tbxFrame;
    }
}


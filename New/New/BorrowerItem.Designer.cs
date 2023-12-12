
namespace New
{
    partial class BorrowerItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lnameTB = new System.Windows.Forms.TextBox();
            this.minitTB = new System.Windows.Forms.TextBox();
            this.fnameTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.MaskedTextBox();
            this.sexTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lnameTB
            // 
            this.lnameTB.Location = new System.Drawing.Point(27, 19);
            this.lnameTB.Name = "lnameTB";
            this.lnameTB.Size = new System.Drawing.Size(81, 22);
            this.lnameTB.TabIndex = 0;
            this.lnameTB.Text = "Lname";
            // 
            // minitTB
            // 
            this.minitTB.Location = new System.Drawing.Point(135, 19);
            this.minitTB.Name = "minitTB";
            this.minitTB.Size = new System.Drawing.Size(78, 22);
            this.minitTB.TabIndex = 1;
            this.minitTB.Text = "minit";
            // 
            // fnameTB
            // 
            this.fnameTB.Location = new System.Drawing.Point(245, 19);
            this.fnameTB.Name = "fnameTB";
            this.fnameTB.Size = new System.Drawing.Size(77, 22);
            this.fnameTB.TabIndex = 2;
            this.fnameTB.Text = "Fname";
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(445, 19);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(131, 22);
            this.phoneTB.TabIndex = 3;
            this.phoneTB.Text = "Phone";
            // 
            // sexTB
            // 
            this.sexTB.Location = new System.Drawing.Point(350, 19);
            this.sexTB.Name = "sexTB";
            this.sexTB.Size = new System.Drawing.Size(62, 22);
            this.sexTB.TabIndex = 4;
            this.sexTB.Text = "Sex";
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(608, 19);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(226, 22);
            this.emailTB.TabIndex = 5;
            this.emailTB.Text = "Email";
            // 
            // BorrowerItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.sexTB);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.fnameTB);
            this.Controls.Add(this.minitTB);
            this.Controls.Add(this.lnameTB);
            this.Name = "BorrowerItem";
            this.Size = new System.Drawing.Size(867, 62);
            this.Load += new System.EventHandler(this.BorrowerItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lnameTB;
        private System.Windows.Forms.TextBox minitTB;
        private System.Windows.Forms.TextBox fnameTB;
        private System.Windows.Forms.MaskedTextBox phoneTB;
        private System.Windows.Forms.TextBox sexTB;
        private System.Windows.Forms.TextBox emailTB;
    }
}

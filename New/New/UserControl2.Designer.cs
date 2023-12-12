
namespace New
{
    partial class UserControl2
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
            this.useridTextBox = new System.Windows.Forms.TextBox();
            this.dateofbirthTextBox = new System.Windows.Forms.MaskedTextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.xoabtn = new System.Windows.Forms.Button();
            this.suabtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // useridTextBox
            // 
            this.useridTextBox.Location = new System.Drawing.Point(26, 21);
            this.useridTextBox.Name = "useridTextBox";
            this.useridTextBox.Size = new System.Drawing.Size(106, 22);
            this.useridTextBox.TabIndex = 0;
            this.useridTextBox.Text = "USER_ID";
            // 
            // dateofbirthTextBox
            // 
            this.dateofbirthTextBox.Location = new System.Drawing.Point(151, 21);
            this.dateofbirthTextBox.Name = "dateofbirthTextBox";
            this.dateofbirthTextBox.Size = new System.Drawing.Size(91, 22);
            this.dateofbirthTextBox.TabIndex = 1;
            this.dateofbirthTextBox.Text = "DateofBirth";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(263, 21);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(123, 22);
            this.phoneTextBox.TabIndex = 2;
            this.phoneTextBox.Text = "Phone";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(404, 21);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(123, 22);
            this.emailTextBox.TabIndex = 3;
            this.emailTextBox.Text = "email";
            // 
            // xoabtn
            // 
            this.xoabtn.BackColor = System.Drawing.Color.Red;
            this.xoabtn.Location = new System.Drawing.Point(552, 20);
            this.xoabtn.Name = "xoabtn";
            this.xoabtn.Size = new System.Drawing.Size(75, 23);
            this.xoabtn.TabIndex = 4;
            this.xoabtn.Text = "XÓA";
            this.xoabtn.UseVisualStyleBackColor = false;
            this.xoabtn.Click += new System.EventHandler(this.xoabtn_Click);
            // 
            // suabtn
            // 
            this.suabtn.BackColor = System.Drawing.Color.Aqua;
            this.suabtn.Location = new System.Drawing.Point(649, 21);
            this.suabtn.Name = "suabtn";
            this.suabtn.Size = new System.Drawing.Size(75, 23);
            this.suabtn.TabIndex = 5;
            this.suabtn.Text = "SỬA";
            this.suabtn.UseVisualStyleBackColor = false;
            this.suabtn.Click += new System.EventHandler(this.suabtn_Click);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.suabtn);
            this.Controls.Add(this.xoabtn);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.dateofbirthTextBox);
            this.Controls.Add(this.useridTextBox);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(754, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button xoabtn;
        private System.Windows.Forms.Button suabtn;
        public System.Windows.Forms.TextBox useridTextBox;
        public System.Windows.Forms.MaskedTextBox dateofbirthTextBox;
        public System.Windows.Forms.TextBox phoneTextBox;
        public System.Windows.Forms.TextBox emailTextBox;
    }
}


namespace New
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
            this.loadbtn = new System.Windows.Forms.Button();
            this.UserLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchBT = new System.Windows.Forms.Button();
            this.userControl24 = new New.UserControl2();
            this.userControl23 = new New.UserControl2();
            this.userControl22 = new New.UserControl2();
            this.userControl21 = new New.UserControl2();
            this.UserLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadbtn
            // 
            this.loadbtn.BackColor = System.Drawing.Color.Yellow;
            this.loadbtn.Location = new System.Drawing.Point(509, 398);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(97, 23);
            this.loadbtn.TabIndex = 2;
            this.loadbtn.Text = "Load";
            this.loadbtn.UseVisualStyleBackColor = false;
            this.loadbtn.Click += new System.EventHandler(this.connectbtn_Click);
            // 
            // UserLayoutPanel
            // 
            this.UserLayoutPanel.AutoScroll = true;
            this.UserLayoutPanel.Controls.Add(this.userControl24);
            this.UserLayoutPanel.Controls.Add(this.userControl23);
            this.UserLayoutPanel.Controls.Add(this.userControl22);
            this.UserLayoutPanel.Controls.Add(this.userControl21);
            this.UserLayoutPanel.Location = new System.Drawing.Point(23, 93);
            this.UserLayoutPanel.Name = "UserLayoutPanel";
            this.UserLayoutPanel.Size = new System.Drawing.Size(759, 269);
            this.UserLayoutPanel.TabIndex = 3;
            this.UserLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(654, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "THÊM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(418, 30);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(228, 22);
            this.searchTB.TabIndex = 5;
            // 
            // searchBT
            // 
            this.searchBT.Location = new System.Drawing.Point(676, 30);
            this.searchBT.Name = "searchBT";
            this.searchBT.Size = new System.Drawing.Size(75, 23);
            this.searchBT.TabIndex = 6;
            this.searchBT.Text = "TÌM";
            this.searchBT.UseVisualStyleBackColor = true;
            this.searchBT.Click += new System.EventHandler(this.button2_Click);
            // 
            // userControl24
            // 
            this.userControl24.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.userControl24.Location = new System.Drawing.Point(3, 3);
            this.userControl24.Name = "userControl24";
            this.userControl24.Size = new System.Drawing.Size(754, 65);
            this.userControl24.TabIndex = 3;
            // 
            // userControl23
            // 
            this.userControl23.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.userControl23.Location = new System.Drawing.Point(3, 74);
            this.userControl23.Name = "userControl23";
            this.userControl23.Size = new System.Drawing.Size(754, 65);
            this.userControl23.TabIndex = 2;
            // 
            // userControl22
            // 
            this.userControl22.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.userControl22.Location = new System.Drawing.Point(3, 145);
            this.userControl22.Name = "userControl22";
            this.userControl22.Size = new System.Drawing.Size(754, 65);
            this.userControl22.TabIndex = 1;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.userControl21.Location = new System.Drawing.Point(3, 216);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(756, 65);
            this.userControl21.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.searchBT);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserLayoutPanel);
            this.Controls.Add(this.loadbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.UserLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.FlowLayoutPanel UserLayoutPanel;
        private UserControl2 userControl24;
        private UserControl2 userControl23;
        private UserControl2 userControl22;
        private UserControl2 userControl21;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button searchBT;
    }
}


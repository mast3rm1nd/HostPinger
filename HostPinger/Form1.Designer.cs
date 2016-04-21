namespace HostPinger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextBox_Hosts = new System.Windows.Forms.TextBox();
            this.Text_Box_Results = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox_Hosts
            // 
            this.TextBox_Hosts.Location = new System.Drawing.Point(12, 26);
            this.TextBox_Hosts.Multiline = true;
            this.TextBox_Hosts.Name = "TextBox_Hosts";
            this.TextBox_Hosts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Hosts.Size = new System.Drawing.Size(211, 91);
            this.TextBox_Hosts.TabIndex = 0;
            this.TextBox_Hosts.Text = "94.247.246.192\r\ndb2.volgo-balt.ru\r\ngoogle.com";
            // 
            // Text_Box_Results
            // 
            this.Text_Box_Results.Location = new System.Drawing.Point(12, 136);
            this.Text_Box_Results.Multiline = true;
            this.Text_Box_Results.Name = "Text_Box_Results";
            this.Text_Box_Results.ReadOnly = true;
            this.Text_Box_Results.Size = new System.Drawing.Size(211, 87);
            this.Text_Box_Results.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hosts to ping";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Results";
            // 
            // Button_Go
            // 
            this.Button_Go.Location = new System.Drawing.Point(12, 229);
            this.Button_Go.Name = "Button_Go";
            this.Button_Go.Size = new System.Drawing.Size(211, 23);
            this.Button_Go.TabIndex = 2;
            this.Button_Go.Text = "Go!";
            this.Button_Go.UseVisualStyleBackColor = true;
            this.Button_Go.Click += new System.EventHandler(this.Button_Go_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 261);
            this.Controls.Add(this.Button_Go);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text_Box_Results);
            this.Controls.Add(this.TextBox_Hosts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HostsPinger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Hosts;
        private System.Windows.Forms.TextBox Text_Box_Results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_Go;



    }
}


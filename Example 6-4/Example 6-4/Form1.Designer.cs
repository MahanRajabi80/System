namespace Example_6_4
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
            this.btnHibernate = new System.Windows.Forms.Button();
            this.btnStandby = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHibernate
            // 
            this.btnHibernate.Location = new System.Drawing.Point(116, 34);
            this.btnHibernate.Name = "btnHibernate";
            this.btnHibernate.Size = new System.Drawing.Size(163, 40);
            this.btnHibernate.TabIndex = 0;
            this.btnHibernate.Tag = "1";
            this.btnHibernate.Text = "&Hibernate";
            this.btnHibernate.UseVisualStyleBackColor = true;
            this.btnHibernate.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnStandby
            // 
            this.btnStandby.Location = new System.Drawing.Point(116, 80);
            this.btnStandby.Name = "btnStandby";
            this.btnStandby.Size = new System.Drawing.Size(163, 40);
            this.btnStandby.TabIndex = 1;
            this.btnStandby.Tag = "2";
            this.btnStandby.Text = "&Standby";
            this.btnStandby.UseVisualStyleBackColor = true;
            this.btnStandby.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.Location = new System.Drawing.Point(116, 126);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(163, 40);
            this.btnShutdown.TabIndex = 2;
            this.btnShutdown.Tag = "3";
            this.btnShutdown.Text = "Sh&ut down";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnLogoff
            // 
            this.btnLogoff.Location = new System.Drawing.Point(116, 172);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(163, 40);
            this.btnLogoff.TabIndex = 3;
            this.btnLogoff.Tag = "4";
            this.btnLogoff.Text = "&Log off";
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(116, 218);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(163, 40);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.Tag = "5";
            this.btnRestart.Text = "&Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 290);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.btnStandby);
            this.Controls.Add(this.btnHibernate);
            this.Name = "Form1";
            this.Text = "Example 6-4 (System)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHibernate;
        private System.Windows.Forms.Button btnStandby;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Button btnRestart;
    }
}


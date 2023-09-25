namespace Spicetify_installer
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
            this.windows_install_btn = new System.Windows.Forms.Button();
            this.windows_lbl = new System.Windows.Forms.Label();
            this.windows_continue_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.close_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // windows_install_btn
            // 
            this.windows_install_btn.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windows_install_btn.Location = new System.Drawing.Point(12, 84);
            this.windows_install_btn.Name = "windows_install_btn";
            this.windows_install_btn.Size = new System.Drawing.Size(104, 51);
            this.windows_install_btn.TabIndex = 0;
            this.windows_install_btn.Text = "Install";
            this.windows_install_btn.UseVisualStyleBackColor = true;
            this.windows_install_btn.Click += new System.EventHandler(this.windows_install_btn_Click);
            // 
            // windows_lbl
            // 
            this.windows_lbl.AutoSize = true;
            this.windows_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windows_lbl.Location = new System.Drawing.Point(12, 59);
            this.windows_lbl.Name = "windows_lbl";
            this.windows_lbl.Size = new System.Drawing.Size(86, 22);
            this.windows_lbl.TabIndex = 1;
            this.windows_lbl.Text = "Windows";
            // 
            // windows_continue_btn
            // 
            this.windows_continue_btn.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windows_continue_btn.Location = new System.Drawing.Point(16, 141);
            this.windows_continue_btn.Name = "windows_continue_btn";
            this.windows_continue_btn.Size = new System.Drawing.Size(100, 51);
            this.windows_continue_btn.TabIndex = 2;
            this.windows_continue_btn.Text = "continue";
            this.windows_continue_btn.UseVisualStyleBackColor = true;
            this.windows_continue_btn.Visible = false;
            this.windows_continue_btn.Click += new System.EventHandler(this.windows_continue_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Make sure to open the windows powershell!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "continue when downloading is done!";
            this.label2.Visible = false;
            // 
            // close_btn
            // 
            this.close_btn.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.Location = new System.Drawing.Point(166, 84);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(104, 51);
            this.close_btn.TabIndex = 5;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Visible = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // close_lbl
            // 
            this.close_lbl.AutoSize = true;
            this.close_lbl.Location = new System.Drawing.Point(122, 40);
            this.close_lbl.Name = "close_lbl";
            this.close_lbl.Size = new System.Drawing.Size(210, 22);
            this.close_lbl.TabIndex = 6;
            this.close_lbl.Text = "Installing is done! enjoy!";
            this.close_lbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 221);
            this.Controls.Add(this.close_lbl);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.windows_continue_btn);
            this.Controls.Add(this.windows_lbl);
            this.Controls.Add(this.windows_install_btn);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Spicetify installer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button windows_install_btn;
        private System.Windows.Forms.Label windows_lbl;
        private System.Windows.Forms.Button windows_continue_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label close_lbl;
    }
}


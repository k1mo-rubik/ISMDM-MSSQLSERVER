namespace ISMDM_MSSQLSERVER
{
    partial class Item
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
            this.l_name = new System.Windows.Forms.Label();
            this.l_spec = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_job = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_name.Location = new System.Drawing.Point(86, 9);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(57, 20);
            this.l_name.TabIndex = 4;
            this.l_name.Text = "label1";
            // 
            // l_spec
            // 
            this.l_spec.AutoSize = true;
            this.l_spec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_spec.Location = new System.Drawing.Point(87, 49);
            this.l_spec.Name = "l_spec";
            this.l_spec.Size = new System.Drawing.Size(44, 16);
            this.l_spec.TabIndex = 5;
            this.l_spec.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lb_job);
            this.panel1.Location = new System.Drawing.Point(656, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 46);
            this.panel1.TabIndex = 7;
            // 
            // lb_job
            // 
            this.lb_job.AutoSize = true;
            this.lb_job.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lb_job.ForeColor = System.Drawing.Color.Gray;
            this.lb_job.Location = new System.Drawing.Point(20, 15);
            this.lb_job.Name = "lb_job";
            this.lb_job.Size = new System.Drawing.Size(46, 18);
            this.lb_job.TabIndex = 8;
            this.lb_job.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(-1, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 81);
            this.panel2.TabIndex = 8;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(828, 77);
            this.Controls.Add(this.l_spec);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item";
            this.Load += new System.EventHandler(this.Item_Load);
            this.Click += new System.EventHandler(this.Item_Click);
            this.DoubleClick += new System.EventHandler(this.Item_DoubleClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Label l_spec;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_job;
        private System.Windows.Forms.Panel panel2;
    }
}
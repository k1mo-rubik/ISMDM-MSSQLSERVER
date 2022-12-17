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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_spec = new System.Windows.Forms.TextBox();
            this.tb_spec2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name.Location = new System.Drawing.Point(104, 27);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(270, 25);
            this.tb_name.TabIndex = 1;
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_spec
            // 
            this.tb_spec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_spec.Location = new System.Drawing.Point(384, 27);
            this.tb_spec.Multiline = true;
            this.tb_spec.Name = "tb_spec";
            this.tb_spec.Size = new System.Drawing.Size(180, 25);
            this.tb_spec.TabIndex = 2;
            this.tb_spec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_spec2
            // 
            this.tb_spec2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_spec2.Location = new System.Drawing.Point(570, 27);
            this.tb_spec2.Multiline = true;
            this.tb_spec2.Name = "tb_spec2";
            this.tb_spec2.Size = new System.Drawing.Size(122, 25);
            this.tb_spec2.TabIndex = 3;
            this.tb_spec2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::ISMDM_MSSQLSERVER.Properties.Resources.man;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 77);
            this.Controls.Add(this.tb_spec2);
            this.Controls.Add(this.tb_spec);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item";
            this.Load += new System.EventHandler(this.Item_Load);
            this.Click += new System.EventHandler(this.Item_Click);
            this.DoubleClick += new System.EventHandler(this.Item_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_spec;
        private System.Windows.Forms.TextBox tb_spec2;
    }
}
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.l_name = new System.Windows.Forms.Label();
            this.l_spec = new System.Windows.Forms.Label();
            this.l_spec2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_name.Location = new System.Drawing.Point(124, 35);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(44, 16);
            this.l_name.TabIndex = 4;
            this.l_name.Text = "label1";
            // 
            // l_spec
            // 
            this.l_spec.AutoSize = true;
            this.l_spec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_spec.Location = new System.Drawing.Point(380, 35);
            this.l_spec.Name = "l_spec";
            this.l_spec.Size = new System.Drawing.Size(44, 16);
            this.l_spec.TabIndex = 5;
            this.l_spec.Text = "label1";
            // 
            // l_spec2
            // 
            this.l_spec2.AutoSize = true;
            this.l_spec2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_spec2.Location = new System.Drawing.Point(563, 35);
            this.l_spec2.Name = "l_spec2";
            this.l_spec2.Size = new System.Drawing.Size(44, 16);
            this.l_spec2.TabIndex = 6;
            this.l_spec2.Text = "label1";
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 77);
            this.Controls.Add(this.l_spec2);
            this.Controls.Add(this.l_spec);
            this.Controls.Add(this.l_name);
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
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Label l_spec;
        private System.Windows.Forms.Label l_spec2;
    }
}
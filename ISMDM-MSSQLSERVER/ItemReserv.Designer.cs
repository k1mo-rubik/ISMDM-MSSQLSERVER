namespace ISMDM_MSSQLSERVER
{
    partial class ItemReserv
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
            this.l_client = new System.Windows.Forms.Label();
            this.l_service = new System.Windows.Forms.Label();
            this.l_emp = new System.Windows.Forms.Label();
            this.l_date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_client
            // 
            this.l_client.AutoSize = true;
            this.l_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_client.Location = new System.Drawing.Point(0, 31);
            this.l_client.Name = "l_client";
            this.l_client.Size = new System.Drawing.Size(44, 16);
            this.l_client.TabIndex = 1;
            this.l_client.Text = "label1";
            // 
            // l_service
            // 
            this.l_service.AutoSize = true;
            this.l_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_service.Location = new System.Drawing.Point(233, 31);
            this.l_service.Name = "l_service";
            this.l_service.Size = new System.Drawing.Size(44, 16);
            this.l_service.TabIndex = 2;
            this.l_service.Text = "label2";
            // 
            // l_emp
            // 
            this.l_emp.AutoSize = true;
            this.l_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_emp.Location = new System.Drawing.Point(383, 31);
            this.l_emp.Name = "l_emp";
            this.l_emp.Size = new System.Drawing.Size(44, 16);
            this.l_emp.TabIndex = 3;
            this.l_emp.Text = "label3";
            // 
            // l_date
            // 
            this.l_date.AutoSize = true;
            this.l_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_date.Location = new System.Drawing.Point(587, 31);
            this.l_date.Name = "l_date";
            this.l_date.Size = new System.Drawing.Size(44, 16);
            this.l_date.TabIndex = 4;
            this.l_date.Text = "label4";
            // 
            // ItemReserv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 77);
            this.Controls.Add(this.l_date);
            this.Controls.Add(this.l_emp);
            this.Controls.Add(this.l_service);
            this.Controls.Add(this.l_client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemReserv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item";
            this.Load += new System.EventHandler(this.ItemReserv_Load);
            this.Click += new System.EventHandler(this.ItemReserv_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_client;
        private System.Windows.Forms.Label l_service;
        private System.Windows.Forms.Label l_emp;
        private System.Windows.Forms.Label l_date;
    }
}
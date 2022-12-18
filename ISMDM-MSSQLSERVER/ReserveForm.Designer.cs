namespace ISMDM_MSSQLSERVER
{
    partial class ReserveForm
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
            this.cb_client = new System.Windows.Forms.ComboBox();
            this.cb_emp = new System.Windows.Forms.ComboBox();
            this.cb_serv = new System.Windows.Forms.ComboBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.cb_time = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_client
            // 
            this.cb_client.FormattingEnabled = true;
            this.cb_client.Location = new System.Drawing.Point(196, 58);
            this.cb_client.Name = "cb_client";
            this.cb_client.Size = new System.Drawing.Size(312, 21);
            this.cb_client.TabIndex = 0;
            // 
            // cb_emp
            // 
            this.cb_emp.FormattingEnabled = true;
            this.cb_emp.Location = new System.Drawing.Point(196, 97);
            this.cb_emp.Name = "cb_emp";
            this.cb_emp.Size = new System.Drawing.Size(312, 21);
            this.cb_emp.TabIndex = 1;
            this.cb_emp.SelectedIndexChanged += new System.EventHandler(this.cb_emp_SelectedIndexChanged);
            // 
            // cb_serv
            // 
            this.cb_serv.FormattingEnabled = true;
            this.cb_serv.Location = new System.Drawing.Point(196, 138);
            this.cb_serv.Name = "cb_serv";
            this.cb_serv.Size = new System.Drawing.Size(312, 21);
            this.cb_serv.TabIndex = 2;
            this.cb_serv.SelectedIndexChanged += new System.EventHandler(this.cb_serv_SelectedIndexChanged);
            // 
            // dtp_date
            // 
            this.dtp_date.CustomFormat = "";
            this.dtp_date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_date.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_date.Location = new System.Drawing.Point(196, 207);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_date.Size = new System.Drawing.Size(149, 20);
            this.dtp_date.TabIndex = 3;
            // 
            // cb_time
            // 
            this.cb_time.FormattingEnabled = true;
            this.cb_time.IntegralHeight = false;
            this.cb_time.Location = new System.Drawing.Point(394, 206);
            this.cb_time.Name = "cb_time";
            this.cb_time.Size = new System.Drawing.Size(100, 21);
            this.cb_time.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(155)))), ((int)(((byte)(171)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(273, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 61);
            this.button1.TabIndex = 22;
            this.button1.Tag = "";
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReserveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_time);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.cb_serv);
            this.Controls.Add(this.cb_emp);
            this.Controls.Add(this.cb_client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReserveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReserveForms";
            this.Load += new System.EventHandler(this.ReserveForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_client;
        private System.Windows.Forms.ComboBox cb_emp;
        private System.Windows.Forms.ComboBox cb_serv;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.ComboBox cb_time;
        private System.Windows.Forms.Button button1;
    }
}
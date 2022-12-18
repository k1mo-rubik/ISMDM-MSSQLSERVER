namespace ISMDM_MSSQLSERVER
{
    partial class CreateReserveForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
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
            this.cb_emp.Location = new System.Drawing.Point(196, 110);
            this.cb_emp.Name = "cb_emp";
            this.cb_emp.Size = new System.Drawing.Size(312, 21);
            this.cb_emp.TabIndex = 1;
            this.cb_emp.SelectedIndexChanged += new System.EventHandler(this.cb_emp_SelectedIndexChanged);
            // 
            // cb_serv
            // 
            this.cb_serv.FormattingEnabled = true;
            this.cb_serv.Location = new System.Drawing.Point(196, 154);
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
            this.button1.Location = new System.Drawing.Point(196, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 61);
            this.button1.TabIndex = 22;
            this.button1.Tag = "";
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Клиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Сотрудник";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Услуга";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Время";
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(155)))), ((int)(((byte)(171)))));
            this.btn_del.FlatAppearance.BorderSize = 0;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.ForeColor = System.Drawing.Color.White;
            this.btn_del.Location = new System.Drawing.Point(364, 306);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(144, 61);
            this.btn_del.TabIndex = 27;
            this.btn_del.Tag = "";
            this.btn_del.Text = "Удалить";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_click);
            // 
            // CreateReserveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 438);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_time);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.cb_serv);
            this.Controls.Add(this.cb_emp);
            this.Controls.Add(this.cb_client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateReserveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReserveForms";
            this.Load += new System.EventHandler(this.ReserveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_client;
        private System.Windows.Forms.ComboBox cb_emp;
        private System.Windows.Forms.ComboBox cb_serv;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.ComboBox cb_time;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_del;
    }
}
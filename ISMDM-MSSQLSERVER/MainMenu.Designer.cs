namespace ISMDM_MSSQLSERVER
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            this.pnlParentNav = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelWorker = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.аккаунтыTableAdapter = new ISMDM_MSSQLSERVER.mdmdbDataSetTableAdapters.АккаунтыTableAdapter();
            this.mdmdbDataSet = new ISMDM_MSSQLSERVER.mdmdbDataSet();
            this.mdmdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыTableAdapter = new ISMDM_MSSQLSERVER.mdmdbDataSetTableAdapters.КлиентыTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlParentNav.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdmdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdmdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlParentNav
            // 
            this.pnlParentNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(155)))), ((int)(((byte)(171)))));
            this.pnlParentNav.Controls.Add(this.pnlNav);
            this.pnlParentNav.Controls.Add(this.btnReport);
            this.pnlParentNav.Controls.Add(this.btnServices);
            this.pnlParentNav.Controls.Add(this.btnEmployee);
            this.pnlParentNav.Controls.Add(this.btnClients);
            this.pnlParentNav.Controls.Add(this.btnRecord);
            this.pnlParentNav.Controls.Add(this.btnMain);
            this.pnlParentNav.Controls.Add(this.panel3);
            this.pnlParentNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlParentNav.Location = new System.Drawing.Point(0, 0);
            this.pnlParentNav.Name = "pnlParentNav";
            this.pnlParentNav.Size = new System.Drawing.Size(162, 577);
            this.pnlParentNav.TabIndex = 1;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.White;
            this.pnlNav.Location = new System.Drawing.Point(0, 144);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(10, 61);
            this.pnlNav.TabIndex = 8;
            this.pnlNav.Visible = false;
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(0, 388);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(162, 61);
            this.btnReport.TabIndex = 7;
            this.btnReport.Tag = "otc";
            this.btnReport.Text = "Отчёты";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnNav_Click);
            // 
            // btnServices
            // 
            this.btnServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServices.FlatAppearance.BorderSize = 0;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServices.ForeColor = System.Drawing.Color.White;
            this.btnServices.Location = new System.Drawing.Point(0, 327);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(162, 61);
            this.btnServices.TabIndex = 6;
            this.btnServices.Tag = "usl";
            this.btnServices.Text = "Услуги";
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.btnNav_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Location = new System.Drawing.Point(0, 266);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(162, 61);
            this.btnEmployee.TabIndex = 5;
            this.btnEmployee.Tag = "sot";
            this.btnEmployee.Text = "Сотрудники";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnNav_Click);
            // 
            // btnClients
            // 
            this.btnClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.ForeColor = System.Drawing.Color.White;
            this.btnClients.Location = new System.Drawing.Point(0, 205);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(162, 61);
            this.btnClients.TabIndex = 4;
            this.btnClients.Tag = "cli";
            this.btnClients.Text = "Клиенты";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnNav_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.ForeColor = System.Drawing.Color.White;
            this.btnRecord.Location = new System.Drawing.Point(0, 144);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(162, 61);
            this.btnRecord.TabIndex = 3;
            this.btnRecord.Tag = "zap";
            this.btnRecord.Text = "Запись";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnNav_Click);
            // 
            // btnMain
            // 
            this.btnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.Color.White;
            this.btnMain.Location = new System.Drawing.Point(0, 144);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(51, 66);
            this.btnMain.TabIndex = 2;
            this.btnMain.Text = "Главная";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnNav_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelWorker);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 144);
            this.panel3.TabIndex = 0;
            // 
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWorker.ForeColor = System.Drawing.Color.White;
            this.labelWorker.Location = new System.Drawing.Point(36, 100);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(95, 20);
            this.labelWorker.TabIndex = 1;
            this.labelWorker.Text = "НАДПИСЬ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureBox1.Location = new System.Drawing.Point(40, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 58);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.BackColor = System.Drawing.Color.Transparent;
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFormLoader.Location = new System.Drawing.Point(162, 100);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(789, 477);
            this.PnlFormLoader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(201, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(95, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "НАДПИСЬ";
            // 
            // аккаунтыTableAdapter
            // 
            this.аккаунтыTableAdapter.ClearBeforeFill = true;
            // 
            // mdmdbDataSet
            // 
            this.mdmdbDataSet.DataSetName = "mdmdbDataSet";
            this.mdmdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mdmdbDataSetBindingSource
            // 
            this.mdmdbDataSetBindingSource.DataSource = this.mdmdbDataSet;
            this.mdmdbDataSetBindingSource.Position = 0;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.mdmdbDataSetBindingSource;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(155)))), ((int)(((byte)(171)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(728, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 61);
            this.button2.TabIndex = 9;
            this.button2.Tag = "";
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_add);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISMDM_MSSQLSERVER.Properties.Resources.bgSharp3;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.pnlParentNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.pnlParentNav.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdmdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdmdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlParentNav;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelWorker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Label lblTitle;
        private mdmdbDataSetTableAdapters.АккаунтыTableAdapter аккаунтыTableAdapter;
        private mdmdbDataSet mdmdbDataSet;
        private System.Windows.Forms.BindingSource mdmdbDataSetBindingSource;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private mdmdbDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}
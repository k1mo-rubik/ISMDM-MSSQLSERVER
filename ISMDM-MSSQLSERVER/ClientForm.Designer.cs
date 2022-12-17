namespace ISMDM_MSSQLSERVER
{
    partial class ClientForm
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
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mdmdbDataSet = new ISMDM_MSSQLSERVER.mdmdbDataSet();
            this.клиентыTableAdapter = new ISMDM_MSSQLSERVER.mdmdbDataSetTableAdapters.КлиентыTableAdapter();
            this.pn_client = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdmdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.mdmdbDataSet;
            // 
            // mdmdbDataSet
            // 
            this.mdmdbDataSet.DataSetName = "mdmdbDataSet";
            this.mdmdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // pn_client
            // 
            this.pn_client.AutoScroll = true;
            this.pn_client.BackColor = System.Drawing.Color.Transparent;
            this.pn_client.Location = new System.Drawing.Point(0, 0);
            this.pn_client.Name = "pn_client";
            this.pn_client.Size = new System.Drawing.Size(734, 477);
            this.pn_client.TabIndex = 0;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISMDM_MSSQLSERVER.Properties.Resources.bgSharp41;
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.pn_client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdmdbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private mdmdbDataSet mdmdbDataSet;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private mdmdbDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.Panel pn_client;
    }
}
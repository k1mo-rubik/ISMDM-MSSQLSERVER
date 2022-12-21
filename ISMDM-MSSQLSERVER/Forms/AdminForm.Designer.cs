namespace ISMDM_MSSQLSERVER
{
    partial class AdminForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.saveBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewDogovor = new System.Windows.Forms.DataGridView();
            this.коддоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиедоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодклиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gusevaDataSet = new ISMDM_MSSQLSERVER.gusevaDataSet();
            this.действителендоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодсотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.договорыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewSotr = new System.Windows.Forms.DataGridView();
            this.кодсотрудникаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.коддолжностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.кодклиентаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridViewAcc = new System.Windows.Forms.DataGridView();
            this.кодаккаунтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.логинDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.парольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодсотрудникаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.кодгруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.группыпользователейBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.аккаунтыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridViewGrupUser = new System.Windows.Forms.DataGridView();
            this.кодгруппыDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиегруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.уровеньдоступаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridViewDogIRisk = new System.Windows.Forms.DataGridView();
            this.коддоговораDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.кодрискаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.страховыерискиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.договорыирискиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dataGridViewDolzh = new System.Windows.Forms.DataGridView();
            this.коддолжностиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиедолжностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.dataGridViewStrRisk = new System.Windows.Forms.DataGridView();
            this.кодстраховогорискаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниестраховогорискаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.коэффициентрасчетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.договорыTableAdapter = new ISMDM_MSSQLSERVER.gusevaDataSetTableAdapters.ДоговорыTableAdapter();
            this.сотрудникиTableAdapter = new ISMDM_MSSQLSERVER.gusevaDataSetTableAdapters.СотрудникиTableAdapter();
            this.клиентыTableAdapter = new ISMDM_MSSQLSERVER.gusevaDataSetTableAdapters.КлиентыTableAdapter();
            this.аккаунтыTableAdapter = new ISMDM_MSSQLSERVER.gusevaDataSetTableAdapters.АккаунтыTableAdapter();
            this.группы_пользователейTableAdapter = new ISMDM_MSSQLSERVER.gusevaDataSetTableAdapters.Группы_пользователейTableAdapter();
            this.договоры_и_рискиTableAdapter = new ISMDM_MSSQLSERVER.gusevaDataSetTableAdapters.Договоры_и_рискиTableAdapter();
            this.должностиTableAdapter = new ISMDM_MSSQLSERVER.gusevaDataSetTableAdapters.ДолжностиTableAdapter();
            this.страховые_рискиTableAdapter = new ISMDM_MSSQLSERVER.gusevaDataSetTableAdapters.Страховые_рискиTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogovor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gusevaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорыBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSotr)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыпользователейBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аккаунтыBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupUser)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogIRisk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.страховыерискиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорыирискиBindingSource)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDolzh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStrRisk)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(969, 70);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(963, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewDogovor);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(955, 423);
            this.tabPage1.TabIndex = 9;
            this.tabPage1.Text = "Договоры";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDogovor
            // 
            this.dataGridViewDogovor.AutoGenerateColumns = false;
            this.dataGridViewDogovor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDogovor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.коддоговораDataGridViewTextBoxColumn,
            this.наименованиедоговораDataGridViewTextBoxColumn,
            this.кодклиентаDataGridViewTextBoxColumn,
            this.действителендоDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.кодсотрудникаDataGridViewTextBoxColumn});
            this.dataGridViewDogovor.DataSource = this.договорыBindingSource;
            this.dataGridViewDogovor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDogovor.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDogovor.Name = "dataGridViewDogovor";
            this.dataGridViewDogovor.Size = new System.Drawing.Size(949, 417);
            this.dataGridViewDogovor.TabIndex = 1;
            this.dataGridViewDogovor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDogovor_CellContentClick);
            // 
            // коддоговораDataGridViewTextBoxColumn
            // 
            this.коддоговораDataGridViewTextBoxColumn.DataPropertyName = "Код_договора";
            this.коддоговораDataGridViewTextBoxColumn.HeaderText = "Код_договора";
            this.коддоговораDataGridViewTextBoxColumn.Name = "коддоговораDataGridViewTextBoxColumn";
            // 
            // наименованиедоговораDataGridViewTextBoxColumn
            // 
            this.наименованиедоговораDataGridViewTextBoxColumn.DataPropertyName = "Наименование_договора";
            this.наименованиедоговораDataGridViewTextBoxColumn.HeaderText = "Наименование_договора";
            this.наименованиедоговораDataGridViewTextBoxColumn.Name = "наименованиедоговораDataGridViewTextBoxColumn";
            // 
            // кодклиентаDataGridViewTextBoxColumn
            // 
            this.кодклиентаDataGridViewTextBoxColumn.DataPropertyName = "Код_клиента";
            this.кодклиентаDataGridViewTextBoxColumn.DataSource = this.клиентыBindingSource;
            this.кодклиентаDataGridViewTextBoxColumn.DisplayMember = "Фамилия";
            this.кодклиентаDataGridViewTextBoxColumn.HeaderText = "Код_клиента";
            this.кодклиентаDataGridViewTextBoxColumn.Name = "кодклиентаDataGridViewTextBoxColumn";
            this.кодклиентаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодклиентаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодклиентаDataGridViewTextBoxColumn.ValueMember = "Код_клиента";
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.gusevaDataSet;
            // 
            // gusevaDataSet
            // 
            this.gusevaDataSet.DataSetName = "gusevaDataSet";
            this.gusevaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // действителендоDataGridViewTextBoxColumn
            // 
            this.действителендоDataGridViewTextBoxColumn.DataPropertyName = "Действителен_до";
            this.действителендоDataGridViewTextBoxColumn.HeaderText = "Действителен_до";
            this.действителендоDataGridViewTextBoxColumn.Name = "действителендоDataGridViewTextBoxColumn";
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            // 
            // кодсотрудникаDataGridViewTextBoxColumn
            // 
            this.кодсотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Код_сотрудника";
            this.кодсотрудникаDataGridViewTextBoxColumn.DataSource = this.сотрудникиBindingSource;
            this.кодсотрудникаDataGridViewTextBoxColumn.DisplayMember = "Фамилия";
            this.кодсотрудникаDataGridViewTextBoxColumn.HeaderText = "Код_сотрудника";
            this.кодсотрудникаDataGridViewTextBoxColumn.Name = "кодсотрудникаDataGridViewTextBoxColumn";
            this.кодсотрудникаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодсотрудникаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодсотрудникаDataGridViewTextBoxColumn.ValueMember = "Код_сотрудника";
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.gusevaDataSet;
            // 
            // договорыBindingSource
            // 
            this.договорыBindingSource.DataMember = "Договоры";
            this.договорыBindingSource.DataSource = this.gusevaDataSet;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewSotr);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(955, 423);
            this.tabPage2.TabIndex = 10;
            this.tabPage2.Text = "Сотрудники";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSotr
            // 
            this.dataGridViewSotr.AutoGenerateColumns = false;
            this.dataGridViewSotr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSotr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодсотрудникаDataGridViewTextBoxColumn1,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.коддолжностиDataGridViewTextBoxColumn});
            this.dataGridViewSotr.DataSource = this.сотрудникиBindingSource;
            this.dataGridViewSotr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSotr.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSotr.Name = "dataGridViewSotr";
            this.dataGridViewSotr.Size = new System.Drawing.Size(949, 417);
            this.dataGridViewSotr.TabIndex = 1;
            // 
            // кодсотрудникаDataGridViewTextBoxColumn1
            // 
            this.кодсотрудникаDataGridViewTextBoxColumn1.DataPropertyName = "Код_сотрудника";
            this.кодсотрудникаDataGridViewTextBoxColumn1.HeaderText = "Код_сотрудника";
            this.кодсотрудникаDataGridViewTextBoxColumn1.Name = "кодсотрудникаDataGridViewTextBoxColumn1";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // коддолжностиDataGridViewTextBoxColumn
            // 
            this.коддолжностиDataGridViewTextBoxColumn.DataPropertyName = "Код_должности";
            this.коддолжностиDataGridViewTextBoxColumn.DataSource = this.сотрудникиBindingSource;
            this.коддолжностиDataGridViewTextBoxColumn.DisplayMember = "Фамилия";
            this.коддолжностиDataGridViewTextBoxColumn.HeaderText = "Код_должности";
            this.коддолжностиDataGridViewTextBoxColumn.Name = "коддолжностиDataGridViewTextBoxColumn";
            this.коддолжностиDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.коддолжностиDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.коддолжностиDataGridViewTextBoxColumn.ValueMember = "Код_сотрудника";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewClient);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(955, 423);
            this.tabPage3.TabIndex = 11;
            this.tabPage3.Text = "Клиенты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AutoGenerateColumns = false;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодклиентаDataGridViewTextBoxColumn1,
            this.фамилияDataGridViewTextBoxColumn1,
            this.имяDataGridViewTextBoxColumn1,
            this.отчествоDataGridViewTextBoxColumn1,
            this.телефонDataGridViewTextBoxColumn1});
            this.dataGridViewClient.DataSource = this.клиентыBindingSource;
            this.dataGridViewClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClient.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.Size = new System.Drawing.Size(949, 417);
            this.dataGridViewClient.TabIndex = 0;
            // 
            // кодклиентаDataGridViewTextBoxColumn1
            // 
            this.кодклиентаDataGridViewTextBoxColumn1.DataPropertyName = "Код_клиента";
            this.кодклиентаDataGridViewTextBoxColumn1.HeaderText = "Код_клиента";
            this.кодклиентаDataGridViewTextBoxColumn1.Name = "кодклиентаDataGridViewTextBoxColumn1";
            // 
            // фамилияDataGridViewTextBoxColumn1
            // 
            this.фамилияDataGridViewTextBoxColumn1.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.Name = "фамилияDataGridViewTextBoxColumn1";
            // 
            // имяDataGridViewTextBoxColumn1
            // 
            this.имяDataGridViewTextBoxColumn1.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn1.Name = "имяDataGridViewTextBoxColumn1";
            // 
            // отчествоDataGridViewTextBoxColumn1
            // 
            this.отчествоDataGridViewTextBoxColumn1.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn1.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn1.Name = "отчествоDataGridViewTextBoxColumn1";
            // 
            // телефонDataGridViewTextBoxColumn1
            // 
            this.телефонDataGridViewTextBoxColumn1.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn1.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn1.Name = "телефонDataGridViewTextBoxColumn1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridViewAcc);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(955, 423);
            this.tabPage4.TabIndex = 12;
            this.tabPage4.Text = "Аккаунты";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAcc
            // 
            this.dataGridViewAcc.AutoGenerateColumns = false;
            this.dataGridViewAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAcc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодаккаунтаDataGridViewTextBoxColumn,
            this.логинDataGridViewTextBoxColumn,
            this.парольDataGridViewTextBoxColumn,
            this.кодсотрудникаDataGridViewTextBoxColumn2,
            this.кодгруппыDataGridViewTextBoxColumn});
            this.dataGridViewAcc.DataSource = this.аккаунтыBindingSource;
            this.dataGridViewAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAcc.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewAcc.Name = "dataGridViewAcc";
            this.dataGridViewAcc.Size = new System.Drawing.Size(949, 417);
            this.dataGridViewAcc.TabIndex = 0;
            // 
            // кодаккаунтаDataGridViewTextBoxColumn
            // 
            this.кодаккаунтаDataGridViewTextBoxColumn.DataPropertyName = "Код_аккаунта";
            this.кодаккаунтаDataGridViewTextBoxColumn.HeaderText = "Код_аккаунта";
            this.кодаккаунтаDataGridViewTextBoxColumn.Name = "кодаккаунтаDataGridViewTextBoxColumn";
            // 
            // логинDataGridViewTextBoxColumn
            // 
            this.логинDataGridViewTextBoxColumn.DataPropertyName = "Логин";
            this.логинDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.логинDataGridViewTextBoxColumn.Name = "логинDataGridViewTextBoxColumn";
            // 
            // парольDataGridViewTextBoxColumn
            // 
            this.парольDataGridViewTextBoxColumn.DataPropertyName = "Пароль";
            this.парольDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.парольDataGridViewTextBoxColumn.Name = "парольDataGridViewTextBoxColumn";
            // 
            // кодсотрудникаDataGridViewTextBoxColumn2
            // 
            this.кодсотрудникаDataGridViewTextBoxColumn2.DataPropertyName = "Код_сотрудника";
            this.кодсотрудникаDataGridViewTextBoxColumn2.DataSource = this.сотрудникиBindingSource;
            this.кодсотрудникаDataGridViewTextBoxColumn2.DisplayMember = "Фамилия";
            this.кодсотрудникаDataGridViewTextBoxColumn2.HeaderText = "Код_сотрудника";
            this.кодсотрудникаDataGridViewTextBoxColumn2.Name = "кодсотрудникаDataGridViewTextBoxColumn2";
            this.кодсотрудникаDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодсотрудникаDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодсотрудникаDataGridViewTextBoxColumn2.ValueMember = "Код_сотрудника";
            // 
            // кодгруппыDataGridViewTextBoxColumn
            // 
            this.кодгруппыDataGridViewTextBoxColumn.DataPropertyName = "Код_группы";
            this.кодгруппыDataGridViewTextBoxColumn.DataSource = this.группыпользователейBindingSource;
            this.кодгруппыDataGridViewTextBoxColumn.DisplayMember = "Наименование_группы";
            this.кодгруппыDataGridViewTextBoxColumn.HeaderText = "Код_группы";
            this.кодгруппыDataGridViewTextBoxColumn.Name = "кодгруппыDataGridViewTextBoxColumn";
            this.кодгруппыDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодгруппыDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодгруппыDataGridViewTextBoxColumn.ValueMember = "Код_группы";
            // 
            // группыпользователейBindingSource
            // 
            this.группыпользователейBindingSource.DataMember = "Группы_пользователей";
            this.группыпользователейBindingSource.DataSource = this.gusevaDataSet;
            // 
            // аккаунтыBindingSource
            // 
            this.аккаунтыBindingSource.DataMember = "Аккаунты";
            this.аккаунтыBindingSource.DataSource = this.gusevaDataSet;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridViewGrupUser);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(955, 423);
            this.tabPage5.TabIndex = 13;
            this.tabPage5.Text = "Группы_пользователей";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGrupUser
            // 
            this.dataGridViewGrupUser.AutoGenerateColumns = false;
            this.dataGridViewGrupUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrupUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодгруппыDataGridViewTextBoxColumn1,
            this.наименованиегруппыDataGridViewTextBoxColumn,
            this.уровеньдоступаDataGridViewTextBoxColumn});
            this.dataGridViewGrupUser.DataSource = this.группыпользователейBindingSource;
            this.dataGridViewGrupUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGrupUser.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewGrupUser.Name = "dataGridViewGrupUser";
            this.dataGridViewGrupUser.Size = new System.Drawing.Size(949, 417);
            this.dataGridViewGrupUser.TabIndex = 0;
            // 
            // кодгруппыDataGridViewTextBoxColumn1
            // 
            this.кодгруппыDataGridViewTextBoxColumn1.DataPropertyName = "Код_группы";
            this.кодгруппыDataGridViewTextBoxColumn1.HeaderText = "Код_группы";
            this.кодгруппыDataGridViewTextBoxColumn1.Name = "кодгруппыDataGridViewTextBoxColumn1";
            // 
            // наименованиегруппыDataGridViewTextBoxColumn
            // 
            this.наименованиегруппыDataGridViewTextBoxColumn.DataPropertyName = "Наименование_группы";
            this.наименованиегруппыDataGridViewTextBoxColumn.HeaderText = "Наименование_группы";
            this.наименованиегруппыDataGridViewTextBoxColumn.Name = "наименованиегруппыDataGridViewTextBoxColumn";
            // 
            // уровеньдоступаDataGridViewTextBoxColumn
            // 
            this.уровеньдоступаDataGridViewTextBoxColumn.DataPropertyName = "Уровень_доступа";
            this.уровеньдоступаDataGridViewTextBoxColumn.HeaderText = "Уровень_доступа";
            this.уровеньдоступаDataGridViewTextBoxColumn.Name = "уровеньдоступаDataGridViewTextBoxColumn";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridViewDogIRisk);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(955, 423);
            this.tabPage6.TabIndex = 14;
            this.tabPage6.Text = "Договоры_и_риски";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDogIRisk
            // 
            this.dataGridViewDogIRisk.AutoGenerateColumns = false;
            this.dataGridViewDogIRisk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDogIRisk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.коддоговораDataGridViewTextBoxColumn1,
            this.кодрискаDataGridViewTextBoxColumn,
            this.кодDataGridViewTextBoxColumn});
            this.dataGridViewDogIRisk.DataSource = this.договорыирискиBindingSource;
            this.dataGridViewDogIRisk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDogIRisk.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDogIRisk.Name = "dataGridViewDogIRisk";
            this.dataGridViewDogIRisk.Size = new System.Drawing.Size(949, 417);
            this.dataGridViewDogIRisk.TabIndex = 0;
            // 
            // коддоговораDataGridViewTextBoxColumn1
            // 
            this.коддоговораDataGridViewTextBoxColumn1.DataPropertyName = "Код_договора";
            this.коддоговораDataGridViewTextBoxColumn1.DataSource = this.договорыBindingSource;
            this.коддоговораDataGridViewTextBoxColumn1.DisplayMember = "Наименование_договора";
            this.коддоговораDataGridViewTextBoxColumn1.HeaderText = "Код_договора";
            this.коддоговораDataGridViewTextBoxColumn1.Name = "коддоговораDataGridViewTextBoxColumn1";
            this.коддоговораDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.коддоговораDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.коддоговораDataGridViewTextBoxColumn1.ValueMember = "Код_договора";
            // 
            // кодрискаDataGridViewTextBoxColumn
            // 
            this.кодрискаDataGridViewTextBoxColumn.DataPropertyName = "Код_риска";
            this.кодрискаDataGridViewTextBoxColumn.DataSource = this.страховыерискиBindingSource;
            this.кодрискаDataGridViewTextBoxColumn.DisplayMember = "Описание_страхового_риска";
            this.кодрискаDataGridViewTextBoxColumn.HeaderText = "Код_риска";
            this.кодрискаDataGridViewTextBoxColumn.Name = "кодрискаDataGridViewTextBoxColumn";
            this.кодрискаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодрискаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодрискаDataGridViewTextBoxColumn.ValueMember = "Код_страхового_риска";
            // 
            // страховыерискиBindingSource
            // 
            this.страховыерискиBindingSource.DataMember = "Страховые_риски";
            this.страховыерискиBindingSource.DataSource = this.gusevaDataSet;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // договорыирискиBindingSource
            // 
            this.договорыирискиBindingSource.DataMember = "Договоры_и_риски";
            this.договорыирискиBindingSource.DataSource = this.gusevaDataSet;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dataGridViewDolzh);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(955, 423);
            this.tabPage7.TabIndex = 15;
            this.tabPage7.Text = "Должности";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDolzh
            // 
            this.dataGridViewDolzh.AutoGenerateColumns = false;
            this.dataGridViewDolzh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDolzh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.коддолжностиDataGridViewTextBoxColumn1,
            this.наименованиедолжностиDataGridViewTextBoxColumn});
            this.dataGridViewDolzh.DataSource = this.должностиBindingSource;
            this.dataGridViewDolzh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDolzh.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDolzh.Name = "dataGridViewDolzh";
            this.dataGridViewDolzh.Size = new System.Drawing.Size(949, 417);
            this.dataGridViewDolzh.TabIndex = 0;
            // 
            // коддолжностиDataGridViewTextBoxColumn1
            // 
            this.коддолжностиDataGridViewTextBoxColumn1.DataPropertyName = "Код_должности";
            this.коддолжностиDataGridViewTextBoxColumn1.HeaderText = "Код_должности";
            this.коддолжностиDataGridViewTextBoxColumn1.Name = "коддолжностиDataGridViewTextBoxColumn1";
            // 
            // наименованиедолжностиDataGridViewTextBoxColumn
            // 
            this.наименованиедолжностиDataGridViewTextBoxColumn.DataPropertyName = "Наименование_должности";
            this.наименованиедолжностиDataGridViewTextBoxColumn.HeaderText = "Наименование_должности";
            this.наименованиедолжностиDataGridViewTextBoxColumn.Name = "наименованиедолжностиDataGridViewTextBoxColumn";
            // 
            // должностиBindingSource
            // 
            this.должностиBindingSource.DataMember = "Должности";
            this.должностиBindingSource.DataSource = this.gusevaDataSet;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.dataGridViewStrRisk);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(955, 423);
            this.tabPage8.TabIndex = 16;
            this.tabPage8.Text = "Страховые_риски";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStrRisk
            // 
            this.dataGridViewStrRisk.AutoGenerateColumns = false;
            this.dataGridViewStrRisk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStrRisk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодстраховогорискаDataGridViewTextBoxColumn,
            this.описаниестраховогорискаDataGridViewTextBoxColumn,
            this.коэффициентрасчетаDataGridViewTextBoxColumn});
            this.dataGridViewStrRisk.DataSource = this.страховыерискиBindingSource;
            this.dataGridViewStrRisk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStrRisk.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewStrRisk.Name = "dataGridViewStrRisk";
            this.dataGridViewStrRisk.Size = new System.Drawing.Size(949, 417);
            this.dataGridViewStrRisk.TabIndex = 0;
            // 
            // кодстраховогорискаDataGridViewTextBoxColumn
            // 
            this.кодстраховогорискаDataGridViewTextBoxColumn.DataPropertyName = "Код_страхового_риска";
            this.кодстраховогорискаDataGridViewTextBoxColumn.HeaderText = "Код_страхового_риска";
            this.кодстраховогорискаDataGridViewTextBoxColumn.Name = "кодстраховогорискаDataGridViewTextBoxColumn";
            // 
            // описаниестраховогорискаDataGridViewTextBoxColumn
            // 
            this.описаниестраховогорискаDataGridViewTextBoxColumn.DataPropertyName = "Описание_страхового_риска";
            this.описаниестраховогорискаDataGridViewTextBoxColumn.HeaderText = "Описание_страхового_риска";
            this.описаниестраховогорискаDataGridViewTextBoxColumn.Name = "описаниестраховогорискаDataGridViewTextBoxColumn";
            // 
            // коэффициентрасчетаDataGridViewTextBoxColumn
            // 
            this.коэффициентрасчетаDataGridViewTextBoxColumn.DataPropertyName = "Коэффициент_расчета";
            this.коэффициентрасчетаDataGridViewTextBoxColumn.HeaderText = "Коэффициент_расчета";
            this.коэффициентрасчетаDataGridViewTextBoxColumn.Name = "коэффициентрасчетаDataGridViewTextBoxColumn";
            // 
            // договорыTableAdapter
            // 
            this.договорыTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // аккаунтыTableAdapter
            // 
            this.аккаунтыTableAdapter.ClearBeforeFill = true;
            // 
            // группы_пользователейTableAdapter
            // 
            this.группы_пользователейTableAdapter.ClearBeforeFill = true;
            // 
            // договоры_и_рискиTableAdapter
            // 
            this.договоры_и_рискиTableAdapter.ClearBeforeFill = true;
            // 
            // должностиTableAdapter
            // 
            this.должностиTableAdapter.ClearBeforeFill = true;
            // 
            // страховые_рискиTableAdapter
            // 
            this.страховые_рискиTableAdapter.ClearBeforeFill = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 450);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.Shown += new System.EventHandler(this.AdminForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogovor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gusevaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорыBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSotr)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыпользователейBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аккаунтыBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupUser)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogIRisk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.страховыерискиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорыирискиBindingSource)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDolzh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStrRisk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridViewAcc;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        public System.Windows.Forms.DataGridView dataGridViewGrupUser;
        public System.Windows.Forms.DataGridView dataGridViewDogIRisk;
        public System.Windows.Forms.DataGridView dataGridViewDolzh;
        public System.Windows.Forms.DataGridView dataGridViewStrRisk;
        public System.Windows.Forms.DataGridView dataGridViewDogovor;
        public System.Windows.Forms.DataGridView dataGridViewSotr;
        public gusevaDataSet gusevaDataSet;
        private System.Windows.Forms.BindingSource договорыBindingSource;
        public gusevaDataSetTableAdapters.ДоговорыTableAdapter договорыTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        public gusevaDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        public gusevaDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодклиентаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource аккаунтыBindingSource;
        public gusevaDataSetTableAdapters.АккаунтыTableAdapter аккаунтыTableAdapter;
        private System.Windows.Forms.BindingSource группыпользователейBindingSource;
        public gusevaDataSetTableAdapters.Группы_пользователейTableAdapter группы_пользователейTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодгруппыDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиегруппыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn уровеньдоступаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource договорыирискиBindingSource;
        public gusevaDataSetTableAdapters.Договоры_и_рискиTableAdapter договоры_и_рискиTableAdapter;
        private System.Windows.Forms.BindingSource должностиBindingSource;
        public gusevaDataSetTableAdapters.ДолжностиTableAdapter должностиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn коддолжностиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиедолжностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource страховыерискиBindingSource;
        public gusevaDataSetTableAdapters.Страховые_рискиTableAdapter страховые_рискиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn коддоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиедоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодклиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn действителендоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодсотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодсотрудникаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn коддолжностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодаккаунтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn логинDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодсотрудникаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодгруппыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn коддоговораDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодрискаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодстраховогорискаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниестраховогорискаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn коэффициентрасчетаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridViewClient;
    }
}


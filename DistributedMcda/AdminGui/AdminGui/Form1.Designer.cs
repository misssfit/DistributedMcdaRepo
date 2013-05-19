namespace AdminGui
{
    partial class AdministrationConsole
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
            this.connectionToServerFailedLabel = new System.Windows.Forms.Label();
            this.reconnectToServerButton = new System.Windows.Forms.Button();
            this.configurationPanel = new System.Windows.Forms.Panel();
            this.configureActiveTasksCountButton = new System.Windows.Forms.Button();
            this.configureActiveTasksCountTextBox = new System.Windows.Forms.TextBox();
            this.configureActiveTasksCountLabel = new System.Windows.Forms.Label();
            this.sendCalculatedTasksTimeoutButton = new System.Windows.Forms.Button();
            this.calculatedTasksTimeoutUnitLabel = new System.Windows.Forms.Label();
            this.calculatedTasksTimeoutTextBox = new System.Windows.Forms.TextBox();
            this.calculatedTasksTimeoutLabel = new System.Windows.Forms.Label();
            this.sendTasksCalculationTimeoutButton = new System.Windows.Forms.Button();
            this.tasksCalculationTimeoutUnitLabel = new System.Windows.Forms.Label();
            this.tasksCalculationTimeoutTextBox = new System.Windows.Forms.TextBox();
            this.tasksCalculationTimeoutLabel = new System.Windows.Forms.Label();
            this.queueTasksDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.methodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculationStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queueTasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updateTasksDataButton = new System.Windows.Forms.Button();
            this.activeTasksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.queueTasksPanel = new System.Windows.Forms.Panel();
            this.removeQueueTaskButton = new System.Windows.Forms.Button();
            this.prioritizeTaskButton = new System.Windows.Forms.Button();
            this.queueTasksLabel = new System.Windows.Forms.Label();
            this.activeTasksPanel = new System.Windows.Forms.Panel();
            this.removeActiveTaskButton = new System.Windows.Forms.Button();
            this.activeTasksLabel = new System.Windows.Forms.Label();
            this.bwSendTasksCalculationTimeout = new System.ComponentModel.BackgroundWorker();
            this.bwSendCalculatedTasksTimeout = new System.ComponentModel.BackgroundWorker();
            this.bwPrioritizeTask = new System.ComponentModel.BackgroundWorker();
            this.bwUpdateTasksView = new System.ComponentModel.BackgroundWorker();
            this.bwDeleteTask = new System.ComponentModel.BackgroundWorker();
            this.UpdateTasksTimer = new System.Windows.Forms.Timer(this.components);
            this.timerIntervalPanel = new System.Windows.Forms.Panel();
            this.timerIntervalButton = new System.Windows.Forms.Button();
            this.timerIntervalUnitLabel = new System.Windows.Forms.Label();
            this.timerIntervalTextBox = new System.Windows.Forms.TextBox();
            this.timerIntervalLabel = new System.Windows.Forms.Label();
            this.inactiveTasksPanel = new System.Windows.Forms.Panel();
            this.removeInactiveTaskButton = new System.Windows.Forms.Button();
            this.inactiveTaskLabel = new System.Windows.Forms.Label();
            this.inactiveTasksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bwConfigureActiveTasksCount = new System.ComponentModel.BackgroundWorker();
            this.endpointPanel = new System.Windows.Forms.Panel();
            this.endpointLabel = new System.Windows.Forms.Label();
            this.endpointTextBox = new System.Windows.Forms.TextBox();
            this.configurationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queueTasksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueTasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeTasksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            this.queueTasksPanel.SuspendLayout();
            this.activeTasksPanel.SuspendLayout();
            this.timerIntervalPanel.SuspendLayout();
            this.inactiveTasksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inactiveTasksDataGridView)).BeginInit();
            this.endpointPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionToServerFailedLabel
            // 
            this.connectionToServerFailedLabel.AutoSize = true;
            this.connectionToServerFailedLabel.ForeColor = System.Drawing.Color.Red;
            this.connectionToServerFailedLabel.Location = new System.Drawing.Point(3, 53);
            this.connectionToServerFailedLabel.Name = "connectionToServerFailedLabel";
            this.connectionToServerFailedLabel.Size = new System.Drawing.Size(162, 13);
            this.connectionToServerFailedLabel.TabIndex = 0;
            this.connectionToServerFailedLabel.Text = "Nie jesteś połączony z serwerem";
            this.connectionToServerFailedLabel.Visible = false;
            // 
            // reconnectToServerButton
            // 
            this.reconnectToServerButton.Location = new System.Drawing.Point(119, 3);
            this.reconnectToServerButton.Name = "reconnectToServerButton";
            this.reconnectToServerButton.Size = new System.Drawing.Size(105, 23);
            this.reconnectToServerButton.TabIndex = 1;
            this.reconnectToServerButton.Text = "połącz z serwerem";
            this.reconnectToServerButton.UseVisualStyleBackColor = true;
            this.reconnectToServerButton.Click += new System.EventHandler(this.reconnectToServerButton_Click);
            // 
            // configurationPanel
            // 
            this.configurationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.configurationPanel.Controls.Add(this.configureActiveTasksCountButton);
            this.configurationPanel.Controls.Add(this.configureActiveTasksCountTextBox);
            this.configurationPanel.Controls.Add(this.configureActiveTasksCountLabel);
            this.configurationPanel.Controls.Add(this.sendCalculatedTasksTimeoutButton);
            this.configurationPanel.Controls.Add(this.calculatedTasksTimeoutUnitLabel);
            this.configurationPanel.Controls.Add(this.calculatedTasksTimeoutTextBox);
            this.configurationPanel.Controls.Add(this.calculatedTasksTimeoutLabel);
            this.configurationPanel.Controls.Add(this.sendTasksCalculationTimeoutButton);
            this.configurationPanel.Controls.Add(this.tasksCalculationTimeoutUnitLabel);
            this.configurationPanel.Controls.Add(this.tasksCalculationTimeoutTextBox);
            this.configurationPanel.Controls.Add(this.tasksCalculationTimeoutLabel);
            this.configurationPanel.Location = new System.Drawing.Point(4, 89);
            this.configurationPanel.Name = "configurationPanel";
            this.configurationPanel.Size = new System.Drawing.Size(229, 155);
            this.configurationPanel.TabIndex = 2;
            this.configurationPanel.Visible = false;
            // 
            // configureActiveTasksCountButton
            // 
            this.configureActiveTasksCountButton.Location = new System.Drawing.Point(152, 122);
            this.configureActiveTasksCountButton.Name = "configureActiveTasksCountButton";
            this.configureActiveTasksCountButton.Size = new System.Drawing.Size(72, 23);
            this.configureActiveTasksCountButton.TabIndex = 10;
            this.configureActiveTasksCountButton.Text = "wyślij";
            this.configureActiveTasksCountButton.UseVisualStyleBackColor = true;
            this.configureActiveTasksCountButton.Click += new System.EventHandler(this.configureActiveTasksCountButton_Click);
            // 
            // configureActiveTasksCountTextBox
            // 
            this.configureActiveTasksCountTextBox.Location = new System.Drawing.Point(6, 124);
            this.configureActiveTasksCountTextBox.Name = "configureActiveTasksCountTextBox";
            this.configureActiveTasksCountTextBox.Size = new System.Drawing.Size(124, 20);
            this.configureActiveTasksCountTextBox.TabIndex = 9;
            // 
            // configureActiveTasksCountLabel
            // 
            this.configureActiveTasksCountLabel.AutoSize = true;
            this.configureActiveTasksCountLabel.Location = new System.Drawing.Point(3, 108);
            this.configureActiveTasksCountLabel.Name = "configureActiveTasksCountLabel";
            this.configureActiveTasksCountLabel.Size = new System.Drawing.Size(147, 13);
            this.configureActiveTasksCountLabel.TabIndex = 8;
            this.configureActiveTasksCountLabel.Text = "Ilośc aktywnych zadań naraz:";
            // 
            // sendCalculatedTasksTimeoutButton
            // 
            this.sendCalculatedTasksTimeoutButton.Location = new System.Drawing.Point(152, 72);
            this.sendCalculatedTasksTimeoutButton.Name = "sendCalculatedTasksTimeoutButton";
            this.sendCalculatedTasksTimeoutButton.Size = new System.Drawing.Size(72, 23);
            this.sendCalculatedTasksTimeoutButton.TabIndex = 7;
            this.sendCalculatedTasksTimeoutButton.Text = "wyślij";
            this.sendCalculatedTasksTimeoutButton.UseVisualStyleBackColor = true;
            this.sendCalculatedTasksTimeoutButton.Click += new System.EventHandler(this.sendCalculatedTasksTimeoutButton_Click);
            // 
            // calculatedTasksTimeoutUnitLabel
            // 
            this.calculatedTasksTimeoutUnitLabel.AutoSize = true;
            this.calculatedTasksTimeoutUnitLabel.Location = new System.Drawing.Point(129, 77);
            this.calculatedTasksTimeoutUnitLabel.Name = "calculatedTasksTimeoutUnitLabel";
            this.calculatedTasksTimeoutUnitLabel.Size = new System.Drawing.Size(18, 13);
            this.calculatedTasksTimeoutUnitLabel.TabIndex = 6;
            this.calculatedTasksTimeoutUnitLabel.Text = "[s]";
            // 
            // calculatedTasksTimeoutTextBox
            // 
            this.calculatedTasksTimeoutTextBox.Location = new System.Drawing.Point(6, 74);
            this.calculatedTasksTimeoutTextBox.Name = "calculatedTasksTimeoutTextBox";
            this.calculatedTasksTimeoutTextBox.Size = new System.Drawing.Size(125, 20);
            this.calculatedTasksTimeoutTextBox.TabIndex = 5;
            // 
            // calculatedTasksTimeoutLabel
            // 
            this.calculatedTasksTimeoutLabel.AutoSize = true;
            this.calculatedTasksTimeoutLabel.Location = new System.Drawing.Point(3, 58);
            this.calculatedTasksTimeoutLabel.Name = "calculatedTasksTimeoutLabel";
            this.calculatedTasksTimeoutLabel.Size = new System.Drawing.Size(208, 13);
            this.calculatedTasksTimeoutLabel.TabIndex = 4;
            this.calculatedTasksTimeoutLabel.Text = "Timeout dla wyników przeliczonych zadań:";
            // 
            // sendTasksCalculationTimeoutButton
            // 
            this.sendTasksCalculationTimeoutButton.Location = new System.Drawing.Point(152, 23);
            this.sendTasksCalculationTimeoutButton.Name = "sendTasksCalculationTimeoutButton";
            this.sendTasksCalculationTimeoutButton.Size = new System.Drawing.Size(72, 23);
            this.sendTasksCalculationTimeoutButton.TabIndex = 3;
            this.sendTasksCalculationTimeoutButton.Text = "wyślij";
            this.sendTasksCalculationTimeoutButton.UseVisualStyleBackColor = true;
            this.sendTasksCalculationTimeoutButton.Click += new System.EventHandler(this.sendTasksCalculationTimeoutButton_Click);
            // 
            // tasksCalculationTimeoutUnitLabel
            // 
            this.tasksCalculationTimeoutUnitLabel.AutoSize = true;
            this.tasksCalculationTimeoutUnitLabel.Location = new System.Drawing.Point(129, 28);
            this.tasksCalculationTimeoutUnitLabel.Name = "tasksCalculationTimeoutUnitLabel";
            this.tasksCalculationTimeoutUnitLabel.Size = new System.Drawing.Size(18, 13);
            this.tasksCalculationTimeoutUnitLabel.TabIndex = 2;
            this.tasksCalculationTimeoutUnitLabel.Text = "[s]";
            // 
            // tasksCalculationTimeoutTextBox
            // 
            this.tasksCalculationTimeoutTextBox.Location = new System.Drawing.Point(6, 25);
            this.tasksCalculationTimeoutTextBox.Name = "tasksCalculationTimeoutTextBox";
            this.tasksCalculationTimeoutTextBox.Size = new System.Drawing.Size(125, 20);
            this.tasksCalculationTimeoutTextBox.TabIndex = 1;
            // 
            // tasksCalculationTimeoutLabel
            // 
            this.tasksCalculationTimeoutLabel.AutoSize = true;
            this.tasksCalculationTimeoutLabel.Location = new System.Drawing.Point(3, 9);
            this.tasksCalculationTimeoutLabel.Name = "tasksCalculationTimeoutLabel";
            this.tasksCalculationTimeoutLabel.Size = new System.Drawing.Size(188, 13);
            this.tasksCalculationTimeoutLabel.TabIndex = 0;
            this.tasksCalculationTimeoutLabel.Text = "Timeout dla przeliczających się zadań:";
            // 
            // queueTasksDataGridView
            // 
            this.queueTasksDataGridView.AllowUserToAddRows = false;
            this.queueTasksDataGridView.AllowUserToDeleteRows = false;
            this.queueTasksDataGridView.AutoGenerateColumns = false;
            this.queueTasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queueTasksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.methodNameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.creationTimeDataGridViewTextBoxColumn,
            this.calculationStartTimeDataGridViewTextBoxColumn});
            this.queueTasksDataGridView.DataSource = this.queueTasksBindingSource;
            this.queueTasksDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.queueTasksDataGridView.Location = new System.Drawing.Point(3, 34);
            this.queueTasksDataGridView.MultiSelect = false;
            this.queueTasksDataGridView.Name = "queueTasksDataGridView";
            this.queueTasksDataGridView.ReadOnly = true;
            this.queueTasksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.queueTasksDataGridView.Size = new System.Drawing.Size(623, 145);
            this.queueTasksDataGridView.TabIndex = 8;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 200;
            // 
            // methodNameDataGridViewTextBoxColumn
            // 
            this.methodNameDataGridViewTextBoxColumn.DataPropertyName = "MethodName";
            this.methodNameDataGridViewTextBoxColumn.HeaderText = "Metoda";
            this.methodNameDataGridViewTextBoxColumn.Name = "methodNameDataGridViewTextBoxColumn";
            this.methodNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 80;
            // 
            // creationTimeDataGridViewTextBoxColumn
            // 
            this.creationTimeDataGridViewTextBoxColumn.DataPropertyName = "CreationTime";
            this.creationTimeDataGridViewTextBoxColumn.HeaderText = "Utworzono";
            this.creationTimeDataGridViewTextBoxColumn.Name = "creationTimeDataGridViewTextBoxColumn";
            this.creationTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calculationStartTimeDataGridViewTextBoxColumn
            // 
            this.calculationStartTimeDataGridViewTextBoxColumn.DataPropertyName = "CalculationStartTime";
            this.calculationStartTimeDataGridViewTextBoxColumn.HeaderText = "Rozpoczęto";
            this.calculationStartTimeDataGridViewTextBoxColumn.Name = "calculationStartTimeDataGridViewTextBoxColumn";
            this.calculationStartTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // queueTasksBindingSource
            // 
            this.queueTasksBindingSource.DataSource = typeof(AdminGui.AdministrationServiceReference.TaskInfo);
            // 
            // updateTasksDataButton
            // 
            this.updateTasksDataButton.Location = new System.Drawing.Point(6, 52);
            this.updateTasksDataButton.Name = "updateTasksDataButton";
            this.updateTasksDataButton.Size = new System.Drawing.Size(103, 26);
            this.updateTasksDataButton.TabIndex = 9;
            this.updateTasksDataButton.Text = "uaktualnij zadania";
            this.updateTasksDataButton.UseVisualStyleBackColor = true;
            this.updateTasksDataButton.Click += new System.EventHandler(this.updateTasksDataButton_Click);
            // 
            // activeTasksDataGridView
            // 
            this.activeTasksDataGridView.AllowUserToAddRows = false;
            this.activeTasksDataGridView.AllowUserToDeleteRows = false;
            this.activeTasksDataGridView.AutoGenerateColumns = false;
            this.activeTasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activeTasksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.activeTasksDataGridView.DataSource = this.tasksBindingSource;
            this.activeTasksDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.activeTasksDataGridView.Location = new System.Drawing.Point(3, 34);
            this.activeTasksDataGridView.MultiSelect = false;
            this.activeTasksDataGridView.Name = "activeTasksDataGridView";
            this.activeTasksDataGridView.ReadOnly = true;
            this.activeTasksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activeTasksDataGridView.Size = new System.Drawing.Size(623, 145);
            this.activeTasksDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MethodName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Metoda";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn3.HeaderText = "Status";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CreationTime";
            this.dataGridViewTextBoxColumn4.HeaderText = "Utworzono";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CalculationStartTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "Rozpoczęto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataSource = typeof(AdminGui.AdministrationServiceReference.TaskInfo);
            // 
            // queueTasksPanel
            // 
            this.queueTasksPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queueTasksPanel.Controls.Add(this.removeQueueTaskButton);
            this.queueTasksPanel.Controls.Add(this.prioritizeTaskButton);
            this.queueTasksPanel.Controls.Add(this.queueTasksLabel);
            this.queueTasksPanel.Controls.Add(this.queueTasksDataGridView);
            this.queueTasksPanel.Location = new System.Drawing.Point(239, 4);
            this.queueTasksPanel.Name = "queueTasksPanel";
            this.queueTasksPanel.Size = new System.Drawing.Size(631, 189);
            this.queueTasksPanel.TabIndex = 11;
            // 
            // removeQueueTaskButton
            // 
            this.removeQueueTaskButton.Location = new System.Drawing.Point(302, 2);
            this.removeQueueTaskButton.Name = "removeQueueTaskButton";
            this.removeQueueTaskButton.Size = new System.Drawing.Size(100, 26);
            this.removeQueueTaskButton.TabIndex = 14;
            this.removeQueueTaskButton.Text = "usuń zadanie";
            this.removeQueueTaskButton.UseVisualStyleBackColor = true;
            this.removeQueueTaskButton.Click += new System.EventHandler(this.removeQueueTaskButton_Click);
            // 
            // prioritizeTaskButton
            // 
            this.prioritizeTaskButton.Location = new System.Drawing.Point(103, 2);
            this.prioritizeTaskButton.Name = "prioritizeTaskButton";
            this.prioritizeTaskButton.Size = new System.Drawing.Size(193, 26);
            this.prioritizeTaskButton.TabIndex = 13;
            this.prioritizeTaskButton.Text = "przesuń zadanie na początek kolejki";
            this.prioritizeTaskButton.UseVisualStyleBackColor = true;
            this.prioritizeTaskButton.Click += new System.EventHandler(this.prioritizeTaskButton_Click);
            // 
            // queueTasksLabel
            // 
            this.queueTasksLabel.AutoSize = true;
            this.queueTasksLabel.Location = new System.Drawing.Point(3, 9);
            this.queueTasksLabel.Name = "queueTasksLabel";
            this.queueTasksLabel.Size = new System.Drawing.Size(94, 13);
            this.queueTasksLabel.TabIndex = 9;
            this.queueTasksLabel.Text = "Zadania w kolejce";
            // 
            // activeTasksPanel
            // 
            this.activeTasksPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activeTasksPanel.Controls.Add(this.removeActiveTaskButton);
            this.activeTasksPanel.Controls.Add(this.activeTasksLabel);
            this.activeTasksPanel.Controls.Add(this.activeTasksDataGridView);
            this.activeTasksPanel.Location = new System.Drawing.Point(239, 199);
            this.activeTasksPanel.Name = "activeTasksPanel";
            this.activeTasksPanel.Size = new System.Drawing.Size(631, 186);
            this.activeTasksPanel.TabIndex = 12;
            // 
            // removeActiveTaskButton
            // 
            this.removeActiveTaskButton.Location = new System.Drawing.Point(103, 2);
            this.removeActiveTaskButton.Name = "removeActiveTaskButton";
            this.removeActiveTaskButton.Size = new System.Drawing.Size(100, 26);
            this.removeActiveTaskButton.TabIndex = 15;
            this.removeActiveTaskButton.Text = "usuń zadanie";
            this.removeActiveTaskButton.UseVisualStyleBackColor = true;
            this.removeActiveTaskButton.Click += new System.EventHandler(this.removeTaskButton_Click);
            // 
            // activeTasksLabel
            // 
            this.activeTasksLabel.AutoSize = true;
            this.activeTasksLabel.Location = new System.Drawing.Point(3, 9);
            this.activeTasksLabel.Name = "activeTasksLabel";
            this.activeTasksLabel.Size = new System.Drawing.Size(89, 13);
            this.activeTasksLabel.TabIndex = 11;
            this.activeTasksLabel.Text = "Zadania aktywne";
            // 
            // UpdateTasksTimer
            // 
            this.UpdateTasksTimer.Interval = 10000;
            this.UpdateTasksTimer.Tick += new System.EventHandler(this.UpdateTasksTimer_Tick);
            // 
            // timerIntervalPanel
            // 
            this.timerIntervalPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timerIntervalPanel.Controls.Add(this.timerIntervalButton);
            this.timerIntervalPanel.Controls.Add(this.timerIntervalUnitLabel);
            this.timerIntervalPanel.Controls.Add(this.timerIntervalTextBox);
            this.timerIntervalPanel.Controls.Add(this.timerIntervalLabel);
            this.timerIntervalPanel.Controls.Add(this.updateTasksDataButton);
            this.timerIntervalPanel.Location = new System.Drawing.Point(4, 250);
            this.timerIntervalPanel.Name = "timerIntervalPanel";
            this.timerIntervalPanel.Size = new System.Drawing.Size(229, 91);
            this.timerIntervalPanel.TabIndex = 13;
            // 
            // timerIntervalButton
            // 
            this.timerIntervalButton.Location = new System.Drawing.Point(152, 24);
            this.timerIntervalButton.Name = "timerIntervalButton";
            this.timerIntervalButton.Size = new System.Drawing.Size(72, 22);
            this.timerIntervalButton.TabIndex = 13;
            this.timerIntervalButton.Text = "ustaw";
            this.timerIntervalButton.UseVisualStyleBackColor = true;
            this.timerIntervalButton.Click += new System.EventHandler(this.timerInterval_Click);
            // 
            // timerIntervalUnitLabel
            // 
            this.timerIntervalUnitLabel.AutoSize = true;
            this.timerIntervalUnitLabel.Location = new System.Drawing.Point(129, 29);
            this.timerIntervalUnitLabel.Name = "timerIntervalUnitLabel";
            this.timerIntervalUnitLabel.Size = new System.Drawing.Size(26, 13);
            this.timerIntervalUnitLabel.TabIndex = 12;
            this.timerIntervalUnitLabel.Text = "[ms]";
            // 
            // timerIntervalTextBox
            // 
            this.timerIntervalTextBox.Location = new System.Drawing.Point(6, 26);
            this.timerIntervalTextBox.Name = "timerIntervalTextBox";
            this.timerIntervalTextBox.Size = new System.Drawing.Size(125, 20);
            this.timerIntervalTextBox.TabIndex = 11;
            // 
            // timerIntervalLabel
            // 
            this.timerIntervalLabel.AutoSize = true;
            this.timerIntervalLabel.Location = new System.Drawing.Point(3, 10);
            this.timerIntervalLabel.Name = "timerIntervalLabel";
            this.timerIntervalLabel.Size = new System.Drawing.Size(137, 13);
            this.timerIntervalLabel.TabIndex = 10;
            this.timerIntervalLabel.Text = "odświeżanie widoku zadań:";
            // 
            // inactiveTasksPanel
            // 
            this.inactiveTasksPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inactiveTasksPanel.Controls.Add(this.removeInactiveTaskButton);
            this.inactiveTasksPanel.Controls.Add(this.inactiveTaskLabel);
            this.inactiveTasksPanel.Controls.Add(this.inactiveTasksDataGridView);
            this.inactiveTasksPanel.Location = new System.Drawing.Point(239, 391);
            this.inactiveTasksPanel.Name = "inactiveTasksPanel";
            this.inactiveTasksPanel.Size = new System.Drawing.Size(631, 186);
            this.inactiveTasksPanel.TabIndex = 14;
            // 
            // removeInactiveTaskButton
            // 
            this.removeInactiveTaskButton.Location = new System.Drawing.Point(103, 2);
            this.removeInactiveTaskButton.Name = "removeInactiveTaskButton";
            this.removeInactiveTaskButton.Size = new System.Drawing.Size(100, 26);
            this.removeInactiveTaskButton.TabIndex = 15;
            this.removeInactiveTaskButton.Text = "usuń zadanie";
            this.removeInactiveTaskButton.UseVisualStyleBackColor = true;
            this.removeInactiveTaskButton.Click += new System.EventHandler(this.removeInactiveTaskButton_Click);
            // 
            // inactiveTaskLabel
            // 
            this.inactiveTaskLabel.AutoSize = true;
            this.inactiveTaskLabel.Location = new System.Drawing.Point(3, 9);
            this.inactiveTaskLabel.Name = "inactiveTaskLabel";
            this.inactiveTaskLabel.Size = new System.Drawing.Size(103, 13);
            this.inactiveTaskLabel.TabIndex = 11;
            this.inactiveTaskLabel.Text = "Zadania nieaktywne";
            // 
            // inactiveTasksDataGridView
            // 
            this.inactiveTasksDataGridView.AllowUserToAddRows = false;
            this.inactiveTasksDataGridView.AllowUserToDeleteRows = false;
            this.inactiveTasksDataGridView.AutoGenerateColumns = false;
            this.inactiveTasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inactiveTasksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.inactiveTasksDataGridView.DataSource = this.tasksBindingSource;
            this.inactiveTasksDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.inactiveTasksDataGridView.Location = new System.Drawing.Point(3, 34);
            this.inactiveTasksDataGridView.MultiSelect = false;
            this.inactiveTasksDataGridView.Name = "inactiveTasksDataGridView";
            this.inactiveTasksDataGridView.ReadOnly = true;
            this.inactiveTasksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inactiveTasksDataGridView.Size = new System.Drawing.Size(623, 145);
            this.inactiveTasksDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MethodName";
            this.dataGridViewTextBoxColumn7.HeaderText = "Metoda";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn8.HeaderText = "Status";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CreationTime";
            this.dataGridViewTextBoxColumn9.HeaderText = "Utworzono";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CalculationStartTime";
            this.dataGridViewTextBoxColumn10.HeaderText = "Rozpoczęto";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // endpointPanel
            // 
            this.endpointPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endpointPanel.Controls.Add(this.endpointTextBox);
            this.endpointPanel.Controls.Add(this.endpointLabel);
            this.endpointPanel.Controls.Add(this.reconnectToServerButton);
            this.endpointPanel.Controls.Add(this.connectionToServerFailedLabel);
            this.endpointPanel.Location = new System.Drawing.Point(4, 5);
            this.endpointPanel.Name = "endpointPanel";
            this.endpointPanel.Size = new System.Drawing.Size(229, 78);
            this.endpointPanel.TabIndex = 15;
            // 
            // endpointLabel
            // 
            this.endpointLabel.AutoSize = true;
            this.endpointLabel.Location = new System.Drawing.Point(3, 3);
            this.endpointLabel.Name = "endpointLabel";
            this.endpointLabel.Size = new System.Drawing.Size(48, 13);
            this.endpointLabel.TabIndex = 0;
            this.endpointLabel.Text = "endpoint";
            // 
            // endpointTextBox
            // 
            this.endpointTextBox.Location = new System.Drawing.Point(3, 30);
            this.endpointTextBox.Name = "endpointTextBox";
            this.endpointTextBox.Size = new System.Drawing.Size(220, 20);
            this.endpointTextBox.TabIndex = 1;
            // 
            // AdministrationConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 580);
            this.Controls.Add(this.endpointPanel);
            this.Controls.Add(this.inactiveTasksPanel);
            this.Controls.Add(this.timerIntervalPanel);
            this.Controls.Add(this.configurationPanel);
            this.Controls.Add(this.queueTasksPanel);
            this.Controls.Add(this.activeTasksPanel);
            this.Name = "AdministrationConsole";
            this.Text = "Konsola Administratora";
            this.Load += new System.EventHandler(this.AdministrationConsole_Load);
            this.configurationPanel.ResumeLayout(false);
            this.configurationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queueTasksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueTasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeTasksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            this.queueTasksPanel.ResumeLayout(false);
            this.queueTasksPanel.PerformLayout();
            this.activeTasksPanel.ResumeLayout(false);
            this.activeTasksPanel.PerformLayout();
            this.timerIntervalPanel.ResumeLayout(false);
            this.timerIntervalPanel.PerformLayout();
            this.inactiveTasksPanel.ResumeLayout(false);
            this.inactiveTasksPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inactiveTasksDataGridView)).EndInit();
            this.endpointPanel.ResumeLayout(false);
            this.endpointPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label connectionToServerFailedLabel;
        private System.Windows.Forms.Button reconnectToServerButton;
        private System.Windows.Forms.Panel configurationPanel;
        private System.Windows.Forms.Button sendTasksCalculationTimeoutButton;
        private System.Windows.Forms.Label tasksCalculationTimeoutUnitLabel;
        private System.Windows.Forms.TextBox tasksCalculationTimeoutTextBox;
        private System.Windows.Forms.Label tasksCalculationTimeoutLabel;
        private System.Windows.Forms.Label calculatedTasksTimeoutLabel;
        private System.Windows.Forms.Button sendCalculatedTasksTimeoutButton;
        private System.Windows.Forms.Label calculatedTasksTimeoutUnitLabel;
        private System.Windows.Forms.TextBox calculatedTasksTimeoutTextBox;
        private System.Windows.Forms.DataGridView queueTasksDataGridView;
        private System.Windows.Forms.BindingSource queueTasksBindingSource;
        private System.Windows.Forms.Button updateTasksDataButton;
        private System.Windows.Forms.DataGridView activeTasksDataGridView;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private System.Windows.Forms.Panel queueTasksPanel;
        private System.Windows.Forms.Label queueTasksLabel;
        private System.Windows.Forms.Panel activeTasksPanel;
        private System.Windows.Forms.Label activeTasksLabel;
        private System.Windows.Forms.Button prioritizeTaskButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn methodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calculationStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button removeQueueTaskButton;
        private System.Windows.Forms.Button removeActiveTaskButton;
        private System.ComponentModel.BackgroundWorker bwSendTasksCalculationTimeout;
        private System.ComponentModel.BackgroundWorker bwSendCalculatedTasksTimeout;
        private System.ComponentModel.BackgroundWorker bwPrioritizeTask;
        private System.ComponentModel.BackgroundWorker bwUpdateTasksView;
        private System.ComponentModel.BackgroundWorker bwDeleteTask;
        private System.Windows.Forms.Timer UpdateTasksTimer;
        private System.Windows.Forms.Panel timerIntervalPanel;
        private System.Windows.Forms.Button timerIntervalButton;
        private System.Windows.Forms.Label timerIntervalUnitLabel;
        private System.Windows.Forms.TextBox timerIntervalTextBox;
        private System.Windows.Forms.Label timerIntervalLabel;
        private System.Windows.Forms.Panel inactiveTasksPanel;
        private System.Windows.Forms.Button removeInactiveTaskButton;
        private System.Windows.Forms.Label inactiveTaskLabel;
        private System.Windows.Forms.DataGridView inactiveTasksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox configureActiveTasksCountTextBox;
        private System.Windows.Forms.Label configureActiveTasksCountLabel;
        private System.Windows.Forms.Button configureActiveTasksCountButton;
        private System.ComponentModel.BackgroundWorker bwConfigureActiveTasksCount;
        private System.Windows.Forms.Panel endpointPanel;
        private System.Windows.Forms.TextBox endpointTextBox;
        private System.Windows.Forms.Label endpointLabel;
    }
}


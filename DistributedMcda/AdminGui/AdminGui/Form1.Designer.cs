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
            this.tasksDataGridView = new System.Windows.Forms.DataGridView();
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
            this.tasksPanel = new System.Windows.Forms.Panel();
            this.removeTaskButton = new System.Windows.Forms.Button();
            this.tasksLabel = new System.Windows.Forms.Label();
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
            this.configurationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queueTasksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueTasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            this.queueTasksPanel.SuspendLayout();
            this.tasksPanel.SuspendLayout();
            this.timerIntervalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionToServerFailedLabel
            // 
            this.connectionToServerFailedLabel.AutoSize = true;
            this.connectionToServerFailedLabel.ForeColor = System.Drawing.Color.Red;
            this.connectionToServerFailedLabel.Location = new System.Drawing.Point(12, 513);
            this.connectionToServerFailedLabel.Name = "connectionToServerFailedLabel";
            this.connectionToServerFailedLabel.Size = new System.Drawing.Size(176, 13);
            this.connectionToServerFailedLabel.TabIndex = 0;
            this.connectionToServerFailedLabel.Text = "Nie udało się połączyć z serwerem!";
            this.connectionToServerFailedLabel.Visible = false;
            // 
            // reconnectToServerButton
            // 
            this.reconnectToServerButton.Location = new System.Drawing.Point(11, 540);
            this.reconnectToServerButton.Name = "reconnectToServerButton";
            this.reconnectToServerButton.Size = new System.Drawing.Size(105, 23);
            this.reconnectToServerButton.TabIndex = 1;
            this.reconnectToServerButton.Text = "połącz z serwerem";
            this.reconnectToServerButton.UseVisualStyleBackColor = true;
            this.reconnectToServerButton.Visible = false;
            this.reconnectToServerButton.Click += new System.EventHandler(this.reconnectToServerButton_Click);
            // 
            // configurationPanel
            // 
            this.configurationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.configurationPanel.Controls.Add(this.sendCalculatedTasksTimeoutButton);
            this.configurationPanel.Controls.Add(this.calculatedTasksTimeoutUnitLabel);
            this.configurationPanel.Controls.Add(this.calculatedTasksTimeoutTextBox);
            this.configurationPanel.Controls.Add(this.calculatedTasksTimeoutLabel);
            this.configurationPanel.Controls.Add(this.sendTasksCalculationTimeoutButton);
            this.configurationPanel.Controls.Add(this.tasksCalculationTimeoutUnitLabel);
            this.configurationPanel.Controls.Add(this.tasksCalculationTimeoutTextBox);
            this.configurationPanel.Controls.Add(this.tasksCalculationTimeoutLabel);
            this.configurationPanel.Location = new System.Drawing.Point(4, 4);
            this.configurationPanel.Name = "configurationPanel";
            this.configurationPanel.Size = new System.Drawing.Size(229, 189);
            this.configurationPanel.TabIndex = 2;
            this.configurationPanel.Visible = false;
            // 
            // sendCalculatedTasksTimeoutButton
            // 
            this.sendCalculatedTasksTimeoutButton.Location = new System.Drawing.Point(6, 147);
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
            this.calculatedTasksTimeoutUnitLabel.Location = new System.Drawing.Point(137, 124);
            this.calculatedTasksTimeoutUnitLabel.Name = "calculatedTasksTimeoutUnitLabel";
            this.calculatedTasksTimeoutUnitLabel.Size = new System.Drawing.Size(18, 13);
            this.calculatedTasksTimeoutUnitLabel.TabIndex = 6;
            this.calculatedTasksTimeoutUnitLabel.Text = "[s]";
            // 
            // calculatedTasksTimeoutTextBox
            // 
            this.calculatedTasksTimeoutTextBox.Location = new System.Drawing.Point(6, 121);
            this.calculatedTasksTimeoutTextBox.Name = "calculatedTasksTimeoutTextBox";
            this.calculatedTasksTimeoutTextBox.Size = new System.Drawing.Size(125, 20);
            this.calculatedTasksTimeoutTextBox.TabIndex = 5;
            // 
            // calculatedTasksTimeoutLabel
            // 
            this.calculatedTasksTimeoutLabel.AutoSize = true;
            this.calculatedTasksTimeoutLabel.Location = new System.Drawing.Point(3, 96);
            this.calculatedTasksTimeoutLabel.Name = "calculatedTasksTimeoutLabel";
            this.calculatedTasksTimeoutLabel.Size = new System.Drawing.Size(208, 13);
            this.calculatedTasksTimeoutLabel.TabIndex = 4;
            this.calculatedTasksTimeoutLabel.Text = "Timeout dla wyników przeliczonych zadań:";
            // 
            // sendTasksCalculationTimeoutButton
            // 
            this.sendTasksCalculationTimeoutButton.Location = new System.Drawing.Point(6, 61);
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
            this.tasksCalculationTimeoutUnitLabel.Location = new System.Drawing.Point(137, 38);
            this.tasksCalculationTimeoutUnitLabel.Name = "tasksCalculationTimeoutUnitLabel";
            this.tasksCalculationTimeoutUnitLabel.Size = new System.Drawing.Size(18, 13);
            this.tasksCalculationTimeoutUnitLabel.TabIndex = 2;
            this.tasksCalculationTimeoutUnitLabel.Text = "[s]";
            // 
            // tasksCalculationTimeoutTextBox
            // 
            this.tasksCalculationTimeoutTextBox.Location = new System.Drawing.Point(6, 35);
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
            this.queueTasksDataGridView.Location = new System.Drawing.Point(3, 35);
            this.queueTasksDataGridView.MultiSelect = false;
            this.queueTasksDataGridView.Name = "queueTasksDataGridView";
            this.queueTasksDataGridView.ReadOnly = true;
            this.queueTasksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.queueTasksDataGridView.Size = new System.Drawing.Size(623, 242);
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
            this.updateTasksDataButton.Location = new System.Drawing.Point(6, 3);
            this.updateTasksDataButton.Name = "updateTasksDataButton";
            this.updateTasksDataButton.Size = new System.Drawing.Size(103, 26);
            this.updateTasksDataButton.TabIndex = 9;
            this.updateTasksDataButton.Text = "uaktualnij zadania";
            this.updateTasksDataButton.UseVisualStyleBackColor = true;
            this.updateTasksDataButton.Click += new System.EventHandler(this.updateTasksDataButton_Click);
            // 
            // tasksDataGridView
            // 
            this.tasksDataGridView.AllowUserToAddRows = false;
            this.tasksDataGridView.AllowUserToDeleteRows = false;
            this.tasksDataGridView.AutoGenerateColumns = false;
            this.tasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tasksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tasksDataGridView.DataSource = this.tasksBindingSource;
            this.tasksDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tasksDataGridView.Location = new System.Drawing.Point(3, 34);
            this.tasksDataGridView.MultiSelect = false;
            this.tasksDataGridView.Name = "tasksDataGridView";
            this.tasksDataGridView.ReadOnly = true;
            this.tasksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tasksDataGridView.Size = new System.Drawing.Size(623, 242);
            this.tasksDataGridView.TabIndex = 10;
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
            this.queueTasksPanel.Size = new System.Drawing.Size(631, 283);
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
            // tasksPanel
            // 
            this.tasksPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tasksPanel.Controls.Add(this.removeTaskButton);
            this.tasksPanel.Controls.Add(this.tasksLabel);
            this.tasksPanel.Controls.Add(this.tasksDataGridView);
            this.tasksPanel.Location = new System.Drawing.Point(239, 293);
            this.tasksPanel.Name = "tasksPanel";
            this.tasksPanel.Size = new System.Drawing.Size(631, 281);
            this.tasksPanel.TabIndex = 12;
            // 
            // removeTaskButton
            // 
            this.removeTaskButton.Location = new System.Drawing.Point(197, 2);
            this.removeTaskButton.Name = "removeTaskButton";
            this.removeTaskButton.Size = new System.Drawing.Size(100, 26);
            this.removeTaskButton.TabIndex = 15;
            this.removeTaskButton.Text = "usuń zadanie";
            this.removeTaskButton.UseVisualStyleBackColor = true;
            this.removeTaskButton.Click += new System.EventHandler(this.removeTaskButton_Click);
            // 
            // tasksLabel
            // 
            this.tasksLabel.AutoSize = true;
            this.tasksLabel.Location = new System.Drawing.Point(3, 9);
            this.tasksLabel.Name = "tasksLabel";
            this.tasksLabel.Size = new System.Drawing.Size(188, 13);
            this.tasksLabel.TabIndex = 11;
            this.tasksLabel.Text = "Zadania ukończone oraz poza kolejką";
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
            this.timerIntervalPanel.Location = new System.Drawing.Point(4, 199);
            this.timerIntervalPanel.Name = "timerIntervalPanel";
            this.timerIntervalPanel.Size = new System.Drawing.Size(228, 280);
            this.timerIntervalPanel.TabIndex = 13;
            // 
            // timerIntervalButton
            // 
            this.timerIntervalButton.Location = new System.Drawing.Point(6, 106);
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
            this.timerIntervalUnitLabel.Location = new System.Drawing.Point(137, 81);
            this.timerIntervalUnitLabel.Name = "timerIntervalUnitLabel";
            this.timerIntervalUnitLabel.Size = new System.Drawing.Size(26, 13);
            this.timerIntervalUnitLabel.TabIndex = 12;
            this.timerIntervalUnitLabel.Text = "[ms]";
            // 
            // timerIntervalTextBox
            // 
            this.timerIntervalTextBox.Location = new System.Drawing.Point(6, 78);
            this.timerIntervalTextBox.Name = "timerIntervalTextBox";
            this.timerIntervalTextBox.Size = new System.Drawing.Size(125, 20);
            this.timerIntervalTextBox.TabIndex = 11;
            // 
            // timerIntervalLabel
            // 
            this.timerIntervalLabel.AutoSize = true;
            this.timerIntervalLabel.Location = new System.Drawing.Point(3, 47);
            this.timerIntervalLabel.Name = "timerIntervalLabel";
            this.timerIntervalLabel.Size = new System.Drawing.Size(137, 13);
            this.timerIntervalLabel.TabIndex = 10;
            this.timerIntervalLabel.Text = "odświeżanie widoku zadań:";
            // 
            // AdministrationConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 574);
            this.Controls.Add(this.timerIntervalPanel);
            this.Controls.Add(this.configurationPanel);
            this.Controls.Add(this.reconnectToServerButton);
            this.Controls.Add(this.connectionToServerFailedLabel);
            this.Controls.Add(this.queueTasksPanel);
            this.Controls.Add(this.tasksPanel);
            this.Name = "AdministrationConsole";
            this.Text = "Konsola Administratora";
            this.Load += new System.EventHandler(this.AdministrationConsole_Load);
            this.configurationPanel.ResumeLayout(false);
            this.configurationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queueTasksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueTasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            this.queueTasksPanel.ResumeLayout(false);
            this.queueTasksPanel.PerformLayout();
            this.tasksPanel.ResumeLayout(false);
            this.tasksPanel.PerformLayout();
            this.timerIntervalPanel.ResumeLayout(false);
            this.timerIntervalPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView tasksDataGridView;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private System.Windows.Forms.Panel queueTasksPanel;
        private System.Windows.Forms.Label queueTasksLabel;
        private System.Windows.Forms.Panel tasksPanel;
        private System.Windows.Forms.Label tasksLabel;
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
        private System.Windows.Forms.Button removeTaskButton;
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
    }
}


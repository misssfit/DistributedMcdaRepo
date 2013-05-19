using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using AdminGui.AdministrationServiceReference;

namespace AdminGui
{
    public partial class AdministrationConsole : Form
    {
        private AdministrationServiceClient srv;
        private EndpointAddress endpoint;

        public AdministrationConsole()
        {
            InitializeComponent();
        }

        private void AdministrationConsole_Load(object sender, EventArgs e)
        {
            tasksCalculationTimeoutTextBox.Text = "3600";
            calculatedTasksTimeoutTextBox.Text = "1800";
            timerIntervalTextBox.Text = "10000";
            configureActiveTasksCountTextBox.Text = "5";
            endpointTextBox.Text = "http://localhost:8090/CalculationService/Administration";
                        
            //bool connectionResult = ConnectToAdministrationServer();
            managePanelsVisibilty(false);
            
            bwSendTasksCalculationTimeout.DoWork += setTasksCalculationTimeout;
            bwSendCalculatedTasksTimeout.DoWork += setCalculatedTasksTimeout;
            bwConfigureActiveTasksCount.DoWork += setActiveTasksCount;

            bwPrioritizeTask.DoWork += prioritizeTask;
            bwPrioritizeTask.RunWorkerCompleted += updateTasksView;

            bwUpdateTasksView.DoWork += sendUpdateTasksRequest;
            bwUpdateTasksView.RunWorkerCompleted += updateTasksData;

            bwDeleteTask.DoWork += removeTask;
            bwDeleteTask.RunWorkerCompleted += updateTasksView;
        }

        private void managePanelsVisibilty(bool connectionToServerResult)
        {
            if (connectionToServerResult == false)
            {
                UpdateTasksTimer.Enabled = false;

                connectionToServerFailedLabel.Visible = true;
                
                configurationPanel.Visible = false;
                activeTasksPanel.Visible = false;
                queueTasksPanel.Visible = false;
                inactiveTasksPanel.Visible = false;
                timerIntervalPanel.Visible = false;
            }
            else
            {
                UpdateTasksTimer.Enabled = true;

                connectionToServerFailedLabel.Visible = false;
                
                configurationPanel.Visible = true;
                activeTasksPanel.Visible = true;
                queueTasksPanel.Visible = true;
                inactiveTasksPanel.Visible = true;
                timerIntervalPanel.Visible = true;
            }
        }

        private bool ConnectToAdministrationServer() 
        {
            try
            {
                if (srv == null)
                {
                    endpoint = new EndpointAddress(endpointTextBox.Text);
                    srv = new AdministrationServiceClient("WSHttpBinding_IAdministrationService", endpoint);
                }
                if (srv.State == CommunicationState.Closed || srv.State == CommunicationState.Created)
                {
                    srv.Open();
                }
                else if (srv.State == CommunicationState.Faulted)
                {
                    endpoint = new EndpointAddress(endpointTextBox.Text);
                    srv = new AdministrationServiceClient("WSHttpBinding_IAdministrationService", endpoint);
                    srv.Open();
                }
                
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

        private void reconnectToServerButton_Click(object sender, EventArgs e)
        {
            bool connectionResult = ConnectToAdministrationServer();
            managePanelsVisibilty(connectionResult);
        }

        private void sendTasksCalculationTimeoutButton_Click(object sender, EventArgs e)
        {
            int timeoutValue;
            if (int.TryParse(tasksCalculationTimeoutTextBox.Text, out timeoutValue) == true)
            {
                timeoutValue *= 1000;
                bwSendTasksCalculationTimeout.RunWorkerAsync(timeoutValue);
            }
            else
            {
                MessageBox.Show("Nie można sparsować wartości timeout dla przeliczających się zadań");
            }
        }

        private void setTasksCalculationTimeout(object sender, DoWorkEventArgs e)
        {
            if(ConnectToAdministrationServer() == false)
            {
                e.Cancel = true;
                return;
            }
            srv.ConfigureTasksCalculationTimeout((int)e.Argument);
            Console.WriteLine("tasks calculation timeout set to: " + (int)e.Argument + " [ms]");
        }

        private void sendCalculatedTasksTimeoutButton_Click(object sender, EventArgs e)
        {
            int timeoutValue;
            if (int.TryParse(calculatedTasksTimeoutTextBox.Text, out timeoutValue) == true)
            {
                timeoutValue *= 1000;
                bwSendCalculatedTasksTimeout.RunWorkerAsync(timeoutValue);
            }
            else
            {
                MessageBox.Show("Nie można sparsować wartości timeout dla wyników przeliczonych zadań");
            }
        }

        private void setCalculatedTasksTimeout(object sender, DoWorkEventArgs e)
        {
            if (ConnectToAdministrationServer() == false)
            {
                e.Cancel = true;
                return;
            }
            srv.ConfigureCalculatedTasksTimeout((int)e.Argument);
            Console.WriteLine("calculated tasks timeout set to: " + (int)e.Argument + " [ms]");
        }

        private void configureActiveTasksCountButton_Click(object sender, EventArgs e)
        {
            int activeTasksCount;
            if (int.TryParse(configureActiveTasksCountTextBox.Text, out activeTasksCount) == true)
            {
                bwConfigureActiveTasksCount.RunWorkerAsync(activeTasksCount);
            }
            else
            {
                MessageBox.Show("Nie można sparsować wartości dla ilości aktywnych zadań");
            }
        }

        private void setActiveTasksCount(object sender, DoWorkEventArgs e)
        {
            if (ConnectToAdministrationServer() == false)
            {
                e.Cancel = true;
                return;
            }
            srv.ConfigureActiveTasksCount((int)e.Argument);
            Console.WriteLine("active tasks count set to: " + (int)e.Argument);
        }

        private void updateTasksDataButton_Click(object sender, EventArgs e)
        {
            if (bwUpdateTasksView.IsBusy == false)
            {
                bwUpdateTasksView.RunWorkerAsync();
            }
        }

        private void sendUpdateTasksRequest(object sender, DoWorkEventArgs e)
        {
            if (ConnectToAdministrationServer() == false)
            {
                e.Cancel = true;
                return;
            }
            e.Result = srv.GetAllTasks();
        }

        private void updateTasksData(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled == true)
            {
                return;
            }
            
            KeyValuePair<TaskPool, TaskInfo[]>[] result = (KeyValuePair<TaskPool, TaskInfo[]>[])e.Result;
            foreach (var keyValuePair in result)
            {
                if (keyValuePair.Key.Equals(TaskPool.Queue))
                {
                    queueTasksDataGridView.DataSource = keyValuePair.Value;
                }
                else if (keyValuePair.Key.Equals(TaskPool.Active))
                {
                    activeTasksDataGridView.DataSource = keyValuePair.Value;
                }
                else
                {
                    inactiveTasksDataGridView.DataSource = keyValuePair.Value;
                }
            }
        }

        private void updateTasksView(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
                return;
            if (bwUpdateTasksView.IsBusy == false)
            {
                bwUpdateTasksView.RunWorkerAsync();
            }
        }

        private void prioritizeTaskButton_Click(object sender, EventArgs e)
        {
            if (queueTasksDataGridView.SelectedRows.Count > 0)
            {
                String taskId = (String)queueTasksDataGridView.SelectedRows[0].Cells[0].Value;
                bwPrioritizeTask.RunWorkerAsync(taskId);
            }
            else
            {
                MessageBox.Show("Należy zaznaczyć zadanie do przesunięcia w kolejce!");
            }
        }

        private void prioritizeTask(object sender, DoWorkEventArgs e)
        {
            if (ConnectToAdministrationServer() == false)
            {
                e.Cancel = true;
                return;
            }
            srv.PrioritizeTask((String)e.Argument);
            Console.WriteLine("move task with id: " + (String)e.Argument + " to the top of the queue");
        }

        private void removeTask(object sender, DoWorkEventArgs e)
        {
            if (ConnectToAdministrationServer() == false)
            {
                e.Cancel = true;
                return;
            }
            srv.DeleteTask((String)e.Argument);
            Console.WriteLine("remove task with id: " + (String)e.Argument);
        }

        private void removeQueueTaskButton_Click(object sender, EventArgs e)
        {
            if (queueTasksDataGridView.SelectedRows.Count > 0)
            {
                String taskId = (String)queueTasksDataGridView.SelectedRows[0].Cells[0].Value;
                bwDeleteTask.RunWorkerAsync(taskId);
            }
            else
            {
                MessageBox.Show("Należy zaznaczyć zadanie do usunięcia!");
            }
        }

        private void removeTaskButton_Click(object sender, EventArgs e)
        {
            if (activeTasksDataGridView.SelectedRows.Count > 0)
            {
                String taskId = (String)activeTasksDataGridView.SelectedRows[0].Cells[0].Value;
                bwDeleteTask.RunWorkerAsync(taskId);
            }
            else
            {
                MessageBox.Show("Należy zaznaczyć zadanie do usunięcia!");
            }
        }

        private void removeInactiveTaskButton_Click(object sender, EventArgs e)
        {
            if (inactiveTasksDataGridView.SelectedRows.Count > 0)
            {
                String taskId = (String)inactiveTasksDataGridView.SelectedRows[0].Cells[0].Value;
                bwDeleteTask.RunWorkerAsync(taskId);
            }
            else
            {
                MessageBox.Show("Należy zaznaczyć zadanie do usunięcia!");
            }
        }

        private void UpdateTasksTimer_Tick(object sender, EventArgs e)
        {
            if (bwUpdateTasksView.IsBusy == false)
            {
                bwUpdateTasksView.RunWorkerAsync();
            }
        }

        private void timerInterval_Click(object sender, EventArgs e)
        {
            int interval;
            if (int.TryParse(timerIntervalTextBox.Text, out interval) == true)
            {
                UpdateTasksTimer.Interval = interval;
            }
            else
            {
                MessageBox.Show("Nie można sparsować wartości interwału dla zegara odświeżania!");
            }
        }        
    }
}

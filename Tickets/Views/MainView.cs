using System;
using System.Windows.Forms;
using Tickets.Interfaces;
using Tickets.Models;
using Tickets.Services;
using Tickets.Word;

namespace Tickets.Views
{
    public partial class MainView : Form
    {
        private readonly ITicketService ticketService;

        public MainView()
        {
            InitializeComponent();

            var wordHandler = new WordHandler();
            ticketService = new TicketService(wordHandler);
        }

        private void OnCanIncludeTasksCheckBoxValueChanged(object sender, EventArgs eventArgs)
        {
            lbPathToTasks.Enabled = cbCanIncludeTasks.Checked;
            tbPathToTasks.Enabled = cbCanIncludeTasks.Checked;
            btOpenTasks.Enabled = cbCanIncludeTasks.Checked;
        }

        private void OnFileDialogOpen(object sender, EventArgs eventArgs)
        {
            if (sender is ButtonBase button)
            {
                var fileDialog = default(FileDialog);
                var pathTextBox = default(TextBoxBase);

                if (button.Name.Equals(nameof(btOpenQuestions)))
                {
                    fileDialog = openQuestionsFileDialog;
                    pathTextBox = tbPathToQuestions;
                }
                else if (button.Name.Equals(nameof(btOpenTasks)))
                {
                    fileDialog = openTasksFileDialog;
                    pathTextBox = tbPathToTasks;
                }

                var dialogResult = fileDialog.ShowDialog();

                if (dialogResult.Equals(DialogResult.OK))
                {
                    pathTextBox.Text = fileDialog.FileName;
                }
            }
        }

        private void OnExportClick(object sender, EventArgs eventArgs)
        {
            var saveDialogResult = saveFileDialog.ShowDialog();

            if (saveDialogResult.Equals(DialogResult.OK))
            {
                var ticketsSettings = new TicketsSettings()
                {
                    Header = tbHeader.Text,
                    FacultyTitle = tbFacultyTitle.Text,
                    DepartmentTitle = tbDepartmentTitle.Text,
                    DisciplineTitle = tbDisciplineTitle.Text,
                    StudyYear = tbStudyYear.Text,
                    DepartmentChief = tbDepartmentChief.Text,
                    QuestionsCount = Convert.ToInt32(ntbQuestionsCount.Value),
                    CanIncludeTasks = cbCanIncludeTasks.Checked,
                    TicketsCount = Convert.ToInt32(ntbTicketsCount.Value),
                    DestinationFilepath = saveFileDialog.FileName,
                    PathToQuestions = tbPathToQuestions.Text,
                    PathToTasks = tbPathToTasks.Text
                };

                try
                {
                    ticketService.CreateTickets(ticketsSettings);
                }

                catch (Exception error)
                {
                    MessageBox.Show(this, error.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }
    }
}

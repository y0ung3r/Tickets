
namespace Tickets.Views
{
    partial class MainView
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbHeader = new System.Windows.Forms.TextBox();
            this.tbFacultyTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDepartmentTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDisciplineTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbStudyYear = new System.Windows.Forms.TextBox();
            this.btExport = new System.Windows.Forms.Button();
            this.lbPathToQuestions = new System.Windows.Forms.Label();
            this.tbPathToQuestions = new System.Windows.Forms.TextBox();
            this.btOpenQuestions = new System.Windows.Forms.Button();
            this.btOpenTasks = new System.Windows.Forms.Button();
            this.tbPathToTasks = new System.Windows.Forms.TextBox();
            this.lbPathToTasks = new System.Windows.Forms.Label();
            this.cbCanIncludeTasks = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ntbTicketsCount = new System.Windows.Forms.NumericUpDown();
            this.openQuestionsFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ntbQuestionsCount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.openTasksFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDepartmentChief = new System.Windows.Forms.TextBox();
            this.cbCanUseTaskWord = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ntbTicketsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbQuestionsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Шапка";
            // 
            // tbHeader
            // 
            this.tbHeader.Location = new System.Drawing.Point(12, 33);
            this.tbHeader.Multiline = true;
            this.tbHeader.Name = "tbHeader";
            this.tbHeader.Size = new System.Drawing.Size(368, 76);
            this.tbHeader.TabIndex = 1;
            this.tbHeader.Text = "Стерлитамакский филиал федерального государственного \r\nбюджетного образовательног" +
    "о учреждения высшего образования \r\n«Башкирский государственный университет»";
            // 
            // tbFacultyTitle
            // 
            this.tbFacultyTitle.Location = new System.Drawing.Point(12, 139);
            this.tbFacultyTitle.Name = "tbFacultyTitle";
            this.tbFacultyTitle.Size = new System.Drawing.Size(368, 20);
            this.tbFacultyTitle.TabIndex = 2;
            this.tbFacultyTitle.Text = "Математики и информационных технологий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Факультет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Кафедра";
            // 
            // tbDepartmentTitle
            // 
            this.tbDepartmentTitle.Location = new System.Drawing.Point(12, 190);
            this.tbDepartmentTitle.Name = "tbDepartmentTitle";
            this.tbDepartmentTitle.Size = new System.Drawing.Size(368, 20);
            this.tbDepartmentTitle.TabIndex = 4;
            this.tbDepartmentTitle.Text = "Прикладной информатики и программирования";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Предмет";
            // 
            // tbDisciplineTitle
            // 
            this.tbDisciplineTitle.Location = new System.Drawing.Point(12, 243);
            this.tbDisciplineTitle.Name = "tbDisciplineTitle";
            this.tbDisciplineTitle.Size = new System.Drawing.Size(368, 20);
            this.tbDisciplineTitle.TabIndex = 6;
            this.tbDisciplineTitle.Text = "Программирование";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Учебный год";
            // 
            // tbStudyYear
            // 
            this.tbStudyYear.Location = new System.Drawing.Point(12, 295);
            this.tbStudyYear.Name = "tbStudyYear";
            this.tbStudyYear.Size = new System.Drawing.Size(368, 20);
            this.tbStudyYear.TabIndex = 8;
            this.tbStudyYear.Text = "2020-2021";
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(273, 612);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(107, 23);
            this.btExport.TabIndex = 10;
            this.btExport.Text = "Сформировать";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.OnExportClick);
            // 
            // lbPathToQuestions
            // 
            this.lbPathToQuestions.AutoSize = true;
            this.lbPathToQuestions.Location = new System.Drawing.Point(10, 435);
            this.lbPathToQuestions.Name = "lbPathToQuestions";
            this.lbPathToQuestions.Size = new System.Drawing.Size(149, 13);
            this.lbPathToQuestions.TabIndex = 11;
            this.lbPathToQuestions.Text = "Путь до файла с вопросами";
            // 
            // tbPathToQuestions
            // 
            this.tbPathToQuestions.Location = new System.Drawing.Point(12, 451);
            this.tbPathToQuestions.Name = "tbPathToQuestions";
            this.tbPathToQuestions.ReadOnly = true;
            this.tbPathToQuestions.Size = new System.Drawing.Size(325, 20);
            this.tbPathToQuestions.TabIndex = 12;
            // 
            // btOpenQuestions
            // 
            this.btOpenQuestions.Location = new System.Drawing.Point(343, 449);
            this.btOpenQuestions.Name = "btOpenQuestions";
            this.btOpenQuestions.Size = new System.Drawing.Size(37, 23);
            this.btOpenQuestions.TabIndex = 13;
            this.btOpenQuestions.Text = "...";
            this.btOpenQuestions.UseVisualStyleBackColor = true;
            this.btOpenQuestions.Click += new System.EventHandler(this.OnFileDialogOpen);
            // 
            // btOpenTasks
            // 
            this.btOpenTasks.Enabled = false;
            this.btOpenTasks.Location = new System.Drawing.Point(343, 554);
            this.btOpenTasks.Name = "btOpenTasks";
            this.btOpenTasks.Size = new System.Drawing.Size(37, 23);
            this.btOpenTasks.TabIndex = 16;
            this.btOpenTasks.Text = "...";
            this.btOpenTasks.UseVisualStyleBackColor = true;
            this.btOpenTasks.Click += new System.EventHandler(this.OnFileDialogOpen);
            // 
            // tbPathToTasks
            // 
            this.tbPathToTasks.Enabled = false;
            this.tbPathToTasks.Location = new System.Drawing.Point(12, 556);
            this.tbPathToTasks.Name = "tbPathToTasks";
            this.tbPathToTasks.ReadOnly = true;
            this.tbPathToTasks.Size = new System.Drawing.Size(325, 20);
            this.tbPathToTasks.TabIndex = 15;
            // 
            // lbPathToTasks
            // 
            this.lbPathToTasks.AutoSize = true;
            this.lbPathToTasks.Enabled = false;
            this.lbPathToTasks.Location = new System.Drawing.Point(10, 540);
            this.lbPathToTasks.Name = "lbPathToTasks";
            this.lbPathToTasks.Size = new System.Drawing.Size(142, 13);
            this.lbPathToTasks.TabIndex = 14;
            this.lbPathToTasks.Text = "Путь до файла с задачами";
            // 
            // cbCanIncludeTasks
            // 
            this.cbCanIncludeTasks.AutoSize = true;
            this.cbCanIncludeTasks.Enabled = false;
            this.cbCanIncludeTasks.Location = new System.Drawing.Point(13, 516);
            this.cbCanIncludeTasks.Name = "cbCanIncludeTasks";
            this.cbCanIncludeTasks.Size = new System.Drawing.Size(162, 17);
            this.cbCanIncludeTasks.TabIndex = 17;
            this.cbCanIncludeTasks.Text = "Включать задачи в билеты";
            this.cbCanIncludeTasks.UseVisualStyleBackColor = true;
            this.cbCanIncludeTasks.CheckedChanged += new System.EventHandler(this.OnCanIncludeTasksCheckBoxValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 598);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Количество билетов:";
            // 
            // ntbTicketsCount
            // 
            this.ntbTicketsCount.Location = new System.Drawing.Point(12, 614);
            this.ntbTicketsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ntbTicketsCount.Name = "ntbTicketsCount";
            this.ntbTicketsCount.Size = new System.Drawing.Size(70, 20);
            this.ntbTicketsCount.TabIndex = 20;
            this.ntbTicketsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ntbTicketsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // openQuestionsFileDialog
            // 
            this.openQuestionsFileDialog.Filter = "Документ Word|*.docx";
            this.openQuestionsFileDialog.Title = "Выберите файл с вопросами...";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "docx";
            this.saveFileDialog.Filter = "Документ Word|*.docx";
            this.saveFileDialog.Title = "Сохранить как...";
            // 
            // ntbQuestionsCount
            // 
            this.ntbQuestionsCount.Location = new System.Drawing.Point(12, 406);
            this.ntbQuestionsCount.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ntbQuestionsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ntbQuestionsCount.Name = "ntbQuestionsCount";
            this.ntbQuestionsCount.Size = new System.Drawing.Size(49, 20);
            this.ntbQuestionsCount.TabIndex = 22;
            this.ntbQuestionsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ntbQuestionsCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Количество вопросов:";
            // 
            // openTasksFileDialog
            // 
            this.openTasksFileDialog.Filter = "Документ Word|*.docx";
            this.openTasksFileDialog.Title = "Выберите файл с задачами...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Заведующий кафедрой";
            // 
            // tbDepartmentChief
            // 
            this.tbDepartmentChief.Location = new System.Drawing.Point(12, 349);
            this.tbDepartmentChief.Name = "tbDepartmentChief";
            this.tbDepartmentChief.Size = new System.Drawing.Size(368, 20);
            this.tbDepartmentChief.TabIndex = 23;
            this.tbDepartmentChief.Text = "Хасанов М.К.";
            // 
            // cbCanUseTaskWord
            // 
            this.cbCanUseTaskWord.AutoSize = true;
            this.cbCanUseTaskWord.Location = new System.Drawing.Point(13, 493);
            this.cbCanUseTaskWord.Name = "cbCanUseTaskWord";
            this.cbCanUseTaskWord.Size = new System.Drawing.Size(157, 17);
            this.cbCanUseTaskWord.TabIndex = 25;
            this.cbCanUseTaskWord.Text = "Включать слово \"Задача\"";
            this.cbCanUseTaskWord.UseVisualStyleBackColor = true;
            this.cbCanUseTaskWord.CheckedChanged += new System.EventHandler(this.OnCanUseTaskWordCheckBoxValueChanged);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 651);
            this.Controls.Add(this.cbCanUseTaskWord);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDepartmentChief);
            this.Controls.Add(this.ntbQuestionsCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ntbTicketsCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCanIncludeTasks);
            this.Controls.Add(this.btOpenTasks);
            this.Controls.Add(this.tbPathToTasks);
            this.Controls.Add(this.lbPathToTasks);
            this.Controls.Add(this.btOpenQuestions);
            this.Controls.Add(this.tbPathToQuestions);
            this.Controls.Add(this.lbPathToQuestions);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbStudyYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDisciplineTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDepartmentTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFacultyTitle);
            this.Controls.Add(this.tbHeader);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экзаменационные билеты";
            ((System.ComponentModel.ISupportInitialize)(this.ntbTicketsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbQuestionsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHeader;
        private System.Windows.Forms.TextBox tbFacultyTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDepartmentTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDisciplineTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbStudyYear;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Label lbPathToQuestions;
        private System.Windows.Forms.TextBox tbPathToQuestions;
        private System.Windows.Forms.Button btOpenQuestions;
        private System.Windows.Forms.Button btOpenTasks;
        private System.Windows.Forms.TextBox tbPathToTasks;
        private System.Windows.Forms.Label lbPathToTasks;
        private System.Windows.Forms.CheckBox cbCanIncludeTasks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ntbTicketsCount;
        private System.Windows.Forms.OpenFileDialog openQuestionsFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.NumericUpDown ntbQuestionsCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openTasksFileDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDepartmentChief;
        private System.Windows.Forms.CheckBox cbCanUseTaskWord;
    }
}


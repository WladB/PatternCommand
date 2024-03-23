using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UkrainianLanguage_VirtualSimulator
{
    public partial class Task : Form
    {
        public Task()
        {
            InitializeComponent();
        }
        DbManager db = DbManager.getInstance();
        public string primaryKey;
        int top = -10;
        string[] RightAnswers;
        bool oneRightAnswer = false;
        string link;
        private string[] peretvor(string str)
        {
            string[] mas = str.Split(';');
            return mas;
        }
        private void Add(Panel panel, string str)
        {
            if (!oneRightAnswer)
            {
                CheckBox task = new CheckBox();
                task.Height = 20;
                task.AutoSize = true;
                task.Name = "task" + (panel.Controls.Count);
                task.Text = str;
                top += 30;
                task.Top = top;
                task.Left = 29;
                task.Checked = false;
                panel.Controls.Add(task);
            }
            else
            {
                RadioButton task = new RadioButton();

                task.Height = 20;
                task.AutoSize = true;
                task.Name = "task" + (panel.Controls.Count);
                task.Text = str;
                top += 30;
                task.Top = top;
                task.Left = 29;
                task.Checked = false;
                panel.Controls.Add(task);
            }
        }
        private void Align(Label lab, Form form)
        {
            lab.Left = (form.Width / 2) - (lab.Size.Width / 2);
        }
        private void Restart()
        {
            TaskCaptionLabel.Text = db.GetInfo("Tasks", "Id", "Caption", primaryKey);
            Align(TaskCaptionLabel, this);
            Align(TaskDescriptionLabel, this);
            TaskDescription.Text = db.GetInfo("Tasks", "Id", "Description", primaryKey);
            link = db.GetInfo("Topics", "Id", "Rules", db.GetInfo("Tasks", "Id", "Topic_id", primaryKey));
            string[] a = peretvor(db.GetInfo("Tasks", "Id", "AnswerVariants", primaryKey));
            RightAnswers = peretvor(db.GetInfo("Tasks", "Id", "RightAnswer", primaryKey));
            top = -10;

            if (RightAnswers.Length > 1)
            {
                TestType.Text = "Оберіть декілька правильних відповідей";
                oneRightAnswer = false;
            }
            else
            {
                TestType.Text = "Оберіть одну правильну відповідь";
                oneRightAnswer = true;
            }
            AnswersPanel.Controls.Clear();
            foreach (string str in a)
            {
                Add(AnswersPanel, str);
            }
        }
        private void Task_Load(object sender, EventArgs e)
        {
            Restart();
        }
        public bool Odnakovi(string[] arr1, string[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                return false;
            }

            Array.Sort(arr1);
            Array.Sort(arr2);

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }

            return true;
        }
        private void CheckButton_Click(object sender, EventArgs e)
        {
            List<string> controlNames = new List<string>();
            for (int i = 0; i < AnswersPanel.Controls.Count; i++)
            {
                if (!oneRightAnswer)
                {
                    if (((CheckBox)AnswersPanel.Controls[i]).Checked)
                    {
                        controlNames.Add(((CheckBox)AnswersPanel.Controls[i]).Text);
                    }
                }
                else
                {
                    if (((RadioButton)AnswersPanel.Controls[i]).Checked)
                    {
                        controlNames.Add(((RadioButton)AnswersPanel.Controls[i]).Text);
                    }
                }
            }
            if (Odnakovi(controlNames.ToArray(), RightAnswers))
            {
                MessageBox.Show("Всі відповіді вірні!");
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                MessageBox.Show("Не вірно, спробуйте ще");
                for (int i = 0; i < AnswersPanel.Controls.Count; i++)
                {
                    if (!oneRightAnswer)
                    {
                        ((CheckBox)AnswersPanel.Controls[i]).Checked = false;
                    }
                    else
                    {
                        ((RadioButton)AnswersPanel.Controls[i]).Checked = false;
                    }
                }
            }

        }
        private void ViewingRulesButton_Click(object sender, EventArgs e)
        {
            Browser form2 = new Browser();
            form2.Link = link;
            form2.ShowDialog();
        }
    }
}

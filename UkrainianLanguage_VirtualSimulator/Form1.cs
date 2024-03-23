using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UkrainianLanguage_VirtualSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbManager db = DbManager.getInstance();
        public int top = 27;
        public int left = 47;
        public string tableName = "Sections";
        public string primaryKey;
        private void EditingTasks_Click(object sender, EventArgs e)
        {
            TaskEditingForm form = new TaskEditingForm();
            form.f = this;
            form.ShowDialog();
            top = 27;
            left = 47;
        }
        private void Reestration_Click(object sender, EventArgs e)
        {
            Reestration reestration = new Reestration();
            reestration.ShowDialog();
        }
        private int createButton(string caption, string tag, Panel parent)
        {
            Button btn = new Button();
            btn.Text = caption;
            btn.Tag = tag;
            btn.Width = 190;
            btn.Top = top;
            btn.Left = left;
            btn.Click += ListButton_Click;
            parent.Controls.Add(btn);
            return btn.Size.Width;
        }
      
        List<string> list = new List<string>();
        public void UpdatePanel()
        {
            // List<string> list = new List<string>(); 
            string[] listN;
            switch (tableName)
            {
                case "Sections": list = db.valueList("Sections", "Id"); InformLabel.Text = "Оберіть потрібний розділ:"; break;
                case "Topics": list = db.valueList("Topics", ("Section_id = '" + primaryKey + "'"), "Id"); InformLabel.Text = "Оберіть потрібну тему:"; break;
                case "Tasks": list = db.valueList("Tasks", ("Topic_id = '" + primaryKey + "'"), "Id"); InformLabel.Text = "Оберіть потрібне завдання:"; break;
            }

            //-----------------------------------------Сортування--------------------------------------
            listN = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                listN[i] = db.GetInfo(tableName, "Id", "Caption", list[i]);
            }
           
            listN = listN.OrderBy(item => GetNumericValue(item)).ToArray();
            int j = 0;
            for (int i = 0; i < list.Count;)
            {
               

                if (listN[i] == db.GetInfo(tableName, "Id", "Caption", list[j]))
                {
                    listN[i] = list[j];
                    i++;
                    j = 0;
                }
                else
                {
                    j++;
                }

            }

            //-----------------------------------------------------------------------------------------
            for (int i = 0; i < list.Count; i++)
            {

                if (left >= 662) { top += 47; left = 47; }
                left += 47 + createButton(db.GetInfo(tableName, "Id", "Caption", listN[i]), listN[i], ListPanel);
            }
        }

        int GetNumericValue(string s)
        {
            string numericPart = new string(s.Where(char.IsDigit).ToArray());
            return string.IsNullOrEmpty(numericPart) ? 0 : int.Parse(numericPart);
        }
        private void ListButton_Click(object sender, EventArgs e)
        {
            if (tableName == "Topics")
            {
                ListPanel.Controls.Clear();

                top = 27;
                left = 47;
                tableName = "Tasks";
                BackButton.Visible = true;
                this.primaryKey = (sender as Button).Tag.ToString();
                UpdatePanel();
            }
            else if (tableName == "Sections")
            {
                ListPanel.Controls.Clear();

                top = 27;
                left = 47;
                tableName = "Topics";
                this.primaryKey = (sender as Button).Tag.ToString();
                BackButton.Visible = true;
                UpdatePanel();
            }
            else
            {
                Task task = new Task();
                task.primaryKey = (sender as Button).Tag.ToString();
                task.ShowDialog();
                if (task.DialogResult == DialogResult.OK)
                {
                    (sender as Button).BackColor = Color.LightGreen;
                }
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (tableName == "Topics")
            {
                ListPanel.Controls.Clear();
                top = 27;
                left = 47;
                tableName = "Sections";
                InformLabel.Text = "Оберіть потрібний розділ:";
                BackButton.Visible = false;
                UpdatePanel();
            }
            else if (tableName != "Sections")
            {
                ListPanel.Controls.Clear();
                InformLabel.Text = "Оберіть потрібну тему:";
                top = 27;
                left = 47;
                tableName = "Topics";
                primaryKey = db.GetInfo("Topics", "Id", "Section_id", primaryKey);
                BackButton.Visible = true;
                UpdatePanel();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InformLabel.Text = "Увійдіть до свого акаунту!";
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void EntryButton_Click(object sender, EventArgs e)
        {
            Entry enter = new Entry();
            enter.ShowDialog();
            if (enter.DialogResult == DialogResult.Yes)
            {
                menuStrip1.Items[2].Visible = true;
                menuStrip1.Items[2].Enabled = true;
                menuStrip1.Items[0].Visible = false;
                menuStrip1.Items[1].Visible = false;
                menuStrip1.Items[3].Visible = true;
                UpdatePanel();
            }
            else if (enter.DialogResult == DialogResult.OK)
            {
                menuStrip1.Items[2].Visible = false;
                menuStrip1.Items[2].Enabled = false;
                menuStrip1.Items[0].Visible = false;
                menuStrip1.Items[1].Visible = false;
                menuStrip1.Items[3].Visible = true;
                menuStrip1.Items[4].Visible = true;
                UpdatePanel();

            }
            else
            {
                menuStrip1.Items[3].Visible = false;
                menuStrip1.Items[2].Visible = false;
                menuStrip1.Items[2].Enabled = false;
                menuStrip1.Items[0].Visible = true;
                menuStrip1.Items[1].Visible = true;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            menuStrip1.Items[3].Visible = false;
            menuStrip1.Items[2].Visible = false;
            menuStrip1.Items[2].Enabled = false;
            menuStrip1.Items[4].Visible = false;
            menuStrip1.Items[0].Visible = true;
            menuStrip1.Items[1].Visible = true;
            BackButton.Visible = false;
            tableName = "Sections";
            InformLabel.Text = "Увійдіть до свого акаунту";
            top = 27;
            left = 47;
            ListPanel.Controls.Clear();
        }

        private void MyCabinetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyCabinet cabinet = new MyCabinet();
            cabinet.ShowDialog();
        }
    }
}

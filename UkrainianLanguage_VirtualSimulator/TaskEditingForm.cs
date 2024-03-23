using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UkrainianLanguage_VirtualSimulator
{
    public partial class TaskEditingForm : Form
    {
        public TaskEditingForm()
        {
            InitializeComponent();
        }
        DbManager db = DbManager.getInstance();
        int top = -10;
        List<string> valuefields = new List<string>();
        Panel varAnswers;
        CheckedListBox RightAnswers;
        string primarykey = "";
        string TableName = "";
        public Form1 f;
       

        private void WorkingWithSectionsB_Click(object sender, EventArgs e)
        {
            AddRadioButton.Visible = true;
            DeleteRadioButton.Visible = true;
            EditRadioButton.Visible = true;

            AddRadioButton.Checked = false;
            DeleteRadioButton.Checked = false;
            EditRadioButton.Checked = false;

            AddRecordB.Visible = false;
            UpdateRecordB.Visible = false;
            SearchCLabel.Visible = false;

            TableLabel.Text = "Вміст таблиці розділи:";

            SearchCLabel.Text = "";
            SearchTLabel.Text = "Назва розділу";

            SearchTBox.Text = "";
            SearchCBox.Text = "";
            db.TableRecords("Sections", DataGrid);
            DataGrid.Visible = true;

            FildPanel.Controls.Clear();
            Label label = new Label();
            label.Text = "Назва розділу";
            label.Left = 0;
            label.Top = 20;

            TextBox textBox = new TextBox();
            textBox.Size = new Size(463, 22);
            textBox.Name = "Caption";
            textBox.Top = 45;
            textBox.Left = 0;

            Label label1 = new Label();
            label1.Text = "Опис розділу";
            label1.Left = 0;
            label1.Top = 70;

            TextBox textBox1 = new TextBox();
            textBox1.Size = new Size(463, 50);
            textBox1.Name = "Description";
            textBox1.Multiline = true;
            textBox1.Top = 95;
            textBox1.Left = 0;

            FildPanel.Controls.Add(label);
            FildPanel.Controls.Add(textBox);
            FildPanel.Controls.Add(label1);
            FildPanel.Controls.Add(textBox1);


            SearchCBox.Visible = false;
            FildPanel.Visible = true;
            TableName = "Sections";
            lab.Visible = false;
        }

        private void WorkingWithTopicsB_Click(object sender, EventArgs e)
        {
            AddRadioButton.Visible = true;
            DeleteRadioButton.Visible = true;
            EditRadioButton.Visible = true;

            AddRadioButton.Checked = false;
            DeleteRadioButton.Checked = false;
            EditRadioButton.Checked = false;

            AddRecordB.Visible = false;
            UpdateRecordB.Visible = false;

            TableLabel.Text = "Вміст таблиці теми:";

            SearchCLabel.Visible = true;
            SearchCLabel.Text = "Розділ";
            SearchTLabel.Text = "Назва теми";
            SearchTBox.Text = "";
            SearchCBox.Text = "";
            db.TableRecords("Topics", DataGrid);
            DataGrid.Visible = true;

            FildPanel.Controls.Clear();
            Label label = new Label();
            label.Text = "Назва теми";
            label.Left = 0;
            label.Top = 20;

            TextBox textBox = new TextBox();
            textBox.Size = new Size(463, 22);
            textBox.Name = "Caption";
            textBox.Top = 45;
            textBox.Left = 0;

            Label label1 = new Label();
            label1.Text = "Опис теми";
            label1.Left = 0;
            label1.Top = 70;

            TextBox textBox1 = new TextBox();
            textBox1.Size = new Size(463, 50);
            textBox1.Name = "Description";
            textBox1.Multiline = true;
            textBox1.Top = 95;
            textBox1.Left = 0;

            Label label2 = new Label();
            label2.Text = "Посилання на правила";
            label2.AutoSize = true;
            label2.Left = 0;
            label2.Top = 150;

            TextBox textBox2 = new TextBox();
            textBox2.Size = new Size(463, 22);
            textBox2.Name = "Pravila";
            textBox2.Top = 175;
            textBox2.Left = 0;

            Label label3 = new Label();
            label3.Text = "Оберіть відповідний розділ для теми";
            label3.AutoSize = true;
            label3.Left = 0;
            label3.Top = 200;

            ComboBox Combo = new ComboBox();
            Combo.Size = new Size(463, 22);
            Combo.Name = "Combo";
            Combo.Top = 225;
            Combo.Left = 0;
            db.ComboContent(Combo, "Sections");
            db.ComboContent(SearchCBox, "Sections");
            FildPanel.Controls.Add(label);
            FildPanel.Controls.Add(textBox);
            FildPanel.Controls.Add(label1);
            FildPanel.Controls.Add(textBox1);
            FildPanel.Controls.Add(label2);
            FildPanel.Controls.Add(textBox2);
            FildPanel.Controls.Add(label3);
            FildPanel.Controls.Add(Combo);

            SearchCBox.Visible = true;
            FildPanel.Visible = true;

            TableName = "Topics";
            top = 0;
            lab.Visible = false;
        }
        private string GenerateUniqueId(int size)
        {
            Guid uniqueId = Guid.NewGuid();
            return uniqueId.ToString().Substring(0, size);
        }
        private void WorkingWithTasksB_Click(object sender, EventArgs e)
        {
            AddRadioButton.Visible = true;
            DeleteRadioButton.Visible = true;
            EditRadioButton.Visible = true;

            AddRadioButton.Checked = false;
            DeleteRadioButton.Checked = false;
            EditRadioButton.Checked = false;

            AddRecordB.Visible = false;
            UpdateRecordB.Visible = false;

            TableLabel.Text = "Вміст таблиці завдання:";

            SearchCLabel.Text = "Тема";
            SearchTLabel.Text = "Назва завдання";
            SearchCLabel.Visible = true;
            SearchTBox.Text = "";
            SearchCBox.Text = "";
            db.TableRecords("Tasks", DataGrid);
            DataGrid.Visible = true;

            FildPanel.Controls.Clear();
            Label label = new Label();
            label.Text = "Назва завдання";
            label.Left = 0;
            label.Top = 20;

            TextBox textBox = new TextBox();
            textBox.Size = new Size(463, 22);
            textBox.Name = "Caption";
            textBox.Top = 45;
            textBox.Left = 0;

            Label label1 = new Label();
            label1.Text = "Опис завдання";
            label1.Left = 0;
            label1.Top = 70;

            TextBox textBox1 = new TextBox();
            textBox1.Size = new Size(463, 50);
            textBox1.Name = "Description";
            textBox1.Multiline = true;
            textBox1.Top = 95;
            textBox1.Left = 0;

            Label label2 = new Label();
            label2.Text = "Оберіть тему завдання";
            label2.Left = 0;
            label2.Top = 155;
            label2.AutoSize = true;

            ComboBox Combo = new ComboBox();
            Combo.Size = new Size(463, 22);
            Combo.Name = "Combo";
            Combo.Top = 180;
            Combo.Left = 0;

            varAnswers = new Panel();
            varAnswers.Size = new Size(357, 173);
            varAnswers.Name = "PanelVarAnswers";
            varAnswers.Top = 270;
            varAnswers.Left = 0;
            varAnswers.BorderStyle = BorderStyle.FixedSingle;
            varAnswers.AutoScroll = true;

            Button plus = new Button();
            plus.Location = new Point(89, 8);
            plus.Size = new Size(38, 23);
            plus.Text = "+";
            plus.Click += plus_Click;
            Label Informlabel = new Label();
            Informlabel.Location = new Point(133, 12);
            Informlabel.Size = new Size(96, 12);
            Informlabel.Text = "Варіанти відповіді:";
            Informlabel.AutoSize = true;
            Button minus = new Button();
            minus.Location = new Point(235, 8);
            minus.Size = new Size(38, 23);
            minus.Text = "-";
            minus.Click += minus_Click;
            GroupBox gpbox = new GroupBox();
            gpbox.Location = new Point(0, 225);
            gpbox.Size = new Size(357, 35);
            gpbox.Controls.Add(plus);
            gpbox.Controls.Add(Informlabel);
            gpbox.Controls.Add(minus);

            Label label3 = new Label();
            label3.Text = "Правильні відповіді";
            label3.Left = 0;
            label3.Top = 468;
            label3.AutoSize = true;

            RightAnswers = new CheckedListBox();
            RightAnswers.Size = new Size(463, 100);
            RightAnswers.Name = "Combo1";
            RightAnswers.Top = 493;
            RightAnswers.Left = 0;

            db.ComboContent(Combo, "Topics");
            db.ComboContent(SearchCBox, "Topics");
            FildPanel.Controls.Add(label);
            FildPanel.Controls.Add(textBox);
            FildPanel.Controls.Add(label1);
            FildPanel.Controls.Add(textBox1);
            FildPanel.Controls.Add(label2);
            FildPanel.Controls.Add(Combo);
            FildPanel.Controls.Add(label3);
            FildPanel.Controls.Add(gpbox);
            FildPanel.Controls.Add(varAnswers);
            FildPanel.Controls.Add(RightAnswers);

            SearchCBox.Visible = true;
            FildPanel.Visible = true;
            TableName = "Tasks";
            lab.Visible = false;
        }
        private void Add(Panel panel, string str)
        {
            TextBox task = new TextBox();
            task.Size = new Size(300, 20);
            task.Name = "task" + (panel.Controls.Count);
            task.Text = str;
            top += 30;
            task.Top = top;
            task.Left = 29;
            task.TextChanged += textBox_TextChanged;
            panel.Controls.Add(task);
        }
        private void Refresh(CheckedListBox chekbox, Panel variantAnsvers)
        {
            chekbox.Items.Clear();
            for (int i = 0; i < variantAnsvers.Controls.Count; i++)
            {
                if (((TextBox)variantAnsvers.Controls[i]).Text != "")
                {
                    chekbox.Items.Add(((TextBox)variantAnsvers.Controls[i]).Text);
                }
            }
        }
        private void plus_Click(object sender, EventArgs e)
        {
            Add(varAnswers, "");
            Refresh(RightAnswers, varAnswers);
        }
        void textBox_TextChanged(object sender, EventArgs e)
        {
            RightAnswers.Items.Clear();
            if (((TextBox)sender).Text.Contains("'"))
            {
                ((TextBox)sender).Text = ((TextBox)sender).Text.Replace("'", "`");

            }
            Refresh(RightAnswers, varAnswers);
        }
        private void minus_Click(object sender, EventArgs e)
        {
            if ((varAnswers.Controls.Count) > 0)
            {
                top -= 30;
                varAnswers.Controls.Remove(varAnswers.Controls[varAnswers.Controls.Count - 1]);
            }
            Refresh(RightAnswers, varAnswers);
        }
        bool IsFild(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "")
                {
                    return false;
                }
            }
            return true;
        }
       
        private void AddRecordB_Click(object sender, EventArgs e)
        {
            
            valuefields.Clear();
            valuefields.Add(GenerateUniqueId(TableName == "Tasks" ? 6 : 4));
            valuefields.Add((FildPanel.Controls[1] as TextBox).Text);
            valuefields.Add((FildPanel.Controls[3] as TextBox).Text);

            if (TableName == "Topics")
            {
                valuefields.Add((FildPanel.Controls[5] as TextBox).Text);
                valuefields.Add(db.pk("Sections", (FildPanel.Controls[7] as ComboBox).Text));
            }
            else if (TableName == "Tasks")
            {
                if (varAnswers.Controls.Count >= 2 && ((TextBox)varAnswers.Controls[0]).Text != "" && ((TextBox)varAnswers.Controls[1]).Text != "" && RightAnswers.CheckedItems.Count >= 1)
                {

                    valuefields.Add(db.pk("Topics", (FildPanel.Controls[5] as ComboBox).Text));
                    string str = "";
                    for (int i = 0; i < varAnswers.Controls.Count; i++)
                    {
                        if (((TextBox)varAnswers.Controls[i]).Text != "")
                        {
                            str += ((TextBox)varAnswers.Controls[i]).Text + ";";
                        }
                    }
                    str = str.Remove(str.Length - 1);
                    valuefields.Add(str);
                    str = "";
                    for (int i = 0; i < RightAnswers.CheckedItems.Count; i++)
                    {
                        str += RightAnswers.CheckedItems[i] + ";";
                    }
                    str = str.Remove(str.Length - 1);
                    valuefields.Add(str);
                    str = "";
                    IsShownMessage = false;
                }
                else
                {
                    MessageBox.Show("Додайте 2 або більше варіантів відповіді! Та хочаб одну правильну відповідь");
                    IsShownMessage = true;
                }
            }
            if (IsFild(valuefields) && !IsShownMessage)
            {
                for (int i = 0; i < valuefields.Count; i++)
                {
                    if (valuefields[i].Contains("'"))
                    {
                        valuefields[i] = valuefields[i].Replace("'", "`");
                    }
                }
                db.AddRecord(TableName, valuefields);
                Filtration_Click(sender, e);

            }
            else if (!IsShownMessage)
            {
                MessageBox.Show("Всі поля мають бути заповненими");
            }

        }
        bool IsShownMessage = false;
        private void UpdateRecordB_Click(object sender, EventArgs e)
        {
            
            if (EditRadioButton.Checked)
            {
                if (primarykey != "")
                {
                    valuefields.Clear();
                    valuefields.Add(primarykey);
                    valuefields.Add((FildPanel.Controls[1] as TextBox).Text);
                    valuefields.Add((FildPanel.Controls[3] as TextBox).Text);

                    if (TableName == "Topics")
                    {
                        valuefields.Add((FildPanel.Controls[5] as TextBox).Text);
                        valuefields.Add(db.pk("Sections", (FildPanel.Controls[7] as ComboBox).Text));
                    }
                    else if (TableName == "Tasks")
                    {
                        if (varAnswers.Controls.Count >= 2 && ((TextBox)varAnswers.Controls[0]).Text != "" && ((TextBox)varAnswers.Controls[1]).Text != "" && RightAnswers.CheckedItems.Count >= 1)
                        {

                            valuefields.Add(db.pk("Topics", (FildPanel.Controls[5] as ComboBox).Text));
                            string str = "";
                            for (int i = 0; i < varAnswers.Controls.Count; i++)
                            {
                                if (((TextBox)varAnswers.Controls[i]).Text != "")
                                {
                                    str += ((TextBox)varAnswers.Controls[i]).Text + ";";
                                }
                            }
                            str = str.Remove(str.Length - 1);
                            valuefields.Add(str);
                            str = "";
                            for (int i = 0; i < RightAnswers.CheckedItems.Count; i++)
                            {
                                str += RightAnswers.CheckedItems[i] + ";";
                            }
                            str = str.Remove(str.Length - 1);
                            valuefields.Add(str);
                            str = "";
                            IsShownMessage = false;
                        }
                        else
                        {
                            MessageBox.Show("Додайте 2 або більше варіантів відповіді! Та хочаб одну правильну відповідь");
                            IsShownMessage = true;
                        }
                    }
                    if (IsFild(valuefields) && !IsShownMessage)
                    {
                        for(int i=0; i<valuefields.Count; i++){
                            if (valuefields[i].Contains("'"))
                            {
                                valuefields[i] = valuefields[i].Replace("'", "`");
                            }
                        }
                        db.UpdateRecord(TableName, valuefields, primarykey);
                        Filtration_Click(sender, e);
                    }
                    else if (!IsShownMessage)
                    {
                        MessageBox.Show("Всі поля мають бути заповненими коректно");
                    }
                }
                else{
                    MessageBox.Show("Запис не обрано, або його не існує");
                }
            }
        }
        private void AddRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FildPanel.Visible = true;
            AddRecordB.Visible = true;
            UpdateRecordB.Visible = false;
            lab.Visible = false;
        }

        private void DeleteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FildPanel.Visible = false;
            AddRecordB.Visible = false;
            UpdateRecordB.Visible = false;
            lab.Visible = true;  
        }

        private void EditRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FildPanel.Visible = true;
            AddRecordB.Visible = false;
            UpdateRecordB.Visible = true;
            lab.Visible = false;
        }
        private string[] peretvor(string str)
        {
            string[] mas = str.Split(';');
            return mas;
        }
        private void SetChekedItem(CheckedListBox box, string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                box.SetItemChecked(box.Items.IndexOf(arr[i]), true);
            }
        }
        int i = 1;


        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                primarykey = DataGrid.Rows[e.RowIndex].Cells[(DataGrid.Columns[db.ViewPK(TableName)]).Index].Value.ToString();
                if (DeleteRadioButton.Checked)
                {
                    db.DeleteRecord(TableName, primarykey);
                    switch (TableName)
                    {
                        case "Tasks":
                            (FildPanel.Controls[1] as TextBox).Text = "";
                            (FildPanel.Controls[3] as TextBox).Text = "";
                            (FildPanel.Controls[5] as ComboBox).Text = "";
                            varAnswers.Controls.Clear();
                            RightAnswers.Items.Clear();
                            break;
                        case "Topics":
                            (FildPanel.Controls[1] as TextBox).Text = "";
                            (FildPanel.Controls[3] as TextBox).Text = "";
                            (FildPanel.Controls[5] as TextBox).Text = "";
                            (FildPanel.Controls[7] as ComboBox).Text = "";
                            break;
                        case "Sections":
                            (FildPanel.Controls[1] as TextBox).Text = "";
                            (FildPanel.Controls[3] as TextBox).Text = "";
                            break;
                    }
                    Filtration_Click(sender, e);
                    primarykey = "";
                }
                else
                {
                    i = 0;
                    int j = 1;
                    while (j < DataGrid.Rows[e.RowIndex].Cells.Count)
                    {
                        if (FildPanel.Controls[i].GetType().ToString() != "System.Windows.Forms.Label" && FildPanel.Controls[i].GetType().ToString() != "System.Windows.Forms.GroupBox")
                        {
                            if (TableName == "Tasks")
                            {
                                if (FildPanel.Controls[i].Name == "PanelVarAnswers")
                                {
                                    top = -10;

                                    varAnswers.Controls.Clear();

                                    RightAnswers.Items.Clear();

                                    foreach (string str in peretvor(DataGrid.Rows[e.RowIndex].Cells[j].Value.ToString()))
                                    {
                                        Add(varAnswers, str);
                                    }
                                }
                                else if (FildPanel.Controls[i].Name == "Combo1")
                                {
                                    ((CheckedListBox)FildPanel.Controls[i]).Items.AddRange(peretvor(DataGrid.Rows[e.RowIndex].Cells[j - 1].Value.ToString()));
                                    SetChekedItem(((CheckedListBox)FildPanel.Controls[i]), (peretvor(DataGrid.Rows[e.RowIndex].Cells[j].Value.ToString())));
                                }
                            }
                            if (FildPanel.Controls[i].Name != "Combo")
                            {
                                FildPanel.Controls[i].Text = DataGrid.Rows[e.RowIndex].Cells[j].Value.ToString();
                            }
                            else
                            {
                                FildPanel.Controls[i].Text = db.GetInfo(TableName == "Topics" ? "Sections" : "Topics", "Id", "Caption", DataGrid.Rows[e.RowIndex].Cells[j].Value.ToString());//покищо
                            }
                            i++;
                            j++;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
            }
        }

        Label lab;
        private void TaskEditing_Load(object sender, EventArgs e)
        {
            lab = new Label();
            lab.Text = "Натисніть у таблиці на запис, який потрібно видалити";
            lab.AutoSize = true;
            lab.Visible = false;
            lab.Top = 100;
            lab.Left = 210;
            WorkingWithSectionsB_Click(sender, e);
            BackPanel1.Controls.Add(lab);
        }
        private void TaskEditing_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.ListPanel.Controls.Clear();
            f.top = 27;
            f.left = 47;
            f.UpdatePanel();
        }

        private void Filtration_Click(object sender, EventArgs e)
        {
            if (SearchCBox.Text.Contains("'"))
            {
                SearchCBox.Text = SearchCBox.Text.Replace("'", "`");
            }
            if (SearchTBox.Text.Contains("'"))
            {
                SearchTBox.Text = SearchTBox.Text.Replace("'", "`");
            }
            bool IsPresent=false;
            for(int i= 0; i < SearchCBox.Items.Count; i++){
                if (SearchCBox.Items[i].ToString().ToLower() == SearchCBox.Text.ToLower()) {
                    IsPresent = true;
                }
               
            }
           

            if ((SearchTBox.Text != "" ||  SearchCBox.Text!=""&& IsPresent) && !TableLabel.Text.Contains("(Фільтрація):"))
            {

                TableLabel.Text = TableLabel.Text.Remove(TableLabel.Text.Length - 1);
                TableLabel.Text += "(Фільтрація):";
            }
            else if (SearchTBox.Text == "" && !IsPresent)
            {
                TableLabel.Text = TableLabel.Text.Replace("(Фільтрація):", ":");

            }

            string[] NameColm;
            string[] param;
            switch (TableName)
            {
                case "Tasks":
                    NameColm = new string[] { "Caption", "Topic_id" };
                    param = new string[] { SearchTBox.Text, db.pk("Topics", SearchCBox.Text) };
                    db.SearchRecord("Tasks", NameColm, param, DataGrid);
                    break;
                case "Topics":
                    NameColm = new string[] { "Caption", "Section_id" };
                    param = new string[] { SearchTBox.Text, db.pk("Sections", SearchCBox.Text) };
                    db.SearchRecord("Topics", NameColm, param, DataGrid);
                    break;
                case "Sections":
                    NameColm = new string[] { "Caption" };
                    param = new string[] { SearchTBox.Text };
                    db.SearchRecord("Sections", NameColm, param, DataGrid);
                    break;
            }

        }
    }
}

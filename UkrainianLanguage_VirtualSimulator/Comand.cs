using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UkrainianLanguage_VirtualSimulator
{
    public interface AbstractComand
    {
        string GetInfo();
        void Execute(List<Object> parameters);

    }
    //------------------------------Elements Menu----------------------------------
    class CommandStatistics : AbstractComand
    {
        public string GetInfo()
        {
            return "Перегляд статистики проходження розділів";
        }
        public void Execute(List<Object> parameters = null)
        {

            Panel panel2 = new Panel();
            Label label1 = new Label();
            Label label2 = new Label();
          
            // panel2
            panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Location = new System.Drawing.Point(24, 289);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(310, 149);
            panel2.TabIndex = 1;
            // label1
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(140, 273);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 13);
            label1.TabIndex = 2;
            label1.Text = "Ваша статистика";
            // label2
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(8, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(293, 13);
            label2.TabIndex = 0;
            label2.Text = "Ваша статистика наразі не доступна, спробуйте пізніше";

            for (int i = 0; i < ((Form)parameters[0]).Controls.Count; i++)
            {
                if (((Form)parameters[0]).Controls[i].Name != "panel1")
                {
                    ((Form)parameters[0]).Controls.Remove(((Form)parameters[0]).Controls[i]);
                    i = 0;
                }
            }

            ((Form)parameters[0]).Controls.Add(panel2);
            ((Form)parameters[0]).Controls.Add(label1);
            panel2.Controls.Add(label2);
        }
    }
    class CommandViewUserName : AbstractComand
    {
        public string GetInfo()
        {
            return "Перегляд ім'я користувача";
        }
        public void Execute(List<Object> parameters)
        {
            // DbManager db = DbManager.getInstance();
            Label label1 = new Label();
            // label1
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(165, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 13);
            label1.TabIndex = 1;
            label1.Text = "Користувач: " + "User";
            for (int i = 0; i < ((Form)parameters[0]).Controls.Count; i++)
            {
                if (((Form)parameters[0]).Controls[i].Name != "panel1")
                {
                    ((Form)parameters[0]).Controls.Remove(((Form)parameters[0]).Controls[i]);
                    i = 0;
                }
            }
        ((Form)parameters[0]).Controls.Add(label1);
        }
    }
    class CommandViewKurs : AbstractComand
    {
        public string GetInfo()
        {
            return "Перегляд курсів";
        }
        public void Execute(List<Object> parameters)
        {
            DbManager db = DbManager.getInstance();
            List<string> s = db.valueList("Sections", "Id");
            ListBox listBox1 = new ListBox();
            Label label1 = new Label();

            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(27, 81);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(96, 13);
            label1.TabIndex = 2;
            label1.Text = "Доступні розділи:";

            listBox1.FormattingEnabled = true;
            listBox1.Location = new System.Drawing.Point(27, 100);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(324, 134);
            listBox1.TabIndex = 1;
            for (int i = 0; i < ((Form)parameters[0]).Controls.Count; i++)
            {
                if (((Form)parameters[0]).Controls[i].Name != "panel1")
                {
                    ((Form)parameters[0]).Controls.Remove(((Form)parameters[0]).Controls[i]);
                    i = 0;
                }
            }
            ((Form)parameters[0]).Controls.Add(listBox1);
            ((Form)parameters[0]).Controls.Add(label1);
            for (int i = 0; i < s.Count; i++)
            {
                listBox1.Items.Add(db.GetInfo("Sections", "Id", "Caption", s[i]));
            }
        }
    }
    //-------------------------------------------ButtonCreator-----------------------------------------
    public class Btn
    {
        MyCabinet myCabinet;
        public void createButton(string caption, int T, int L, int i, Panel parent, MyCabinet f)
        {
            myCabinet = f;
            Button btn = new Button();
            btn.Text = caption;
            btn.Width = 190;
            btn.Top = T;
            btn.Left = L;
            btn.Tag = i;
            btn.Click += button_Click;
            parent.Controls.Add(btn);

        }
        void button_Click(object sender, EventArgs e)
        { 
            myCabinet.MyC(Convert.ToInt32(((Button)sender).Tag));
        }
    }
    //---------------------------------------UI_Menu-------------------------------------------
    public class UI_class
    {
        List<AbstractComand> commands = new List<AbstractComand>();
        Btn b = new Btn();
        public UI_class()
        {
            commands.Add(new CommandStatistics());
            commands.Add(new CommandViewUserName());
            commands.Add(new CommandViewKurs());
        }

        public void ButtonMenu(Panel panel, MyCabinet f)
        {
            int top = 27;
            int left = 90;
            for (int i = 0; i < commands.Count; i++)
            {
                b.createButton(commands[i].GetInfo(), top, left, i, panel, f);
                top += 47;
            }
        }
        public void ListBoxMenu(ListBox list)
        {
            list.Items.Clear();
            for (int i = 0; i < commands.Count; i++)
            {
                list.Items.Add(commands[i].GetInfo());
            }
        }
        public void ExecuteCmd(int cmd, List<Object> parameters = null)
        {
            commands[cmd].Execute(parameters);
        }
    }
}


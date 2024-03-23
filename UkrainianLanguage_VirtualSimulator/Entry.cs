using System;
using System.Windows.Forms;

namespace UkrainianLanguage_VirtualSimulator
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }
        DbManager db = DbManager.getInstance();

        private void EntryButton_Click(object sender, EventArgs e)
        {
            if (db.GetInfo("Users", "Login", "Password", textBox1.Text.GetHashCode().ToString()) != "" && db.GetInfo("Users", "Login", "Password", textBox1.Text.GetHashCode().ToString()) == textBox2.Text.GetHashCode().ToString())
            {
                MessageBox.Show("Вітаємо");
                if (db.GetInfo("Users", "Login", "role", textBox1.Text.GetHashCode().ToString()) == "0")
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    DialogResult = DialogResult.Yes;
                }

            }
            else
            {
                textBox2.Text = "";
                MessageBox.Show("Невірний логін або пароль");
            }

        }
    }
}

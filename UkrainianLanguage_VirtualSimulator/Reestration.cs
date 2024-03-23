using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UkrainianLanguage_VirtualSimulator
{
    public partial class Reestration : Form
    {
        public Reestration()
        {
            InitializeComponent();
        }
        DbManager db = DbManager.getInstance();
        List<string> valueFields = new List<string>();
        private void Reestration_Load(object sender, EventArgs e)
        {
            valueFields.Clear();
        }
        
        private void ReestrationButton_Click(object sender, EventArgs e)
        {
            if (PasswordTB.Text == ConfirmPasswordTB.Text)
            {
                if (db.GetInfo("Users", "Login", "Login", LoginTB.Text.GetHashCode().ToString()) == "" && LoginTB.Text != "")
                {
                    valueFields.Add(LoginTB.Text.GetHashCode().ToString());
                    valueFields.Add("0");
                    valueFields.Add(PasswordTB.Text.GetHashCode().ToString());
                    db.AddRecord("Users", valueFields);
                    valueFields.Clear();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Користувач з таким логіном вже існує або логін є некоректним!");
                }
            }
            else
            {
                MessageBox.Show("Паролі не співпадають");
                ConfirmPasswordTB.Text = "";
            }
        }
    }
}

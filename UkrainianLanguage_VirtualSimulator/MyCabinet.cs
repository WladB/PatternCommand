using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UkrainianLanguage_VirtualSimulator
{
  
    public partial class MyCabinet : Form
    {
        public MyCabinet()
        {
            InitializeComponent();
            //createButton();
        }
        public int top = 27;
        public int left = 47;
        public static int tag;
       
        UI_class ui = new UI_class();
        private void MyCabinet_Load(object sender, EventArgs e)
        {
            ui.ButtonMenu(this.panel1, this); 
        }

        
        public  void MyC(int t)
        {
            List<object> list = new List<object>();
            list.Add(this);
            ui.ExecuteCmd(Convert.ToInt32(t), list);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ui.ListBoxMenu(listBox1);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<object> list = new List<object>();
            list.Add(this);
            ui.ExecuteCmd(listBox1.SelectedIndex, list);
        }
    }
}

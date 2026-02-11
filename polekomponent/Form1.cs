using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace polekomponent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int left = 30;
            Button[] buttonArray = new Button[100];
            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i] = new Button();
                buttonArray[i].Size = new Size(50, 23); buttonArray[i].Location = new Point(left, 50);
                buttonArray[i].Text = Convert.ToString(i);
                buttonArray[i].Click += new System.EventHandler(this.button_Click); this.Controls.Add(buttonArray[i]);
                left += 56;
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Text = "Klik!";
        }
    }
}

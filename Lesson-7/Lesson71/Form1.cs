using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_7_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lblNumber.Text = "0";
            lblCount.Text = "0";
        }

        int CommandNumber = 0;


        private void BtnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            CommandNumber++;
            lblCount.Text = CommandNumber.ToString();
        }

        private void BtnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            CommandNumber++;
            lblCount.Text = CommandNumber.ToString();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            CommandNumber++;
            lblCount.Text = CommandNumber.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rykavi4ka
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Отправлено ! ");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 fm7 = new Form7();
            fm7.Show();
            this.Hide();
            MessageBox.Show("Внимание! Вы перешли в режим редактирования");
        }
    }
}

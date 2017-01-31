using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_X___Sorting_Algorithms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertionSort im = new InsertionSort();
            im.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectionSort ss = new SelectionSort();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuickSort qs = new QuickSort();
            qs.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            BubbleSort bs = new BubbleSort();
            bs.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MergeSort ms = new MergeSort();
            ms.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

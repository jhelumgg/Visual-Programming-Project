﻿using System;
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
    public partial class MergeSort : Form
    {
        private int[] arr = new int[10];
        List<TextBox> textBoxes = new List<TextBox>();
        List<List<TextBox>> lists = new List<List<TextBox>>();
        List<TextBox> one = new List<TextBox>();
        List<TextBox> two = new List<TextBox>();
        List<TextBox> three = new List<TextBox>();
        List<TextBox> four = new List<TextBox>();
        public MergeSort()
        {
            InitializeComponent();
            textBoxes = new List<TextBox>
            {
                textBox1,
                textBox2,
                textBox3,
                textBox4,
                textBox5,
                textBox6,
                textBox7,
                textBox8,
                textBox9,
                textBox10
            };
            one = new List<TextBox>
            {
                textBox20,
                textBox19,
                textBox18,
                textBox17,
                textBox16,
                textBox15,
                textBox14,
                textBox13,
                textBox12,
                textBox11
            };
            two = new List<TextBox>
            {
                textBox30,
                textBox29,
                textBox28,
                textBox27,
                textBox26,
                textBox25,
                textBox24,
                textBox23,
                textBox22,
                textBox21
            };
            three = new List<TextBox>
            {
                textBox40,
                textBox39,
                textBox38,
                textBox37,
                textBox36,
                textBox35,
                textBox34,
                textBox33,
                textBox32,
                textBox31
            };
            four = new List<TextBox>
            {
                textBox50,
                textBox49,
                textBox48,
                textBox47,
                textBox46,
                textBox45,
                textBox44,
                textBox43,
                textBox42,
                textBox41
            };
            
            lists = new List<List<TextBox>>
            {
                one,
                two,
                three,
                four,
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    arr[i] = int.Parse(textBoxes[i].Text);
                }
                catch (Exception)
                {
                    arr[i] = 0;
                }
            }
            merge(arr);
            //for (int i = 0; i < 10; i++)
               // textBoxes[i].Text = arr[i].ToString();
        }
        public void merge(int[] array)
        {
            int y = 0;
            if (array.Length < 2)
                return;
            int step = 1;
            int startL, startR;

            while (step < array.Length)
            {
                startL = 0;
                startR = step;
                while (startR + step <= array.Length)
                {
                    mergeArrays(array, startL, startL + step, startR, startR + step);
                    startL = startR + step;
                    startR = startL + step;
                }
                if (startR < array.Length)
                    mergeArrays(array, startL, startL + step, startR, array.Length);
                step *= 2;
                List<TextBox> gg = lists[y];
                for (int x = 0; x < 10; x++)
                    gg[x].Text = arr[x].ToString();
                y++;
            }
        }
        public void mergeArrays(int[] array, int startL, int stopL, int startR, int stopR)
        {

            int[] right = new int[stopR - startR + 1];
            int[] left = new int[stopL - startL + 1];

            for (int i = 0, k = startR; i < (right.Length - 1); ++i, ++k)
                right[i] = array[k];
            for (int i = 0, k = startL; i < (left.Length - 1); ++i, ++k)
                left[i] = array[k];
            
            right[right.Length - 1] = int.MaxValue;
            left[left.Length - 1] = int.MaxValue;

            for (int k = startL, m = 0, n = 0; k < stopR; ++k)
            {
                if (left[m] <= right[n])
                {
                    array[k] = left[m];
                    m++;
                }
                else {
                    array[k] = right[n];
                    n++;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu M = new Menu();
            M.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < 4; k++)
            {
                List<TextBox> gg = lists[k];
                for (int x = 0; x < 10; x++)
                    gg[x].Text = "";
            }
            for (int o = 0; o < 10; o++)
            {
                textBoxes[o].Text = "";
            }
        }

        private void MergeSort_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoScore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a, b;
        string op;
        double result;
        Random rd = new Random();

        /// <summary>
        /// 出题按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            a = rd.Next(9)+1;
            b = rd.Next(9)+1;
            int opp = rd.Next(4);
            switch (opp)
            {
                case 0: op = "+"; result = a + b; 
                    break;
                case 1: op = "-"; result = a - b; 
                    break;
                case 2: op = "*"; result = a * b;
                    break;
                case 3: op = "/"; result = a / b;
                    break;
            }
            labA.Text = a.ToString();
            labB.Text = b.ToString();
            labOp.Text = op;
            txtResult.Text = "";
        }

        /// <summary>
        /// 判分按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJudge_Click(object sender, EventArgs e)
        {
            string str = txtResult.Text;
            double d = double.Parse(str);
            string disp = "" + a + op + b + "=" + str + " ";
            if (d == result)
               // if(Math.Abs(d-result)< Math.E-3)
                disp += "☺";
            else
                disp += "✘";
            lstDisp.Items.Add(disp);
        }
    }
}

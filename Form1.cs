using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LambdaHITS;

namespace LambdaHITS
{
    public partial class Form1 : Form
    {
        int N;
        double T;
        public Form1()
        {
            InitializeComponent();
        }
        private void LabelInit()
        {
            labelFlow1.Text = "FLOW 1:\n";
            labelFlow2.Text = "FLOW 2:\n";
            labelFlow1and2.Text = "FLOW 1 && 2:\n";
            labelFlow1plus2.Text = "FLOW 1 + 2:\n";
            N = (int)nNum.Value;
            T = (double)tNum.Value;
        }

        private void StreamFlow(Flow lambda, Label label)
        {
            for (int i = 0; i < lambda.currentFlow.Length; i++)
            {
                if (lambda.currentFlow[i] != 0)
                {
                    label.Text += (i + 1) + ": " + ((double)lambda.currentFlow[i] / N) + "\n";
                }
            }

        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            
            Flow lambda1 = new Flow();
            Flow lambda2 = new Flow();
            Flow lambda1plus2 = new Flow();
            DoubleFlow lambda1and2 = new DoubleFlow();

            lambda1.lambda = (int)lambda1Num.Value;
            lambda2.lambda = (int)lambda2Num.Value;
            lambda1plus2.lambda = (int)lambda1Num.Value + (int)lambda2Num.Value;
            lambda1and2.lambda[0] = (int)lambda1Num.Value;
            lambda1and2.lambda[1] = (int)lambda2Num.Value;

            LabelInit();
            for (int i = 0; i < N; i++)
            {
                lambda1.CreateCurrentFlow(T);
                lambda2.CreateCurrentFlow(T);
                lambda1plus2.CreateCurrentFlow(T);
                lambda1and2.CreateCurrentFlow(T);
            }


            StreamFlow(lambda1, labelFlow1);
            StreamFlow(lambda2, labelFlow2);
            StreamFlow(lambda1plus2, labelFlow1plus2);
            StreamFlow(lambda1and2, labelFlow1and2);
        }
    }
}

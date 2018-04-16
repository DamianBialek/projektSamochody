using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace projektSamochody
{
    public partial class ThreadForm : Form
    {
        Thread watek;

        public delegate void DelPrzypiszTextBox(int i);
        public DelPrzypiszTextBox delMetoda;

        public ThreadForm()
        {
            InitializeComponent();
            this.delMetoda += przypiszTextBox;
        }

        public void metodaWatku()
        {
            for (int i = 1; i < 1001; i++)
            {
                this.Invoke(delMetoda, i);
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            watek = new Thread(metodaWatku);
            watek.Start();
        }

        private void ThreadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.watek.Abort();
            this.delMetoda -= przypiszTextBox;
        }

        private void przypiszTextBox(int i)
        {
            this.textBox1.Text = i.ToString();
        }
    }
}

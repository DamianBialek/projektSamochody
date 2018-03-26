using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projektSamochody.Classes;
using projektSamochody.UserControls;

namespace projektSamochody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.samochody.SetAutoScrollMargin(20,20);


            utworzNowSamochod();
        }

        public void utworzNowSamochod()
        {
            Samochod nowySamochod = new Samochod("Audi","A6",2004,0,10,false,70,7,200);
            ControlSamochod kontrolkaSamochodu = new ControlSamochod(nowySamochod);

            this.samochody.Controls.Add(kontrolkaSamochodu);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            utworzNowSamochod();
        }
    }
}

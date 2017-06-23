using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RC1._0.Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 本店车辆信息_Click(object sender, EventArgs e)
        {
            CarInfo.CarInfo carinfo = new CarInfo.CarInfo();
            carinfo.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            CarMana.AddCar addcar = new CarMana.AddCar();
            addcar.Show();
        }
    }
}

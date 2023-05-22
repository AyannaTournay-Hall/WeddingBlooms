using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeddingBloomsDraft3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            ClientInfo clientInfo = new ClientInfo();
            clientInfo.Show();
        }

        private void weddingButton_Click(object sender, EventArgs e)
        {
            WeddingInfo weddingInfo = new WeddingInfo();
            weddingInfo.Show();
        }

        private void supplyButton_Click(object sender, EventArgs e)
        {
            Supply supply = new Supply();
            supply.Show();
        }

        private void vendorButton_Click(object sender, EventArgs e)
        {
            Vendors vendor = new Vendors();
            vendor.Show();
        }
    }
}

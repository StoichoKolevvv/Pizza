using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDelivery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lsbPizzaType_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string type = cmbType.Text;
            string size = "";
            


            if (rbSmall.Checked)
            {
                size = rbSmall.Text;
            }
            else if (rbMedium.Checked)
            {
                size = rbMedium.Text;
            }
            else
            {
                size = rbBig.Text;
            }

            if (txtCount.Text == "1")
            {
                MessageBox.Show($"Поръчахте пица: {type}, с размер {size}");
            }
            else
            {
                MessageBox.Show($"Поръчахте {txtCount.Text} пици {type}, с размер {size} и добавки: ");
            }

        }
    }
}

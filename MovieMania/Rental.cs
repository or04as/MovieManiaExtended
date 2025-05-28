using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMania
{
    public partial class Rental : Form
    {
        int movieIdentifier;
        public Rental(int movieID)
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customerDialog = new Customer("Add");
            customerDialog.ShowDialog();
        }
    }
}

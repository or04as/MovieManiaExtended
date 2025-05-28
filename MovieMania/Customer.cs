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
    public partial class Customer : Form
    {
        string formType;
        public Customer(string formTypeInput)
        {
            InitializeComponent();
            formType = formTypeInput;

            if (formType == "Add")
            {
                btnCreate.Visible = true;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
            }
            else if (formType == "Edit")
            {
                btnCreate.Visible = false;
                btnDelete.Visible = true;
                btnUpdate.Visible = true;
            }
        }

        
    }
}

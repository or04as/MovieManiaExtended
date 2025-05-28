using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMania
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void NavigationButton_Click(object sender, EventArgs e) {
            if (sender is Control button) {
                button.ForeColor = Color.FromArgb(131, 186, 230); //Highlight color of clicked button
                foreach (Control control in pnlNav.Controls) {
                    if (control is Button && control != button) {
                        control.ForeColor = Color.FromArgb(208, 217, 222); //Reset color of other buttons
                    }
                }
                if(button.Name == "btnHome")
                    tcOptions.SelectedIndex = 0; //Home tab
                else if(button.Name == "btnBrowse")
                    tcOptions.SelectedIndex = 1; //Browse tab
                else if (button.Name == "btnRentals")
                    tcOptions.SelectedIndex = 2; //Rentals tab
                else if (button.Name == "btnStatistics")
                    tcOptions.SelectedIndex = 3; //Statistics tab
            }
        }

        private void ShowRentalDialog(object sender, EventArgs e) {
            if (sender is Control pictureBox) { 
                Match match = Regex.Match(pictureBox.Name, @"(\d+)$");
                Rental rentalDialog = new Rental(int.Parse(match.Value));
                rentalDialog.ShowDialog();
            }
        }
    }
}

using Mars.Rover.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mars.Rover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlateauNext_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(txtUpperRight.Text, out int upperRight) && int.TryParse(txtLowerLeft.Text, out int lowerLeft))
            {

                Plateau plateau = new Plateau(upperRight,lowerLeft);
                RoverForm roverForm = new RoverForm(plateau);
                roverForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Please valid entries.");
            }

        }
    }


}

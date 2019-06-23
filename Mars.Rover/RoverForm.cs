using Mars.Rover.Business.Helpers;
using Mars.Rover.Business.Provider;
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
    public partial class RoverForm : Form
    {
        Plateau plateau;
        public RoverForm(Plateau plateau)
        {
            InitializeComponent();
            this.plateau = plateau;
            cBoxDirection.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxDirection.Items.Add(Direction.N);
            cBoxDirection.Items.Add(Direction.E);
            cBoxDirection.Items.Add(Direction.S);
            cBoxDirection.Items.Add(Direction.W);
        }


        private void btnRoverNext_Click(object sender, EventArgs e)
        {
            if (CommandChecker.IsValidCommand(txtCommands.Text) && cBoxDirection.Text != string.Empty && int.TryParse(txtXCoord.Text, out int xCoord) && int.TryParse(txtYCoord.Text, out int yCoord))
            {
                Direction direction = (Direction)Enum.Parse(typeof(Direction), cBoxDirection.Text, true);
                SendRover sendRover = new SendRover(new Data.Rover { X = xCoord, Y = yCoord, Direction = direction }, txtCommands.Text);
                Data.Rover result = sendRover.GetRover();
                string status = string.Empty;
                if(result.X <= plateau.LowerLeft && result.Y <= plateau.UpperRight)
                {
                    status = "Rover moved.";
                }
                else
                {
                    status = "Rover left the plateau field.";
                }
                
                listRovers.Items.Add($"{status} || X: {result.X.ToString()} || Y: {result.Y.ToString()} || Direction: {result.Direction.ToString()}");

            }
            else
            {
                MessageBox.Show("Please valid entries.");
            }
        }

        private void RoverForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

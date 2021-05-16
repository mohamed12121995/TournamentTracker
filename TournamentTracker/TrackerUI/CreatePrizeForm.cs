using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {

                // model.PlaceName = placeNameValue.Text - instead of creating this a constructor can be created so it makes it easier

                PrizeModel model = new PrizeModel(
                    placeNameValue.Text, 
                    placeNumberValue.Text, 
                    prizeAmountValue.Text, 
                    prizePercentageValue.Text);
       
            }
        }

        private bool ValidateForm()
        {
            // validate 4 fields first before clicking
            bool output = true;

            // Place number
            int placeNumber = 0;
            //create boolean which converts string to number
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);
            // checks if the parse has worked
            if (placeNumberValidNumber == false)
            {
                output = false;
            }
            //ID cannot be less than 1, place number 1 or greater
            if (placeNumber < 1)
            {
                output = false;
            }

            // Place name
            // Place name cannot be empty
            if (placeNameValue.Text.Length == 0)
            {
                output = false;
            }

            // Prize amount and percentage
            // default prize amount has to be a decimal; default percentage is a integer number
            decimal prizeAmount = 0;
            int prizePercentage = 0;
            //create boolean which converts textbox to decimal
            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            //create boolean which converts textbox to integer
            bool prizePercentageValid = int.TryParse(prizePercentageValue.Text, out prizePercentage);

            // Check if the parse is false
            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }

            // Cannot have a prize amount or prize percentage which is less than 0
            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            // cannot give the whole prize or give out nothing when giving the reward
            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}

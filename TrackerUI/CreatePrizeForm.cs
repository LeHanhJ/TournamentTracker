﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        public void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    PlaceNameValue.Text,
                    PlaceNumberValue.Text,
                    PrizeAmountValue.Text,
                    PrizePercentageValue.Text);

                GlobalConfig.Connection.CreatePrize(model);

                PlaceNameValue.Text = "";
                PlaceNumberValue.Text = "";
                PrizeAmountValue.Text = "0";
                PrizePercentageValue.Text = "0";
            }

            else
            {
                MessageBox.Show("This form has invalid information. Please update and try again.");
            }

        }

        private bool ValidateForm()
        {
            bool output = true;
            int PlaceNumber = 0;
            bool PlaceNumberValidNumber = (int.TryParse(PlaceNumberValue.Text, out PlaceNumber));

            if (PlaceNumberValidNumber == false)
            {
                output = false;
            }

            if (PlaceNumber < 1)
            {
                output = false;
            }

            if (PlaceNameValue.Text.Length == 0)
            {
                output = false;
            }

            decimal PrizeAmount = 0;
            double PrizePercentage = 0;
            bool PrizeAmountValid = decimal.TryParse(PrizeAmountValue.Text, out PrizeAmount);
            bool PrizePercentageValid = double.TryParse(PrizePercentageValue.Text, out PrizePercentage);

            if (!PrizeAmountValid && !PrizePercentageValid)
            {
                output = false;
            }

            if (PrizeAmount <= 0 && PrizePercentage <= 0)
            {
                output = false;
            }

            if(PrizePercentage < 0 || PrizePercentage > 100)
            {
                output = false;
            }

            return output;
        }

        private void PrizeAmountValue_TextChanged(object sender, EventArgs e)
        {
      
        }
    }
}

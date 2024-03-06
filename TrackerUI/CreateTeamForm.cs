using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Models;
using TrackerLibrary;
using System.Security.AccessControl;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        /// availableTeamMembers is for Select Team Member dropdown
        /// selectedTeamMembers is for the List Box
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All(); /// <-- Loading list data and grabbing all in list
   
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm()
        {
            InitializeComponent();

            /// CreateSampleData();

            WireUpLists();
        }

        /// <summary>
        ///  HACK - Sample Data
        /// </summary>
        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Hubba", LastName = "Bubba" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Inigo", LastName = "Montoya" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Ay", LastName = "Bee" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Dino", LastName = "Spumoni" });


        }

        private void WireUpLists()
        {
            SelectTeamMemberDropdown.DataSource = availableTeamMembers;
            SelectTeamMemberDropdown.DisplayMember = "FullName";

            TeamMembersListBox.DataSource = selectedTeamMembers;
            TeamMembersListBox.DisplayMember = "FullName";
        }

        public void CreateMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel person = new PersonModel(
                    FirstNameValue.Text,
                    LastNameValue.Text,
                    EmailValue.Text,
                    CellNumberValue.Text);

                GlobalConfig.Connection.CreatePerson(person);

                FirstNameValue.Text = "";
                LastNameValue.Text = "";
                EmailValue.Text = "";
                CellNumberValue.Text = "";

            }

            else
            {
                MessageBox.Show("Please fill out all the fields.");
            }
        }

        private bool ValidateForm()
        {
            // TODO - Add validate for the form
            if (FirstNameValue.Text.Length == 0)
            {
                return false;
            }

            if (LastNameValue.Text.Length == 0)
            {
                return false;
            }

            if (EmailValue.Text.Length == 0)
            {
                return false;
            }

            if (CellNumberValue.Text.Length == 0)
            {
                return false;
            }

            return true;
        }


    }
}

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
        /// availableTeamMembers is a list of people for Select Team Member dropdown
        /// selectedTeamMembers is a list of people for the List Box
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All(); /// <-- Loading list data and grabbing all in list
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();


        public CreateTeamForm() //Constructor
        {
            InitializeComponent();
            /// CreateSampleData();

            // Calling the mothod in the constructor
            WireUpLists();
        }



        /// <summary>
        ///  HACK - Sample Data
        /// </summary>
        //private void CreateSampleData()
        //{
        //    availableTeamMembers.Add(new PersonModel { FirstName = "Hubba", LastName = "Bubba" });
        //    availableTeamMembers.Add(new PersonModel { FirstName = "Inigo", LastName = "Montoya" });

        //    selectedTeamMembers.Add(new PersonModel { FirstName = "Ay", LastName = "Bee" });
        //    selectedTeamMembers.Add(new PersonModel { FirstName = "Dino", LastName = "Spumoni" });
        //}

        // WireUpLists() is used to connect the team members that we have/created
        // to where we would display them (ie: the dropdown and the listbox)
        private void WireUpLists()
        {

            SelectTeamMemberDropdown.DataSource = null;
            // Setting up the dropdown to show a list of all the
            // team members who have been added to the list by their full name
            SelectTeamMemberDropdown.DataSource = availableTeamMembers;
            SelectTeamMemberDropdown.DisplayMember = "FullName";

            TeamMembersListBox.DataSource = null;
            // Setting the list box to show the list of team members
            // by their full name
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

        // This is what happens when we click on the AddMember Button
        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            // "(PersonModel)" tells SelectedItem that it is a PersonModel,
            // and SelectedTeamMemberDropdown tells where the selected item is 
            // coming from and assigns it to p
            PersonModel p = (PersonModel)SelectTeamMemberDropdown.SelectedItem;

            // We will take the team member from the dropdown list (the list of 
            // people that we told WiredUpLists() to hook up) and tell it to be
            // removed from the dropdown and added to the listbox
            availableTeamMembers.Remove(p);
            selectedTeamMembers.Add(p);

            // Initialize WireUpLists() again to "refresh" the lists (?)
            WireUpLists();

        }

    }
}

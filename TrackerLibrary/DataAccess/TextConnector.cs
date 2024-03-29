﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Xml.Linq;
using System.Net;

namespace TrackerLibrary.DataAccess
{

    public class TextConnector : IDataConnection
    {

        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";
       


            // Create da person
        public PersonModel CreatePerson(PersonModel model)
        {
                //Grab the items in the PeopleFile and put it into a list of persons
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            // Starts the index at 1
            int currentId = 1;
            // If the PeopleFile starts at 1 or higher, we will make the currentId add 1 to get the max value
            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }

            // And then we will assign it to the current model's id to the that currentId, and add it to the model and save it
            model.Id = currentId;
            people.Add(model);
            people.SaveToPeopleFile(PeopleFile);

            return model;
        }

            // TODO - Wire up the CreatePrize for text files

            /// <summary>
            /// Setting up the connection to text files
            /// We will store each model in its own text file (FullFilePath and LoadFile from TextConnectionProcessor)
            /// > Instead of storing to the file name, we'll store to a path to where all the files go in one folder path (see constant above)
            /// </summary>
            /// <param name="model"></param>
            /// <returns></returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {

            /// Load the text file of prizes and convert the text to a List<PrizeModel> 
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            /// Find the max ID
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;
            /// Add new record with the new ID (max +1) to the list
            prizes.Add(model);
            /// Convert the prizes to a list<string>
            /// 6) Save List<String> to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;

        }

        public List<PersonModel> GetPerson_All()
        {
            /// List<PersonModel> PeopleFile.FullFilePath().LoadFile().ConvertToPersonsModel(); (??)
            throw new NotImplementedException();
            
        }
    }
}

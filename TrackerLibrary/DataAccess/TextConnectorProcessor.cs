using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;



namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) //PrizeModel.csv - filename
        { ///Take file name and return the full file path
          /// C:\Users\dell\Desktop\Portfolio\TournamentTracker\PrizeModels.csv
            // ps: "filePath" is from app.config
            return $"{ConfigurationManager.AppSettings["filePath"] }\\{fileName}";
        }



            // LoadFile() is used in TextConnector.cs
            // "file" refers to the file inserted from TextConnector.cs
        public static List<string> LoadFile(this string file)
        {
            /// If the file does not exist, then make a new file of list of strings
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            // and then read all the lines of the file and return them into a list
            return File.ReadAllLines(file).ToList();
        }



            // ConvertToPrizeModels() is used in conjuction with LoadFile()
            // and loads the list of strings that is from that method
        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            /// The output of this function will be a list of PrizesModels
            List<PrizeModel> output = new List<PrizeModel>();

            // For each line in the PrizesFile that's been inputted,
            // insert the items in the corrsponding columns in the text file
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }

            return output;
        }

            
        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            /// convert to a List<string>
            List<string> lines = new List<string>();

            // for each prize object in models, we'll add it to the new list of strings
            foreach(PrizeModel p in models)
            {
                lines.Add($"{ p.Id }, {p.PlaceNumber}, {p.PlaceName}, {p.PrizeAmount}, {p.PrizePercentage}");
            }

            // And we will update the file in the full file path with our changes to "lines"
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }


            /// <summary>
            /// Conver to PersonModels
            /// </summary>
            /// <param name="lines"></param>
            /// <returns></returns>
        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.PhoneNumber = cols[4];
                output.Add(p);
            }

            return output;
        }


        public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
        {

            List<string> lines = new List<string>();

            foreach(PersonModel p in models)
            {
                lines.Add($"{ p.Id }, { p.FirstName }, { p.LastName }, { p.EmailAddress }, { p.PhoneNumber }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);

        }
    }
}

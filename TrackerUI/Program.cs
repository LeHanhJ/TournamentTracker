using TrackerLibrary;

namespace TrackerUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            ApplicationConfiguration.Initialize();

            /// Initialize the database connections
            GlobalConfig.InitializeConnections(DatabaseType.Sql);
            Application.Run(new CreateTeamForm());
            /// Now that it's initialized, everyone can use the information
            /// When CreatePrizeForm() loads, it will have access to the information

            /// Application.Run(new TournamentDashboardForm());


        }
    }
}
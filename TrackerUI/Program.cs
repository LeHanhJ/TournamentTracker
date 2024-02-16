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
            TrackerLibrary.GlobalConfig.InitializeConnections(true, true);
            /// Now that it's initialized, everyone can use the information
            /// 
            /// When CreatePrizeForm() loads, it will have access to the information
            Application.Run(new CreatePrizeForm());

            /// Application.Run(new TournamentDashboardForm());


        }
    }
}
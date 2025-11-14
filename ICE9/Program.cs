namespace ICE9
{
    public enum FormType
    {
        Splash,
        Start,
        Next,
        Final,
        About
    }


    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            // Creates a new Instance of SelectionForm
            Application.Run(new SelectionForm());
        }
    }
}
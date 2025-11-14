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
        public static SplashForm SplashForm;
        public static SelectionForm SelectionForm;
        public static NextForm NextForm;
        public static FinalForm FinalForm;
        public static AboutForm AboutForm;

        public static List<Form> Forms;

        public static bool IsExiting = false;


        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            // Creates a new Instance of SelectionForm
            Application.Run(new SelectionForm());
        }
    }
}
namespace TP1_Structures
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmAccueil()); // <--- ICI
        }
    }
}
namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                User user1 = new User { Name = "Тои", Age = 33 };
                User user2 = new User { Name = "Алиса", Age = 26 };


                db.Users.AddRange(user1, user2);
                db.SaveChanges();
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());


    }
    } 
}

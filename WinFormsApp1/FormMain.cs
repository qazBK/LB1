namespace WinFormsApp1
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Users.ToList();
                labelUsers.Text = "Сптсок пользоватилей:";

                foreach (User u in users)
                {
                    labelInfAdoutUsers.Text += ($"{u.Id}.{u.Name}-{u.Age} \n");
                }

            }
        }
    }
} 

namespace Nagytestver
{
    public partial class Form1 : Form
    {
        Models.SoftwareUsageContext context = new Models.SoftwareUsageContext ();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Szoft2.Week10.BigBrother.BigBrother bigBrother= new Szoft2.Week10.BigBrother.BigBrother();
            bigBrother.AblakVáltás += BigBrother_AblakVáltás;
        }

        private void BigBrother_AblakVáltás(object sender, Szoft2.Week10.BigBrother.AlkalmazásHasználatEventArgs e)
        {
            if (e.Ablakcím != null && e.AlkalmazásNév!=null && e.LoginNév!=null)
            {
                Models.SoftwareUsage softwareUsage = new Models.SoftwareUsage();
                softwareUsage.ApplicationName = e.AlkalmazásNév;
                softwareUsage.WindowTitle = e.Ablakcím;
                softwareUsage.Login = e.LoginNév;
                softwareUsage.Time = (int);
            }
        }
    }
}
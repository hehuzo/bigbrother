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
            bigBrother.AblakV�lt�s += BigBrother_AblakV�lt�s;
        }

        private void BigBrother_AblakV�lt�s(object sender, Szoft2.Week10.BigBrother.Alkalmaz�sHaszn�latEventArgs e)
        {
            if (e.Ablakc�m != null && e.Alkalmaz�sN�v!=null && e.LoginN�v!=null)
            {
                Models.SoftwareUsage softwareUsage = new Models.SoftwareUsage();
                softwareUsage.ApplicationName = e.Alkalmaz�sN�v;
                softwareUsage.WindowTitle = e.Ablakc�m;
                softwareUsage.Login = e.LoginN�v;
                softwareUsage.Time = (int);
            }
        }
    }
}
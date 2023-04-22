namespace LR1ApakorOptimization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            //this.WindowState = FormWindowState.Normal;
        }

        private void StartPassiveSearch_Click(object sender, EventArgs e)
        {
            if (X0.Text != "" && X1.Text != "" && Epsilon.Text != "")
            {
                PassiveSearch search = new PassiveSearch(
                    Convert.ToDouble(X0.Text),
                    Convert.ToDouble(X1.Text),
                    Convert.ToDouble(Epsilon.Text));
                ResultX.Text = Convert.ToString(search.GetX());
                ResultF.Text = Convert.ToString(search.GetF());
                Iterations.Text = Convert.ToString(search.GetIterations());
                ErrorRate.Text = Convert.ToString(search.GetErrorRate());
                TimeOfDoing.Text = Convert.ToString(search.TimeOfDoing());
            }
            else
            {
                PassiveSearch search = new PassiveSearch();
                ResultX.Text = Convert.ToString(search.GetX());
                ResultF.Text = Convert.ToString(search.GetF());
                Iterations.Text = Convert.ToString(search.GetIterations());
                ErrorRate.Text = Convert.ToString(search.GetErrorRate());
                TimeOfDoing.Text = Convert.ToString(search.TimeOfDoing());
            }
        }

        private void StartDihotomiaMethod_Click(object sender, EventArgs e)
        {
            if (X0.Text != "" && X1.Text != "" && Epsilon.Text != "")
            {
                Dihotomia search = new Dihotomia(
                    Convert.ToDouble(X0.Text),
                    Convert.ToDouble(X1.Text),
                    Convert.ToDouble(Epsilon.Text));
                ResultX.Text = Convert.ToString(search.GetX());
                ResultF.Text = Convert.ToString(search.GetF());
                Iterations.Text = Convert.ToString(search.GetIterations());
                ErrorRate.Text = Convert.ToString(search.GetErrorRate());
                TimeOfDoing.Text = Convert.ToString(search.TimeOfDoing());
            }
            else
            {
                Dihotomia search = new Dihotomia();
                ResultX.Text = Convert.ToString(search.GetX());
                ResultF.Text = Convert.ToString(search.GetF());
                Iterations.Text = Convert.ToString(search.GetIterations());
                ErrorRate.Text = Convert.ToString(search.GetErrorRate());
                TimeOfDoing.Text = Convert.ToString(search.TimeOfDoing());
            }
        }

        private void StartGoldSearchMethod_Click(object sender, EventArgs e)
        {
            if (X0.Text != "" && X1.Text != "" && Epsilon.Text != "")
            {
                GoldSearch search = new GoldSearch(
                    Convert.ToDouble(X0.Text),
                    Convert.ToDouble(X1.Text),
                    Convert.ToDouble(Epsilon.Text));
                ResultX.Text = Convert.ToString(search.GetX());
                ResultF.Text = Convert.ToString(search.GetF());
                Iterations.Text = Convert.ToString(search.GetIterations());
                ErrorRate.Text = Convert.ToString(search.GetErrorRate());
                TimeOfDoing.Text = Convert.ToString(search.TimeOfDoing());
            }
            else
            {
                GoldSearch search = new GoldSearch();
                ResultX.Text = Convert.ToString(search.GetX());
                ResultF.Text = Convert.ToString(search.GetF());
                Iterations.Text = Convert.ToString(search.GetIterations());
                ErrorRate.Text = Convert.ToString(search.GetErrorRate());
                TimeOfDoing.Text = Convert.ToString(search.TimeOfDoing());
            }
        }

        private void StartFibonaciMethod_Click(object sender, EventArgs e)
        {

            if (X0.Text != "" && X1.Text != "" && Epsilon.Text != "")
            {
                Fibonaci search = new Fibonaci(
                    Convert.ToDouble(X0.Text),
                    Convert.ToDouble(X1.Text),
                    Convert.ToDouble(Epsilon.Text));
                ResultX.Text = Convert.ToString(search.GetX());
                ResultF.Text = Convert.ToString(search.GetF());
                Iterations.Text = Convert.ToString(search.GetIterations());
                ErrorRate.Text = Convert.ToString(search.GetErrorRate());
                TimeOfDoing.Text = Convert.ToString(search.TimeOfDoing());
            }
            else
            {
                Fibonaci search = new Fibonaci();
                ResultX.Text = Convert.ToString(search.GetX());
                ResultF.Text = Convert.ToString(search.GetF());
                Iterations.Text = Convert.ToString(search.GetIterations());
                ErrorRate.Text = Convert.ToString(search.GetErrorRate());
                TimeOfDoing.Text = Convert.ToString(search.TimeOfDoing());
            }
        }

        private void StartKasanieMethod_Click(object sender, EventArgs e)
        {
            if (X0.Text != "" && X1.Text != "" && Epsilon.Text != "")
            {
                KasatelniMethod search = new KasatelniMethod(
                    Convert.ToDouble(X0.Text),
                    Convert.ToDouble(Epsilon.Text));
                ResultX.Text = Convert.ToString(search.GetX());
                ResultF.Text = Convert.ToString(search.GetF());
                Iterations.Text = Convert.ToString(search.GetIterations());
                ErrorRate.Text = Convert.ToString(search.GetErrorRate());
                TimeOfDoing.Text = Convert.ToString(search.TimeOfDoing());
            }
            else
            {
                KasatelniMethod search = new KasatelniMethod();
                ResultX.Text = Convert.ToString(search.GetX());
                ResultF.Text = Convert.ToString(search.GetF());
                Iterations.Text = Convert.ToString(search.GetIterations());
                ErrorRate.Text = Convert.ToString(search.GetErrorRate());
                TimeOfDoing.Text = Convert.ToString(search.TimeOfDoing());
            }
        }

        private void StartNuRafMethod_Click(object sender, EventArgs e)
        {
            if (X0.Text != "" && X1.Text != "" && Epsilon.Text != "")
            {
                NuRaf search = new NuRaf(
                    Convert.ToDouble(X0.Text),
                    Convert.ToDouble(Epsilon.Text));
                ResultX.Text = Convert.ToString(search.GetX());
                ResultF.Text = Convert.ToString(search.GetF());
                Iterations.Text = Convert.ToString(search.GetIterations());
                ErrorRate.Text = Convert.ToString(search.GetErrorRate());
                TimeOfDoing.Text = Convert.ToString(search.TimeOfDoing());
            }
            else
            {
                NuRaf search = new NuRaf();
                ResultX.Text = Convert.ToString(search.GetX());
                ResultF.Text = Convert.ToString(search.GetF());
                Iterations.Text = Convert.ToString(search.GetIterations());
                ErrorRate.Text = Convert.ToString(search.GetErrorRate());
                TimeOfDoing.Text = Convert.ToString(search.TimeOfDoing());
            }
        }

        private void StartSekuchMethod_Click(object sender, EventArgs e)
        {
            if (X0.Text != "" && X1.Text != "" && Epsilon.Text != "")
            {
                SekuckMethod search = new SekuckMethod(
                    Convert.ToDouble(X0.Text),
                    Convert.ToDouble(X1.Text),
                    Convert.ToDouble(Epsilon.Text)); ;
                ResultX.Text = Convert.ToString(search.GetX());
                ResultF.Text = Convert.ToString(search.GetF());
                Iterations.Text = Convert.ToString(search.GetIterations());
                ErrorRate.Text = Convert.ToString(search.GetErrorRate());
                TimeOfDoing.Text = Convert.ToString(search.TimeOfDoing());
            }
            else
            {
                SekuckMethod search = new SekuckMethod();
                ResultX.Text = Convert.ToString(search.GetX());
                ResultF.Text = Convert.ToString(search.GetF());
                Iterations.Text = Convert.ToString(search.GetIterations());
                ErrorRate.Text = Convert.ToString(search.GetErrorRate());
                TimeOfDoing.Text = Convert.ToString(search.TimeOfDoing());
            }
        }
    }
}
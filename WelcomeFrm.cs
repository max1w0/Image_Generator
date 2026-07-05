namespace ImageGenerator
{
    public partial class WelcomeFrm : Form
    {
        public WelcomeFrm()
        {
            InitializeComponent();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(0, 0, 0);
        }
        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }
        Point lastPoint;
        private void WelcomeForm_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void WelcomeForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneratorFrm generatorForm = new GeneratorFrm();
            generatorForm.Show();
        }
        private void StartButton_MouseEnter(object sender, EventArgs e)
        {
            StartButton.ForeColor = Color.FromArgb(0, 0, 0);
        }
        private void StartButton_MouseLeave(object sender, EventArgs e)
        {
            StartButton.ForeColor = Color.White;
        }
    }
}

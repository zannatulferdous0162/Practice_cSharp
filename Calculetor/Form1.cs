namespace Calculetor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int fo = int.Parse(textBoxFirstOperend.Text);
            int so = int.Parse(textBoxSecondOperend.Text);
            if (radBtnAdd.Checked)
            {
                txtBoxExpression.Text = fo + " + " + so;
                txtBoxResult.Text = (fo + so).ToString();
            }
            else if (radBtnSub.Checked)
            {
                txtBoxExpression.Text = fo + " - " + so;
                txtBoxResult.Text = (fo - so).ToString();
            }
            else if (radBtnMulti.Checked)
            {
                txtBoxExpression.Text = fo + " * " + so;
                txtBoxResult.Text = (fo * so).ToString();
            }
            else if (radBtnDiv.Checked)
            {
                txtBoxExpression.Text = fo + " / " + so;
                txtBoxResult.Text = (fo / so).ToString();
            }
            else if (radBtnRem.Checked)
            {
                txtBoxExpression.Text = fo + " % " + so;
                txtBoxResult.Text = (fo % so).ToString();
            }
        }
    }
}
    
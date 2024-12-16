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
            int fo, so;

            // Input validation
            if (!int.TryParse(textBoxFirstOperend.Text, out fo))
            {
                MessageBox.Show("Invalid input for First Operand. Please enter a valid number.");
                return;
            }

            if (!int.TryParse(textBoxSecondOperend.Text, out so))
            {
                MessageBox.Show("Invalid input for Second Operand. Please enter a valid number.");
                return;
            }

            // Calculation logic
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
                if (so == 0)
                {
                    MessageBox.Show("Division by zero is not allowed.");
                    return;
                }
                txtBoxExpression.Text = fo + " / " + so;
                txtBoxResult.Text = ((double)fo / so).ToString("F2");
            }
            else if (radBtnRem.Checked)
            {
                if (so == 0)
                {
                    MessageBox.Show("Division by zero is not allowed.");
                    return;
                }
                txtBoxExpression.Text = fo + " % " + so;
                txtBoxResult.Text = (fo % so).ToString();
            }
            else
            {
                MessageBox.Show("Please select an operation.");
            }
        }
    }
}
    
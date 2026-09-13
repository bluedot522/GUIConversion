namespace GUIConversion
{

    public partial class FormMovieDiscount : Form
    {
        public FormMovieDiscount()
        {
            InitializeComponent();
        }
        private void FormMovieDiscount_Load(object sender, EventArgs e)
        {
           

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            ValidateInput();

        }
        private void CalculateDiscount()
        {
            //Calculates half-off movie discount amount. Standard is $20.00

            int age = Convert.ToInt32(txtAge.Text);
            string rating = txtRating.Text;
            const decimal TOTAL = 20.00m;
            decimal finalAmount;
            decimal discount;
            string verdict;

            if ((age < 13 || age >= 65) && (rating == "G" || rating == "g"))
            {
                discount = 0.5m;
                verdict = "applies";
            }

            else
            {
                discount = 0;
                verdict = "does not apply";
            }
            finalAmount = (TOTAL - (discount * TOTAL));

            DisplayResults(verdict, finalAmount);
        }
        private void ClearText()
        {
            txtAge.Clear();
            txtRating.Clear();
            lblOutput.Text = "";
        }
        private void DisplayResults(string verdict, decimal finalAmount)
        {
            lblOutput.Text = $"The discount {verdict}. The total is: {finalAmount:C}";
        }
        private void ValidateInput()
        {
            //Validates age and movie rating
            if (string.IsNullOrWhiteSpace(txtAge.Text))
            {
                lblOutput.Text = "Age must not be blank.";
            }
            else if (string.IsNullOrWhiteSpace(txtRating.Text))
            {
                lblOutput.Text = "Rating must not be blank.";
            }

            else if (!(int.TryParse(txtAge.Text, out int n)))
            {
                lblOutput.Text = lblOutput.Text + " Please enter a valid age";
            }

            else if (txtRating.Text != "G" && txtRating.Text != "g" && txtRating.Text != "PG" && txtRating.Text != "pg" && txtRating.Text != "PG-13"
                && txtRating.Text != "pg-13" && txtRating.Text != "PG13" && txtRating.Text != "pg13" && txtRating.Text != "R" && txtRating.Text != "r"
                && txtRating.Text != "MA-17" && txtRating.Text != "ma-17" && txtRating.Text != "MA17" && txtRating.Text != "ma17" && txtRating.Text != "X" && txtRating.Text != "x")
            {
                lblOutput.Text = "Please enter a valid movie rating. (G, PG, PG-13, R, MA-17, X).";
            }
            else
            {
                CalculateDiscount();
            }
        }
    }
}

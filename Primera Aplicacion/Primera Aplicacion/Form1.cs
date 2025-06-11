namespace Primera_Aplicacion
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();
            BankAccount bankAccount = new BankAccount("Pedro");
            bankAccount.Saldo = 3500;
            BankAccounts.Add(bankAccount);
            BankAccountGrid.DataSource = BankAccounts;
        }

        private void retirarClick(object sender, EventArgs e)
        {

        }

        private void depositarClick(object sender, EventArgs e)
        {

        }

        private void crearCuentaClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputName.Text))
            {
                return;
            }
            BankAccount bankAccount = new BankAccount(inputName.Text);
            BankAccounts.Add(bankAccount);
            RefreshGrid();
            inputName.Text = string.Empty;
        }

        private void RefreshGrid()
        {
            BankAccountGrid.DataSource = null;
            BankAccountGrid.DataSource = BankAccounts;
        }


    }
}

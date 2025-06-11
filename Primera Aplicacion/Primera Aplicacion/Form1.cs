using System.Windows.Forms;

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
            if (BankAccountGrid.SelectedRows.Count > 0 && AmountNum.Value > 0)
            {
                BankAccount? selectedBankAccount = BankAccountGrid.SelectedRows[0].DataBoundItem as BankAccount;
                selectedBankAccount.Saldo -= AmountNum.Value;
                RefreshGrid();
                AmountNum.Value = 0;
            }

        }

        private void depositarClick(object sender, EventArgs e)
        {
            if (BankAccountGrid.SelectedRows.Count > 0 && AmountNum.Value>0)
            {
                BankAccount? selectedBankAccount = BankAccountGrid.SelectedRows[0].DataBoundItem as BankAccount;
                selectedBankAccount.Saldo += AmountNum.Value;
                RefreshGrid();
                AmountNum.Value = 0;
            }
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

using LogProject.Database;
using LogProject.Forms;
using Microsoft.EntityFrameworkCore;

namespace LogProject
{
    public partial class LoginForm : Form
    {
        private string _selectedConnectionString;

        public LoginForm()
        {
            InitializeComponent();
            InitializeDatabaseComboBox();
        }

        private void InitializeDatabaseComboBox()
        {
            cmbDatabases.Items.Add("LoggingProject");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Connection();
            if (string.IsNullOrEmpty(_selectedConnectionString))
            {
                MessageBox.Show("Пожалуйста, выберите строку подключения.");
                return;
            }

            using var dbContext = CreateDbContext();
            var user = dbContext.Operators.FirstOrDefault(u => u.Username == txbLogin.Text && u.Password == txbPassword.Text);

            if (user != null)
            {
                this.Hide();
                MainForm mainForm = new(user, dbContext);
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неверные учетные данные. Пожалуйста, попробуйте снова.");
            }
        }

        private AppDbContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(_selectedConnectionString);
            return new AppDbContext(optionsBuilder.Options);
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Connection()
        {
            _selectedConnectionString =
                    $"Data Source=DBSRV\\AG2023;" +
                    $" Database={cmbDatabases.Text};" +
                    $" Trusted_Connection=True;" +
                    $" Integrated Security=true;" +
                    $" MultipleActiveResultSets=true;" +
                    $" TrustServerCertificate=true;";
        }
    }
}

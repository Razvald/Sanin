using LogProject.Controls;
using LogProject.Database;
using LogProject.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace LogProject.Forms
{
    public partial class MainForm : Form
    {
        private readonly Operator _user;
        private readonly AppDbContext _dbContext;

        public MainForm(Operator user, AppDbContext dbContext)
        {
            InitializeComponent();
            _user = user;
            _dbContext = dbContext;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayOrders(GetAllProjects());

            bool isAdmin = _user.Role == Role.Administrator;
            btnGraph.Visible = isAdmin;
            btnAddAreaPoint.Visible = isAdmin;
        }

        private void btnOrderList_Click(object sender, EventArgs e)
        {
            DisplayOrders(GetAllProjects());
        }

        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            DisplayOrders(GetMyOrders(_user.Id));
        }

        private void DisplayOrders(List<Project> projects)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var project in projects)
            {
                var areas = _dbContext.Areas.Where(a => a.ProjectId == project.Id).ToList();
                foreach (var area in areas)
                {
                    OrderControl orderControl = new()
                    {
                        ProjectId = project.Id.ToString(),
                        ClientName = project.Customer?.Name ?? "Не указано",
                        ClientPhone = project.Customer?.Phone ?? "Не указано",
                        ProjectName = project.Name ?? "Не указано",
                        ProjectAddress = project.Address ?? "Не указано",
                        AreaName = area.Name ?? "Не указано"
                    };

                    flowLayoutPanel1.Controls.Add(orderControl);
                }
            }
        }

        public List<Project> GetAllProjects()
        {
            var projects = _dbContext.Projects
                .Include(p => p.Customer)
                .ToList();

            return projects;
        }

        public List<Project> GetMyOrders(int userId)
        {
            var projects = _dbContext.Projects
                .Include(p => p.Customer)
                .Where(p => _dbContext.Profiles
                .Any(pr => pr.OperatorId == userId
                && pr.Area.ProjectId == p.Id))
                .ToList();

            return projects;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var reportsControl = new ReportControl(_user, _dbContext)
            {
                Anchor = AnchorStyles.None,
                Margin = new Padding((flowLayoutPanel1.Width - Width) / 4, 0, 0, 0)
            };

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(reportsControl);
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            var pickets = _dbContext.Pickets.ToList();
            var profilePoints = _dbContext.ProfilePoints.ToList();

            DataAnalizeControl dataAnalizeControl = new(_dbContext, pickets, profilePoints);

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(dataAnalizeControl);
        }

        private void CreateUser(object sender, EventArgs e)
        {/*
            var roles = Enum.GetValues(typeof(Role)).Cast<Role>().ToList();
            CreateSpecialistControl createSpecialistControl = new(roles, _dbContext);

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(createSpecialistControl);*/
        }

        private void btnAddAreaPoint_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();

            LoginForm loginForm = new();
            loginForm.Show();
        }
    }
}
//https://scottplot.net/cookbook/5.0/
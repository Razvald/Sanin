using LogProject.Database;
using LogProject.Database.Entities;
using Microsoft.VisualBasic.ApplicationServices;

namespace LogProject.Controls
{
    public partial class ReportControl : UserControl
    {
        private readonly AppDbContext _dbContext;
        private readonly Operator _user;

        public ReportControl(Operator user, AppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _user = user;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Создаем новую запись Picket
            Picket newPicket = new Picket
            {
                X = int.Parse(txtPicketX.Text),
                Y = int.Parse(txtPicketY.Text),
                Value = int.Parse(txtPicketValue.Text),
                ProfileId = GetCurrentProfileId()
            };

            _dbContext.Pickets.Add(newPicket);

            // Создаем новую запись ProfilePoint
            ProfilePoint newProfilePoint = new ProfilePoint
            {
                X = int.Parse(txtProfilePointX.Text),
                Y = int.Parse(txtProfilePointY.Text),
                ProfileId = GetCurrentProfileId()
            };

            _dbContext.ProfilePoints.Add(newProfilePoint);

            // Сохраняем изменения в базе данных
            _dbContext.SaveChanges();

            MessageBox.Show("Записи успешно добавлены!");

            // Опционально: очистка полей формы после добавления записей
            ClearFormFields();
        }

        private int GetCurrentProfileId()
        {
            // Получаем ProfileId по текущему OperatorId
            var profile = _dbContext.Profiles
                .FirstOrDefault(p => p.OperatorId == _user.Id);

            return profile?.Id ?? 0;
        }

        private void ClearFormFields()
        {
            txtPicketX.Text = "";
            txtPicketY.Text = "";
            txtPicketValue.Text = "";
            txtProfilePointX.Text = "";
            txtProfilePointY.Text = "";
        }
    }
}

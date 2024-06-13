using LogProject.Database;
using LogProject.Database.Entities;
using ScottPlot;
using ScottPlot.Colormaps;

namespace LogProject.Controls
{
    public partial class DataAnalizeControl : UserControl
    {
        private readonly AppDbContext _dbContext;
        private readonly List<Picket> _pickets;
        private readonly List<ProfilePoint> _profilePoints;

        public DataAnalizeControl(AppDbContext dbContext, List<Picket> pickets, List<ProfilePoint> profilePoints)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _pickets = pickets;
            _profilePoints = profilePoints;
            FillProfileComboBox();
        }

        private void FillProfileComboBox()
        {
            cmbProfile.Items.Clear();
            foreach (var profilePoint in _dbContext.Profiles)
            {
                cmbProfile.Items.Add(profilePoint.Id.ToString());
            }
        }

        private void UpdatePlot()
        {
            formsPlot1.Plot.Clear();

            // Проверяем, выбран ли элемент в ComboBox
            if (cmbProfile.SelectedItem == null)
            {
                return;
            }

            // Получаем выбранный профиль из ComboBox
            if (!int.TryParse(cmbProfile.SelectedItem.ToString(), out int selectedProfileId))
            {
                // Обработка ошибки, если не удалось преобразовать строку в число
                MessageBox.Show("Некорректный формат выбранного профиля");
                return;
            }

            var profilePickets = _pickets.Where(p => p.ProfileId == selectedProfileId).ToList();
            var profilePoints = _profilePoints.Where(pp => pp.ProfileId == selectedProfileId).ToList();

            // Создаем массив значений для графика пикетов
            double[] picketX = profilePickets.Select(p => (double)p.X).ToArray();
            double[] picketY = profilePickets.Select(p => (double)p.Y).ToArray();

            // Создаем массив значений для графика профильных точек
            double[] profileX = profilePoints.Select(pp => (double)pp.X).ToArray();
            double[] profileY = profilePoints.Select(pp => (double)pp.Y).ToArray();

            // Добавляем точки пикетов и профильных точек на график
            formsPlot1.Plot.Add.Scatter(picketX, picketY);
            formsPlot1.Plot.Add.Scatter(profileX, profileY);

            // Устанавливаем лимиты осей
            double minX = Math.Min(picketX.Min(), profileX.Min());
            double maxX = Math.Max(picketX.Max(), profileX.Max());
            double minY = Math.Min(picketY.Min(), profileY.Min());
            double maxY = Math.Max(picketY.Max(), profileY.Max());
            formsPlot1.Plot.Axes.SetLimits(minX, minY, maxX - minX, maxY - minY);

            // Строим график
            formsPlot1.Plot.XLabel("X");
            formsPlot1.Plot.YLabel("Y");
            formsPlot1.Plot.Title($"График для профиля {selectedProfileId}");

            formsPlot1.Refresh();
        }

        private void cmbProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePlot();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            formsPlot1.Plot.Clear();
            formsPlot1.Refresh();
        }
    }
}

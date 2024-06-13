using LogProject.Database;
using LogProject.Database.Entities;

namespace LogProject.Controls
{
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
        }

        public string ProjectId
        {
            get { return lblOrderId.Text; }
            set { lblOrderId.Text = value; }
        }

        public string ClientName
        {
            set { lblClientName.Text = value; }
        }

        public string ClientPhone
        {
            set { lblClientPhone.Text = value; }
        }

        public string ProjectName
        {
            set { lblProjectName.Text = value; }
        }

        public string ProjectAddress
        {
            set { lblProjectAddress.Text = value; }
        }

        public string AreaName
        {
            set { lblAreaName.Text = value; }
        }
    }
}

using IMS.Infrastructure.Data;

namespace IMS.Application
{
    public partial class Form1 : Form
    {
        private AppDbContext _context = new AppDbContext();

        public Form1()
        {
            InitializeComponent();
            LoadPrograms();
        }

        private void LoadPrograms()
        {
            dataGridView1.DataSource = _context.Programs.ToList();
        }
    }
}

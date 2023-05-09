using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLabEntity.AutoDB;
using TestLabLibrary.Repository;

namespace TestLabManagerApp.ChildForm
{

    public partial class frmSubmitPaper : Form
    {
        IPaperRepository _paperRepository;
        int IdPaperSelected = 0;
        string searchValue = "";
        public frmSubmitPaper(IRepository rp)
        {
            InitializeComponent();
            _paperRepository = rp.PaperRepository;
            LoadPaperFilter();
        }

        public void LoadPaperFilter()
        {
            List<TlPaper> tlPapers = _paperRepository.GetPapers();
            if (tlPapers.Count > 0)
            {
                IdPaperSelected = tlPapers[0].Id;
                cbFilterByPaper.DataSource = tlPapers;
                cbFilterByPaper.DisplayMember = "PaperName";
                cbFilterByPaper.ValueMember = "Id";
                LoadData();
            }
        }

        public void LoadData()
        {
            List<TlSubmitpaper> tlSubmitpapers = _paperRepository.GetSubmitPapers(0, 9999, IdPaperSelected, searchValue);
            var _bind = tlSubmitpapers.Select(a => new
            {
                StudentId = a.StudentId,
                StudentName = a.Student.Fullname,
                PaperName = a.Paper.PaperName,
                StartTime = a.StartTime,
                EndTime = a.UpdateAt,
                Mark = a.Mark,
            }).ToList();
            dataGridView1.DataSource = _bind;
        }

        private void cbFilterByPaper_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                IdPaperSelected = int.Parse(cbFilterByPaper.SelectedValue.ToString());
                LoadData();
            }
            catch (Exception ex)
            {

            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class AdministrationForm : Form
    {
        public AdministrationForm()
        {
            InitializeComponent();
        }

        private void 목록관리LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
            AdListForm form = new AdListForm();
            InitChildForm(form, "목록관리");
        }
        private void InitChildForm(Form form, string strFormTitle)
        {
            form.Text = strFormTitle;
            form.Dock = DockStyle.Fill;
            form.MdiParent = this;
            form.Show();
            form.WindowState = FormWindowState.Normal;
        }

        private void 회원관리MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
            AdMemberForm form = new AdMemberForm();
            InitChildForm(form, "회원관리");
        }

        private void 통계SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
            AdStatisticsForm form = new AdStatisticsForm();
            InitChildForm(form, "통계");
        }

        private void AdministrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("정말 종료하시겠습니까?","종료",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                foreach (var item in this.MdiChildren)
                {
                    item.Close();
                }
                e.Cancel = false;
                //Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
            
        }

        private void AdministrationForm_Load(object sender, EventArgs e)
        {

        }

        private void 회원성향분석SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
            DiffShowForm form = new DiffShowForm();
            InitChildForm(form, "성향차이분석");
        }
    }
}


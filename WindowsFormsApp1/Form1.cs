using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<BenhNhan> BenhNhanList = new List<BenhNhan>();
        private List<TinhTrang> TinhTrangList = new List<TinhTrang>();
        NanNhan db = new NanNhan();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NanNhan db = new NanNhan();
            FillTinhTrang(db.TinhTrangs.ToList());
            BindGrid(db.BenhNhans.ToList());
            FillInfected(db.BenhNhans.ToList());
        }
        private void FillTinhTrang(List<TinhTrang> List)
        {
            this.cmbState.DataSource = List;
            this.cmbState.DisplayMember = "TenTT";
            this.cmbState.ValueMember = "MaTT";
        }
        private void FillInfected(List<BenhNhan> ListBenhNhan)
        {
            ListBenhNhan.Insert(0, new BenhNhan { MaBN = string.Empty });
            this.cmbInfected.DataSource = ListBenhNhan;
            this.cmbInfected.ValueMember = "MaBN";


        }
        private void BindGrid(List<BenhNhan> BenhNhan)
        {
            dgvVictim.Rows.Clear();
            foreach (var item in BenhNhan)
            {
                int index = dgvVictim.Rows.Add();
                dgvVictim.Rows[index].Cells["MaBN"].Value = item.MaBN;
                dgvVictim.Rows[index].Cells["TenBN"].Value = item.TenBN;
                dgvVictim.Rows[index].Cells["TinhTrang"].Value = item.TinhTrang.TenTT;
                
                string F = "";
                if (item.BNTXG == null)
                {
                    F = "F0";
                }
                   dgvVictim.Rows[index].Cells["F"].Value = F;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();

            if (Application.OpenForms.Count != 0)
            {
                Application.Exit();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtID.Text) || string.IsNullOrEmpty(TxtName.Text))
                {
                    MessageBox.Show($"Vui lòng nhập đầy đủ thông tin bệnh nhân!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else  if (TxtID.Text.Length > 6)
                    {
                        MessageBox.Show($"Số ký tự tối đa cho phép là 6.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtID.Text = TxtID.Text.Substring(0, 6);
                    }
                

                NanNhan db = new NanNhan();
                var updateBN = db.BenhNhans.SingleOrDefault(c => c.MaBN.Equals(TxtID.Text));
                if (updateBN != null)
                {
                    updateBN.TenBN = TxtName.Text;
                    updateBN.MaTT = (int)cmbState.SelectedValue;
                    updateBN.GhiChu = TxtNote.Text;
                    updateBN.BNTXG = (string)cmbInfected.SelectedValue;

                }
                else
                {

                    BenhNhan BN = new BenhNhan()
                    {
                        TenBN = TxtID.Text,
                        MaBN = TxtID.Text,
                        GhiChu = TxtNote.Text,
                        MaTT = (int)cmbState.SelectedValue,
                        BNTXG = (string)cmbInfected.SelectedValue,

                    };
                    db.BenhNhans.Add(BN);

                }
                db.SaveChanges();
                BindGrid(db.BenhNhans.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Cập nhật dữ liệu thành công! ", "Thông báo" , MessageBoxButtons.OK);

        }

        private void dgvVictim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      int RowIndex = e.RowIndex;
            if (RowIndex >= 0)
            {
                TxtName.Text = dgvVictim.Rows[RowIndex].Cells["TenBN"].Value.ToString();
                TxtID.Text = dgvVictim.Rows[RowIndex].Cells["MaBN"].Value.ToString();
                cmbState.Text = dgvVictim.Rows[RowIndex].Cells["TinhTrang"].Value.ToString();
                string maBN = dgvVictim.Rows[RowIndex].Cells["MaBN"].Value.ToString();
                var gc = db.BenhNhans.SingleOrDefault(c => c.MaBN.Equals(TxtID.Text));
                TxtNote.Text = gc.GhiChu;
                cmbInfected.Text = gc.BNTXG;
            }
        }

        private void dgvVictim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }
            private void TxtID_TextChanged(object sender, EventArgs e)
            {
         
            }

        private void truyVếtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    }


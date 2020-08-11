using BULs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ontapktrabaiso3
{
    public partial class Form1 : Form
    {
        SanPhamBUL bul = new SanPhamBUL();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hienthi();
          



        }

        private void hienthi()
        {
            dgvSanpham.DataSource = bul.getSanPham();
            cbLoaisp.DataSource = bul.getLoaiSP();
            cbLoaisp.DisplayMember = "tenloai";  

            

        }

        private void dgvSanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtTensp.Text = dgvSanpham.Rows[row].Cells[1].Value.ToString();
            txtMasp.Text = dgvSanpham.Rows[row].Cells[0].Value.ToString();
            txtSoluong.Text = dgvSanpham.Rows[row].Cells[2].Value.ToString();
            txtDOngia.Text = dgvSanpham.Rows[row].Cells[3].Value.ToString();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var selectedItem = (cbLoaisp.SelectedItem as DataRowView);
            
            string maloai = selectedItem["maloai"].ToString();
            MessageBox.Show("mã: " + maloai);
            
            bul.addSanPham(new DTOs.SanPhamDTO(txtMasp.Text.ToString(), txtTensp.Text.ToString(), int.Parse(txtSoluong.Text), int.Parse(txtDOngia.Text), maloai));
            hienthi();
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            var selectedItem = (cbLoaisp.SelectedItem as DataRowView);

            string maloai = selectedItem["maloai"].ToString();
            MessageBox.Show("mã: " + maloai);

            bul.UpadateSanpham(new DTOs.SanPhamDTO(txtMasp.Text.ToString(), txtTensp.Text.ToString(), int.Parse(txtSoluong.Text), int.Parse(txtDOngia.Text), maloai));
            hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xóa sp", "Bạn có chắc", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK) {
                bul.DeleteSanpham(txtMasp.Text);
                hienthi();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (bul.findSanPham(txtMasp.Text).Count == 0)
            {
                MessageBox.Show("Ko tim thay");
            }
            else
            {
                dgvSanpham.DataSource = bul.findSanPham(txtMasp.Text);
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.Service;
using DoAn.XML;

namespace DoAn
{
    public partial class frmXoaGiaoVien : Form
    {
        public frmXoaGiaoVien()
        {
            InitializeComponent();
        }

        GiaoVien gv = new GiaoVien();
        GiaoVienXML gvXML = new GiaoVienXML();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMsv.Text))
            {
                gv.Mgv = txtMsv.Text;

                gvXML.Xoa(gv);
                if (MessageBox.Show("Xóa thành công bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmXoaSinhVien xoa = new frmXoaSinhVien();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Mời nhập mã giáo viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmXoaGiaoVien_Load(object sender, EventArgs e)
        {
            
        }
    }
}

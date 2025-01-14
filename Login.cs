﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class frmLogin : Form
    {
        string name;
        string type;
        DataProvider Provider=new DataProvider();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ms = MessageBox.Show("Bạn có muốn thoát không? ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ms == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Ham kiem tra Dang nhap
        private bool CheckLogin(string username, string password, string typeA)
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.loadAccount();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i][0].ToString() == username && table.Rows[i][2].ToString() == password && table.Rows[i][3].ToString() == typeA)
                {
                    name = table.Rows[i][1].ToString();
                    type = table.Rows[i][3].ToString();
                    //MessageBox.Show("Xin chào "+name+" :)", "Đăng nhập thành công",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Su kien click btnLogin
        private void btnLogin_Click(object sender, EventArgs e)
        {
     
            
            try
            {
                string user = txtUsername.Text;
                string pass = txtPassword.Text;
                string type = "CASHIER";
                if (rdbAdmin.Checked == true)
                {
                    type = "ADMIN";
                }

                if ( txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Vui long nhap day du thong tin","Canh bao");
                }
                else
                {
                    if (CheckLogin(user, pass, type) == true)
                    {
                        frmMain main = new frmMain(user, name, pass, type);
                        this.Hide();
                        main.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu ", "Lỗi...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        /*   txtUsername.Text = "admin";
                           txtPassword.Text = "admin";
                           rdbAdmin.Checked = true;*/
                    }
                }
            }
            catch
            {
                //neu chua co co so du lieu
                MessageBox.Show("Cơ sở dữ liệu không tồn tại. Vui lòng tạo mới theo file hướng dẫn", "Lỗi...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

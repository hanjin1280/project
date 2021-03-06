﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            //Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // HJ 위치 수정 [20200703 14:10] : LoginProcess 위치 수정
            //LoginProcess();
            // HJ 수정 [20200703 14:19] : if문 내 조건 수정(LoginProcess에서 다시 ID, P/W 텍스트박스가 비어있는지 확인하므로) 
            //if (!rdbtnAdmin.Checked && !rdbtnMember.Checked && !string.IsNullOrEmpty(txtID.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            if ((!rdbtnAdmin.Checked && !rdbtnMember.Checked))
            {
                MessageBox.Show("관리자/사용자 모드를 선택해 주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // HJ 추가 [20200703 14:21] : return 추가
                return;
            }
            LoginProcess();
        }

        private void LoginProcess()
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("아이디/패스워드를 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);               
                txtID.Focus();
                // HJ 위치 수정 [20200703 14:10] : return 주석 품 ( return이 없을 경우 밑의 소스가 그대로 실행됨 )
                return;
            }

            // HJ 수정 [20200703 14:12] : 단락(탭) 수정
            if (rdbtnMember.Checked)
            { 
                try
                {
                    using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING)) //commons.cs 로 만들었어요
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT userID, userSearch FROM userTbl " +
                                          " WHERE userID = @userID " +
                                            " AND userPassword = @userPassword ";
                        SqlParameter paramUserID = new SqlParameter("@userID", SqlDbType.VarChar, 50);
                        paramUserID.Value = txtID.Text;
                        cmd.Parameters.Add(paramUserID);

                        SqlParameter paramUserPassword = new SqlParameter("@userPassword", SqlDbType.VarChar, 50);
                        paramUserPassword.Value = txtPassword.Text;
                        cmd.Parameters.Add(paramUserPassword);

                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        string struserID = reader["userID"] != null ? reader["userID"].ToString() : "";


                        if (struserID != "")
                        {
                            MessageBox.Show("접속성공", "로그인성공");
                            Commons.LOGINUSERID = struserID;
                            //ProductForm form = new ProductForm();
                            //form.WindowState = FormWindowState.Maximized;
                            //form.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("접속실패", "로그인실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("로그인에 실패했습니다.\n아이디/비밀번호를 확인해 주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Clear();
                    txtPassword.Clear();
                    txtID.Focus();
                }
            }

            if(rdbtnAdmin.Checked)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING)) //commons.cs 로 만들었어요
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT masterID FROM masterTbl " +
                                          " WHERE masterID = @masterID " +
                                            " AND masterPassword = @masterPassword ";
                        SqlParameter paramMasterID = new SqlParameter("@masterID", SqlDbType.VarChar, 50);
                        paramMasterID.Value = txtID.Text;
                        cmd.Parameters.Add(paramMasterID);

                        SqlParameter paramPassword = new SqlParameter("@masterPassword", SqlDbType.VarChar, 50);
                        paramPassword.Value = txtPassword.Text;
                        cmd.Parameters.Add(paramPassword);

                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        string strMasterID = reader["masterID"] !=null? reader["masterID"].ToString():"";

                        if(strMasterID !="")
                        {
                            MessageBox.Show("접속성공", "로그인성공");
                            //HJ 수정 [20200703 16:40] : form.showDialog()를 하게 되면 Login창이 꺼지지 않음, 코드 위치 수정
                            //HJ 추가 [20200703 20:55] : Program.cs에 미리 창을 만들어 놓음으로서 Login창이 꺼지더라도 관리자 창이 안꺼지도록 수정
                            Commons.LOGINUSERID = strMasterID;
                            //AdministrationForm form = new AdministrationForm();
                            //form.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("접속실패", "로그인실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("로그인에 실패했습니다.\n아이디 / 비밀번호를 확인해 주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Clear();
                    txtPassword.Clear();
                    txtID.Focus ();
                }
                
            }

        }
       
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
               btnOK.Focus();
            }
        }

        private void rdbtnMember_MouseClick(object sender, MouseEventArgs e)
        {
            btnOK.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewMemberForm form = new NewMemberForm();
            form.ShowDialog();
        }
    }
}

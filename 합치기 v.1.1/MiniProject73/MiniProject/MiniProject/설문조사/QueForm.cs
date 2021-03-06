﻿using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class QueForm : Form
    {
        int STT1 = 0;
        int STT2 = 0;
        int STT3 = 0;


        public QueForm()
        {
            InitializeComponent();

            //WindowState = FormWindowState.Maximized;
            //Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            //{
            //    DataSet ds = new DataSet();
            //    conn.Open();

            //    // 2개의 파라미터 정의 (항상 @로 시작)
            //    string sql = " SELECT STD1,STD2,STD3 FROM dbo.userTbl where userID = @userID";
            //    SqlCommand cmd = new SqlCommand(sql, conn);

            //    // 각 파라미터 타입 및 값 입력
            //    SqlParameter paramCity = new SqlParameter("@userID", SqlDbType.VarChar, 50);
            //    paramCity.Value = Commons.LOGINUSERID;
            //    // SqlCommand 객체의 Parameters 속성에 추가
            //    cmd.Parameters.Add(paramCity);



            //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //    adapter.Fill(ds, "User_Information");

            //    conn.Close();
            //    soo.DataSource = ds; //그리드의 데이터 소스에다가 붓는다.
            //    soo.DataMember = "User_Information";

            //    STT1 = int.Parse(soo[0, 0].Value.ToString());
            //    STT2 = int.Parse(soo[1, 0].Value.ToString());
            //    STT3 = int.Parse(soo[2, 0].Value.ToString());
            //}

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            bool b = false;
            foreach (RadioButton rdo in metroPanel1.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    rdo.Checked = true;
                    b = true;
                    break;
                }
            }
            if (b == false)
            {
                MessageBox.Show("첫번재 설문조사를 선택해주세요.");
                return;
            }

            b = false;
            foreach (RadioButton rdo in metroPanel2.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    rdo.Checked = true;
                    b = true;
                    break;
                }
            }
            if (b == false)
            {
                MessageBox.Show("두번재 설문조사를 선택해주세요.");
                return;

            }

            b = false;
            foreach (RadioButton rdo in metroPanel3.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    rdo.Checked = true;
                    b = true;
                    break;
                }
            }
            if (b == false)
            {
                MessageBox.Show("세번재 설문조사를 선택해주세요.");
                return;

            }

            b = false;
            foreach (RadioButton rdo in metroPanel4.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    rdo.Checked = true;
                    b = true;
                    break;
                }
            }
            if (b == false)
            {
                MessageBox.Show("네번재 설문조사를 선택해주세요.");
                return;

            }

            using(SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT STD1, STD2, STD3 FROM userTbl WHERE userID = @userID ";

                SqlParameter paramID = new SqlParameter("@userID", SqlDbType.VarChar, 50);
                paramID.Value = Commons.LOGINUSERID;
                cmd.Parameters.Add(paramID);

                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();
                if(STT1 + int.Parse(reader[0].ToString()) > 100)
                {
                    STT1 = 100;
                }
                else if(STT1 + int.Parse(reader[0].ToString()) < 0)
                {
                    STT1 = 0;
                }
                else
                {
                    STT1 = STT1 + int.Parse(reader[0].ToString());
                }

                if (STT2 + int.Parse(reader[1].ToString()) > 100)
                {
                    STT2 = 100;
                }
                else if (STT2 + int.Parse(reader[1].ToString()) < 0)
                {
                    STT2 = 0;
                }
                else
                {
                    STT2 = STT2 + int.Parse(reader[1].ToString());
                }

                if (STT3 + int.Parse(reader[2].ToString()) > 100)
                {
                    STT3 = 100;
                }
                else if (STT3 + int.Parse(reader[2].ToString()) < 0)
                {
                    STT3 = 0;
                }
                else
                {
                    STT3 = STT3 + int.Parse(reader[2].ToString());
                }
            }

            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                DataSet ds = new DataSet();
                conn.Open();

                // 2개의 파라미터 정의 (항상 @로 시작)
                string sql = " UPDATE dbo.userTbl SET STD1 = @STD1, STD2 = @STD2, STD3 = @STD3 where userID = @userID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                // 각 파라미터 타입 및 값 입력
                SqlParameter paramCity = new SqlParameter("@userID", SqlDbType.VarChar, 50);
                paramCity.Value = Commons.LOGINUSERID;
                // SqlCommand 객체의 Parameters 속성에 추가
                cmd.Parameters.Add(paramCity);

                SqlParameter paramSTD1 = new SqlParameter("@STD1", SqlDbType.Int);
                paramSTD1.Value = STT1;
                // SqlCommand 객체의 Parameters 속성에 추가
                cmd.Parameters.Add(paramSTD1);

                SqlParameter paramSTD2 = new SqlParameter("@STD2", SqlDbType.Int);
                paramSTD2.Value = STT2;
                // SqlCommand 객체의 Parameters 속성에 추가
                cmd.Parameters.Add(paramSTD2);

                SqlParameter paramSTD3 = new SqlParameter("@STD3", SqlDbType.Int);
                paramSTD3.Value = STT3;
                // SqlCommand 객체의 Parameters 속성에 추가
                cmd.Parameters.Add(paramSTD3);

                cmd.ExecuteNonQuery();
                conn.Close();

                 
            }
            Form2 form = new Form2();        
            form.WindowState = FormWindowState.Maximized;
            form.Dock = DockStyle.Fill;
            form.ShowDialog();
            this.Close();

        }

        private void MetroButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "UPDATE userTbl SET userSearch = 1 WHERE userID = @userID ";

                SqlParameter paramID = new SqlParameter("@userID", SqlDbType.VarChar, 50);
                paramID.Value = Commons.LOGINUSERID;
                cmd.Parameters.Add(paramID);

                cmd.ExecuteNonQuery();
            }
            this.Close();
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)   //1-1
        {
            RadioButton rdobtn = (RadioButton)sender;
            if (rdobtn.Checked)
            {
                STT1 = STT1 + 10;
            }
            else
            {
                STT1 = STT1 - 10;
            }

        }

        private void metroRadioButton4_CheckedChanged(object sender, EventArgs e)   //1-4
        {
            RadioButton rdobtn = (RadioButton)sender;       
            if (rdobtn.Checked)
            {
                STT1 = STT1 + 10;
            }
            else
            {
                STT1 = STT1 - 10;
            }
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)   //1-2
        {
            RadioButton rdobtn = (RadioButton)sender;
            if(rdobtn.Checked)
            {
                STT1 = STT1 + 10;
            }
            else
            {
                STT1 = STT1 - 10;
            }
        }

        private void metroRadioButton3_CheckedChanged(object sender, EventArgs e)   //1-3
        {
            RadioButton rdobtn = (RadioButton)sender;
            if (rdobtn.Checked)
            {
                STT1 = STT1 + 20;
            }
            else
            {
                STT1 = STT1 - 20;
            }
           
        }

        private void metroRadioButton6_CheckedChanged(object sender, EventArgs e)   //2-1
        {
            RadioButton rdobtn = (RadioButton)sender;
            if (rdobtn.Checked)
            {
                STT2 = STT2 + 20;
            }
            else
            {
                STT2 = STT2 - 20;
            }
           
        }

        private void metroRadioButton9_CheckedChanged(object sender, EventArgs e)   //2-2
        {
            RadioButton rdobtn = (RadioButton)sender;
            if (rdobtn.Checked)
            {
                STT2 = STT2 + 30;
            }
            else
            {
                STT2 = STT2 - 30;
            }

            
        }

        private void metroRadioButton10_CheckedChanged(object sender, EventArgs e)  //2-3
        {
            RadioButton rdobtn = (RadioButton)sender;
            if (rdobtn.Checked)
            {
                STT2 = STT2 + 30;
            }
            else
            {
                STT2 = STT2 - 30;
            }
        }

        private void metroRadioButton7_CheckedChanged(object sender, EventArgs e)   //2-4
        {
            RadioButton rdobtn = (RadioButton)sender;
            if (rdobtn.Checked)
            {
                STT2 = STT2 + 10;
            }
            else
            {
                STT2 = STT2 - 10;
            }
            
        }

        private void metroRadioButton11_CheckedChanged(object sender, EventArgs e)  //3-1
        {
            RadioButton rdobtn = (RadioButton)sender;
            if (rdobtn.Checked)
            {
                STT3 = STT3 - 10;
            }
            else
            {
                STT3 = STT3 + 10;
            }
           
        }

        private void metroRadioButton14_CheckedChanged(object sender, EventArgs e)  //3-2
        {
            RadioButton rdobtn = (RadioButton)sender;
            if (rdobtn.Checked)
            {
                STT3 = STT3 - 20;
            }
            else
            {
                STT3 = STT3 + 20;
            }

            
        }

        private void metroRadioButton15_CheckedChanged(object sender, EventArgs e)  //3-3
        {
            RadioButton rdobtn = (RadioButton)sender;
            if (rdobtn.Checked)
            {
                STT3 = STT3 + 20;
            }
            else
            {
                STT3 = STT3 - 20;
            }

           
        }

        private void metroRadioButton12_CheckedChanged(object sender, EventArgs e)  //3-4
        {
            RadioButton rdobtn = (RadioButton)sender;
            if (rdobtn.Checked)
            {
                STT3 = STT3 + 10;
            }
            else
            {
                STT3 = STT3 - 10;
            }

           
        }

        private void metroRadioButton5_CheckedChanged(object sender, EventArgs e)   //4-1
        {
            RadioButton rdobtn = (RadioButton)sender;
            if (rdobtn.Checked)
            {
                STT1 += 10;
            }
            else
            {
                STT1 = STT1 + 10;
            }
            
        }

        private void metroRadioButton13_CheckedChanged(object sender, EventArgs e)  //4-2
        {
            RadioButton rdobtn = (RadioButton)sender;
            if (rdobtn.Checked)
            {
                STT2 = STT2 + 20;
            }
            else
            {
                STT2 = STT2 -20;
            }

           
        }

        private void metroRadioButton16_CheckedChanged(object sender, EventArgs e)  //4-3
        {
            RadioButton rdobtn = (RadioButton)sender;
            if (rdobtn.Checked)
            {
                STT3 = STT3 + 10;
            }
            else
            {
                STT3 = STT3 + 10;
            }

        }

        private void metroRadioButton8_CheckedChanged(object sender, EventArgs e)   //4-4
        {

            RadioButton rdobtn = (RadioButton)sender;
            if (rdobtn.Checked)
            {
                STT1 = STT1 + 10;
            }
            else
            {
                STT1 = STT1 - 10;
            }

        }
    }
}
 

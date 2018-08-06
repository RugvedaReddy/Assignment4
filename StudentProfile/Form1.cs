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

namespace StudentProfile
{
    public partial class Form1 : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader r = null;
        string constr = "Data Source=(local);Initial Catalog=StudentInfo;Integrated Security=True;Pooling=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblphonenumber_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //text box
            string RollNo = txtRollNo.Text;
            //combo box
            string Name = txtName.Text;
            //RADIOBUTTON
           // string DOJ = CbDOJ.SelectedItem.ToString();

            string gender = " ";
            if (rbMale.Checked)
                gender = rbMale.Text;
            if (rbFemale.Checked)
                gender = rbFemale.Text;
            string department= CbDepartment.SelectedItem.ToString();
            string course= CbCourse.SelectedItem.ToString();
            string semester=CbSemester.SelectedItem.ToString();
            string address = txtAddress.Text;
            string phonenumber = txtPhoneNumber.Text;
            //MessageBox.Show(RollNo + "\n" + Name + "\n" + DOJ + "\n" + gender + "\n" + department + "\n" + course+"\n"+semester+"\n"+address+"\n"+phonenumber);

            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "insert into StudentInfo values(@roll,@nm,@doj,@gen,@dpt,@course,@sem,@add,@phone)";//parameters to sql querry
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@roll", RollNo);
                cmd.Parameters.AddWithValue("@nm", Name);
                // cmd.Parameters.AddWithValue("@doj", DOJ);//("@date", SqlDbType.Date).Value = dtpdateof.Value.Date;
                cmd.Parameters.AddWithValue("@doj", SqlDbType.Date).Value = dtpDOJ.Value.Date;
                cmd.Parameters.AddWithValue("@gen", gender);
                cmd.Parameters.AddWithValue("@dpt", department);
                cmd.Parameters.AddWithValue("@course",course);
                cmd.Parameters.AddWithValue("@sem", semester);
                cmd.Parameters.AddWithValue("@add", address);
                cmd.Parameters.AddWithValue("@phone", phonenumber);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("data inserted:" + res);

            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }

        }

        private void txtRollNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
             try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "select*from StudentInfo";
                cmd = new SqlCommand(query, con);
                r = cmd.ExecuteReader();
                lbselect.Items.Clear();
                while(r.Read())
                {
                    for(int i=0;i<r.FieldCount;i++)
                    {
                        lbselect.Items.Add(r[i]);
                      


                    }
                    lbselect.Items.Add("*************");

                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //sem,phone,address can be updated
            try
            {
                string semester = CbSemester.SelectedItem.ToString();
                string address=txtAddress.Text;
                string phonenumber=txtPhoneNumber.Text;//just check as phonenumber is of int type
                
                
                con = new SqlConnection(constr);
                con.Open();
                string query = "update StudentInfo set Semester=@sem,Address=@addr,PhoneNumber=@pn";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@sem", semester);
                cmd.Parameters.AddWithValue("@addr", address);
                cmd.Parameters.AddWithValue("@pn", phonenumber);
                
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("DATA UPDATED:" + res);


            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string RollNo = txtRollNo.Text;
               // MessageBox.Show("ID IS:" + id);
                con = new SqlConnection(constr);
                con.Open();
                string query = "delete from StudentInfo where RollNo=@rn";
                cmd = new SqlCommand(query,con);
                cmd.Parameters.AddWithValue("@rn",RollNo);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("DATA DELETED" + res);
                //this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);

                
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }
        }

        private void rbFind_Click(object sender, EventArgs e)
        {
            try
            {
                int RollNo = int.Parse(txtRollNo.Text);
                con = new SqlConnection(constr);
                con.Open();
               
               
                string query = "select * from StudentInfo where RollNo=@roll";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@roll", RollNo);
                r = cmd.ExecuteReader();
                lbselect.Items.Clear();
                while (r.Read())
                {
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        lbselect.Items.Add(r[i]);



                    }
                    
                   /* txtName.Text = r["Name"].ToString();

                    dtpDOJ.Text = ((DateTime)r["DOJ"]).ToString();

                    if (r["gender"].ToString() == "male")

                    {

                        rbMale.Checked = true;

                    }

                    if (r["gender"].ToString() == "female")

                    {

                        rbFemale.Checked = true;

                    }

                    CbDepartment.SelectedItem = r["department"].ToString();

                    CbCourse.SelectedItem = r["course"].ToString();

                    CbSemester.SelectedItem = r["semester"].ToString();

                    txtAddress.Text = r["address"].ToString();

                   txtPhoneNumber.Text = r["phone"].ToString();*/

                    lbselect.Items.Add("************");

                }

            }

            catch (SqlException sql)

            {

                MessageBox.Show(sql.Message);

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }

            finally

            {

                con.Close();

            }
            }
            
            }

        }
    
    



        
    



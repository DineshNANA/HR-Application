using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;
using System.Collections;


namespace HR_Application
{

    public class Employee
    {
        static string connstr = "Data Source=CMBTRNDB02/APP8SP2;User ID=ifsapp;Password=ifsapp";
        OracleConnection conn = new OracleConnection(connstr);

        private string emp_id;
        private string emp_name;
        private string nic;
        private string contact;
        private string address;
        private string dep_name;
        private string email;
        private string gender;

        public string Emp_id
        {
            get { return emp_id; }
            set { emp_id = value; }
        }

        public string Emp_name
        {
            get { return emp_name; }
            set { emp_name = value; }
        }

        public string Nic
        {
            get { return nic; }
            set { nic = value; }
        }

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Dep_name
        {
            get { return dep_name; }
            set { dep_name = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public Employee()
        {

        }

        public Employee(string emp_id)
        {

            this.emp_id = emp_id;
        }


        //register Employee


        public void Emp_Register(
            string a_emp_name,
            string a_nic,
            string a_contact,
            string a_dep_id,
            string a_password,
            string a_email,
            string a_gender,
            string a_addresss,
            string a_status,
            string a_role_id
            )
        {
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("HR_REGISTER_EMPLOYEE", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter p1 = cmd.Parameters.Add("EMP_NAME", OracleDbType.Varchar2);
                cmd.Parameters["EMP_NAME"].Value = a_emp_name;
                p1.Direction = ParameterDirection.Input;

                OracleParameter p2 = cmd.Parameters.Add("NIC_NO", OracleDbType.Varchar2);
                cmd.Parameters["NIC_NO"].Value = a_nic;
                p2.Direction = ParameterDirection.Input;

                OracleParameter p3 = cmd.Parameters.Add("contact_no", OracleDbType.Varchar2);
                cmd.Parameters["contact_no"].Value = a_contact;
                p3.Direction = ParameterDirection.Input;

                OracleParameter p4 = cmd.Parameters.Add("dep_id", OracleDbType.Varchar2);
                cmd.Parameters["dep_id"].Value = a_dep_id;
                p4.Direction = ParameterDirection.Input;

                OracleParameter p5 = cmd.Parameters.Add("password_", OracleDbType.Varchar2);
                cmd.Parameters["password_"].Value = a_password;
                p5.Direction = ParameterDirection.Input;

                OracleParameter p6 = cmd.Parameters.Add("email", OracleDbType.Varchar2);
                cmd.Parameters["email"].Value = a_email;
                p6.Direction = ParameterDirection.Input;

                OracleParameter p7 = cmd.Parameters.Add("gender", OracleDbType.Varchar2);
                cmd.Parameters["gender"].Value = a_gender;
                p7.Direction = ParameterDirection.Input;

                OracleParameter p8 = cmd.Parameters.Add("address", OracleDbType.Varchar2);
                cmd.Parameters["address"].Value = a_addresss;
                p8.Direction = ParameterDirection.Input;

                OracleParameter p9 = cmd.Parameters.Add("status", OracleDbType.Varchar2);
                cmd.Parameters["status"].Value = a_status;
                p9.Direction = ParameterDirection.Input;

                OracleParameter p10 = cmd.Parameters.Add("role_id", OracleDbType.Varchar2);
                cmd.Parameters["role_id"].Value = a_role_id;
                p10.Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
            }

            catch (Exception e)
            {
                Console.WriteLine(e);

            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
                     
        }

        public ArrayList Get_Employee_list(string depid)
        {
            ArrayList emp_list = new ArrayList();
            try
            {
                conn.Open();
                

                OracleCommand cmd = new OracleCommand("HR_GET_EMPLOYEE_LIST", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter p1 = cmd.Parameters.Add("depid", OracleDbType.Varchar2);
                p1.Direction = ParameterDirection.Input;

                OracleParameter p2 = cmd.Parameters.Add("return_value", OracleDbType.RefCursor);
                p1.Direction = ParameterDirection.ReturnValue;

                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    emp_list.Add(dr[1].ToString());
                }
                dr.Close();

            }


            catch (Exception e)
            {
                Console.WriteLine(e);
            }
           
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
             
            return emp_list;

        }


        public ArrayList GetEmployeeList()
        {
            ArrayList empList = new ArrayList();

            try
            {
                conn.Open();

                OracleCommand command = new OracleCommand("HR_EMPLOYEE_DETAILS", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("return_value", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
                OracleDataReader objReader = command.ExecuteReader();

                while (objReader.Read())
                {
                    empList.Add(objReader["Emp_Id"].ToString() + " - " + objReader["Emp_Name"].ToString());
                }
                Console.WriteLine("Returning Employee list");
                objReader.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            finally
            {
                conn.Close();
            }
            return empList;
        }


        public ArrayList Get_Profile(string emp_id)
        {
            ArrayList emp_profile = new ArrayList();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("HR_EMP_PROFILE_FUNCTION", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter p1 = cmd.Parameters.Add("return_val", OracleDbType.RefCursor);
                p1.Direction = ParameterDirection.ReturnValue;

                OracleParameter p2 = cmd.Parameters.Add("a_empid", OracleDbType.Varchar2);
                cmd.Parameters["a_empid"].Value = emp_id;
                p2.Direction = ParameterDirection.Input;

               

                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                emp_profile.Add(dr[0].ToString());      //emp_id
                emp_profile.Add(dr[1].ToString());      //emp_name
                emp_profile.Add(dr[2].ToString());      //nic_no
                emp_profile.Add(dr[3].ToString());      //address
                emp_profile.Add(dr[4].ToString());      //contact_no
                emp_profile.Add(dr[5].ToString());      //designation
                emp_profile.Add(dr[6].ToString());      //depname
                emp_profile.Add(dr[7].ToString());      //department_location


                dr.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return emp_profile;
             
        }

        public void Edit_Profile(string emp_id,string emp_name,string dep_name,string address,string contact)
        {


        }

        public Int16 Employee_Login(string emp_id, string paswd, string roll)
        {
             
            conn.Open();
            OracleCommand cmd = new OracleCommand("HR_EMPLOYEE_LOGIN",conn);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter p1 = cmd.Parameters.Add("return_val",OracleDbType.Int16);
            p1.Direction = ParameterDirection.ReturnValue;


            OracleParameter p2 = cmd.Parameters.Add("a_emp_id", OracleDbType.Varchar2);
            cmd.Parameters["a_emp_id"].Value = emp_id;
            p2.Direction = ParameterDirection.Input;

            OracleParameter p3 = cmd.Parameters.Add("a_paswd", OracleDbType.Varchar2);
            cmd.Parameters["a_paswd"].Value = paswd;
            p3.Direction = ParameterDirection.Input;

            OracleParameter p4 = cmd.Parameters.Add("a_role", OracleDbType.Varchar2);
            cmd.Parameters["a_role"].Value = roll;
            p4.Direction = ParameterDirection.Input;
            
            cmd.ExecuteNonQuery();

            Int16 num =Convert.ToInt16( cmd.Parameters["return_val"].Value.ToString());
            return num;
        }

        public ArrayList Get_Profile()
        {
            ArrayList emp_profile = new ArrayList();
            string emp_id = this.emp_id;
            try
            {
                Console.WriteLine("Connection opens");
                conn.Open();
                OracleCommand cmd = new OracleCommand("HR_EMP_PROFILE_FUNCTION", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter p1 = cmd.Parameters.Add("return_val", OracleDbType.RefCursor);
                p1.Direction = ParameterDirection.ReturnValue;

                OracleParameter p2 = cmd.Parameters.Add("a_empid", OracleDbType.Varchar2);
                cmd.Parameters["a_empid"].Value = emp_id;
                p2.Direction = ParameterDirection.Input;

              

                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                emp_profile.Add(dr[0].ToString());      //emp_id
                emp_profile.Add(dr[1].ToString());      //emp_name
                emp_profile.Add(dr[2].ToString());      //nic_no
                emp_profile.Add(dr[3].ToString());      //address
                emp_profile.Add(dr[4].ToString());      //contact_no
                emp_profile.Add(dr[5].ToString());      //designation
                emp_profile.Add(dr[6].ToString());      //depname
                emp_profile.Add(dr[7].ToString());      //department_location


                dr.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return emp_profile;

        }



        
    }
}

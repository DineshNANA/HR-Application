using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;


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
        private string designation;
        private string sex;

        //public Employee()
        //{

        //}

        public void Emp_Register(
            string a_emp_name,
            string a_nic,
            string a_contact,
            string a_address,
            string a_designation,
            string a_dep_id,
            string a_password)
        {
            
            conn.Open();
            OracleCommand cmd = new OracleCommand("REGISTER_EMPLOYEE", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter p1 = cmd.Parameters.Add("EMP_NAME", OracleDbType.Varchar2);
            cmd.Parameters["EMP_NAME"].Value = a_emp_name;
            p1.Direction = ParameterDirection.Input;

            OracleParameter p2 = cmd.Parameters.Add("NIC_NO", OracleDbType.Varchar2);
            cmd.Parameters["NIC_NO"].Value = a_nic;
            p2.Direction = ParameterDirection.Input;

            OracleParameter p3 = cmd.Parameters.Add("ADDRESS", OracleDbType.Varchar2);
            cmd.Parameters["ADDRESS"].Value = a_address;
            p3.Direction = ParameterDirection.Input;

            OracleParameter p4 = cmd.Parameters.Add("CONTACT_NO", OracleDbType.Varchar2);
            cmd.Parameters["CONTACT_NO"].Value = a_contact;
            p4.Direction = ParameterDirection.Input;

            OracleParameter p5 = cmd.Parameters.Add("DESIGNATION", OracleDbType.Varchar2);
            cmd.Parameters["DESIGNATION"].Value = a_designation;
            p5.Direction = ParameterDirection.Input;

            OracleParameter p6 = cmd.Parameters.Add("DEP_ID", OracleDbType.Varchar2);
            cmd.Parameters["DEP_ID"].Value = a_dep_id;
            p6.Direction = ParameterDirection.Input;

            OracleParameter p7 = cmd.Parameters.Add("PASSWORD", OracleDbType.Varchar2);
            cmd.Parameters["PASSWORD"].Value = a_password;
            p7.Direction = ParameterDirection.Input;

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public OracleDataReader Get_Employee_list(string dep_id)
        {
          
            conn.Open();
            OracleCommand cmd = new OracleCommand("HR_GET_EMPLOYEE_LIST", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter p1 = cmd.Parameters.Add("depid", OracleDbType.Varchar2);
            p1.Direction = ParameterDirection.Input;

            OracleParameter p2 = cmd.Parameters.Add("return_value", OracleDbType.RefCursor);
            p1.Direction = ParameterDirection.ReturnValue;

            OracleDataReader dr = cmd.ExecuteReader();
            conn.Close();
            return dr;

        }

        public OracleDataReader Get_Profile()
        {
          
            conn.Open();
            OracleCommand cmd = new OracleCommand("HR_EMP_PROFILE_FUNCTION", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter p1 = cmd.Parameters.Add("empid", OracleDbType.Varchar2);
            p1.Direction = ParameterDirection.Input;

            OracleParameter p2 = cmd.Parameters.Add("return_val", OracleDbType.RefCursor);
            p2.Direction = ParameterDirection.ReturnValue;

            OracleDataReader dr = cmd.ExecuteReader();
            conn.Close();
            return dr; 
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



        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace HR_Application
{
    class DepartmentClass
    {
        string connstr = "Data Source=CMBTRNDB02/APP8SP2;User ID=ifsapp;Password=ifsapp";

        

        public void Register_Department(
            string a_dep_name,
            string a_address,
            string a_dep_head
            )

        {
            OracleConnection conn = new OracleConnection(connstr);
            conn.Open();
            OracleCommand cmd = new OracleCommand("HR_REGISTER_DEPARTMENT",conn);
            cmd.CommandType = CommandType.StoredProcedure;


            OracleParameter p1 = cmd.Parameters.Add("DEP_NAME", OracleDbType.Varchar2);
            cmd.Parameters["DEP_NAME"].Value = a_dep_name;
            p1.Direction = ParameterDirection.Input;


            OracleParameter p2 = cmd.Parameters.Add("ADDRESS", OracleDbType.Varchar2);
            cmd.Parameters["ADDRESS"].Value = a_dep_name;
            p1.Direction = ParameterDirection.Input;

            OracleParameter p3 = cmd.Parameters.Add("DEP_HEAD", OracleDbType.Varchar2);
            cmd.Parameters["DEP_HEAD"].Value = a_dep_name;
            p1.Direction = ParameterDirection.Input;

            cmd.ExecuteNonQuery();
  
        }

        public OracleDataReader Get_Department_list()
        {
            OracleConnection conn = new OracleConnection(connstr);
            conn.Open();
            OracleCommand cmd = new OracleCommand("HR_GET_DEPARTMENT_DETAILS", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter p1 = cmd.Parameters.Add("return_value", OracleDbType.RefCursor);
            p1.Direction = ParameterDirection.ReturnValue;
           // OracleDbType db = cmd.Parameters["return_value"].Value;
            OracleDataReader objReader = cmd.ExecuteReader();
            return objReader;

            
        }

        

    }

    
}

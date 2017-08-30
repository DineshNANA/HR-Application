using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace HR_Application
{
    class Role_Class
    {
        OracleConnection conn = Connection.Main();

        public ArrayList Get_Role_Details()
        {
            conn.Open();
            ArrayList restl = new ArrayList();
            OracleCommand cmd = new OracleCommand("HR_GET_ROLE_DETAILS", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleParameter p1 = cmd.Parameters.Add("return_val", OracleDbType.RefCursor);
            p1.Direction = ParameterDirection.ReturnValue;
            OracleDataReader dr = cmd.ExecuteReader();

            while(dr.Read()){

                restl.Add(dr[1].ToString());

            }
            conn.Close();
            return restl;
        }


        public ArrayList GetRoleDetails()
        {
            conn.Open();
            ArrayList restl = new ArrayList();
            OracleCommand cmd = new OracleCommand("HR_GET_ROLE_DETAILS", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleParameter p1 = cmd.Parameters.Add("return_val", OracleDbType.RefCursor);
            p1.Direction = ParameterDirection.ReturnValue;
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                restl.Add(dr["Role_ID"].ToString()+"-"+ dr["ROLE_NAME"].ToString());

            }
            conn.Close();
            return restl;

        }

    }

}

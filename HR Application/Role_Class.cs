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
        OracleConnection connection = Connection.Main();

        public ArrayList Get_Role_Details()
        {
            connection.Open();
            ArrayList restl = new ArrayList();
            OracleCommand cmd = new OracleCommand("HR_GET_ROLE_DETAILS", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleParameter p1 = cmd.Parameters.Add("return_val", OracleDbType.RefCursor);
            p1.Direction = ParameterDirection.ReturnValue;
            OracleDataReader dr = cmd.ExecuteReader();

            while(dr.Read()){

                restl.Add(dr[1].ToString());

            }
            connection.Close();
            return restl;
        }

        public ArrayList GetRoleList()
        {
            ArrayList roleList = new ArrayList();

            try
            {
                connection.Open();

                OracleCommand command = new OracleCommand("HR_GET_ROLE_DETAILS", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("return_value", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
                OracleDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    roleList.Add(dataReader["Role_Id"].ToString() + " - " + dataReader["Role_Name"].ToString());
                }
            }

            catch (Exception e) { Console.WriteLine(e.Message); }

            finally { connection.Close(); }

            return roleList;
        }

    }

}

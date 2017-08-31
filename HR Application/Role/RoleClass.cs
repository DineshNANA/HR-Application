using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace HR_Application.Role
{
    class RoleClass
    {
        OracleConnection connection = Connection.Main();


        public void AddRole(string roleName, string roleDescription)
        {
            try
            {
                connection.Open();
                OracleCommand command = new OracleCommand("HR_ROLE_CREATE", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("Role_Name", OracleDbType.Varchar2, roleName, ParameterDirection.Input);
                command.Parameters.Add("Role_Description", OracleDbType.Varchar2, roleDescription, ParameterDirection.Input);
                command.ExecuteNonQuery();
            }

            catch (Exception e) { Console.WriteLine(e.Message); }

            finally
            {
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }
        }

        public ArrayList GetRoleList()
        {
            ArrayList roleList = new ArrayList();

            try
            {
                connection.Open();
                OracleCommand command = new OracleCommand("HR_GET_ROLE_DETAILS", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("return_val", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
                OracleDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read()) { roleList.Add(dataReader["Role_Name"].ToString()); }
                dataReader.Close();
            }

            catch (Exception e) { Console.WriteLine(e.Message); }

            finally
            {
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }

            return roleList;
        }

    }

}

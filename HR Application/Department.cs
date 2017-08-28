using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;
using System.Windows.Forms;

namespace HR_Application
{
    class Department
    {
        string connectionString = "Data Source=CMBTRNDB02/APP8SP2;User ID=ifsapp;Password=ifsapp";
        
        public void createDepartment(string depId, string depName, string address)
        {
            OracleConnection connection = new OracleConnection(connectionString);
            
            try
            {
                connection.Open();

                OracleCommand command = new OracleCommand("CREATE_DEPARTMENT", connection);
                command.BindByName = true;
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("Dep_Id", OracleDbType.Varchar2, depId, ParameterDirection.Input);
                command.Parameters.Add("Dep_Name", OracleDbType.Varchar2, depName, ParameterDirection.Input);
                command.Parameters.Add("Address", OracleDbType.Varchar2, address, ParameterDirection.Input);

                command.ExecuteNonQuery();
                Console.WriteLine("I'm here");
            }
            
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}

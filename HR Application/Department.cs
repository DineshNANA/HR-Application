using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace HR_Application
{
    class Department
    {
        OracleConnection connection = Connection.Main();
        
        public void createDepartment(string depId, string depName, string address, string depHead)
        {
            try
            {
                connection.Open();

                OracleCommand command = new OracleCommand("HR_DEPARTMENT_CREATE", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("Dep_Id", OracleDbType.Varchar2, depId, ParameterDirection.Input);
                command.Parameters.Add("Dep_Name", OracleDbType.Varchar2, depName, ParameterDirection.Input);
                command.Parameters.Add("Address", OracleDbType.Varchar2, address, ParameterDirection.Input);
                command.Parameters.Add("Dep_Head", OracleDbType.Varchar2, depHead, ParameterDirection.Input);

                command.ExecuteNonQuery();
                Console.WriteLine("Successfully added a Department");
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


        public void editDetails(string depId, string depName, string address, string depHead)
        {
            try
            {
                connection.Open();

                OracleCommand command = new OracleCommand("HR_DEPARTMENT_EDIT", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("Dep_Id", OracleDbType.Varchar2, depId, ParameterDirection.Input);
                command.Parameters.Add("Dep_Name", OracleDbType.Varchar2, depName, ParameterDirection.Input);
                command.Parameters.Add("Address", OracleDbType.Varchar2, address, ParameterDirection.Input);
                command.Parameters.Add("Dep_Head", OracleDbType.Varchar2, depHead, ParameterDirection.Input);

                command.ExecuteNonQuery();
                Console.WriteLine("Successfully updated Department details");
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


        public void deleteDepartment(string depId)
        {
            try
            {
                connection.Open();

                OracleCommand command = new OracleCommand("HR_DEPARTMENT_DELETE", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("Dep_Id", OracleDbType.Varchar2, depId, ParameterDirection.Input);

                command.ExecuteNonQuery();
                Console.WriteLine("Successfully deleted Department");
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            finally
            {
                connection.Close();
            }
        }


        public ArrayList getDepartmentList()
        {
            ArrayList results = new ArrayList();

            try
            {
                connection.Open();

                OracleCommand command = new OracleCommand("HR_GET_DEPARTMENT_DETAILS", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("return_value", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
                OracleDataReader objReader = command.ExecuteReader();

                while (objReader.Read())
                {
                    results.Add(objReader["Dep_Name"].ToString());
                }
                Console.WriteLine("Returning Department list");
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            finally
            {
                connection.Close();
            }

            return results;
        }





    }
}

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
        
        public string createDepartment(string depId, string depName, string address, string depHead)
        {
            string result;
            Console.WriteLine(depHead);

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
                result = "Success";
            }
            
            catch (Exception e)
            {
                Console.WriteLine(e);
                result = "Failed";
            }
            
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return result;
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


        public string deleteDepartment(string depId)
        {
            string result;

            try
            {
                connection.Open();

                OracleCommand command = new OracleCommand("HR_DEPARTMENT_DELETE", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("Dep_Id", OracleDbType.Varchar2, depId, ParameterDirection.Input);

                command.ExecuteNonQuery();
                result = "Success";
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                result = "Failed";
            }

            finally
            {
                connection.Close();
            }
            return result;
        }

        public ArrayList Get_Employee_list(string depid)
        {
            ArrayList emp_list = new ArrayList();
            try
            {
                connection.Open();
               
                OracleCommand cmd = new OracleCommand("HR_GET_EMPLOYEE_LIST", connection);
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
                
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return emp_list;
             
        }

        public ArrayList getDepartmentList()
        {
            ArrayList depList = new ArrayList();

            try
            {
                connection.Open();

                OracleCommand command = new OracleCommand("HR_GET_DEPARTMENT_DETAILS", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("return_value", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
                OracleDataReader objReader = command.ExecuteReader();

                while (objReader.Read())
                {
                    depList.Add(objReader["Dep_Id"].ToString() + " - " + objReader["Dep_Name"].ToString());
                }
                objReader.Close();
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

            return depList;
        }

        public List<Employee> GetEmployeeList(string depId)
        {
            List<Employee> depEmpList = new List<Employee>();

            try
            {
                connection.Open();

                OracleCommand command = new OracleCommand("HR_EMPLOYEE_LIST", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("employee_list", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
                command.Parameters.Add("dep_id", OracleDbType.Varchar2, depId, ParameterDirection.Input);
                OracleDataReader objReader = command.ExecuteReader();

                while (objReader.Read())
                {
                    Employee newEmployee = new Employee();
                    newEmployee.Emp_id = objReader["Emp_Id"].ToString();
                    newEmployee.Emp_name = objReader["Emp_Name"].ToString();
                    newEmployee.Nic = objReader["NIC_No"].ToString();
                    newEmployee.Address = objReader["Address"].ToString();
                    newEmployee.Contact = objReader["Contact_No"].ToString();
                    newEmployee.Designation = objReader["Designation"].ToString();
                    newEmployee.Dep_name = objReader["Dep_Id"].ToString();
                    depEmpList.Add(newEmployee);
                }
                Console.WriteLine("Returning list of Employee objects");
            }

            catch (Exception e) { Console.WriteLine(e.Message); }

            finally { connection.Close(); }

            return depEmpList;
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using System.Data;
using System.Collections;

namespace HR_Application
{
    class Task
    {
        OracleConnection connection = Connection.Main();

        private string taskId;
        private string taskName;
        private int maxEmployees;
        private string depId;
        private string status;

        public string TaskId
        {
            get { return this.taskId; }
            set { this.taskId = value; }
        }

        public string TaskName
        {
            get { return this.taskName; }
            set { this.taskName = value; }
        }

        public int MaxEmployees
        {
            get { return this.maxEmployees; }
            set { this.maxEmployees = value; }
        }

        public string DepId
        {
            get { return this.depId; }
            set { this.depId = value; }
        }

        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }


        public void CreateTask(string taskName, decimal maxEmployees, string depId, string status)
        {
            try
            {
                connection.Open();

                OracleCommand command = new OracleCommand("HR_TASK_CREATE", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("Task_Name", OracleDbType.Varchar2, taskName, ParameterDirection.Input);
                command.Parameters.Add("Max_Employees", OracleDbType.Decimal, maxEmployees, ParameterDirection.Input);
                command.Parameters.Add("Dep_Id", OracleDbType.Varchar2, depId, ParameterDirection.Input);
                command.Parameters.Add("Status", OracleDbType.Varchar2, status, ParameterDirection.Input);

                command.ExecuteNonQuery();
            }

            catch (Exception e) { Console.WriteLine(e.Message); }

            finally
            {
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }
        }


        public List<Task> GetTaskList()
        {
            List<Task> taskList = new List<Task>();

            try
            {
                connection.Open();

                OracleCommand command = new OracleCommand("HR_TASK_LIST", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("task_list", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
                OracleDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Task newTask = new Task();
                    newTask.TaskId = dataReader["Task_Id"].ToString();
                    newTask.TaskName = dataReader["Task_Name"].ToString();
                    // newTask.MaxEmployees = (int) dataReader["Max_Employees"];
                    newTask.DepId = dataReader["Dep_Id"].ToString();
                    newTask.Status = dataReader["Status"].ToString();
                    Console.WriteLine(newTask.TaskId);
                    taskList.Add(newTask);
                }

                dataReader.Close();
                Console.WriteLine("Returning Task list for all Departments");
            }

            catch (Exception e) { Console.WriteLine(e); }

            finally
            {
                if(connection.State == ConnectionState.Open) { connection.Close(); }
            }

            return taskList;
        }


        public List<Task> GetTaskList(string depId)
        {
            List<Task> depTaskList = new List<Task>();

            try
            {
                connection.Open();

                OracleCommand command = new OracleCommand("HR_DEPARTMENT_TASK_LIST", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("department_task_list", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
                command.Parameters.Add("Dep_Id", OracleDbType.Varchar2, depId, ParameterDirection.Input);
                OracleDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Task newTask = new Task();
                    newTask.TaskId = dataReader["Task_Id"].ToString();
                    newTask.TaskName = dataReader["Task_Name"].ToString();
                    // newTask.MaxEmployees = (int) dataReader["Max_Employees"];
                    newTask.DepId = dataReader["Dep_Id"].ToString();
                    newTask.Status = dataReader["Status"].ToString();
                    depTaskList.Add(newTask);
                }

                dataReader.Close();
                Console.WriteLine("Returning Task list for a Department");
            }

            catch (Exception e) { Console.WriteLine(e); }

            finally
            {
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }

            return depTaskList;
        }


        public ArrayList GetTask(string taskId)
        {
            ArrayList taskDetails = new ArrayList();
            OracleDataReader dataReader;

            try
            {
                connection.Open();

                OracleCommand command = new OracleCommand("HR_TASK_GET", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("task_details", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
                command.Parameters.Add("task_id", OracleDbType.Varchar2, taskId, ParameterDirection.Input);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Task task = new Task();
                    task.TaskId = dataReader["Task_Id"].ToString();
                    task.TaskName = dataReader["Task_Name"].ToString();
                    task.MaxEmployees = (int) dataReader["Max_Employees"];
                    task.DepId = dataReader["Dep_Id"].ToString();
                    task.Status = dataReader["Status"].ToString();
                    taskDetails.Add(task);
                }
                Console.WriteLine("Returning details of a Task");
            }

            catch (Exception e) { Console.WriteLine(e.Message); }

            finally { connection.Close(); }

            return taskDetails;
        }


        public void EditTask(string taskId, string taskName, decimal maxEmployees, string depId, string status)
        {
            try
            {
                connection.Open();

                OracleCommand command = new OracleCommand("HR_TASK_EDIT", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("Task_Id", OracleDbType.Varchar2, taskId, ParameterDirection.Input);
                command.Parameters.Add("Task_Name", OracleDbType.Varchar2, taskName, ParameterDirection.Input);
                command.Parameters.Add("Max_Employees", OracleDbType.Decimal, maxEmployees, ParameterDirection.Input);
                command.Parameters.Add("Dep_Id", OracleDbType.Varchar2, depId, ParameterDirection.Input);
                command.Parameters.Add("Status", OracleDbType.Varchar2, status, ParameterDirection.Input);

                command.ExecuteNonQuery();
            }

            catch (Exception e) { Console.WriteLine(e.Message); }

            finally
            {
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }
        }


        public ArrayList GetEmployList(string task_id,string dep_id)
        {
            ArrayList employ_id_list = new ArrayList();
            try
            {
                connection.Open();

                OracleCommand cmd = new OracleCommand("HR_GET_EMPLOYEE_ASSIGN_TASK", connection);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter p1 = cmd.Parameters.Add("return_val", OracleDbType.RefCursor);
                p1.Direction = ParameterDirection.ReturnValue;

                OracleParameter p2 = cmd.Parameters.Add("task_id", OracleDbType.Varchar2);
                cmd.Parameters["task_id"].Value = task_id;
                p2.Direction = ParameterDirection.Input;

                OracleParameter p3 = cmd.Parameters.Add("a_dep_id", OracleDbType.Varchar2);
                cmd.Parameters["a_dep_id"].Value = dep_id;
                p3.Direction = ParameterDirection.Input;

                OracleDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    employ_id_list.Add(dataReader[0].ToString()+" - "+dataReader[1].ToString());
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }


            return employ_id_list;
        }


        public void Assign_Employee(string task_id, string emp_id)
        {

            connection.Open();

            OracleCommand cmd = new OracleCommand("HR_ASSIGN_EMPLOYEES", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter p1 = cmd.Parameters.Add("a_task_id", OracleDbType.Varchar2);
            cmd.Parameters["a_task_id"].Value = task_id;
            p1.Direction = ParameterDirection.Input;

            OracleParameter p2 = cmd.Parameters.Add("a_emp_id", OracleDbType.Varchar2);
            cmd.Parameters["a_emp_id"].Value = emp_id;
            p2.Direction = ParameterDirection.Input;

            cmd.ExecuteNonQuery();


        }



    }
}

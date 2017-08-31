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


        public void CreateTask(string taskId, string taskName, decimal maxEmployees, string depId, string status)
        {
            try
            {
                connection.Open();

                OracleCommand command = new OracleCommand("HR_TASK_CREATE", connection);
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


        public ArrayList GetTaskList()
        {
            ArrayList taskList = new ArrayList();

            try
            {
                connection.Open();

                OracleCommand command = new OracleCommand("HR_TASK_LIST", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("task_list", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
                Console.WriteLine("I'm here");
                OracleDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    taskList.Add(dataReader["Task_Id"].ToString() + " - " + dataReader["Task_Name"].ToString());
                }

                dataReader.Close();
                Console.WriteLine("Returning Task list");
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            finally
            {
                if(connection.State == ConnectionState.Open) { connection.Close(); }
            }

            return taskList;
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
                    Task newTask = new Task();
                    newTask.TaskId = dataReader["Task_Id"].ToString();
                    newTask.TaskName = dataReader["Task_Name"].ToString();
                    newTask.MaxEmployees = (int) dataReader["Max_Employees"];
                    newTask.DepId = dataReader["Dep_Id"].ToString();
                    newTask.Status = dataReader["Status"].ToString();
                    taskDetails.Add(newTask);
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

    }
}

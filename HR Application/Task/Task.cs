using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using System.Data;

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
            { connection.Close(); }
        }
    }
}

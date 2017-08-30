CREATE OR REPLACE PROCEDURE hr_task_create(
       taskId IN VARCHAR2, taskName IN VARCHAR2, maxEmp IN NUMBER, depId IN VARCHAR2, status IN VARCHAR2) IS
BEGIN
  INSERT INTO HR_Task(task_id, task_name, max_employees, dep_id, status)
  VALUES (taskId, taskName, maxEmp, depId, status);
END hr_task_create;
/

CREATE OR REPLACE PROCEDURE hr_task_create(
       taskId IN VARCHAR2, taskName IN VARCHAR2, maxEmp IN NUMBER, depId IN VARCHAR2, status IN VARCHAR2) IS
BEGIN
  INSERT INTO HR_Task(task_id, task_name, max_employees, dep_id, status)
  VALUES (taskId, taskName, maxEmp, depId, status);
END hr_task_create;
/


CREATE OR REPLACE FUNCTION hr_task_list
RETURN SYS_REFCURSOR IS task_list SYS_REFCURSOR;
BEGIN
  OPEN task_list FOR
  SELECT * FROM HR_Task;
  RETURN task_list;
END hr_task_list;
/


CREATE OR REPLACE FUNCTION hr_department_task_list(depId IN VARCHAR2)
RETURN SYS_REFCURSOR IS department_task_list SYS_REFCURSOR;
BEGIN
  OPEN department_task_list FOR
  SELECT * FROM HR_Task
  WHERE dep_id = depId;
  RETURN department_task_list;
END hr_department_task_list;


CREATE OR REPLACE FUNCTION hr_task_get (taskId IN VARCHAR2)
RETURN SYS_REFCURSOR IS task_details SYS_REFCURSOR;
BEGIN
  OPEN task_details FOR
  SELECT * FROM HR_Task
  WHERE task_id = taskId;
  RETURN task_details;
END hr_task_get;
/


CREATE OR REPLACE PROCEDURE hr_task_edit(
       taskId IN VARCHAR2, taskName IN VARCHAR2, maxEmp IN NUMBER, depId IN VARCHAR2, status_new IN VARCHAR2) IS
BEGIN
  UPDATE HR_Task
  SET task_name = taskName, max_employees = maxEmp, dep_id = depId, status = status_new
  WHERE task_id = taskId;
END hr_task_edit;
/


CREATE OR REPLACE FUNCTION hr_department_task_assignment(taskId IN VARCHAR2)
RETURN SYS_REFCURSOR IS hr_dep_task_assignment_list SYS_REFCURSOR;
BEGIN
OPEN hr_dep_task_assignment_list 
FOR SELECT e.emp_id, e.emp_name FROM hr_employee e
JOIN hr_task_assignment a ON e.emp_id = a.emp_id
WHERE task_id = taskId;
RETURN hr_dep_task_assignment_list;
END hr_department_task_assignment;
/


CREATE OR REPLACE PROCEDURE hr_task_assignment_delete(
taskId IN VARCHAR2, empId IN VARCHAR2) AS
BEGIN
  DELETE FROM HR_Task_Assignment WHERE task_id = taskId AND emp_id = empId;
END;
/

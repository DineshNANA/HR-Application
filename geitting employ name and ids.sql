CREATE OR REPLACE FUNCTION HR_GET_EMPLOYEE_ASSIGN_TASK(a_task_id IN VARCHAR2,a_dep_id IN VARCHAR2)
RETURN SYS_REFCURSOR
IS 
result_set SYS_REFCURSOR;

BEGIN 
  
open result_set for select emp_id, emp_name from HR_EMPLOYEE where dep_id = a_dep_id and emp_id NOT IN (select emp_id from HR_TASK_ASSIGNMENT where TASK_id = a_task_id);
  
  
  RETURN result_set; 
  
END HR_GET_EMPLOYEE_ASSIGN_TASK;


 

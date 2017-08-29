CREATE OR REPLACE PROCEDURE register_employee(
       emp_id IN VARCHAR2, emp_name IN VARCHAR2, nic_no IN VARCHAR2, address IN VARCHAR2, contact_no IN VARCHAR2, designation IN VARCHAR2, dep_id IN VARCHAR2) IS 

BEGIN
       INSERT INTO HR_Employee VALUES(emp_id, emp_name, nic_no, address, contact_no, designation, dep_id);
END register_employee;
/


CREATE OR REPLACE FUNCTION get_all_employees
RETURN HR_Employee%ROWTYPE
IS temp_row HR_Employee%ROWTYPE;

BEGIN
   SELECT * INTO temp_row FROM HR_Employee;
   RETURN temp_row;
END get_all_employees;
/


CREATE OR REPLACE PROCEDURE change_department(empId IN VARCHAR2, depId IN VARCHAR2)
IS

BEGIN
   UPDATE HR_Employee
   SET dep_id = depId
   WHERE emp_id = empId;
END;
/


CREATE OR REPLACE PROCEDURE assign_task(empId IN VARCHAR2, taskId IN VARCHAR2)
IS

BEGIN
   INSERT INTO HR_Task_Assignment(task_id, emp_id)
   VALUES (empId, taskId);
END;
/


CREATE OR REPLACE PROCEDURE edit_details(
    empId IN VARCHAR2, emp_name_new IN VARCHAR2, nic_no_new IN VARCHAR2, address_new IN VARCHAR2, contact_no_new IN VARCHAR2, designation_new IN VARCHAR2, dep_id_new IN VARCHAR2) IS

BEGIN
   UPDATE HR_Employee
   SET emp_name = emp_name_new, nic_no = nic_no_new, address = address_new, contact_no = contact_no_new, designation = designation_new, dep_id = dep_id_new
   WHERE emp_id = empId;
END;
/


CREATE OR REPLACE PROCEDURE change_status(empId IN VARCHAR2, status_new IN VARCHAR2)
IS

BEGIN
   UPDATE HR_Employee
   SET status = status_new
   WHERE emp_id = empId;
END;
/


CREATE OR REPLACE FUNCTION hr_employee_details
RETURN SYS_REFCURSOR IS employee_list SYS_REFCURSOR;
BEGIN
  OPEN employee_list FOR SELECT emp_id, emp_name FROM HR_Employee;
  RETURN employee_list;
END hr_employee_details;

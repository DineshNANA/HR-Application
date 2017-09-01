CREATE OR REPLACE PROCEDURE hr_department_create(
    depId IN VARCHAR2, depName IN VARCHAR2, address IN VARCHAR2, depHead IN VARCHAR2) AS
BEGIN
    INSERT INTO HR_Department(Dep_Id, Dep_Name, Address, Dep_Head)
    VALUES (depId, depName, address, depHead);
    COMMIT;
END hr_department_create;
/


CREATE OR REPLACE PROCEDURE hr_department_edit(
       depId IN VARCHAR2, dep_name_new IN VARCHAR2, address_new IN VARCHAR2, depHead_new IN VARCHAR2) AS
BEGIN
  UPDATE HR_Department
  SET dep_name = dep_name_new, address = address_new, dep_head = depHead_new
  WHERE dep_id = depId;
  COMMIT;
END hr_department_edit;
/


CREATE OR REPLACE PROCEDURE hr_department_delete(depId IN VARCHAR2) AS
BEGIN
  DELETE FROM HR_Department
  WHERE Dep_Id = DepID;
  COMMIT;
END hr_department_delete;
/


CREATE OR REPLACE FUNCTION get_all_dep_employees(depId IN VARCHAR2)
RETURN HR_Employee%ROWTYPE
IS temp_row HR_Employee%ROWTYPE;

BEGIN
   SELECT * INTO temp_row FROM HR_Employee WHERE dep_id = depId;
   RETURN temp_row;
END get_all_dep_employees;
/


CREATE OR REPLACE FUNCTION hr_employee_list(depId IN VARCHAR2)
RETURN SYS_REFCURSOR IS employee_list SYS_REFCURSOR;
BEGIN
  OPEN employee_list FOR SELECT * FROM HR_Employee WHERE dep_id = depId;
  RETURN employee_list;
END hr_employee_list;
/


CREATE OR REPLACE FUNCTION hr_department_get (depId IN VARCHAR2)
RETURN SYS_REFCURSOR IS department_details SYS_REFCURSOR;
BEGIN
  OPEN department_details FOR
  SELECT * FROM HR_Department
  WHERE dep_id = depId;
  RETURN department_details;
END hr_department_get;
/

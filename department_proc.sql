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
END  hr_department_edit;
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

CREATE OR REPLACE PROCEDURE create_department(
    depId IN VARCHAR2, depName IN VARCHAR2, address IN VARCHAR2) AS
BEGIN
    INSERT INTO HR_Department(Dep_Id, Dep_Name, Address)
    VALUES (depId, depName, address);
END create_department;
/


CREATE OR REPLACE PROCEDURE edit_dep_details(
       depId IN VARCHAR2, dep_name_new IN VARCHAR2, address_new IN VARCHAR2, depHead_new IN VARCHAR2) AS
BEGIN
  UPDATE HR_Department
  SET dep_name = dep_name_new, address = address_new, dep_head = depHead_new
  WHERE dep_id = depId;
END;
/


CREATE OR REPLACE FUNCTION get_all_dep_employees(depId IN VARCHAR2)
RETURN HR_Employee%ROWTYPE
IS temp_row HR_Employee%ROWTYPE;

BEGIN
   SELECT * INTO temp_row FROM HR_Employee WHERE dep_id = depId;
   RETURN temp_row;
END get_all_dep_employees;
/

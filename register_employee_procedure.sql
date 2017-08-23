CREATE OR REPLACE PROCEDURE register_employee(
       
       emp_name IN VARCHAR2, 
       nic_no IN VARCHAR2, 
       address IN VARCHAR2, 
       contact_no IN VARCHAR2, 
       designation IN VARCHAR2, 
       dep_id IN VARCHAR2) 
IS

emp_ide VARCHAR2(3);

BEGIN
       emp_ide := TO_CHAR(HR_EMP_ID.nextval);
       INSERT INTO HR_Employee VALUES(
       'EMP'||emp_ide, 
       emp_name, 
       nic_no, 
       address, 
       contact_no, 
       designation, 
       dep_id);
       

END register_employee;

/*create sequence HR_EMP_ID NOCACHE start with 101;

select * from HR_EMPLOYEE
BEGIN 
  register_employee('Dinesh Nanayakkara','931413584V','Galle','0742514963','Manager','DEP1');
end;
*/

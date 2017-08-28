CREATE OR REPLACE FUNCTION HR_EMPLOYEE_LOGIN(
a_emp_id IN VARCHAR2, 
a_paswd IN VARCHAR2,
a_role IN VARCHAR2 )
RETURN NUMBER
as
 
e_count Number;
role_match Number;
rol_id varchar2(6);

BEGIN 
  
  select count(*) into e_count from HR_EMPLOYEE where  EMP_ID = a_emp_id and PASSWORD = a_paswd;
  select ROLE_ID into rol_id from HR_ROLE where ROLE_NAME = a_role;
 
  if e_count =1 then
     select Count(*) into role_match from HR_EMPLOYEE_ROLE where ROLE_ID = rol_id and EMP_id = a_emp_id;
     if role_match = 1 then
        return 1;
     else 
       return 0;
     end if;
  
  else 
    return -1;
  end if;
end HR_EMPLOYEE_LOGIN;
    
/*Declare
numre Number;
BEGIN 
  numre := HR_EMPLOYEE_LOGIN('EMP118','DINESH','User');
  dbms_output.put_line(numre);
END;
 */

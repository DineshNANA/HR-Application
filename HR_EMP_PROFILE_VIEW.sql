create or replace view HR_EMP_PROFILE as
    select  e.emp_id,e.emp_name,e.nic_no,e.address,e.contact_no,e.designation,d.dep_name,d.address as D_location
    from   HR_EMPLOYEE e
           join
           HR_DEPARTMENT d
           on (e.dep_id = d.dep_id);
           
select * from HR_EMP_PROFILE
select * from HR_EMP_PROFILE WHERE EMP_ID='EMP101'
select * from HR_EMPLOYEE 
select * from HR_DEPARTMENT

CREATE OR REPLACE FUNCTION HR_EMP_PROFILE_FUNCTION(
empid HR_EMPLOYEE.emp_Id%TYPE)
RETURN HR_EMP_PROFILE%ROWTYPE
IS
 CURSOR GET_DATA IS 
 SELECT * FROM HR_EMP_PROFILE WHERE emp_id = empid;
 
 output_rec HR_EMP_PROFILE%ROWTYPE;
BEGIN
  OPEN GET_DATA;
  FETCH GET_DATA INTO output_rec;
  CLOSE GET_DATA;
  RETURN output_rec;
  
   
END HR_EMP_PROFILE_FUNCTION;

 
DECLARE
  output  HR_EMP_PROFILE%ROWTYPE;
BEGIN
  output := HR_EMP_PROFILE_FUNCTION('EMP101');
  dbms_output.put_line(output.emp_id);
  dbms_output.put_line(output.emp_name);
  dbms_output.put_line(output.nic_no);
  dbms_output.put_line(output.contact_no);
  dbms_output.put_line(output.designation);
  dbms_output.put_line(output.dep_name);
  dbms_output.put_line(output.D_location);
  
END;

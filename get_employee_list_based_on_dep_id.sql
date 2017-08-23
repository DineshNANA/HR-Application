create or replace type emp_type is object (emp_id VARCHAR2(6),emp_name VARCHAR2(30));
create or replace type emp_ty_nt is table of emp_type;

CREATE OR REPLACE FUNCTION HR_GET_EMPLOYEE_LIST(
depid HR_EMPLOYEE.dep_Id%TYPE)
RETURN emp_ty_nt
IS
 vemp_ty_nt emp_ty_nt := emp_ty_nt(); 
 cursor cmp is
 SELECT emp_id,emp_name FROM HR_EMPLOYEE WHERE dep_id = depid;
 
  
BEGIN
  for r_emp in cmp
    loop
      
      vemp_ty_nt.extend;
      
      vemp_ty_nt(vemp_ty_nt.last):= emp_type(r_emp.emp_id, r_emp.emp_name);
    
    end loop;
   return vemp_ty_nt;
  
   
END HR_GET_EMPLOYEE_LIST;


DECLARE 
   vemp_type emp_ty_nt;
BEGIN
  vemp_type :=HR_GET_EMPLOYEE_LIST('DEP002');
  dbms_output.put_line(vemp_type.count);
  
  
end;             

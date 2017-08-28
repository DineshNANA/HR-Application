CREATE OR REPLACE FUNCTION HR_GET_EMPLOYEE_LIST(
depid HR_EMPLOYEE.dep_Id%TYPE)
RETURN SYS_REFCURSOR
IS
 result_set SYS_REFCURSOR;
  



BEGIN
open result_set for select * from HR_EMPLOYEE where dep_id = depid;

return result_set;


END HR_GET_EMPLOYEE_LIST;
/

CREATE OR REPLACE FUNCTION HR_GET_ROLE_DETAILS
RETURN SYS_REFCURSOR
IS
role_details SYS_REFCURSOR;
BEGIN
  OPEN role_details FOR select * from HR_ROLE;

  RETURN role_details;

END HR_GET_ROLE_DETAILS;



 
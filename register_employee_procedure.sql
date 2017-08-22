CREATE OR REPLACE PROCEDURE REGISTER_EMPLOYEE (emp_id IN VARCHAR2,emp_name IN VARCHAR2,nic_no IN VARCHAR2,address IN VARCHAR2,contact_no IN VARCHAR2, designation IN VARCHAR2)
IS 
BEGIN 
  INSERT INTO HR_EMPLOYEE VALUES(emp_id,emp_name,nic_no,address,contact_no,designation);
END REGISTER_EMPLOYEE;


BEGIN 
  REGISTER_EMPLOYEE('003','John Smith','864125698V','Colombo','0742674289','labor');
  commit;
END;

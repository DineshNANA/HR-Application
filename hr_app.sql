CREATE TABLE HR_Department(
    dep_id VARCHAR2(6) PRIMARY KEY,
    dep_name VARCHAR2(25) NOT NULL,
    address VARCHAR(50),
    dep_head VARCHAR(6)
    CONSTRAINT fk_department FOREIGN KEY (dep_head) REFERENCES HR_Employee(emp_id));
    
CREATE TABLE HR_Employee(
    emp_id VARCHAR2(6) PRIMARY KEY,
    emp_name VARCHAR2(50) NOT NULL,
    nic_no VARCHAR2(12) NOT NULL,
    gender VARCHAR2(1) NOT NULL,
    contact_no VARCHAR2(12),
    email VARCHAR2(12),
    dep_id VARCHAR2(6) NOT NULL,
    status VARCHAR2(10) DEFAULT 'Active' NOT NULL,
    password VARCHAR2(40) NOT NULL,
    CONSTRAINT fk_employee FOREIGN KEY (dep_id) REFERENCES HR_Department(dep_id));
    
CREATE TABLE HR_Role(
    role_id VARCHAR2(6) PRIMARY KEY,
    role_name VARCHAR2(15) NOT NULL,
    role_description VARCHAR2(50));
    
CREATE TABLE HR_Task(
    task_id VARCHAR2(6) PRIMARY KEY,
    task_name VARCHAR2(25) NOT NULL,
    max_employees NUMBER NOT NULL,
    dep_id VARCHAR2(6) NOT NULL,
    status VARCHAR2(25) NOT NULL,
    CONSTRAINT fk_hr_task FOREIGN KEY(dep_id) REFERENCES HR_Department(dep_id));

CREATE TABLE HR_Employee_Role(
    emp_id VARCHAR2(6),
    role_id VARCHAR2(6),
    CONSTRAINT pk_hr_employee_role PRIMARY KEY(emp_id, role_id));

CREATE TABLE HR_Task_Assignment(
    task_id VARCHAR2(6),
    emp_id VARCHAR2(6),
    CONSTRAINT pk_hr_task_assignment PRIMARY KEY(task_id, emp_id));

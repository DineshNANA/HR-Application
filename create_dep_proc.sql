CREATE OR REPLACE PROCEDURE create_department(
    depId IN VARCHAR2, depName IN VARCHAR2, address IN VARCHAR2) AS
BEGIN
    INSERT INTO HR_Department(Dep_Id, Dep_Name, Address)
    VALUES (depId, depName, address);
END create_department;


BEGIN
    create_department('DEP001', 'Human Resource', '501, Galle Road, Colombo - 06');
    COMMIT;
END;

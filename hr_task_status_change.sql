CREATE OR REPLACE PROCEDURE HR_CHANGE_TASK_STATUS(
taskid IN VARCHAR2,
status_tsk IN VARCHAR2)

IS

BEGIN
  
  update HR_TASK SET status =status_tsk where task_id = taskid;
  
END HR_CHANGE_TASK_STATUS;

/* 
finished
temporary_stopped

*/

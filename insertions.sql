
DROP VIEW jobApplications
DROP VIEW interviewsConducted
DROP VIEW interviewsScheduled

GO;

CREATE VIEW jobApplications AS
SELECT a.ID, a.title AS Title, COUNT(*) AS applications FROM
Jobs a RIGHT JOIN Applications b
ON a.ID = b.JobID
Group By a.ID, a.title


GO;
CREATE VIEW interviewsConducted AS
SELECT jobID,  count(*) as conducted From Interviews
where happendTime <= GETDATE()
GROUP BY jobID
GO;

CREATE VIEW interviewsScheduled AS
SELECT jobID, COUNT(*) as scheduled From Interviews
where scheduledTime >= GETDATE()
Group by jobID

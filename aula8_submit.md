# BD: Guião 8


## ​8.1
 
### *a)*

```
CREATE PROCEDURE RemoveEmployee @Ssn CHAR(9)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        DELETE FROM DEPENDENT 
        WHERE Essn = @Ssn;

        DELETE FROM WORKS_ON 
        WHERE Essn = @Ssn;

        UPDATE EMPLOYEE
        SET Super_ssn = NULL
        WHERE Super_ssn = @Ssn;

        UPDATE DEPARTMENT
        SET Mgr_ssn = NULL
        WHERE Mgr_ssn = @Ssn;

        DELETE FROM EMPLOYEE
        WHERE Ssn = @Ssn;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END

```

### *b)* 

```
CREATE PROCEDURE RecordEmployee
AS
BEGIN
	SET NOCOUNT ON;

	BEGIN TRY
		BEGIN TRANSACTION

		SELECT E.Fname, E.Minit, E.Lname, E.Ssn, D.Dname AS Department, D.Mgr_start_date, DATEDIFF(YEAR, D.Mgr_start_date, getdate()) AS YearsManager
		FROM Department as D JOIN Employee as E ON E.Ssn = D.Mgr_ssn
		ORDER BY D.Mgr_start_date

		COMMIT TRANSACTION;
    END TRY

    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
```

### *c)* 

```
CREATE TRIGGER LimitManager
ON
DEPARTMENT
FOR INSERT, UPDATE
AS
BEGIN
	SET NOCOUNT ON;

	BEGIN TRY
		BEGIN TRANSACTION

        IF EXISTS (
            SELECT i.Mgr_ssn
            FROM inserted AS i 
                JOIN Department as D ON 
                D.Mgr_ssn = i.Mgr_ssn AND D.Dnumber <> i.Dnumber
        )

		COMMIT TRANSACTION;
    END TRY

    BEGIN CATCH
        RAISERROR('Não pode ser gestor mais do que um departamento', 16, 1);
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
```

### *d)* 

```
CREATE TRIGGER VencimentoFuncvsGest
ON
EMPLOYEE
AFTER INSERT, UPDATE
AS
BEGIN
	SET NOCOUNT ON;

	BEGIN TRY
		BEGIN TRANSACTION

        UPDATE E
        SET E.Salary = GM.Salary - 1
        FROM Employee as E JOIN inserted AS i ON E.Ssn = i.Ssn JOIN Department AS D ON D.Dnumber = E.Dno JOIN Employee as GM ON GM.Dno=D.Dnumber
        WHERE E.Salary > i.Salary

		COMMIT TRANSACTION;
    END TRY

    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
```

### *e)* 

```
CREATE FUNCTION dbo.FuncionarioProjetos(@ssn CHAR(9))
RETURNS TABLE
AS
RETURN
(
    SELECT p.pname, p.plocation
    FROM project p
    INNER JOIN works_on w ON p.pnumber = w.pno
    WHERE w.essn = @ssn
);
```

### *f)* 

```
CREATE FUNCTION dbo.EmployeeAboveAverage(@dno INT)
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM employee
    WHERE dno = @dno
      AND salary > (SELECT AVG(salary) FROM employee WHERE dno = @dno)
);
```

### *g)* 

```
CREATE FUNCTION dbo.employeeDeptHighAverage(@dno INT)
RETURNS @ProjectBudget TABLE
(
    pnumber INT,
    pname VARCHAR(50),
    monthly_cost DECIMAL(10,2),
    accumulated_cost DECIMAL(10,2)
)
AS
BEGIN
    DECLARE @pno INT, @pname VARCHAR(50), @monthly_cost DECIMAL(10,2), @accum DECIMAL(10,2)
    SET @accum = 0;

    DECLARE project_cursor CURSOR FOR
        SELECT p.pnumber, p.pname
        FROM project p
        WHERE p.dnum = @dno;

    OPEN project_cursor;
    FETCH NEXT FROM project_cursor INTO @pno, @pname;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        SELECT @monthly_cost = SUM(e.salary * w.hours/40.0) 
        FROM works_on w
        INNER JOIN employee e ON w.essn = e.ssn
        WHERE w.pno = @pno;

        SET @accum = @accum + ISNULL(@monthly_cost,0);

        INSERT INTO @ProjectBudget(pnumber, pname, monthly_cost, accumulated_cost)
        VALUES(@pno, @pname, ISNULL(@monthly_cost,0), @accum);

        FETCH NEXT FROM project_cursor INTO @pno, @pname;
    END

    CLOSE project_cursor;
    DEALLOCATE project_cursor;

    RETURN;
END;
```

### *h)* 

```
###Solução "After"

CREATE TRIGGER trg_DepartmentDeleted_After
ON Department
AFTER DELETE
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'department_deleted')
    BEGIN
        SELECT *
        INTO department_deleted
        FROM Department
        WHERE 1 = 0;
    END

    INSERT INTO department_deleted
    SELECT *
    FROM deleted;
END;

###Solução "Instead of"

CREATE TRIGGER trg_DepartmentDeleted_Instead
ON Department
INSTEAD OF DELETE
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'department_deleted')
    BEGIN
        SELECT *
        INTO department_deleted
        FROM Department
        WHERE 1 = 0;
    END

    INSERT INTO department_deleted
    SELECT *
    FROM deleted;

    DELETE d
    FROM Department d
    INNER JOIN deleted del ON d.dnumber = del.dnumber;
END;
```

### *i)* 

```
... Write here your answer ...
```

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
... Write here your answer ...
```

### *f)* 

```
... Write here your answer ...
```

### *g)* 

```
... Write here your answer ...
```

### *h)* 

```
... Write here your answer ...
```

### *i)* 

```
... Write here your answer ...
```

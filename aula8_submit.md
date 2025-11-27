# BD: Guião 8


## ​8.1
 
### *a)*

```
SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION
            DELETE FROM Works_ON WHERE ESSN = @SSN;
            DELETE FROM [DEPENDENT] WHERE ESSN = @SSN;
            DELETE FROM EMPLOYEE WHERE ESSN = @SSN;
        COMMIT TRANSACTION SCHEDULEDELETE
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION SCHEDULEDELETE
    END CATCH
    END
```

### *b)* 

```
... Write here your answer ...
```

### *c)* 

```
... Write here your answer ...
```

### *d)* 

```
... Write here your answer ...
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

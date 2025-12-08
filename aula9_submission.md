# BD: Guião 9


## ​9.1. Complete a seguinte tabela.
Complete the following table.

| #    | Query                                                                                                      | Rows  | Cost  | Pag. Reads | Time (ms) | Index used | Index Op.            | Discussion |
| :--- | :--------------------------------------------------------------------------------------------------------- | :---- | :---- | :--------- | :-------- | :--------- | :------------------- | :--------- |
| 1    | SELECT * from Production.WorkOrder                                                                         | 72591 | 0.484 | 531        | 1171      | PK_WordOrder_WorkOrderID           | Clustered Index Scan |            |
| 2    | SELECT * from Production.WorkOrder where WorkOrderID=1234                                                  | 1     | 0.00328      | 26         | 19        | PK_WordOrder_WorkOrderID           |  Busca de Indice Clusterizado                    |            |
| 3.1  | SELECT * FROM Production.WorkOrder WHERE WorkOrderID between 10000 and 10010                               | 11    | 0.00329      | 26         | 14        | PK_WordOrder_WorkOrderID           |  Busca de Indice Clusterizado                    |            |
| 3.2  | SELECT * FROM Production.WorkOrder WHERE WorkOrderID between 1 and 72591                                   | 72591 | 0.474      | 554        | 701       | PK_WordOrder_WorkOrderID           | Busca de Indice Clusterizado                     |            |
| 4    | SELECT * FROM Production.WorkOrder WHERE StartDate = '2012-05-14'                                          | 55    | 0.474      | 554        | 47        | PK_WordOrder_WorkOrderID           | Verificação do Indice Clusterizado                     |            |
| 5    | SELECT * FROM Production.WorkOrder WHERE ProductID = 757                                                   | 9     | 0.00329      | 44         | 41        | IX_WorkOrder_ProductID           | Verificação do Indice Clusterizado                      |            |
| 6.1  | SELECT WorkOrderID, StartDate FROM Production.WorkOrder WHERE ProductID = 757                              | 9     | 0.00329      | 44         | 33        | IX_WorkOrder_ProductID           | Busca de Indice                     |            |
| 6.2  | SELECT WorkOrderID, StartDate FROM Production.WorkOrder WHERE ProductID = 945                              | 1106  | 0.474       | 554        | 48        |PK_WordOrder_WorkOrderID            | Verificação do Indice Clusterizado                     |            |
| 6.3  | SELECT WorkOrderID FROM Production.WorkOrder WHERE ProductID = 945 AND StartDate = '2011-12-04'            | 1     | 0.474      | 556        | 42        | PK_WordOrder_WorkOrderID           | Verificação do Indice Clusterizado                       |            |
| 7    | SELECT WorkOrderID, StartDate FROM Production.WorkOrder WHERE ProductID = 945 AND StartDate = '2011-12-04' | 1     | 0.474       | 556        | 38        | PK_WordOrder_WorkOrderID           | Verificação do Indice Clusterizado                       |            |
| 8    | SELECT WorkOrderID, StartDate FROM Production.WorkOrder WHERE ProductID = 945 AND StartDate = '2011-12-04' | 1     | 0.474      | 556        | 25        |  PK_WordOrder_WorkOrderID          |  Verificação do Indice Clusterizado                      |            |

## ​9.2.

### a)

```
ALTER TABLE mytemp
ADD CONSTRAINT PK_mytemp_rid PRIMARY KEY CLUSTERED (rid);
```

### b)

```
index 		fragmentação (avg)	    espaço de página (avg)	page_count

CLUSTERED INDEX	98,9674682210737	67,1782354361705	    854
CLUSTERED INDEX	0			        89,8640327328886	    2
CLUSTERED INDEX	0			        0,395364583748204	    1
```

### c)

```
index fillfactor a 65% 

index 		fragmentação (avg)	    espaço de página (avg)	page_count
CLUSTERED INDEX	99,1616714728509	68,8601433160346	    835
CLUSTERED INDEX	0			        87,5596874460104	    2
CLUSTERED INDEX	0			        0,395654583652204	    1

tempo de execução 11 minutos e 58 segundos

index fillfactor a 80%
	
index 		fragmentação (avg)	    espaço de página (avg)	page_count
CLUSTERED INDEX	99,1926172247515	66,2382258463059	    867
CLUSTERED INDEX	0			        60,6755778583397	    3
CLUSTERED INDEX	0			        0,615386706203125	    1

tempo de execução 12 minutos e 56 segundos
```

### d)

```
Inserted      50000 total records (Identity)
Milliseconds used (Alínea D, Identity Insert): 2610

Horário de conclusão: 2025-12-08T22:40:43.1772231+00:00

O tempo reduziu significativamente porque foi utilizada uma chave clustered sequencial que evita a fragmentação e não um valor aleatório.
```

### e)

```
Hora de Início do teste E: Dec  8 2025  10:47PM
Inserted      50000 total records (Identity + 4 Indexes)
Milliseconds used (Alínea E): 12413

Horário de conclusão: 2025-12-08T22:47:19.6286402+00:00

A alteração da chave primária para IDENTITY na Alínea D resultou numa queda no tempo de inserção de 50.000 registos de aproximadamente 12 minutos para2.610 milissegundos, o que comprova a eficiência da inserção sequencial em índices Clustered.
Porém, a adição dos quatro índices não-clustered na Alínea E fez o tempo subir para 12.413 milissegundos, um aumento de cerca de 475%.
Esta diferença confirma o fenómeno de Amplificação de Escrita, em que o custo de ter que atualizar cinco estruturas B-Tree por cada registo inserido prejudica significativamente o desempenho de escrita, mesmo quando a inserção é sequencial.
```

## ​9.3.

```
-- (i) O funcionário com determinado número ssn;
CREATE UNIQUE INDEX idx_employee_ssn ON Employee(Ssn);

-- (ii) O(s) funcionário(s) com determinado primeiro e último nome;
CREATE INDEX idx_employee_name ON Employee(Fname, Lname);

-- (iii) Os funcionários que trabalham para determinado departamento;
CREATE INDEX idx_employee_dno ON Employee(Dno);

-- (iv) Os funcionários que trabalham para determinado projeto;
CREATE INDEX idx_works_on_pno ON Works_on(Pno);

-- (v) Os dependentes de determinado funcionário;
CREATE INDEX idx_dependent_essn ON [Dependent](Essn);

-- (vi) Os projetos associados a determinado departamento
CREATE INDEX idx_project_dnum ON Project(Dnum);

-- EXTRA: Os projetos de um determinado funcionário
CREATE INDEX idx_works_on_essn ON Works_on(Essn);
```

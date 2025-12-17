INSERT INTO Competição (organizador, nome, datainicio, datafim, n_etapas)
VALUES
('Volta a Portugal', '86ª Volta a Portugal', '2025-08-06', '2025-08-17', 10);


INSERT INTO Etapa (duracao, numetapa, distancia, velocidademedia)
VALUES
-- 2025
('04:15:00', 1, 160.5, 38.0),
('03:50:00', 2, 155.0, 40.4),
('04:30:00', 3, 165.2, 36.7),
('05:00:00', 4, 180.0, 36.0),
('03:40:00', 5, 150.3, 41.0),
('04:10:00', 6, 170.1, 40.8),
('04:45:00', 7, 175.0, 36.8),
('03:55:00', 8, 158.7, 40.5),
('04:20:00', 9, 168.2, 38.7),
('03:30:00', 10, 140.0, 40.0);

INSERT INTO Localidade (latitude, longitude, altitude, nome, distrito, ordem, ID_etapa)
VALUES
-- ===================
-- 2025
-- ==================

-- Prólogo (Etapa 1 no perfil de etapas é o prólogo)
('41.2200', '-8.6100', '50', 'Maia', 'Porto', 1, 1),
('41.2200', '-8.6100', '50', 'Maia', 'Porto', 2, 1),

-- Etapa 1: Viana do Castelo → Braga (Sameiro)
('41.7000', '-8.8333', '30', 'Viana do Castelo', 'Viana do Castelo', 1, 2),
('41.5550', '-8.4160', '350', 'Braga (Sameiro)', 'Braga', 2, 2),

-- Etapa 2: Felgueiras → Fafe
('41.3720', '-8.1550', '200', 'Felgueiras', 'Porto', 1, 3),
('41.4350', '-7.9050', '150', 'Fafe', 'Braga', 2, 3),

-- Etapa 3: Boticas → Bragança
('41.7580', '-7.8650', '450', 'Boticas', 'Vila Real', 1, 4),
('41.8050', '-6.7570', '350', 'Bragança', 'Bragança', 2, 4),

-- Etapa 4: Bragança → Mondim de Basto (Senhora da Graça)
('41.8050', '-6.7570', '350', 'Bragança', 'Bragança', 1, 5),
('41.4410', '-7.9660', '1200', 'Mondim de Basto (Senhora da Graça)', 'Vila Real', 2, 5),

-- Etapa 5: Lamego → Viseu
('41.0900', '-7.8060', '150', 'Lamego', 'Viseu', 1, 6),
('40.6610', '-7.9090', '300', 'Viseu', 'Viseu', 2, 6),

-- Etapa 6: Águeda → Guarda
('40.5760', '-8.4440', '50', 'Águeda', 'Aveiro', 1, 7),
('40.5370', '-7.2650', '800', 'Guarda', 'Guarda', 2, 7),

-- Etapa 7: Sabugal → Covilhã (Torre)
('40.3590', '-7.1890', '400', 'Sabugal', 'Guarda', 1, 8),
('40.2820', '-7.5030', '1993', 'Covilhã (Torre)', 'Castelo Branco', 2, 8),

-- Etapa 8: Ferreira do Zêzere → Santarém  
('39.7670', '-8.3190', '120', 'Ferreira do Zêzere', 'Santarém', 1, 9),
('39.2330', '-8.6850', '60', 'Santarém', 'Santarém', 2, 9),

-- Etapa 9: Alcobaça → Montejunto  
('39.5530', '-9.0460', '50', 'Alcobaça', 'Leiria', 1, 10),
('39.3170', '-9.1330', '600', 'Montejunto', 'Santarém', 2, 10),

-- Etapa 10: Lisboa → Lisboa (CRI)  
('38.7223', '-9.1393', '20', 'Lisboa', 'Lisboa', 1, 11),
('38.7223', '-9.1393', '20', 'Lisboa', 'Lisboa', 2, 11);

-- 2024

-- 2023

-- 1. Inserir Pessoas (Ciclistas e Diretores) com datas de nascimento preenchidas
INSERT INTO Pessoa (nome, nacionalidade, datanascimento)
VALUES
  -- CICLISTAS (UCI_ID 1 a 111)
  -- ATI
  ('Artem Nych', 'Rússia', '1995-03-21'),
  ('Rubén Fernández', 'Espanha', '1991-03-01'),
  ('Fábio Costa', 'Portugal', '1999-07-04'),
  ('Pedro Silva', 'Portugal', '2001-07-07'),
  ('Harrison Wood', 'Reino Unido', '2000-06-14'),
  ('Rafael Reis', 'Portugal', '1992-07-15'),
  ('Alexis Guerin', 'França', '1992-06-06'),

  -- CJR
  ('Iúri Leitão', 'Portugal', '1998-07-03'),
  ('Julen Arriola‑Bengoa', 'Espanha', '2001-02-16'),
  ('Joseba López', 'Espanha', '2000-03-05'),
  ('Calum Johnston', 'Reino Unido', '1998-11-01'),
  ('Francisco Peñuela', 'Venezuela', '2001-02-01'),
  ('Tyler Stites', 'Estados Unidos', '1998-03-18'),
  ('Alex Díaz', 'Espanha', '2001-07-28'),

  -- ICA
  ('Zac Marriage', 'Austrália', '2003-11-12'),
  ('Brady Gilmore', 'Austrália', '2001-04-14'),
  ('Moritz Kretschy', 'Alemanha', '2002-05-12'),
  ('Daniel Lima', 'Portugal', '2004-12-12'),
  ('Pau Martí', 'Espanha', '2004-11-24'),
  ('Jens Verbrugghe', 'Bélgica', '2004-09-23'),
  ('Rotem Tene', 'Israel', '2001-03-30'),

  -- PTL
  ('Jonathan Klever Caicedo', 'Equador', '1993-04-28'),
  ('Edgar Cadena', 'México', '2000-08-20'),
  ('Edison Callejas', 'Colômbia', '2000-11-25'),
  ('César Leonel Cisneros', 'México', '2005-05-14'),  -- Data real
  ('Carlos García Alfonso', 'Espanha', '2003-11-21'), -- Data real
  ('Yeferson Camargo', 'Colômbia', '2004-11-10'),     -- Data real
  ('Andrii Ponomar', 'Ucrânia', '2002-09-05'),        -- Data real
  
  -- ATF (AP Hotels & Resorts / Tavira / SC Farense)
  ('Afonso Silva', 'Portugal', '2004-03-22'),         -- Data real
  ('Carlos Salgueiro', 'Portugal', '1999-06-09'),     -- Data real
  ('Diogo Barbosa', 'Portugal', '2000-06-13'),        -- Data real
  ('Francisco Campos', 'Portugal', '1997-10-10'),     -- Data real
  ('Ailetz Lasa', 'Espanha', '2000-03-03'),           -- Data simulada
  ('Diogo Pinto', 'Portugal', '2001-05-15'),          -- Data simulada
  ('Jesús Peña', 'Colômbia', '2000-02-12'),           -- Data simulada
  
  -- PEC (Project Echelon Racing)
  ('Kieran Haug', 'Estados Unidos', '1999-01-20'),    -- Data simulada
  ('Richard Arnopol', 'Estados Unidos', '1992-05-10'),-- Data real
  ('Samuel Boardman', 'Estados Unidos', '1995-09-08'),-- Data real
  ('Cade Bickmore', 'Estados Unidos', '1998-03-28'),  -- Data real
  ('Caleb Classen', 'Estados Unidos', '2001-09-19'),  -- Data real
  ('Laurent Gervais', 'Canadá', '1997-11-03'),        -- Data real
  ('Hugo Scala Jr', 'Estados Unidos', '1997-12-29'),  -- Data real
  
  -- ALL (Aviludo – Louletano – Loulé)
  ('Nicolás Tivani', 'Argentina', '1995-10-31'),      -- Data real
  ('Tomas Contte', 'Argentina', '1998-08-01'),        -- Data real
  ('Jesús del Pino', 'Espanha', '1990-09-09'),        -- Data simulada (veterano)
  ('David Domínguez', 'Espanha', '2000-07-28'),       -- Data simulada
  ('Carlos Oyarzún', 'Chile', '1981-10-26'),          -- Data simulada (conhecido veterano)
  ('Cláudio Leal', 'Portugal', '2001-11-22'),         -- Data simulada
  ('Jorge Gálvez', 'Espanha', '2001-04-18'),          -- Data simulada
  
  -- TAV (Tavfer – Ovos Matinados – Mortágua)
  ('João Matias', 'Portugal', '1991-05-26'),          -- Data simulada
  ('Bruno Silva', 'Portugal', '1988-05-17'),          -- Data simulada
  ('Leangel Linárez', 'Venezuela', '1997-08-07'),     -- Data simulada
  ('Francisco Morais', 'Portugal', '1998-08-26'),     -- Data simulada
  ('Gonçalo Carvalho', 'Portugal', '1997-12-03'),     -- Data simulada
  ('César Martingil', 'Portugal', '1995-01-10'),      -- Data simulada
  ('Ángel Sánchez', 'Espanha', '1993-04-12'),         -- Data simulada
  
  -- A6D (Atom 6 Bikes – Decca)
  ('Oliver Bleddyn', 'Austrália', '2002-01-27'),      -- Data real
  ('Matthew King', 'Reino Unido', '1995-10-20'),      -- Data simulada
  ('Jan Kino', 'Bélgica', '2003-02-14'),              -- Data simulada
  ('Angus Miller', 'Austrália', '2002-08-30'),        -- Data simulada
  ('Jeremy Smith', 'Austrália', '2001-05-05'),        -- Data simulada
  ('Bogdan Zabelinskiy', 'Chipre', '2002-01-12'),     -- Data simulada
  ('Matthew May', 'Reino Unido', '2000-09-09'),       -- Data simulada
  
  -- EFP (Efapel Cycling)
  ('Joaquim Silva', 'Portugal', '1992-03-19'),        -- Data real
  ('Tiago Antunes', 'Portugal', '1997-04-09'),        -- Data real
  ('André Carvalho', 'Portugal', '1997-10-31'),       -- Data simulada
  ('Maurício Moreira', 'Uruguai', '1995-07-18'),      -- Data real
  ('Santiago Mesa', 'Colômbia', '1997-11-11'),        -- Data real
  ('Pedro Pinto', 'Portugal', '2001-11-05'),          -- Data simulada
  ('António Ferreira', 'Portugal', '2000-04-03'),     -- Data simulada
  ('Aleksandr Grigorev', 'Rússia', '1992-03-21'),     -- Data simulada
  ('Keegan Swirbul', 'Estados Unidos', '1995-09-02'), -- Data simulada
  ('Oriol Vidal', 'Espanha', '2000-01-29'),           -- Data simulada
  
  -- IBA (Illes Balears Arabay)
  ('Edgar Curto', 'Portugal', '1999-06-28'),          -- Data real
  ('Unai Esparza', 'Espanha', '2000-06-02'),          -- Data real
  ('Ricard Fitó', 'Espanha', '2001-02-14'),           -- Data simulada
  ('Sebastian Mora', 'Espanha', '1988-02-19'),        -- Data real
  ('Álvaro Sagrado', 'Espanha', '2000-05-10'),        -- Data simulada
  ('Joan Roca', 'Espanha', '2001-01-15'),             -- Data simulada
  ('Sergio Trueba', 'Espanha', '2000-08-12'),         -- Data simulada
  
  -- CDF (Feirense – Beeceler)
  ('António Carvalho', 'Portugal', '1989-10-25'),     -- Data real
  ('Byron Munton', 'Reino Unido', '1998-12-12'),      -- Data simulada
  ('Francisco Pereira', 'Portugal', '1999-08-30'),    -- Data simulada
  ('Diogo Gonçalves', 'Portugal', '1997-05-15'),      -- Data simulada
  ('Ivo Pinheiro', 'Portugal', '1998-09-09'),         -- Data simulada
  ('Fábio Oliveira', 'Portugal', '1994-10-25'),       -- Data simulada
  ('Pedro Andrade', 'Portugal', '2000-05-31'),        -- Data simulada
  
  -- RPB (Rádio Popular – Paredes – Boavista)
  ('Lucas Lopes', 'Portugal', '2003-04-10'),          -- Data simulada
  ('Tiago Leal', 'Portugal', '1999-10-22'),           -- Data simulada
  ('Hélder Gonçalves', 'Portugal', '2000-06-16'),     -- Data simulada
  ('Daniel Dias', 'Portugal', '2001-07-29'),          -- Data simulada
  ('César Fonte', 'Portugal', '1986-12-10'),          -- Data real
  ('Raul Rota', 'Portugal', '1999-11-18'),            -- Data simulada
  ('Gonçalo Amado', 'Portugal', '1994-02-09'),        -- Data simulada
  
  -- GSU (GI Group Holding – Simoldes – UDO)
  ('Rui Carvalho', 'Portugal', '1995-04-28'),         -- Data simulada
  ('Gaspar Gonçalves', 'Portugal', '1995-05-24'),     -- Data simulada
  ('André Ribeiro', 'Portugal', '2000-12-12'),        -- Data simulada
  ('Miquel Valls', 'Espanha', '2000-01-30'),          -- Data simulada
  ('Adrian Bustamante', 'Colômbia', '1998-06-07'),    -- Data simulada
  ('Cesar Guavita', 'Colômbia', '2002-01-13'),        -- Data simulada
  ('Andrey André', 'Rússia', '2003-10-10'),           -- Data simulada
  
  -- LAA (Credibom / LA Alumínios / Marcos Car)
  ('Emanuel Duarte', 'Portugal', '1997-01-24'),       -- Data real
  ('Gonçalo Leaça', 'Portugal', '1997-10-29'),        -- Data simulada
  ('João Medeiros', 'Portugal', '2000-04-10'),        -- Data simulada
  ('Hugo Nunes', 'Portugal', '1996-11-17'),           -- Data real
  ('Diogo Narciso', 'Portugal', '2001-11-19'),        -- Data simulada
  ('Alexandre Montez', 'Portugal', '2002-01-06'),     -- Data simulada
  ('Daniel Jorge', 'Portugal', '2001-06-04'),         -- Data simulada
  
  -- TSL (Team Skyline)
  ('Adam Lewis', 'Reino Unido', '1995-08-21'),        -- Data simulada
  ('Jack Makohon', 'Estados Unidos', '2000-12-12'),   -- Data simulada
  ('Conn Mc Dunphy', 'Irlanda', '1997-02-03'),        -- Data simulada
  ('Sean Christian', 'Estados Unidos', '2001-10-10'), -- Data simulada
  ('Cian Keogh', 'Irlanda', '1999-04-06'),            -- Data simulada
  ('Liam Flanagan', 'Irlanda', '2000-09-09'),         -- Data simulada

  -- DIRETORES DESPORTIVOS (Corrigido: Apenas 12 diretores, um para cada equipa)
  ('Vidal Fitas', 'Portugal', '1976-02-02'),         -- 112: ATF
  ('Isaiah Newkirk', 'Estados Unidos', '1990-05-12'),-- 113: PEC (Corrigido de Jose Reviejo)
  ('Américo Silva', 'Portugal', '1965-08-10'),       -- 114: ALL (Corrigido de Tim Elverson)
  ('Gustavo Veloso', 'Espanha', '1980-01-29'),       -- 115: TAV (Reordenado)
  ('Stijn De Vriese', 'Bélgica', '1975-03-12'),      -- 116: A6D (Corrigido para o Belga da Atom 6)
  ('José Azevedo', 'Portugal', '1973-09-19'),        -- 117: EFP
  ('Daniel Navarro', 'Espanha', '1983-07-18'),       -- 118: IBA
  ('Joaquim Andrade', 'Portugal', '1969-08-16'),     -- 119: CDF
  ('José Santos', 'Portugal', '1960-04-20'),         -- 120: RPB
  ('Manuel Correia', 'Portugal', '1965-12-12'),      -- 121: GSU
  ('Hernâni Brôco', 'Portugal', '1981-06-13'),       -- 122: LAA
  ('Michael Tacci', 'Estados Unidos', '1980-05-05'), -- 123: TSL
  ('Ricardo Pereira', 'Portugal', '1978-05-15'),    -- 124: ATI 
  ('José Miguel Fernández', 'Espanha', '1975-09-20'), -- 125: CJR
  ('Ruben Plaza', 'Espanha', '1980-02-29'), -- 126: ICA
  ('David Plaza', 'Espanha', '1970-04-10'); -- 127: PTL

-- 2. Inserir na tabela DiretorDesportivo com os IDs das pessoas criadas acima
INSERT INTO DiretorDesportivo (UCI_ID) VALUES
(112), -- Vidal Fitas
(113), -- Isaiah Newkirk
(114), -- Américo Silva
(115), -- Gustavo Veloso
(116), -- Stijn De Vriese
(117), -- José Azevedo
(118), -- Daniel Navarro
(119), -- Joaquim Andrade
(120), -- José Santos
(121), -- Manuel Correia
(122), -- Hernâni Brôco
(123); -- Michael Tacci
(124), -- Ricardo Pereira (ATI)
(125), -- José Miguel Fernández (CJR)
(126), -- Ruben Plaza (ICA)
(127); -- David Plaza (PTL)

-- 3. Inserir Equipas com a associação correta ao Diretor Desportivo
INSERT INTO Equipa (paisorigem, numciclistas, nome, anofundacao, UCI_ID_DiretorDesportivo)
VALUES
('Portugal', 7, 'ATI', 2003, 124), -- Anicolor
('Espanha', 7, 'CJR', 1993, 125),  -- Caja Rural
('Israel', 7, 'ICA', 2010, 126),   -- Israel Academy
('México', 7, 'PTL', 2003, 127);   -- Petrolike
('Portugal', 7, 'ATF', 2004, 112), 
('Estados Unidos', 7, 'PEC', 2010, 113), 
('Portugal', 7, 'ALL', 1983, 114), 
('Portugal', 7, 'TAV', 2006, 115), 
('Austrália', 7, 'A6D', 2015, 116), 
('Portugal', 10, 'EFP', 2006, 117), 
('Espanha', 7, 'IBA', 2012, 118), 
('Portugal', 7, 'CDF', 1995, 119), 
('Portugal', 7, 'RPB', 1998, 120),
('Portugal', 7, 'GSU', 2014, 121), 
('Portugal', 8, 'LAA', 2011, 122), 
('Irlanda', 6, 'TSL', 2016, 123); 

INSERT INTO Ciclista (numdorsal, UCI_ID)
VALUES
(1, 1), (2, 2), (3, 3), (4, 4), (5, 5), (6, 6), (7, 7), (8, 8), (9, 9), (10, 10),
(11, 11), (12, 12), (13, 13), (14, 14), (15, 15), (16, 16), (17, 17), (18, 18), (19, 19), (20, 20),
(21, 21), (22, 22), (23, 23), (24, 24), (25, 25), (26, 26), (27, 27), (28, 28), (29, 29), (30, 30),
(31, 31), (32, 32), (33, 33), (34, 34), (35, 35), (36, 36), (37, 37), (38, 38), (39, 39), (40, 40),
(41, 41), (42, 42), (43, 43), (44, 44), (45, 45), (46, 46), (47, 47), (48, 48), (49, 49), (50, 50),
(51, 51), (52, 52), (53, 53), (54, 54), (55, 55), (56, 56), (57, 57), (58, 58), (59, 59), (60, 60),
(61, 61), (62, 62), (63, 63), (64, 64), (65, 65), (66, 66), (67, 67), (68, 68), (69, 69), (70, 70),
(71, 71), (72, 72), (73, 73), (74, 74), (75, 75), (76, 76), (77, 77), (78, 78), (79, 79), (80, 80),
(81, 81), (82, 82), (83, 83), (84, 84), (85, 85), (86, 86), (87, 87), (88, 88), (89, 89), (90, 90),
(91, 91), (92, 92), (93, 93), (94, 94), (95, 95), (96, 96), (97, 97), (98, 98), (99, 99), (100, 100),
(101, 101), (102, 102), (103, 103), (104, 104), (105, 105), (106, 106), (107, 107), (108, 108), (109, 109), (110, 110),
(111, 111);

INSERT INTO Bicicleta (codigo, marca, modelo, anofabrico, numdorsal_ciclista)
VALUES
(0001, 'Specialized', 'Tarmac SL7', 2023, 1),
(0002, 'Trek', 'Emonda SLR', 2022, 2),
(0003, 'Canyon', 'Ultimate CF', 2023, 3),
(0004, 'BMC', 'Teammachine SLR01', 2022, 4),
(0005, 'Giant', 'TCR Advanced SL', 2023, 5),
(0006, 'Pinarello', 'Dogma F12', 2023, 6),
(0007, 'Scott', 'Addict RC', 2022, 7),
(0008, 'Colnago', 'C64', 2023, 8),
(0009, 'Orbea', 'Orca M10', 2022, 9),
(0010, 'Cervelo', 'R5', 2023, 10);

------------------------------------------------------------
-- CLASSIFICAÇÃO GERAL  
------------------------------------------------------------

INSERT INTO Classificacao (diferenca_vencedor, posicao)
VALUES
('00:00:00', 1), ('00:01:15', 2), ('00:01:51', 3), ('00:02:24', 4), ('00:03:14', 5), ('00:04:32', 6), ('00:04:42', 7), ('00:04:45', 8), ('00:05:30', 9), ('00:05:31', 10),
('00:05:53', 11), ('00:06:43', 12), ('00:06:56', 13), ('00:07:34', 14), ('00:07:42', 15), ('00:10:41', 16), ('00:11:24', 17), ('00:12:03', 18), ('00:12:25', 19), ('00:12:41', 20),
('00:13:28', 21), ('00:15:55', 22), ('00:16:37', 23), ('00:17:39', 24), ('00:19:18', 25), ('00:20:52', 26), ('00:22:44', 27), ('00:24:13', 28), ('00:24:56', 29), ('00:26:49', 30),
('00:35:50', 31), ('00:36:26', 32), ('00:38:24', 33), ('00:40:23', 34), ('00:41:48', 35), ('00:44:10', 36), ('00:44:31', 37), ('00:46:32', 38), ('00:46:49', 39), ('00:53:32', 40),
('00:55:14', 41), ('00:59:28', 42), ('01:00:52', 43), ('01:04:45', 44), ('01:07:35', 45), ('01:12:59', 46), ('01:21:35', 47), ('01:23:48', 48), ('01:23:51', 49), ('01:24:05', 50),
('01:24:17', 51), ('01:24:46', 52), ('01:25:33', 53), ('01:25:36', 54), ('01:28:11', 55), ('01:28:17', 56), ('01:29:36', 57), ('01:31:25', 58), ('01:33:18', 59), ('01:34:16', 60),
('01:36:55', 61), ('01:37:37', 62), ('01:37:40', 63), ('01:38:15', 64), ('01:39:39', 65), ('01:47:32', 66), ('01:52:12', 67), ('01:52:24', 68), ('01:52:54', 69), ('01:53:29', 70),
('01:53:48', 71), ('01:54:01', 72), ('01:54:51', 73), ('01:55:26', 74), ('01:55:54', 75), ('01:57:51', 76), ('01:58:34', 77), ('02:02:31', 78), ('02:03:28', 79), ('02:03:33', 80),
('02:03:58', 81), ('02:12:32', 82), ('02:13:25', 83), ('02:18:44', 84), ('02:23:15', 85), ('02:26:55', 86), ('02:28:41', 87), ('02:35:52', 88), ('02:37:33', 89), ('02:46:17', 90),
('02:53:46', 91), ('02:54:19', 92), ('02:54:19', 93), ('03:17:51', 94), ('03:19:26', 95);


-- ============================================================
-- CLASSIFICAÇÃO GERAL POR EQUIPAS 
-- ============================================================
('00:00:00', 1), ('00:13:40', 2), ('00:19:42', 3), ('00:20:57', 4), ('00:26:42', 5), 
('00:30:59', 6), ('00:37:15', 7), ('00:40:45', 8), ('00:54:54', 9), ('01:00:35', 10),
('01:08:38', 11), ('01:53:20', 12), ('02:18:48', 13), ('02:34:25', 14), ('02:38:46', 15), ('03:20:08', 16);


-- ============================================================
-- CLASSIFICAÇÃO JUVENTUDE 
-- ============================================================
('00:00:00', 1), ('00:00:23', 2), ('00:15:22', 3), ('00:18:43', 4), ('00:41:19', 5), 
('00:53:58', 6), ('01:18:18', 7), ('01:22:41', 8), ('01:47:24', 9), ('01:48:18', 10),
('02:21:25', 11), ('02:40:47', 12);




------------------------------------------------------------
-- PRÓLOGO – 06/08/2025 – vencedor: Rafael Reis – 3:51
------------------------------------------------------------
INSERT INTO ResultadoEtapa (tempofinal, penalizacaotempo, bonificaotempo, UCI_ID_ciclista, ID_etapa, ID_classificacao)
INSERT INTO ResultadoEtapa (tempofinal, penalizacaotempo, bonificaotempo, UCI_ID_ciclista, ID_etapa, ID_classificacao)
VALUES
-- =========================================================
-- ETAPA 1 (PRÓLOGO - 5 KM)
-- =========================================================
('00:03:51', '00:00:00', '00:00:00', 41, 1, 1), ('00:03:52', '00:00:00', '00:00:00', 22, 1, 2), ('00:03:52', '00:00:00', '00:00:00', 79, 1, 3), ('00:03:52', '00:00:00', '00:00:00', 85, 1, 4), ('00:03:57', '00:00:00', '00:00:00', 27, 1, 5), 
('00:03:58', '00:00:00', '00:00:00', 70, 1, 6), ('00:04:01', '00:00:00', '00:00:00', 3, 1, 7), ('00:04:06', '00:00:00', '00:00:00', 98, 1, 8), ('00:04:06', '00:00:00', '00:00:00', 61, 1, 9), ('00:04:09', '00:00:00', '00:00:00', 100, 1, 10),
('00:04:11', '00:00:00', '00:00:00', 65, 1, 11), ('00:04:11', '00:00:00', '00:00:00', 101, 1, 12), ('00:04:11', '00:00:00', '00:00:00', 54, 1, 13), ('00:04:11', '00:00:00', '00:00:00', 16, 1, 14), ('00:04:12', '00:00:00', '00:00:00', 95, 1, 15), 
('00:04:12', '00:00:00', '00:00:00', 114, 1, 16), ('00:04:14', '00:00:00', '00:00:00', 9, 1, 17), ('00:04:14', '00:00:00', '00:00:00', 43, 1, 18), ('00:04:14', '00:00:00', '00:00:00', 42, 1, 19), ('00:04:14', '00:00:00', '00:00:00', 99, 1, 20),
('00:04:19', '00:00:00', '00:00:00', 88, 1, 21), ('00:04:20', '00:00:00', '00:00:00', 75, 1, 22), ('00:04:25', '00:00:00', '00:00:00', 45, 1, 23), ('00:04:26', '00:00:00', '00:00:00', 50, 1, 24), ('00:04:31', '00:00:00', '00:00:00', 31, 1, 25), 
('00:04:31', '00:00:00', '00:00:00', 64, 1, 26), ('00:04:33', '00:00:00', '00:00:00', 86, 1, 27), ('00:04:34', '00:00:00', '00:00:00', 108, 1, 28), ('00:04:34', '00:00:00', '00:00:00', 76, 1, 29), ('00:04:37', '00:00:00', '00:00:00', 4, 1, 30),
('00:04:38', '00:00:00', '00:00:00', 23, 1, 31), ('00:04:38', '00:00:00', '00:00:00', 109, 1, 32), ('00:04:43', '00:00:00', '00:00:00', 40, 1, 33), ('00:04:46', '00:00:00', '00:00:00', 10, 1, 34), ('00:04:51', '00:00:00', '00:00:00', 97, 1, 35), 
('00:04:52', '00:00:00', '00:00:00', 5, 1, 36), ('00:04:54', '00:00:00', '00:00:00', 63, 1, 37), ('00:04:56', '00:00:00', '00:00:00', 25, 1, 38), ('00:04:57', '00:00:00', '00:00:00', 39, 1, 39), ('00:05:02', '00:00:00', '00:00:00', 62, 1, 40),
('00:05:02', '00:00:00', '00:00:00', 59, 1, 41), ('00:05:05', '00:00:00', '00:00:00', 78, 1, 42), ('00:05:06', '00:00:00', '00:00:00', 113, 1, 43), ('00:05:11', '00:00:00', '00:00:00', 60, 1, 44), ('00:05:13', '00:00:00', '00:00:00', 36, 1, 45), 
('00:05:13', '00:00:00', '00:00:00', 19, 1, 46), ('00:05:15', '00:00:00', '00:00:00', 107, 1, 47), ('00:05:16', '00:00:00', '00:00:00', 103, 1, 48), ('00:05:16', '00:00:00', '00:00:00', 96, 1, 49), ('00:05:19', '00:00:00', '00:00:00', 68, 1, 50),
('00:05:22', '00:00:00', '00:00:00', 111, 1, 51), ('00:05:24', '00:00:00', '00:00:00', 53, 1, 52), ('00:05:25', '00:00:00', '00:00:00', 49, 1, 53), ('00:05:27', '00:00:00', '00:00:00', 105, 1, 54), ('00:05:27', '00:00:00', '00:00:00', 2, 1, 55), 
('00:05:29', '00:00:00', '00:00:00', 69, 1, 56), ('00:05:29', '00:00:00', '00:00:00', 35, 1, 57), ('00:05:32', '00:00:00', '00:00:00', 44, 1, 58), ('00:05:33', '00:00:00', '00:00:00', 13, 1, 59), ('00:05:33', '00:00:00', '00:00:00', 1, 1, 60),
('00:05:36', '00:00:00', '00:00:00', 46, 1, 61), ('00:05:38', '00:00:00', '00:00:00', 56, 1, 62), ('00:05:41', '00:00:00', '00:00:00', 80, 1, 63), ('00:05:43', '00:00:00', '00:00:00', 21, 1, 64), ('00:05:44', '00:00:00', '00:00:00', 34, 1, 65), 
('00:05:45', '00:00:00', '00:00:00', 92, 1, 66), ('00:05:50', '00:00:00', '00:00:00', 94, 1, 67), ('00:05:51', '00:00:00', '00:00:00', 74, 1, 68), ('00:05:51', '00:00:00', '00:00:00', 8, 1, 69), ('00:05:51', '00:00:00', '00:00:00', 32, 1, 70),
('00:05:52', '00:00:00', '00:00:00', 87, 1, 71), ('00:05:52', '00:00:00', '00:00:00', 110, 1, 72), ('00:05:52', '00:00:00', '00:00:00', 20, 1, 73), ('00:05:54', '00:00:00', '00:00:00', 77, 1, 74), ('00:05:55', '00:00:00', '00:00:00', 52, 1, 75), 
('00:05:56', '00:00:00', '00:00:00', 17, 1, 76), ('00:05:59', '00:00:00', '00:00:00', 51, 1, 77), ('00:06:01', '00:00:00', '00:00:00', 47, 1, 78), ('00:06:06', '00:00:00', '00:00:00', 7, 1, 79), ('00:06:06', '00:00:00', '00:00:00', 30, 1, 80),
('00:06:08', '00:00:00', '00:00:00', 18, 1, 81), ('00:06:08', '00:00:00', '00:00:00', 83, 1, 82), ('00:06:11', '00:00:00', '00:00:00', 84, 1, 83), ('00:06:11', '00:00:00', '00:00:00', 33, 1, 84), ('00:06:13', '00:00:00', '00:00:00', 93, 1, 85), 
('00:06:14', '00:00:00', '00:00:00', 12, 1, 86), ('00:06:14', '00:00:00', '00:00:00', 57, 1, 87), ('00:06:15', '00:00:00', '00:00:00', 90, 1, 88), ('00:06:16', '00:00:00', '00:00:00', 48, 1, 89), ('00:06:16', '00:00:00', '00:00:00', 37, 1, 90),
('00:06:17', '00:00:00', '00:00:00', 89, 1, 91), ('00:06:17', '00:00:00', '00:00:00', 38, 1, 92), ('00:06:19', '00:00:00', '00:00:00', 55, 1, 93), ('00:06:21', '00:00:00', '00:00:00', 28, 1, 94), ('00:06:23', '00:00:00', '00:00:00', 67, 1, 95), 
('00:06:23', '00:00:00', '00:00:00', 71, 1, 96), ('00:06:24', '00:00:00', '00:00:00', 58, 1, 97), ('00:06:24', '00:00:00', '00:00:00', 26, 1, 98), ('00:06:25', '00:00:00', '00:00:00', 82, 1, 99), ('00:06:26', '00:00:00', '00:00:00', 81, 1, 100),
('00:06:31', '00:00:00', '00:00:00', 66, 1, 101), ('00:06:33', '00:00:00', '00:00:00', 106, 1, 102), ('00:06:33', '00:00:00', '00:00:00', 15, 1, 103), ('00:06:34', '00:00:00', '00:00:00', 72, 1, 104), ('00:06:36', '00:00:00', '00:00:00', 29, 1, 105), 
('00:06:37', '00:00:00', '00:00:00', 104, 1, 106), ('00:06:37', '00:00:00', '00:00:00', 24, 1, 107), ('00:06:40', '00:00:00', '00:00:00', 14, 1, 108), ('00:06:40', '00:00:00', '00:00:00', 11, 1, 109), ('00:06:41', '00:00:00', '00:00:00', 102, 1, 110),
('00:06:42', '00:00:00', '00:00:00', 91, 1, 111), ('00:06:42', '00:00:00', '00:00:00', 6, 1, 112), ('00:06:45', '00:00:00', '00:00:00', 112, 1, 113), ('00:06:47', '00:00:00', '00:00:00', 73, 1, 114),

-- =========================================================
-- ETAPA 2 (LINHA - SPRINT EM PELOTÃO)
-- =========================================================



INSERT INTO Camisola_Ciclista (camisola, UCI_ID_ciclista)
VALUES
('Amarela', 1),
('Verde', 43),
('Azul', 105),
('Branca', 88);

-- =======================================================
-- CATEGORIA 
-- =======================================================
INSERT INTO Categoria_Ciclista (categoria, UCI_ID_ciclista)
VALUES
('Elite', 1), ('Elite', 2), ('Elite', 3), ('Elite', 4), ('Elite', 5), ('Elite', 6), ('Elite', 7), ('Elite', 8), ('Elite', 9), ('Elite', 10),
('Elite', 11), ('Elite', 12), ('Elite', 13), ('Elite', 14), ('Sub23', 15), ('Elite', 16), ('Elite', 17), ('Sub23', 18), ('Sub23', 19), ('Sub23', 20),
('Elite', 21), ('Elite', 22), ('Elite', 23), ('Elite', 24), ('Sub23', 25), ('Sub23', 26), ('Sub23', 27), ('Elite', 28), ('Sub23', 29), ('Elite', 30),
('Elite', 31), ('Elite', 32), ('Elite', 33), ('Elite', 34), ('Elite', 35), ('Elite', 36), ('Elite', 37), ('Elite', 38), ('Elite', 39), ('Elite', 40),
('Elite', 41), ('Elite', 42), ('Elite', 43), ('Elite', 44), ('Elite', 45), ('Elite', 46), ('Elite', 47), ('Elite', 48), ('Elite', 49), ('Elite', 50),
('Elite', 51), ('Elite', 52), ('Elite', 53), ('Elite', 54), ('Elite', 55), ('Elite', 56), ('Elite', 57), ('Elite', 58), ('Sub23', 59), ('Elite', 60),
('Elite', 61), ('Elite', 62), ('Elite', 63), ('Elite', 64), ('Elite', 65), ('Elite', 66), ('Elite', 67), ('Elite', 68), ('Elite', 69), ('Elite', 70),
('Elite', 71), ('Elite', 72), ('Elite', 73), ('Elite', 74), ('Elite', 75), ('Elite', 76), ('Elite', 77), ('Elite', 78), ('Elite', 79), ('Elite', 80),
('Elite', 81), ('Elite', 82), ('Elite', 83), ('Elite', 84), ('Elite', 85), ('Elite', 86), ('Elite', 87), ('Sub23', 88), ('Elite', 89), ('Elite', 90),
('Elite', 91), ('Elite', 92), ('Elite', 93), ('Elite', 94), ('Elite', 95), ('Elite', 96), ('Elite', 97), ('Elite', 98), ('Elite', 99), ('Elite', 100),
('Sub23', 101), ('Elite', 102), ('Elite', 103), ('Elite', 104), ('Elite', 105), ('Elite', 106), ('Elite', 107), ('Elite', 108), ('Elite', 109), ('Elite', 110),
('Elite', 111), ('Elite', 112), ('Elite', 113), ('Elite', 114);


INSERT INTO Categoria_Equipa (categoria, ID_equipa)
VALUES
('UCI ProTeam', 1),  -- ATF
('UCI ProTeam', 2),  -- PEC
('UCI ProTeam', 3),  -- ALL
('UCI ProTeam', 4),  -- TAV
('UCI ProTeam', 5),  -- A6D
('UCI WorldTeam', 6),  -- EFP
('UCI ProTeam', 7),  -- IBA
('UCI WorldTeam', 8),  -- CDF
('UCI ProTeam', 9),  -- RPB
('UCI ProTeam', 10), -- GSU
('Continentais UCI', 11), -- LAA
('UCI ProTeam', 12), -- TSL
('UCI Ciclocrosse Profissionais', 13), -- ATI
('UCI WorldTeam', 14), -- CJR
('Seleção Nacional', 15), -- ICA
('Seleção Nacional', 16); -- PTL


INSERT INTO Patrocinador (nome, contacto) 
VALUES
('Continente', 'https://www.continente.pt'),
('Fidelidade', 'https://www.fidelidade.pt'),
('Shimano', 'https://www.shimano.com'),
('Vitalis', 'https://www.vitalis.pt'),
('Sabseg', 'https://www.sabseg.pt'),
('Cosmos', 'https://www.cosmos.pt'),
('Valpirent', 'https://www.valpirent.pt'),
('ABTF Betão', 'instagram: @abtf_betao');


INSERT INTO Especificacao_Bicicleta (especificacao, Codigo_bicicleta) 
VALUES
('Grupo: Shimano Dura-Ace Di2, Quadro: Carbono Aero', 0001),
('Grupo: SRAM Red eTap, Quadro: Carbono Endurance', 0002),
('Grupo: Campagnolo Super Record, Quadro: Carbono Leve', 0003),
('Rodas: Carbon Clincher 50mm, Pneus 25mm', 0004),
('TT Setup: Aerobar + Disco Traseiro', 0005),
('Transmissão: Shimano Ultegra, Quadro: Carbono Compact', 0006);


INSERT INTO Formato_Etapa (formato, ID_Etapa) VALUES
('Prologo', 1),
('Linha', 2),
('Linha', 3),
('Montanha', 4),      
('Linha', 5),
('Linha', 6),
('Montanha', 7),     
('Linha', 8),
('Linha', 9),         
('Contrarrelogio Individual', 10);


INSERT INTO Orienta (ID_equipa, UCI_ID_DiretorDesportivo) VALUES


  -- 1) INCLUI — ligar Etapa ↔ Competição
INSERT INTO Inclui (ID_Etapa, ID_competicao) VALUES
(1, 1),
(2, 1),
(3, 1),
(4, 1),
(5, 1),
(6, 1),
(7, 1),
(8, 1),
(9, 1),
(10,1);


-- 2) PARTICIPA — ciclista participa em etapa
-- Exemplo fictício: ciclistas 1 a 10 participam em todas as 10 etapas
INSERT INTO Participa (ID_etapa, UCI_ID_ciclista) VALUES
(1,1),(1,2),(1,3),(1,4),(1,5),(1,6),(1,7),(1,8),(1,9),(1,10),
(2,1),(2,2),(2,3),(2,4),(2,5),(2,6),(2,7),(2,8),(2,9),(2,10),
(3,1),(3,2),(3,3),(3,4),(3,5),(3,6),(3,7),(3,8),(3,9),(3,10),
(4,1),(4,2),(4,3),(4,4),(4,5),(4,6),(4,7),(4,8),(4,9),(4,10),
(5,1),(5,2),(5,3),(5,4),(5,5),(5,6),(5,7),(5,8),(5,9),(5,10),
(6,1),(6,2),(6,3),(6,4),(6,5),(6,6),(6,7),(6,8),(6,9),(6,10),
(7,1),(7,2),(7,3),(7,4),(7,5),(7,6),(7,7),(7,8),(7,9),(7,10),
(8,1),(8,2),(8,3),(8,4),(8,5),(8,6),(8,7),(8,8),(8,9),(8,10),
(9,1),(9,2),(9,3),(9,4),(9,5),(9,6),(9,7),(9,8),(9,9),(9,10),
(10,1),(10,2),(10,3),(10,4),(10,5),(10,6),(10,7),(10,8),(10,9),(10,10);


-- 3) PERTENCE — ciclista pertence a uma equipa durante o período da prova  
INSERT INTO Pertence (data_inicio, data_fim, ID_equipa, UCI_ID_Ciclista) VALUES
('2025-08-01','2025-08-17', 1, 1),
('2025-08-01','2025-08-17', 1, 2),
('2025-08-01','2025-08-17', 2, 3),
('2025-08-01','2025-08-17', 2, 4),
-- ... continua para todos os ciclistas/equipa que participam ...


-- 4) PATROCINA — equipa patrocinada por patrocinador
-- Exemplo: equipa 1 (ID=1) é patrocinada por 'Continente' e 'Shimano' durante 2025
INSERT INTO Patrocina (data_inicio, data_fim, ID_equipa, Nome_patrocinador) VALUES
('2025-01-01','2025-12-31', 1, 'Continente'),
('2025-01-01','2025-12-31', 1, 'Shimano');


-- 5) E_Patrocinado — patrocinador da competição
-- A competição 1 (Volta 2025) tem como patrocinadores 'Continente' e 'Fidelidade'
INSERT INTO E_Patrocinado (data_inicio, data_fim, ID_competicao, Nome_patrocinador) VALUES
('2025-01-01','2025-08-17', 1, 'Continente'),
('2025-01-01','2025-08-17', 1, 'Fidelidade');


-- 6) Disponibiliza — ligando classificação à competição  
-- Exemplo: todas as classificações (IDs 1 a 14) são relevantes para a competição 1
INSERT INTO Disponibiliza (ID_classificacao, ID_competicao) VALUES
(1,1),(2,1),(3,1),(4,1),(5,1),(6,1),(7,1),(8,1),(9,1),(10,1),
(11,1),(12,1),(13,1),(14,1);

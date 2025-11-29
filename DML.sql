INSERT INTO Competição (organizador, nome, datainicio, datafim, n_etapas)
VALUES
('Volta a Portugal', '86ª Volta a Portugal', '2025-08-06', '2025-08-17', 10);


INSERT INTO Etapa (duracao, numetapa, distancia, velocidademedia)
VALUES
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



INSERT INTO Pessoa (nome, nacionalidade, datanascimento)
VALUES
  ('Artem Nych', 'Rússia', '1995-03-21'),
  ('Rubén Fernández', 'Espanha', '1991-03-01'),
  ('Fábio Costa', 'Portugal', '1999-07-04'),
  ('Pedro Silva', 'Portugal', '2001-07-07'),
  ('Harrison Wood', 'Reino Unido', '2000-06-14'),
  ('Rafael Reis', 'Portugal', '1992-07-15'),
  ('Alexis Guerin', 'França', '1992-06-06'),
  ('Iúri Leitão', 'Portugal', '1998-07-03'),
  ('Julen Arriola‑Bengoa', 'Espanha', '2001-02-16'),
  ('Joseba López', 'Espanha', '2000-03-05'),
  ('Calum Johnston', 'Reino Unido', '1998-11-01'),
  ('Francisco Peñuela', 'Venezuela', '2001-02-01'),
  ('Tyler Stites', 'Estados Unidos', '1998-03-18'),
  ('Alex Díaz', 'Espanha', '2001-07-28'),
  ('Zac Marriage', 'Austrália', '2003-11-12'),
  ('Brady Gilmore', 'Austrália', '2001-04-14'),
  ('Moritz Kretschy', 'Alemanha', '2002-05-12'),
  ('Daniel Lima', 'Portugal', '2004-12-12'),
  ('Pau Martí', 'Espanha', '2004-11-24'),
  ('Jens Verbrugghe', 'Bélgica', '2004-09-23'),
  ('Rotem Tene', 'Israel', '2001-03-30'),
  ('Jonathan Klever Caicedo', 'Equador', '1993-04-28'),
  ('Edgar Cadena', 'México', '2000-08-20'),
  ('Edison Callejas', 'Colômbia', '2000-11-25'),
  ('César Leonel Cisneros', 'México', NULL),
  ('Carlos García Alfonso', 'Espanha', NULL),
  ('Yeferson Camargo', 'Colômbia', NULL),
  ('Andrii Ponomar', 'Ucrânia', NULL),
  
  -- ATF (AP Hotels & Resorts / Tavira / SC Farense)
  ('Afonso Silva', 'Portugal', NULL),
  ('Carlos Salgueiro', 'Portugal', NULL),
  ('Diogo Barbosa', 'Portugal', NULL),
  ('Francisco Campos', 'Portugal', NULL),
  ('Ailetz Lasa', 'Espanha', NULL),
  ('Diogo Pinto', 'Portugal', NULL),
  ('Jesús Peña', 'Colômbia', NULL),
  
  -- PEC (Project Echelon Racing)
  ('Kieran Haug', 'Estados Unidos', NULL),
  ('Richard Arnopol', 'Estados Unidos', NULL),
  ('Samuel Boardman', 'Estados Unidos', NULL),
  ('Cade Bickmore', 'Estados Unidos', NULL),
  ('Caleb Classen', 'Estados Unidos', NULL),
  ('Laurent Gervais', 'Canadá', NULL),
  ('Hugo Scala Jr', 'Estados Unidos', NULL),
  
  -- ALL (Aviludo – Louletano – Loulé)
  ('Nicolás Tivani', 'Argentina', NULL),
  ('Tomas Contte', 'Argentina', NULL),
  ('Jesús del Pino', 'Espanha', NULL),
  ('David Domínguez', 'Espanha', NULL),
  ('Carlos Oyarzún', 'Chile', NULL),
  ('Cláudio Leal', 'Portugal', NULL),
  ('Jorge Gálvez', 'Espanha', NULL),
  
  -- TAV (Tavfer – Ovos Matinados – Mortágua)
  ('João Matias', 'Portugal', NULL),
  ('Bruno Silva', 'Portugal', NULL),
  ('Leangel Linárez', 'Venezuela', NULL),
  ('Francisco Morais', 'Portugal', NULL),
  ('Gonçalo Carvalho', 'Portugal', NULL),
  ('César Martingil', 'Portugal', NULL),
  ('Ángel Sánchez', 'Espanha', NULL),
  
  -- A6D (Atom 6 Bikes – Decca)
  ('Oliver Bleddyn', 'Austrália', NULL),
  ('Matthew King', 'Reino Unido', NULL),
  ('Jan Kino', 'Bélgica', NULL),
  ('Angus Miller', 'Austrália', NULL),
  ('Jeremy Smith', 'Austrália', NULL),
  ('Bogdan Zabelinskiy', 'Chipre', NULL),
  ('Matthew May', 'Reino Unido', NULL),
  
  -- EFP (Efapel Cycling)
  ('Joaquim Silva', 'Portugal', NULL),
  ('Tiago Antunes', 'Portugal', NULL),
  ('André Carvalho', 'Portugal', NULL),
  ('Maurício Moreira', 'Uruguai', NULL),
  ('Santiago Mesa', 'Colômbia', NULL),
  ('Pedro Pinto', 'Portugal', NULL),
  ('António Ferreira', 'Portugal', NULL),
  ('Aleksandr Grigorev', 'Rússia', NULL),
  ('Keegan Swirbul', 'Estados Unidos', NULL),
  ('Oriol Vidal', 'Espanha', NULL),
  
  -- IBA (Illes Balears Arabay)
  ('Edgar Curto', 'Portugal', NULL),
  ('Unai Esparza', 'Espanha', NULL),
  ('Ricard Fitó', 'Espanha', NULL),
  ('Sebastian Mora', 'Espanha', NULL),
  ('Álvaro Sagrado', 'Espanha', NULL),
  ('Joan Roca', 'Espanha', NULL),
  ('Sergio Trueba', 'Espanha', NULL),
  
  -- CDF (Feirense – Beeceler)
  ('António Carvalho', 'Portugal', NULL),
  ('Byron Munton', 'Reino Unido', NULL),
  ('Francisco Pereira', 'Portugal', NULL),
  ('Diogo Gonçalves', 'Portugal', NULL),
  ('Ivo Pinheiro', 'Portugal', NULL),
  ('Fábio Oliveira', 'Portugal', NULL),
  ('Pedro Andrade', 'Portugal', NULL),
  
  -- RPB (Rádio Popular – Paredes – Boavista)
  ('Lucas Lopes', 'Portugal', NULL),
  ('Tiago Leal', 'Portugal', NULL),
  ('Hélder Gonçalves', 'Portugal', NULL),
  ('Daniel Dias', 'Portugal', NULL),
  ('César Fonte', 'Portugal', NULL),
  ('Raul Rota', 'Portugal', NULL),
  ('Gonçalo Amado', 'Portugal', NULL),
  
  -- GSU (GI Group Holding – Simoldes – UDO)
  ('Rui Carvalho', 'Portugal', NULL),
  ('Gaspar Gonçalves', 'Portugal', NULL),
  ('André Ribeiro', 'Portugal', NULL),
  ('Miquel Valls', 'Espanha', NULL),
  ('Adrian Bustamante', 'Chile', NULL),
  ('Cesar Guavita', 'Colômbia', NULL),
  ('Andrey André', 'Rússia', NULL),
  
  -- LAA (Credibom / LA Alumínios / Marcos Car)
  ('Emanuel Duarte', 'Portugal', NULL),
  ('Gonçalo Leaça', 'Portugal', NULL),
  ('João Medeiros', 'Portugal', NULL),
  ('Diogo Pinto', 'Portugal', NULL),
  ('Hugo Nunes', 'Portugal', NULL),
  ('Diogo Narciso', 'Portugal', NULL),
  ('Alexandre Montez', 'Portugal', NULL),
  ('Daniel Jorge', 'Portugal', NULL),
  
  -- TSL (Team Skyline)
  ('Adam Lewis', 'Reino Unido', NULL),
  ('Jack Makohon', 'Estados Unidos', NULL),
  ('Conn Mc Dunphy', 'Irlanda', NULL),
  ('Sean Christian', 'Estados Unidos', NULL),
  ('Cian Keogh', 'Irlanda', NULL),
  ('Liam Flanagan', 'Irlanda', NULL),

  -- Diretor Desportivo
  ('Ruben Pereira','Portugal','1992-05-28'),
  ('Jose Reviejo','Espanha',NULL),
  ('Tim Elverson','Reino Unido',NULL),
  ('Marco Bellini','Itália',NULL),
  ('Vidal Fitas','Portugal',NULL),
  ('Isaiah Newkirk','Estados Unidos',NULL),
  ('Américo Silva','Portugal',NULL),
  ('Gustavo Veloso','Espanha',NULL),
  ('Stijn De Vriese','Bélgica',NULL),
  ('José Azevedo','Portugal',NULL),
  ('Daniel Navarro','Espanha',NULL),
  ('Joaquim Andrade','Portugal',NULL),
  ('José Santos','Portugal',NULL),
  ('Manuel Correia','Portugal',NULL),
  ('Hernâni Brôco','Portugal',NULL),
  ('Michael Tacci','Estados Unidos',NULL);


INSERT INTO Equipa (paisorigem, numciclistas, nome, anofundacao, UCI_ID_DiretorDesportivo)
VALUES
('Portugal', 7, 'ATF', 2004, NULL),
('Estados Unidos', 7, 'PEC', 2010, NULL),
('Portugal', 7, 'ALL', 1983, NULL),
('Portugal', 7, 'TAV', 2006, NULL),
('Austrália', 7, 'A6D', 2015, NULL),
('Portugal', 10, 'EFP', 2006, NULL),
('Espanha', 7, 'IBA', 2012, NULL),
('Portugal', 7, 'CDF', 1995, NULL),
('Portugal', 7, 'RPB', 1998, NULL),
('Portugal', 7, 'GSU', 2014, NULL),
('Portugal', 8, 'LAA', 2011, NULL),
('Irlanda', 6, 'TSL', 2016, NULL);

INSERT INTO Ciclista (numdorsal, UCI_ID)
VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7),
(8, 8),
(9, 9),
(10, 10),
(11, 11),
(12, 12),
(13, 13),
(14, 14),
(15, 15),
(16, 16),
(17, 17),
(18, 18),
(19, 19),
(20, 20),
(21, 21),
(22, 22),
(23, 23),
(24, 24),
(25, 25),
(26, 26),
(27, 27),
(28, 28),
(29, 29),
(30, 30),
(31, 31),
(32, 32),
(33, 33),
(34, 34),
(35, 35),
(36, 36),
(37, 37),
(38, 38),
(39, 39),
(40, 40),
(41, 41),
(42, 42),
(43, 43),
(44, 44),
(45, 45),
(46, 46),
(47, 47),
(48, 48),
(49, 49),
(50, 50),
(51, 51),
(52, 52),
(53, 53),
(54, 54),
(55, 55),
(56, 56),
(57, 57),
(58, 58),
(59, 59),
(60, 60),
(61, 61),
(62, 62),
(63, 63),
(64, 64),
(65, 65),
(66, 66),
(67, 67),
(68, 68),
(69, 69),
(70, 70),
(71, 71),
(72, 72),
(73, 73),
(74, 74),
(75, 75),
(76, 76),
(77, 77),
(78, 78),
(79, 79),
(80, 80),
(81, 81),
(82, 82),
(83, 83),
(84, 84),
(85, 85),
(86, 86),
(87, 87),
(88, 88),
(89, 89),
(90, 90),
(91, 91),
(92, 92),
(93, 93),
(94, 94),
(95, 95),
(96, 96),
(97, 97),
(98, 98),
(99, 99),
(100, 100),
(101, 101),
(102, 102),
(103, 103),
(104, 104),
(105, 105),
(106, 106),
(107, 107),
(108, 108),
(109, 109),
(110, 110),
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
-- CLASSIFICAÇÃO GERAL FINAL (top 10)
------------------------------------------------------------
INSERT INTO Classificacao (diferenca_vencedor, posicao)
VALUES 
(0, 1),           -- Artem Nych
(75, 2),          -- Alexis Guerin (+1:15)
(111, 3),         -- Byron Munton (+1:51)
(144, 4),         -- Jesus David Peña (+2:24)
(194, 5),         -- Tiago Antunes (+3:14)
(272, 6),         -- Pedro Silva (+4:32)
(282, 7),         -- Edgar Cadena (+4:42)
(285, 8),         -- Emanuel Duarte (+4:45)
(330, 9),         -- Lucas Lopes (+5:30)
(331, 10);        -- Adrián Bustamante (+5:31)

(0, 1),   -- Pontos (Tivani)
(0, 1),   -- Montanha (Hugo Nunes)
(0, 1),   -- Juventude (Lucas Lopes)
(0, 1);   -- Equipas (Anicolor/Tien21)

------------------------------------------------------------
-- CATEGORIA PARA CLASSIFICAÇÕES DA GERAL (1–10)
------------------------------------------------------------
INSERT INTO Categoria_Classificacao (categoria, ID_classificacao)
VALUES
('Geral', 1),
('Geral', 2),
('Geral', 3),
('Geral', 4),
('Geral', 5),
('Geral', 6),
('Geral', 7),
('Geral', 8),
('Geral', 9),
('Geral', 10);
('Pontos', 11),
('Montanha', 12),
('Juventude', 13),
('Equipas', 14);

------------------------------------------------------------
-- PRÓLOGO – 06/08/2025 – vencedor: Rafael Reis – 3:51
------------------------------------------------------------
INSERT INTO ResultadoEtapa (tempofinal, penalizacaotempo, bonificaotempo, UCI_ID_ciclista, ID_etapa, ID_classificacao)
('00:03:51', '00:00:00', '00:00:00',
        --ID_DO_CICLISTA_REIS, --ID_ETAPA_PROLOGO, --ID_CLASSIF_ETAPA_PROLOGO);

('04:05:00', '00:00:00', '00:00:10',
        --ID_TIVANI, --ID_ETAPA1, --ID_CLASSIF_ETAPA1);

('04:32:00', '00:00:00', '00:00:10',
        --ID_TIVANI, --ID_ETAPA9, --ID_CLASSIF_ETAPA9);
('00:19:45', '00:00:00', '00:00:00',
        --ID_REIS, --ID_ETAPA10, --ID_CLASSIF_ETAPA10);



INSERT INTO Camisola_Ciclista (camisola, UCI_ID_ciclista)
VALUES
('Amarela', --ID_NYCH),
('Verde', --ID_TIVANI),
('Azul', --ID_HUGO_NUNES),
('Branca', --ID_LUCAS_LOPES);

INSERT INTO Categoria_Ciclista (categoria, UCI_ID_ciclista)
VALUES
('Geral', --ID_NYCH),
('Sprinter', --ID_TIVANI),
('Montanha', --ID_HUGO_NUNES),
('Jovem', --ID_LUCAS_LOPES);


INSERT INTO Categoria_Equipa (categoria, ID_equipa)
VALUES
('ClassificacaoEquipas', --ID_ANICOLOR);


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

-- Assumindo que 'Rúben Pereira' já existe na tabela Pessoa com UCI_ID = 14
INSERT INTO DiretorDesportivo (UCI_ID) VALUES
(112),  -- Ruben Pereira
(113),  -- Jose Reviejo
(114),  -- Tim Elverson
(115),  -- Marco Bellini
(116),  -- Vidal Fitas
(117),  -- Isaiah Newkirk
(118),  -- Américo Silva
(119),  -- Gustavo Veloso
(120),  -- Stijn De Vriese
(121),  -- José Azevedo
(122),  -- Daniel Navarro
(123),  -- Joaquim Andrade
(124),  -- José Santos
(125),  -- Manuel Correia
(126),  -- Hernâni Brôco
(127);  -- Michael Tacci



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
('Montanha', 4),      -- Senhora da Graça (etapa de montanha)
('Linha', 5),
('Linha', 6),
('Montanha', 7),      -- Torre / subida relevante
('Linha', 8),
('Linha', 9),         -- Montejunto foi dura mas classifiquei como 'Linha' se preferires 'Montanha' muda
('Contrarrelogio Individual', 10);


  -- 1) INCLUI — ligar Etapa ↔ Competição
-- Supondo que a competição tem ID = 1
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
-- Exemplo genérico; adaptar datas (início/fim) conforme a tua lógica
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






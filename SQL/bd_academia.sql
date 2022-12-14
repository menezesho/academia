CREATE DATABASE BD_ACADEMIA;

USE BD_ACADEMIA;

CREATE TABLE PROFESSOR(
	IDPROFESSOR		INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	NOME			VARCHAR(50) NOT NULL,
	CPF				CHAR(11) NOT NULL, --UNIQUE
	IDADE			INT NOT NULL,
	CELULAR			CHAR(11) NOT NULL,
	EMAIL			VARCHAR(50) NOT NULL,
	SENHA			VARCHAR(30) NOT NULL,

	RUA				VARCHAR(100) NOT NULL,
	NUMERO			INT NOT NULL,
	APTO			VARCHAR(5),
	BAIRRO			VARCHAR(50) NOT NULL,
	CIDADE			VARCHAR(50) NOT NULL,
	ESTADO			CHAR(2) NOT NULL
);

CREATE TABLE ALUNO(
	IDALUNO		INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	NOME			VARCHAR(50) NOT NULL,
	CPF				CHAR(11) NOT NULL, --UNIQUE
	IDADE			INT NOT NULL,
	CELULAR			CHAR(11) NOT NULL,
	EMAIL			VARCHAR(50) NOT NULL,
	PESO			INT,
	ALTURA			INT,

	RUA				VARCHAR(100) NOT NULL,
	NUMERO			INT NOT NULL,
	APTO			VARCHAR(5),
	BAIRRO			VARCHAR(50) NOT NULL,
	CIDADE			VARCHAR(50) NOT NULL,
	ESTADO			CHAR(2) NOT NULL
);

CREATE TABLE AULA(
	IDAULA			INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	NOME			VARCHAR(50) NOT NULL,
	DIA				DATE NOT NULL,
	HORA			CHAR(3) NOT NULL
);

CREATE TABLE PARTICIPANTE(
	IDPARTICIPANTE	INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ID_AULA			INT NOT NULL,
	ID_ALUNO		INT,
	ID_PROFESSOR	INT,

	FOREIGN KEY (ID_AULA) REFERENCES AULA(IDAULA),
	FOREIGN KEY (ID_ALUNO) REFERENCES ALUNO(IDALUNO),
	FOREIGN KEY (ID_PROFESSOR) REFERENCES PROFESSOR(IDPROFESSOR)
);

SELECT * FROM PROFESSOR;
SELECT * FROM ALUNO;
SELECT * FROM AULA;
SELECT * FROM PARTICIPANTE;

--drop table participante
--drop table aula
--drop table aluno
--drop table professor

/*
INSERT INTO ALUNO (NOME, CPF, IDADE, CELULAR, EMAIL, PESO, ALTURA, RUA, NUMERO, BAIRRO, CIDADE, ESTADO)
VALUES ('Henrique Menezes', '12345678912', 19, '11222223333', 'henrique@gmail.com', 65, 178, 'Avenida da Moda', 123, 'Centro', 'Passos', 'MG');

INSERT INTO PROFESSOR (NOME, CPF, IDADE, CELULAR, EMAIL, SENHA, RUA, NUMERO, BAIRRO, CIDADE, ESTADO)
VALUES ('Jo?o da Silva', '32165498732', 23, '12123451234', 'joao@gmail.com', '321654', 'Ant?nio Carlos', 321, 'Centro', 'Passos', 'MG');

INSERT INTO AULA (NOME, DIA, HORA)
VALUES ('Jud?', '2022-11-09', '07h');
*/
SELECT * FROM PROFESSOR;
SELECT * FROM ALUNO;
SELECT * FROM AULA;
SELECT * FROM PARTICIPANTE;

SELECT AULA.NOME AS 'Aula', AULA.DIA AS 'Dia', AULA.HORA AS 'Hor?rio', ALUNO.NOME AS 'Aluno', PROFESSOR.NOME AS 'Professor' 
FROM PARTICIPANTE
LEFT JOIN AULA ON AULA.IDAULA = PARTICIPANTE.ID_AULA
LEFT JOIN ALUNO ON ALUNO.IDALUNO = PARTICIPANTE.ID_ALUNO
LEFT JOIN PROFESSOR ON PROFESSOR.IDPROFESSOR = PARTICIPANTE.ID_PROFESSOR
ORDER BY AULA.NOME;


--SELECT ALUNO.NOME, ALUNO.CPF FROM ALUNO JOIN PARTICIPANTE ON PARTICIPANTE.ID_ALUNO = ALUNO.IDALUNO WHERE PARTICIPANTE.ID_AULA = 1;
--SELECT PROFESSOR.NOME, PROFESSOR.CPF FROM PROFESSOR JOIN PARTICIPANTE ON PARTICIPANTE.ID_PROFESSOR = PROFESSOR.IDPROFESSOR WHERE PARTICIPANTE.ID_AULA = 1;
CREATE DATABASE BD_ACADEMIA

USE BD_ACADEMIA

CREATE TABLE professor(
	cracha INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50) NOT NULL,
	cpf CHAR(11) NOT NULL,
	idade INT,
	endereco VARCHAR(50),
	celular CHAR(11),
	email VARCHAR(50),
	usuario VARCHAR(20) NOT NULL,
	senha VARCHAR(30) NOT NULL
)

CREATE TABLE aluno(
	matricula INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50) NOT NULL,
	cpf CHAR(11) NOT NULL,
	idade INT,
	endereco VARCHAR(50),
	celular CHAR(11),
	email VARCHAR(50),
	peso FLOAT,
	altura FLOAT
)

CREATE TABLE aula(
	id			INT PRIMARY KEY IDENTITY(1,1),
	nome		VARCHAR(50) NOT NULL,
	dia			DATE NOT NULL,
	hora		CHAR(3) NOT NULL
)

CREATE TABLE participante(
	id			INT PRIMARY KEY IDENTITY(1,1),
	fkaula		INT,
	fkaluno		INT,
	fkprof		INT,

	FOREIGN KEY (fkaula) REFERENCES aula(id),
	FOREIGN KEY (fkaluno) REFERENCES aluno(matricula),
	FOREIGN KEY (fkprof) REFERENCES professor(cracha)
)

SELECT * FROM professor
SELECT * FROM aluno
SELECT * FROM aula
SELECT * FROM participante

--drop table participante
--drop table aula
--drop table aluno
--drop table professor


--INSERT INTO aluno (nome, cpf, idade, endereco, celular, email, peso, altura) VALUES ('Henrique Menezes', '11111111111', 19, 'Rua X', '33333333333', 'henrique.menezes@gmail.com', 65, 178)
--INSERT INTO professor (nome, cpf, idade, endereco, celular, email, usuario, senha) VALUES ('Henrique Menezes', '11111111111', 19, 'Rua X', '33333333333', 'henrique.menezes@gmail.com', 'henrique-mo', '321654')

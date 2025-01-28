create database Hospital;
use hospital;
CREATE TABLE paciente (
    cpf CHAR(11),
    rg CHAR(10),
    nome VARCHAR(50),
    bairro VARCHAR(20),
    cidade VARCHAR(20),
    cep CHAR(8),
    datanasc DATE
);
/*alet + add*/
alter table paciente add genero char(1);
alter table paciente add rua varchar (50);

/*alter+change*/
alter table paciente change rua endereco varchar(50);

/*alter + modify*/
alter table paciente modify nome varchar(100);

/*alter + alter*/
alter table paciente alter cidade set default 'Juiz de Fora';

/*alter + drop*/
alter table paciente drop bairro;

/*Colocando NOT NULL no atributo nome*/
alter table paciente modify nome varchar (100) not null;

/*Colocando dafaul no atributo cidade*/
alter table paciente change cidade cidade varchar(45) default 'Rio de Janeiro';

/*Definindo CPF como chave primária da tabela paciente*/
alter table paciente add constraint pk_paciente primary key (cpf);

/*Definindo CPF como chave primária da tabela paciente*/
alter table paciente drop primary key;
alter table paciente add constraint pk_paciente primary key (cpf,nome);

/*Adicionando a coluna uf na tabela paciente*/
alter table paciente add column uf char(2);

/*Cadastrando a chave alternatica ou candidata*/
alter table paciente add constraint ck_cid_uf unique (cidade, uf);

/*Cadastrando rg como chave alternativa*/
alter table paciente modify rg decimal(8) unique;

/*Criando a tabela doença*/
CREATE TABLE doenca (
    cid CHAR(5) PRIMARY KEY,
    descricao VARCHAR(100)
);

/*Criando a tabela médico*/
CREATE TABLE medico (
    crm DECIMAL(5) PRIMARY KEY,
    cpf DECIMAL(11),
    nome VARCHAR(100),
    rua VARCHAR(100),
    bairro VARCHAR(25),
    cidade VARCHAR(45),
    cep CHAR(10)
);

/*Criando a tabela especialidade*/
CREATE TABLE especialidade (
    rqe VARCHAR(10) PRIMARY KEY
);

/*Criando a tabela medico_especialidade*/
CREATE TABLE medico_especialidade (
    crm DECIMAL(5),
    rqe VARCHAR(10),
    PRIMARY KEY (crm , rqe),
    FOREIGN KEY (crm)
        REFERENCES medico (crm)
        ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (rqe)
        REFERENCES especialidade (rqe)
        ON DELETE CASCADE ON UPDATE CASCADE
);

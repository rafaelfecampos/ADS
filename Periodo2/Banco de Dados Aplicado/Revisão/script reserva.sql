CREATE TABLE cidade (
    codigocidade DECIMAL(4) PRIMARY KEY,
    nomecidade VARCHAR(40)
);
alter table aeronave change fabricante nomefabricante varchar(40);
alter table aeronave add capacidade int(3);

alter table assento alter classe set default 'Econômica',
add status varchar(15) default 'Disponível';

alter table cidade change nomecidade nomecidade varchar(40) not null;

alter table cliente add constraint ck_cpf unique(cpf);
alter table cliente change endereco endereco varchar(45);

alter table reserva modify codigocliente decimal(5) not null;

alter table voo modify numerovoo varchar(6) not null,
add status varchar(15);

insert into cidade values(1234, 'Rio de Janeiro'),(2345, 'São Paulo'),(3456, 'Belo Horizonte'),(4567, 'Brasília'),(5678, 'Juiz de Fora');


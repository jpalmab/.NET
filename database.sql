create database admin;
use database admin;

create table admin
(
    idAdmin int IDENTITY(1,1) NOT NULL, 
    cedula int,
    usuario varchar(50),
    contrasenia varchar(50), 
    primary key(idAdmin)
);
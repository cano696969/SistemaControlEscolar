Create database TutoVaiLogin
go

use TutoVaiLogin
go

create table Usuario
(
id_area varchar(5),
id_empleado varchar(5),
nombre varchar(50),
usuario varchar(10),
contraseña varchar(10)
);

insert into Usuario values('A0001','E0001','VaidrollTeam','Adm','Adm')
insert into Usuario values('A0002','E0002','Paul Romero Sanchez','Pa01','1234')
insert into Usuario values('A0003','E0003','Christian Rik Flores','Riki01','riki')

create proc sp_logueo_ez
@usuario varchar(10),
@clave varchar(10)
as
select id_area,nombre,usuario,contraseña from Usuario 
where usuario=@usuario and contraseña=@clave
go
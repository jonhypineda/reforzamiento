create database loginweb

use loginweb
go

create table usuario
(
usuario varchar (50),
clave varchar (25)
)

insert into usuario (usuario,clave)
values ('jonhy','abc191019')

insert into usuario (usuario,clave)
values ('ruben','def896523')

select * from usuario

--procedimiento almacenado

create procedure consultarusuario
@nomusuario varchar (50),
@contrase�a varchar (25)
as
begin
select usuario from usuario where @nomusuario =usuario and @contrase�a = clave;
end;

select usuario from usuario where usuario= 'jonhy' and clave= 'abc191019';


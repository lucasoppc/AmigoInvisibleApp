use master
go 
create database testAmigoInvisible6
go
use testAmigoInvisible6
go

create table pistas
(
	fecha datetime,
	texto varchar(1000)
)
go

create table codigo
(
	codigo bit
)
go

create table nombre
(
	nombre varchar(50)
)
go

create table ultimointento
(
	fecha datetime
)
go

create table preguntas
(
	id int identity,
	fecha datetime,
	texto varchar(5000)
)
go

create table intentos
(
	numero int identity,
	texto varchar(1000)
)
go

create table gano
(
	 gano bit not null
)

--ingreso de datos

insert into codigo (codigo) values(0)
go
insert into nombre (nombre) values( 'LUCAS HERNANDEZ')
go
insert into ultimointento (fecha) values(GETDATE()-1)
go
insert into gano (gano) values(0)
go


--prodecimientos almacenados

--agregar pregunta
create proc agregarpregunta @fecha datetime, @texto varchar(500) as
begin
	begin tran
		insert into preguntas (fecha,texto) values(@fecha,@texto)
	if(@@error = 0)
	begin
		commit tran
		return 1
	end
	else
	begin
	 rollback tran
	 return 0
	end
end
go

--ver preguntas
create proc verpreguntas as
begin
	select * from preguntas
end
go

--agregar pistas
create proc agregarpista @texto varchar(5000) as
begin
	begin tran
		insert into pistas (fecha,texto) values(getdate(),@texto)
	if(@@error = 0)
	begin
		commit tran
		return 1
	end
	else
	begin
	 rollback tran
	 return 0
	end
	
end
go

--obtener pistas
create proc obtenerpistas as
begin
	select * from pistas
end
go

--verificar codigo
create proc verificarcodigo as
begin
	if exists(select codigo from codigo where codigo=1)
	begin
		return 1
	end
	else
	begin
		return 0
	end
end
go

--codigoactivado
create proc codigoactivado as
begin
	update codigo set codigo=1
end
go

--codigodesactivado
create proc codigodesactivado as
begin
	update codigo set codigo=0
end
go


--verificar nombre
alter proc verificarnombre @nombre varchar(50) as
begin
	if exists(select * from nombre where nombre = @nombre)
	begin
	update codigo set codigo = 1
	return 1
	end
	else
	begin
	return 0
	end
end
go

create proc agregarIntento as
begin
	update ultimointento set fecha=getdate()
end
go



create proc obtenerultimointento as
begin
	select fecha from ultimointento
end
go

create proc ganar as
begin
	update gano set gano=1
end
go

create proc verificarganado as
begin
	if exists(select gano from gano where gano=1)
	begin
		return 1
	end
	else
	begin
		return 0
	end
end
go


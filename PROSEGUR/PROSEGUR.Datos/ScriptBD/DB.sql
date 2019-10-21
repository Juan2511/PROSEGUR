USE PROSEGUR;

Create Table TblEvaluacionServicio
(
	ClienteCorreo	Varchar(50)Primary Key,
    ClienteNombres	varchar(100) not null
);

Create Table TblDetalleEvaluacionServicio
(
	ClienteCorreo	Varchar(50),
    FechaCalificacion	Date not null,
    Calificacion	int not null,
    Primary Key (ClienteCorreo,FechaCalificacion),
    Foreign Key (ClienteCorreo) References TblEvaluacionServicio(ClienteCorreo)
);


Select ClienteCorreo,FechaCalificacion,Calificacion From TblDetalleEvaluacionServicio;
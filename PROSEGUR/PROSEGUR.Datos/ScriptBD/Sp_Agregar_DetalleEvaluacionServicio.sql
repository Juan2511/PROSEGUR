CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_Agregar_DetalleEvaluacionServicio`(
	IN ParamClienteCorreo	Varchar(50),
    IN ParamFechaCalificacion	Date,
    IN ParamCalificacion	int
)
BEGIN
	INSERT INTO TblDetalleEvaluacionServicio (ClienteCorreo,FechaCalificacion,Calificacion)
    VALUES(ParamClienteCorreo,ParamFechaCalificacion,ParamCalificacion);
END
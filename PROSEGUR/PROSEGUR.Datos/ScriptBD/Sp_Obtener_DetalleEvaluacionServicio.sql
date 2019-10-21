CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_Obtener_DetalleEvaluacionServicio`(
	IN ParamClienteCorreo	Varchar(50),
    IN ParamFechaCalificacion	Date
)
BEGIN
	Select ClienteCorreo,FechaCalificacion,Calificacion From tblDetalleEvaluacionServicio
    Where ClienteCorreo = ParamClienteCorreo And FechaCalificacion = ParamFechaCalificacion;
END
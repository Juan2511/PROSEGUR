CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_Listar_DetalleEvaluacionServicio`(
)
BEGIN
	Select TB.FechaCalificacion,TB.Calificacion,TA.ClienteCorreo,TA.ClienteNombres From TblEvaluacionServicio TA
    INNER JOIN tblDetalleEvaluacionServicio TB On TA.ClienteCorreo = TB.ClienteCorreo
    Order BY 1,2;
END
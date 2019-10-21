CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_Agregar_EvaluacionServicio`(
	In ParamClienteCorreo	Varchar(50),
    IN ParamClienteNombres	varchar(100)
)
BEGIN
	INSERT INTO TblEvaluacionServicio (
    ClienteCorreo,
    ClienteNombres
    ) 
    VALUES (
    ParamClienteCorreo,
    ParamClienteNombres
    );
END
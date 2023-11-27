DELIMITER $$

CREATE PROCEDURE ConsultarSysUsrPorUsuario(IN nome_usuario VARCHAR(20))
BEGIN
    SELECT * FROM sys_usr WHERE usr_user = nome_usuario;

END $$

DELIMITER ;
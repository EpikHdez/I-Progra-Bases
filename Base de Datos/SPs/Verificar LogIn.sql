USE CampeonatosDB;
GO

CREATE PROCEDURE CASP_VerificarLogIn
	@pUserName VARCHAR(100)
AS
BEGIN
	DECLARE @Email VARCHAR(100);
	
	SELECT @Email = CO.Email FROM Corredores CO WHERE CO.Email = @pUserName;
	
	IF @Email = @pUserName
		SELECT 1;
	ELSE
		BEGIN
			SELECT @Email = AD.UserName FROM Administradores AD WHERE AD.Username = @pUserName;

			IF @Email = @pUserName
				SELECT 2;
			ELSE
				SELECT -1;
		END
END
USE CampeonatosDB;
GO

CREATE PROCEDURE CASP_VerificarLogIn
	@pUserName VARCHAR(100),
	@return int OUTPUT
AS
BEGIN
	DECLARE @Email VARCHAR(100);
	
	SELECT @Email = CO.Email FROM Corredores CO WHERE CO.Email = @pUserName;
	
	IF @Email = @pUserName
	Begin
		set @return = 1;
		RETURN @return;
	End

	ELSE
	Begin
		set @return = -1;
		RETURN @return;
	End
END
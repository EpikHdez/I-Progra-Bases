USE ExamWeb

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Ins_Usuario]
(
@NombUsuar VARCHAR(20),
@Contraseña VARCHAR(20),
@CodTipoUsua VARCHAR(20),
@Seccion VARCHAR(10)
) 
AS INSERT INTO usuarios
(
cnombralum, ccontrase, ccodtipusu, cseccion
)
VALUES
(
@NombUsuar, @Contraseña, @CodTipoUsua, @Seccion
)

GO

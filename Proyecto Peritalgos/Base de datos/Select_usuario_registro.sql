USE [ExamWeb]
GO
/****** Object:  StoredProcedure [dbo].[Select_filter_usuarios]    Script Date: 05/29/2012 21:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE dbo.Select_filter_usuarios_registro
	(
	@cnombralum varchar(300), 
	@cseccion varchar(20)
	)
AS
 SELECT * FROM registresp 
 WHERE 
 (
	cnombralum LIKE '%' + @cnombralum + '%'
 )
 AND 
 (
	cseccion LIKE '%' + @cseccion + '%'
 )
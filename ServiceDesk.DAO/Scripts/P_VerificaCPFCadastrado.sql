Use ServiceDeskDB
Go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Luan Simoes
-- Description:	Acesso
-- =============================================
ALTER PROCEDURE P_VerificaCPFCadastrado
	@CPF		Varchar(11) 
AS
BEGIN
	
	Select Count(usu.CPF)
	From ServiceDeskDB.Dbo.T_Usuario As	Usu	
	Where (usu.CPF = @CPF)
		
END
GO

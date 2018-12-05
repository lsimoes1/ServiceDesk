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
CREATE PROCEDURE P_VerificaLoginCadastrado
	@Login		Varchar(11) 
AS
BEGIN
	
	SET NOCOUNT OFF

	Select Count(L.Usuario)
	From ServiceDeskDB.Dbo.T_Login As	L	
	Where (L.usuario = @Login)
		
END
GO

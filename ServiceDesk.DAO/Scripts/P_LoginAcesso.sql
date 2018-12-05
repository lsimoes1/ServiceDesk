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
Create PROCEDURE P_LoginAcesso 
	@Username Varchar(50)
	,@Senha		Varchar(50)
AS
BEGIN
	
	Select Lg.Usuario
		,Lg.Senha
		,Usu.CPF
	From ServiceDeskDB.Dbo.T_Login			As	Lg
	Join ServiceDeskDB.Dbo.T_Usuario		As	Usu	On	Lg.ID = Usu.ID
	Where Usuario = @Username
		And Senha = @Senha

END
GO

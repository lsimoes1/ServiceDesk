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
Create PROCEDURE P_ConsultaPessoa
	@Nome Varchar(50) = Null
	,@CPF		Varchar(11) = Null
AS
BEGIN
	
	Select Lg.Usuario
		,Lg.Senha
		,Lg.TipoUsuario
		,Usu.Nome
		,usu.Sobrenome
		,Tu.Descricao
		,Lg.ID
		,usu.CPF
		,usu.Endereco
		,usu.Sexo
	From ServiceDeskDB.Dbo.T_Login			As	Lg
	Join ServiceDeskDB.Dbo.T_Usuario		As	Usu	On	Lg.ID = Usu.ID
	Join ServiceDeskDB.Dbo.T_TipoUsuario	As	Tu	On	Tu.TipoUsuario = Lg.TipoUsuario
	Where (usu.Nome = @Nome Or CPF = @CPF)
		

END
GO

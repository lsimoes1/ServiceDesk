Use ServiceDeskDB
Go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE P_AtualizaCadastroPessoa
	@Login varchar(100)
	,@Senha Varchar(100)
	,@Nome Varchar(100)
	,@Sobrenome Varchar(100)
	,@CPF Varchar(11)
	,@Endereco varchar(500)
	,@Sexo	char(1)
	,@TipoUsuario Int

AS
BEGIN
	
	Update T_Usuario
	Set Nome = @Nome
	,Sobrenome = @Sobrenome
	,Endereco = @Endereco
	,Sexo = @Sexo
	Where CPF = @CPF

	Update t_login
	set TipoUsuario = @TipoUsuario
	Where Usuario = @Login

END
GO

use ServiceDeskDB
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE P_CadastrarLogin
	@Username		Varchar(50)
	,@Senha			Varchar(50)
	,@Nome			Varchar(50)
	,@Sobrenome		Varchar(50)
	,@CPF			varchar(11)
	,@Endereco		Varchar(500)
	,@Sexo			Char(1)
	,@TipoUsuario	Int
AS
BEGIN

	Insert Into T_Login (Usuario, Senha, TipoUsuario)
	Values (@Username, @Senha, @TipoUsuario)

	Insert Into T_Usuario (Nome, Sobrenome, CPF, Endereco, Sexo)
	Values (@Nome, @Sobrenome, @CPF, @Endereco, @Sexo)
END
GO

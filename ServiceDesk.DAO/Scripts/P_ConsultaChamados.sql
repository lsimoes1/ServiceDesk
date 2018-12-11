USE [ServiceDeskDB]
GO
/****** Object:  StoredProcedure [dbo].[P_ConsultaChamados]    Script Date: 11/12/2018 18:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Luan Simões
-- Create date: 
-- Description:	Consulta os chamados abertos

--	Exec P_ConsultaChamados 3, 'admin'

-- =============================================
ALTER PROCEDURE [dbo].[P_ConsultaChamados] 
	@TipoUsuario Int = Null
	,@Usuario	Varchar(100)
AS
BEGIN
	Select C.ID_Chamado
		,U.Nome
		,C.TituloChamado
		,C.DescricaoChamado
		,C.TipoChamado
		,C.Status
		,C.DataCriacao
		,C.DataAlteracao
		,c.Tratativa
	From T_Usuario		As	U
	Join T_Chamados		As	C	On	U.ID = C.ID_Usuario
	Where U.Nome = IIF(@TipoUsuario In (1), @Usuario, u.nome)

END

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
CREATE PROCEDURE P_AtualizaChamados
	@ID_Chamado Int
	,@Titulo Varchar(500)
	,@Descricao Varchar(500)
	,@Servico Varchar(500)

AS
BEGIN
	
	Update T_Chamados
	Set TituloChamado = @Titulo
	,DescricaoChamado = @Descricao
	,TipoChamado = @Servico
	Where ID_Chamado = @ID_Chamado

END
GO

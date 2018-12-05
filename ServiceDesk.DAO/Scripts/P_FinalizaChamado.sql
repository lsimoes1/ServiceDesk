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
CREATE PROCEDURE P_FinalizaChamados 
	@ID_Chamado Int
	,@Tratativa Varchar(500)

AS
BEGIN
	Update T_Chamados
	Set DataAlteracao = Getdate()
	,Status = 'FECHADO'
	,Tratativa = @Tratativa
	Where ID_Chamado = @ID_Chamado
END
GO

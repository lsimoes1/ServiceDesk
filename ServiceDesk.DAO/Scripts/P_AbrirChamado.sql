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
CREATE PROCEDURE P_AbrirChamado 
	@Id_Usuario Int
	,@TituloChamado Varchar(100)
	,@DescricaoChamado Varchar(500)
	,@TipoChamado Varchar(400)
AS
BEGIN
	Insert Into T_Chamados (ID_Usuario, TituloChamado, DescricaoChamado, TipoChamado, Status, DataAlteracao)
	Values(@Id_Usuario, @TituloChamado, @DescricaoChamado, @TipoChamado, 'ABERTO', Null)

END
GO

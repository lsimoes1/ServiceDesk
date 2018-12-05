
Create Table T_Login (
						ID				Int Identity Primary Key
						,Usuario		Varchar(50) Not Null 
						,Senha			Varchar(500)	Not Null
						,TipoUsuario	INT			Not Null
						,DataCadastro	DateTime	Default Getdate()
					 )

Create Table T_TipoUsuario	(
								ID		Int	identity
								,TipoUsuario		Int
								,Descricao			Varchar(100)
							)

Create Table T_Usuario  (
							ID				Int Identity Constraint FK_T_Usuario_Login Foreign Key (ID) References T_Login (ID)
							,Nome			Varchar(100)	Not Null
							,Sobrenome		Varchar(100)	Not Null
							,CPF			varchar(11)		Not Null
							,Endereco		Varchar(100)
							,Sexo			Varchar(1)		Not Null
							,DataCadastro	Datetime		Default Getdate()
						)


Drop table T_Chamados

Create Table T_Chamados (
							ID_Chamado			Int Identity (822,1)
							,ID_Usuario			Int	
							,TituloChamado		Varchar(500)
							,DescricaoChamado	VARCHAR(1000)
							,TipoChamado		Varchar(500)
							,Status				Varchar(20)
							,DataCriacao		DateTime	Default Getdate()
							,DataAlteracao		Datetime
							,Tratativa			Varchar(1000)

						)


Create table T_ServicoChamado (
								ID_ServicoChamado int identity
								,DescricaoServicoChamado	Varchar(500)
							  )

Insert Into T_Chamados (ID_Usuario, TituloChamado, DescricaoChamado, Status, DataAlteracao)
	Values(1, 'ChamadoTeste 2', 'Criando mais um chamado teste para verificação', 'ABERTO', Null)

Insert Into T_Chamados (ID_Usuario, TituloChamado, DescricaoChamado, Status, DataAlteracao)
	Values(2, 'ChamadoTeste 3', 'Criando um chamado de colaborador teste', 'ABERTO', Null)


Insert into T_ServicoChamado (DescricaoServicoChamado)
Values('Limpeza')

Insert into T_ServicoChamado (DescricaoServicoChamado)
Values('Remoção de Vírus')

Insert into T_ServicoChamado (DescricaoServicoChamado)
Values('Formatação')

Insert into T_ServicoChamado (DescricaoServicoChamado)
Values('Troca de Componetes')


Insert Into T_Login (Usuario, Senha, TipoUsuario)
	Values ('admin', 'admin', 3)

Insert Into T_Usuario (Nome, Sobrenome, CPF, Endereco, Sexo)
	Values ('Administrator', '', '00000000000', Null, 'M')

Insert Into T_TipoUsuario (TipoUsuario, Descricao)
	Values (1 , 'Colaborador')

	
Insert Into T_TipoUsuario (TipoUsuario, Descricao)
	Values (2 , 'TI Suporte')


Insert Into T_TipoUsuario (TipoUsuario, Descricao)
	Values (3 , 'Gerente')


	Drop table T_Chamados
	Drop Table T_TipoUsuario
	Drop Table T_Usuario

	Drop table T_Login
	

Select *
From T_Login

Select *
From T_USuario

Select *
From T_Chamados

truncate table T_Chamados


update T_Chamados
set status = 'ABERTO'
	,DataAlteracao = Null
	,Tratativa = Null


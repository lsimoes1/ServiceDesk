

--Criação do Ambiente


truncate table T_Chamados

	Drop table T_Usuario

	Drop table T_Login

Create Table T_Login (
						ID				Int Identity Primary Key
						,Usuario		Varchar(50) Not Null 
						,Senha			Varchar(500)	Not Null
						,TipoUsuario	INT			Not Null
						,DataCadastro	DateTime	Default Getdate()
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

Insert Into T_Login (Usuario, Senha, TipoUsuario)
	Values ('admin', 'admin', 3)

Insert Into T_Usuario (Nome, Sobrenome, CPF, Endereco, Sexo)
	Values ('Administrator', '', '00000000000', Null, 'M')

Insert Into T_Login (Usuario, Senha, TipoUsuario)
	Values ('lsimoes', '123', 3)

Insert Into T_Usuario (Nome, Sobrenome, CPF, Endereco, Sexo)
	Values ('Luan', 'Simões', '40684748851', Null, 'M')

Insert Into T_Login (Usuario, Senha, TipoUsuario)
	Values ('jsilva', '123', 3)

Insert Into T_Usuario (Nome, Sobrenome, CPF, Endereco, Sexo)
	Values ('João', 'Silva', '48454847488', Null, 'M')


Insert Into T_Login (Usuario, Senha, TipoUsuario)
	Values ('daraujo', '123', 3)

Insert Into T_Usuario (Nome, Sobrenome, CPF, Endereco, Sexo)
	Values ('Douglas', 'Araújo', '25245484855', Null, 'M')


Insert Into T_Chamados (ID_Usuario, TituloChamado, DescricaoChamado, TipoChamado, Status, DataAlteracao)
	Values(2, 'Pc Lento', 'Poderiam por gentileza verificar o meu computador?', 'Limpeza','ABERTO', Null)


Insert Into T_Chamados (ID_Usuario, TituloChamado, DescricaoChamado, TipoChamado, Status, DataAlteracao)
	Values(3, 'Mouse Quebrado', 'Mouse com defeito, poderiam trocar?', 'Troca de Componetes', 'ABERTO', Null)

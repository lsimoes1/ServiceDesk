<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="ServiceDeskWeb.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="scripts/css/materialize.min.css" />
    <link rel="stylesheet" type="text/css" href="scripts/css/home.css" />
    <link rel="stylesheet" type="text/css" href="scripts/css/fonts.css" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="scripts/css/animated.css" />
    <link rel="stylesheet" type="text/css" href="scripts/css/load.css" />
    <script src="scripts/js/Jquery.js"></script>
    <script src="scripts/js/materialize.min.js"></script>
    <script src="scripts/js/home.js"></script>
</head>
<body>

    <!-- Modal Structure -->
    <div id="modalLoad" class="modal modalload">
        <div class="modal-content">
            <div class="lds-spinner">
                <div></div>
                <div></div>
                <div></div>
                <div></div>
                <div></div>
                <div></div>
                <div></div>
                <div></div>
                <div></div>
                <div></div>
                <div></div>
                <div></div>
            </div>
        </div>
    </div>

    <header>
        <div>
            <div>
                <div class="header-container">
                    <h2>ServiceDesk</h2>
                    <a id="linkheader" href="AppLogin.aspx"><i class="material-icons" id="iconheader">exit_to_app</i></a>
                </div>
            </div>
        </div>
    </header>

    <form id="form1" runat="server">
        <asp:ScriptManager runat="server" />

        <div class="row">
            <div class="col s3">
                <div class="DivInfoUsu">
                    <div class="DivInfoUsuDados">
                        <h6 class="hdInfoUso">Dados do Usuário</h6>

                        <label>Id: </label>
                        <label runat="server" id="infoIdColaborador"></label>

                        <br />

                        <label>Colaborador: </label>
                        <label runat="server" id="infoUsu"></label>

                        <br />

                        <label>Cargo: </label>
                        <label runat="server" id="infoTipoUso"></label>

                        <br />

                        <label>CPF: </label>
                        <label runat="server" id="infoCPFUsu"></label>

                    </div>
                </div>
                <div class="DivMenu">
                    <div class="DivInfoUsuDados">
                        <h6 class="hdInfoUso">Menu</h6>

                        <a class="ItensMenu modal-trigger" href="#modalNovoChamado" onclick="ModalNovoChamado()">
                            <div class="menuboard cont">
                                Novo Chamado 
                                    <i class="material-icons">playlist_add</i>
                            </div>
                        </a>

                        <a href="#modalAlteraCadastro" class="ItensMenu modal-trigger">
                            <div class="menuboard cont" id="lkAlteraCadastro">
                                Alterar Cadastro 
                                    <i class="material-icons">edit</i>
                            </div>
                        </a>

                        <a href="#modalNovoCadastro" class="ItensMenu modal-trigger">
                            <div class="menuboard cont" id="lkCadastraLogin">
                                Cadastrar Login 
                                    <i class="material-icons">person_add</i>
                            </div>

                        </a>

                        <asp:LinkButton runat="server" class="ItensMenu">
                                <div class="menuboard cont"> 
                                    Sair 
                                    <i class="material-icons">exit_to_app</i>
                                </div>
                        </asp:LinkButton>
                    </div>
                </div>
            </div>
            <div class="col s8">
                <div class="DivGridResult">
                    <asp:LinkButton runat="server" ID="lbAtualizaChamados" OnClick="lbAtualizaChamados_Click"><i  class="material-icons icon-options tooltipped" data-position="top" data-tooltip="Atualizar chamados">cached</i> </asp:LinkButton>
                    <label>
                        <asp:UpdatePanel runat="server">
                            <ContentTemplate>
                                <asp:GridView ID="GridChamados" runat="server" AutoGenerateColumns="true" CellSpacing="0">
                                </asp:GridView>
                            </ContentTemplate>
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="lbAtualizaChamados" EventName="Click" />
                            </Triggers>
                        </asp:UpdatePanel>
                    </label>
                </div>
            </div>
        </div>

        <!-- Modal Altera Chamado -->
        <div id="modalAlteraChamado" class="modal modal-fixed-footer">
            <div class="modal-content">
                <h4>Alteração de Chamado</h4>
                <div class="row">
                    <div class="col s12">
                        <div class="row">
                            <div class="input-field col s6">
                                <asp:TextBox runat="server" ID="IdChamadoAlteracao" type="text" class="validate"></asp:TextBox>
                                <label for="IdChamadoAlteracao">Id do Chamado</label>
                            </div>
                            <div class="input-field col s6">
                                <asp:TextBox runat="server" disabled ID="ColaboradorAlteracao" type="text" class="validate"> </asp:TextBox>
                                <label for="ColaboradorAlteracao">Colaborador</label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field col s6">
                                <asp:TextBox runat="server" disabled ID="StatusChamadoAlteracao" type="text" class="validate"></asp:TextBox>
                                <label for="StatusChamadoAlteracao">Status</label>
                            </div>
                            <div class="input-field col s6">
                                <asp:TextBox runat="server" disabled ID="DataChamadoAberto" type="text" class="validate"></asp:TextBox>
                                <label for="DataChamadoAberto">Data de Criação</label>
                            </div>

                        </div>
                        <div class="row">
                            <div class="input-field col s6">
                                <asp:TextBox runat="server" ID="TituloChamadoAlteracao" type="text" class="validate" />
                                <label for="TituloChamadoAlteracao">Título do Chamado</label>
                            </div>
                            <div class="input-field col s6">
                                <select runat="server" id="SelectTipoChamadoAlteracao">
                                    <option value="" disabled selected>Tipo do Chamado</option>
                                    <option value="Limpeza">Limpeza</option>
                                    <option value="Remoção de Vírus">Remoção de Vírus</option>
                                    <option value="Formatação">Formatação</option>
                                    <option value="Troca de Componetes">Troca de Componetes</option>
                                </select>
                                <label>Tipo do Chamado</label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col s12">

                                <div class="input-field col s12">
                                    <asp:TextBox runat="server" TextMode="multiline" type="text" ID="DescricaoChamadoAlteracao" class="materialize-textarea"></asp:TextBox>
                                    <label for="DescricaoChamadoAlteracao">Descrição Chamado</label>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="modal-footer">
                <asp:LinkButton runat="server" ID="btnAlteraChamado" OnClick="btnAlteraChamado_Click" class="modal-close waves-effect waves-green btn">Alterar</asp:LinkButton>
            </div>
        </div>

        <%--Modal Encerra Chamado--%>
        <div id="modalEncerraChamado" class="modal modal-fixed-footer">
            <div class="modal-content">
                <h4>Alteração de Chamado</h4>
                <div class="row">
                    <div class="col s12">
                        <div class="row">
                            <div class="input-field col s6">
                                <asp:TextBox runat="server" ID="IdModalEncerraChamado" type="text" class="validate"></asp:TextBox>
                                <label for="IdModalEncerraChamado">Id do Chamado</label>
                            </div>
                            <div class="input-field col s6">
                                <asp:TextBox runat="server" disabled ID="ColaboradorModalEncerraChamado" type="text" class="validate"> </asp:TextBox>
                                <label for="ColaboradorModalEncerraChamado">Colaborador</label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field col s6">
                                <asp:TextBox runat="server" disabled ID="StatusModalEncerraChamado" type="text" class="validate"></asp:TextBox>
                                <label for="StatusModalEncerraChamado">Status</label>
                            </div>
                            <div class="input-field col s6">
                                <asp:TextBox runat="server" disabled ID="DataAbertoModalEncerraChamado" type="text" class="validate"></asp:TextBox>
                                <label for="DataAbertoModalEncerraChamado">Data de Criação</label>
                            </div>

                        </div>
                        <div class="row">
                            <div class="input-field col s6">
                                <asp:TextBox runat="server" ID="TituloModalEncerraChamado" type="text" class="validate" />
                                <label for="TituloModalEncerraChamado">Título do Chamado</label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col s12">

                                <div class="input-field col s12">
                                    <asp:TextBox runat="server" TextMode="multiline" type="text" ID="TratativaModalEncerraChamado" class="materialize-textarea"></asp:TextBox>
                                    <label for="TratativaModalEncerraChamado">Informe o que foi realizado</label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="modal-footer">
                <asp:LinkButton runat="server" ID="btnEncerraChamado" OnClick="btnEncerraChamado_Click" class="modal-close waves-effect waves-green btn">Encerrar</asp:LinkButton>
            </div>
        </div>

        <%--Modal Novo Chamado--%>
        <div id="modalNovoChamado" class="modal modal-fixed-footer">
            <div class="modal-content">
                <h4>Novo Chamado</h4>
                <div class="row formNovoChamado">
                    <div class="col s6">
                        <div class="input-field">
                            <%--Título do Chamado--%>
                            <asp:TextBox runat="server" ID="frmNovoCadTituoCHamado" type="text" class="validate" onkeyup="HabilitaBtnSalvar()"></asp:TextBox>
                            <label for="frmNovoCadTituoCHamado">Título do Chamado</label>
                        </div>
                    </div>
                    <div class="col s6">
                        <div class="input-field">
                            <select runat="server" id="SelectValue">
                                <option value="" disabled selected>Tipo do Chamado</option>
                                <option value="Limpeza">Limpeza</option>
                                <option value="Remoção de Vírus">Remoção de Vírus</option>
                                <option value="Formatação">Formatação</option>
                                <option value="Troca de Componetes">Troca de Componetes</option>
                            </select>
                            <label>Tipo do Chamado</label>
                        </div>

                    </div>
                    <div class="row">
                        <div class="col s12">
                            <div class="input-field">
                                <asp:TextBox runat="server" TextMode="multiline" onkeyup="HabilitaBtnSalvar()" type="text" ID="frmNovoCadDescricao" class="materialize-textarea"></asp:TextBox>
                                <label for="frmNovoCadDescricao">Descrição Chamado</label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="modal-footer">
                <asp:LinkButton disabled ID="BtnSalvarNovoChamado" OnClick="BtnSalvarNovoChamado_Click" Text="Salvar" class="waves-effect waves-green btn" runat="server" />
            </div>
        </div>

        <%--Modal Altera Cadastro--%>
        <div id="modalAlteraCadastro" class="modal">
            <div class="modal-content">
                <h4>Alteração de Cadastro</h4>
            </div>
            <div class="modal-content">

                <%--PRIMEIRA DIV--%>
                <div id="DivConsulta_CPF">

                    <div class="row">
                        <asp:UpdatePanel ID="UpdatePanelConsultaCPF" runat="server">
                            <ContentTemplate>

                                <div class="input-field col s6">
                                    <asp:TextBox runat="server" ID="tbConsultaCPF" type="text" class="validate" onkeyup="HabilitaBotaoCPF()"></asp:TextBox>
                                    <label for="tbConsultaCPF">Digite o CPF ou Nome</label>
                                </div>

                            </ContentTemplate>
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="btnConsultaCPF" EventName="Click" />
                            </Triggers>
                        </asp:UpdatePanel>

                        <div class="modal-footer s6">
                            <asp:LinkButton disabled ID="btnConsultaCPF" OnClick="btnConsultaCPF_Click" Text="Consultar" class="waves-effect waves-green btn" runat="server" />
                        </div>
                    </div>
                </div>
            </div>
            <%--SEGUNDA DIV--%>
            <div class="modal-content">
                <div id="DivAlteraCadastro">
                    <div class="row">

                        <asp:UpdatePanel ID="updatePanelAlteraCadastro" runat="server" UpdateMode="Conditional">
                            <ContentTemplate>

                                <div class="input-field col s5">
                                    <asp:TextBox runat="server" ID="tbNomeAlteracao" type="text" class="validate"></asp:TextBox>
                                    <label class="active" for="tbNomeAlteracao">Nome</label>
                                </div>

                                <div class="input-field col s5">
                                    <asp:TextBox runat="server" ID="tbSobrenomeAlteracao" type="text" class="validate"></asp:TextBox>
                                    <label class="active" for="tbSobrenomeAlteracao">Sobrenome</label>
                                </div>


                                <div class="row">

                                    <div class="input-field col s5">
                                        <asp:TextBox runat="server" ID="tbCpfAlteracao" type="text" class="validate"></asp:TextBox>
                                        <label class="active" for="tbCpfAlteracao">CPF</label>
                                    </div>

                                    <div class=" col s5">

                                        <div class="input-field col s6">
                                            <span>Tipo Usuário</span>
                                            <select runat="server" id="SelectTipoUsuario">
                                                <option value="" disabled selected>Tipo do Chamado</option>
                                                <option value="1">Colaborador</option>
                                                <option value="2">Suporte</option>
                                                <option value="3">Gerente</option>
                                            </select>
                                        </div>

                                    </div>
                                </div>
                                <div class="row">

                                    <div class="input-field col s5">
                                        <span>Sexo</span>
                                        <select runat="server" id="SelectSexo">
                                            <option value="" disabled selected>Sexo</option>
                                            <option value="M">Masculino</option>
                                            <option value="F">Feminino</option>

                                        </select>
                                    </div>

                                </div>

                                <div class="row">
                                    <div class="input-field col s12">
                                        <asp:TextBox runat="server" ID="tbEnderecoAlteracao" type="text" class="validate"></asp:TextBox>
                                        <label class="active" for="tbEnderecoAlteracao">Endereço</label>
                                    </div>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                    <div class="row">
                        <div class="modal-footer">
                            <asp:LinkButton href="#modalAlteraCadastro" ID="btnVoltar" Text="Voltar" class="waves-effect waves-green btn" runat="server" />

                            <asp:LinkButton ID="btnAlteraCadastro" OnClick="btnAlteraCadastro_Click" Text="Salvar" class="waves-effect waves-green btn" runat="server" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div id="modalNovoCadastro" class="modal modal-fixed-footer">
            <div class="modal-content">
                <h4>Novo Cadastro</h4>
                <div class="row">
                    <div class="col s12">
                        <div class="row">
                            <div class="input-field col s6">
                                <asp:TextBox runat="server" ID="tbLoginNovoCad" type="text" class="validate"></asp:TextBox>
                                <label for="tbLoginNovoCad">Login</label>
                            </div>
                            <div class="input-field col s6">
                                <select runat="server" id="selectTipoUsuNovoCad">
                                    <option value="" disabled selected>Tipo do Usuário</option>
                                    <option value="Colaborador">Colaborador</option>
                                    <option value="Suporte/TI">Suporte/TI</option>
                                    <option value="Gerente">Gerente</option>
                                </select>
                                <label>Tipo do Usuário</label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field col s6">
                                <asp:TextBox runat="server" ID="tbNomeNovoCad" type="text" class="validate"> </asp:TextBox>
                                <label for="tbNomeNovoCad">Nome</label>
                            </div>

                            <div class="input-field col s6">
                                <asp:TextBox runat="server" ID="tbSobrenomeNovoCad" type="text" class="validate"></asp:TextBox>
                                <label for="tbSobrenomeNovoCad">Sobrenome</label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col s6">
                                <div class="input-field col s7">
                                    <asp:TextBox runat="server" ID="tbCpfNovoCad" type="text" class="validate"></asp:TextBox>
                                    <label for="tbCpfNovoCad">CPF</label>
                                </div>
                            </div>
                            <div class="col s5">
                                <div>
                                    <p>
                                        <label>
                                            <input name="sexGroup" runat="server" id="ckM" type="radio" />
                                            <span>Masculino</span>
                                        </label>
                                    </p>
                                    <p>
                                        <label>
                                            <input name="sexGroup" runat="server" id="ckF" type="radio" />
                                            <span>Feminino</span>
                                        </label>
                                    </p>

                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col s12">
                                <div class="input-field">
                                    <asp:TextBox runat="server" ID="tbEndNovoCad" type="text" class="validate"></asp:TextBox>
                                    <label for="tbEndNovoCad">Endereço</label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="modal-footer">
                    <asp:LinkButton ID="btnNovoCadastro" OnClick="btnNovoCadastro_Click" Text="Cadastrar" class="waves-effect waves-green btn" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>

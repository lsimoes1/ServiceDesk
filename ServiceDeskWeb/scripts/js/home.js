$(document).ready(function () {
    $('.tooltipped').tooltip();
    $('.modal').modal();
    $('select').formSelect();
    $('#DivConsulta_CPF').addClass('animated fadeInDown');
    $('#DivAlteraCadastro').hide();
    $('.DivInfoUsuDados').show();
    $('.DivGridResult').show();

    $('#btnConsultaCPF').click(function () {

        $('#DivConsulta_CPF').hide();

        $('#DivAlteraCadastro').addClass('animated zoomIn');

        $('#DivAlteraCadastro').show();

    });

    $("#BtnSalvarNovoChamado").click(function () {
        $("#modalLoad").modal('open');
    });
    $("#btnAlteraCadastro").click(function () {
        $("#modalLoad").modal('open');
    });
    $('#btnAlteraChamado').click(function () {
        $("#modalLoad").modal('open');
    });
    $('#btnEncerraChamado').click(function () {
        $("#modalLoad").modal('open');
    });

    $("#btnVoltar").click(function () {
        RetornaConsultaCadastro();
    });

    var TipoUsuario = $("#infoTipoUso").text();

    if (TipoUsuario == "Colaborador") {

        $("#lkAlteraCadastro").removeAttr('href');

        $("#lkAlteraCadastro").removeClass('menuboard');
        $("#lkAlteraCadastro").addClass('menuBoardDisabled');

        $("#lkCadastraLogin").removeClass('menuboard');
        $("#lkCadastraLogin").addClass('menuBoardDisabled');

        $(".menuBoardDisabled").click(function (e) {
            return false;
        });
    }

    GridTr();

    EfeitoGrid();
});

function RetornaConsultaCadastro() {
    $('#DivAlteraCadastro').hide();
    $("#DivConsulta_CPF").show();

    if ($("#tbConsultaCPF").val().length > 0) {
        $("#tbConsultaCPF label").addClass("active");
        M.updateTextFields();
    }
};

function GridTr() {

    $('.DivGridResult tbody').on('click', 'tr', function () {
        $('#IdChamadoAlteracao').val(this.children[0].textContent);
        $('#IdModalEncerraChamado').val(this.children[0].textContent);
        M.updateTextFields();

        $('#ColaboradorAlteracao').val(this.children[1].textContent);
        $('#ColaboradorModalEncerraChamado').val(this.children[1].textContent);
        M.updateTextFields();

        $('#DataChamadoAberto').val(this.children[6].textContent)
        $('#DataAbertoModalEncerraChamado').val(this.children[6].textContent)
        M.updateTextFields();

        $('#StatusChamadoAlteracao').val(this.children[5].textContent);
        $('#StatusModalEncerraChamado').val(this.children[5].textContent);
        M.updateTextFields();

        $('#DescricaoChamadoAlteracao').val(this.children[3].textContent);
        $('#DescricaoModalEncerraChamado').val(this.children[3].textContent);
        M.updateTextFields();

        $('#TituloChamadoAlteracao').val(this.children[2].textContent);
        $('#TituloModalEncerraChamado').val(this.children[2].textContent);
        M.updateTextFields();

        $("#SelectTipoChamadoAlteracao option:contains(" + this.children[4].textContent + ")").attr('selected', 'selected');

    });

}
function EfeitoGrid() {
    var Tr = document.querySelectorAll("tr");

    for (var i = 0; i < Tr.length; i++) {

        var Table = Tr[i];
        var Td = document.createElement('td');
        Td.classList.add('tdOptions');

        if (i == 0) {
            Td.textContent = '';
            Table.appendChild(Td);
        }
        else if (Tr[i].children[5].textContent == "FECHADO") {

            Td.innerHTML = '<a><i class="material-icons icon-options" style="color:green">done_all</i> <a />'
            Table.appendChild(Td);
            DoTimeout(Tr[i], i);
        }
        else {
            Td.innerHTML = '<a href="#modalAlteraChamado" onclick="GridTr()" class="modal-trigger"><i  class="material-icons icon-options tooltipped" data-position="bottom" data-tooltip="Alterar Chamado">create</i> <a/>' +
                '<a href="#modalEncerraChamado" onclick="GridTr()" class="modal-trigger"><i  class="material-icons icon-options tooltipped" data-position="bottom" data-tooltip="Encerrar chamado">close</i> <a/>';

            Table.appendChild(Td);
            DoTimeout(Tr[i], i);
        }
    }
};

function DoTimeout(tr, i) {
    setTimeout(function () {

        $(tr).addClass("animated fadeInDown");
        $(tr).show();
    }, 300 * i);
};

function ModalNovoChamado() {

    $('#frmNovoCadIdSolicitante').focus();

    $("#frmNovoCadIdSolicitante").val(document.querySelector('#infoIdColaborador').textContent);

    M.updateTextFields();
    $("#frmNovoCadColaborador").val(document.querySelector('#infoUsu').textContent);

    M.updateTextFields();
};

function HabilitaBtnSalvar() {
    var TituloChamado = $("#frmNovoCadTituoCHamado").val();
    var TipoChamado = $("#SelectValue").val();
    var Descricao = $("#frmNovoCadDescricao").val();

    if (TituloChamado.length > 0 && TipoChamado.length > 0 && Descricao.length > 0) {
        $('#BtnSalvarNovoChamado').removeAttr('disabled');
    }
    else {
        $('#BtnSalvarNovoChamado').attr('disabled', 'disabled');
    }
};

function HabilitaBotaoCPF() {
    var cpf = $('#tbConsultaCPF').val();

    if (cpf.length > 0) {
        $('#btnConsultaCPF').removeAttr('disabled');
    }
    else {
        $('#btnConsultaCPF').attr('disabled', 'disabled');
    }
};

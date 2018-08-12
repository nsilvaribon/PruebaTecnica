
$(document).ready(function () {
    loadData();
});

function loadData() {
    $.ajax({
        url: "/Usuario/List",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {
                var myDate = new Date(item.FechaNacimiento);
                html += '<tr>';
                html += '<td>' + item.NombreCompleto + '</td>';
                html += '<td>' + item.Direccion + '</td>';
                html += '<td>' + myDate.getDate() + "/" + (myDate.getMonth() + 1) + "/" + myDate.getFullYear() + '</td>';
                html += '<td>' + item.TipoDocumentoSelecionado.TipoDocumento + '</td>';
                html += '<td>' + item.NumeroDocumento + '</td>';
                html += '<td>' + item.Pais + '</td>';
                html += '<td>' + item.Departamento + '</td>';
                html += '<td>' + item.Ciudad + '</td>';
                html += '<td><a href="#" onclick="return getbyID(' + item.UserId + ')">Editar</a> | <a href="#" onclick="Delele(' + item.UserId + ')">Eliminar</a></td>';
                html += '</tr>';
            });
            $('.tbody').html(html);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function Add() {
    var res = validate();
    if (res == false) {
        return false;
    }
    var tipoDocumento={
        Id:$('#TipoDocumento').val(),
        TipoDocumento: $("#TipoDocumento option:selected").text(),
    };
    var usuarioObj = {
        NombreCompleto: $('#NombreCompleto').val(),
        Direccion: $('#Direccion').val(),
        FechaNacimiento: $('#FechaNacimiento').val(),
        TipoDocumento: $('#TipoDocumento').val(),
        TipoDocumentoSelecionado: tipoDocumento,
        NumeroDocumento: $('#NumeroDocumento').val(),
        Pais: $('#Pais').val(),
        Departamento: $('#Departamento').val(),
        Ciudad: $('#Ciudad').val()
    };
    $.ajax({
        url: "/Usuario/Save",
        data: JSON.stringify(usuarioObj),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            if (result == "false") {
                $('#myModal').modal('hide');
                alert("Ocurrió un error al Crear el Usuario");
            }
            else {
                loadData();
                $('#myModal').modal('hide');
            }
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function getbyID(userId) {
    $('#NombreCompleto').css('border-color', 'lightgrey');
    $('#Direccion').css('border-color', 'lightgrey');
    $('#FechaNacimiento').css('border-color', 'lightgrey');
    $('#TipoDocumento').css('border-color', 'lightgrey');
    $('#Pais').css('border-color', 'lightgrey');
    $('#Departamento').css('border-color', 'lightgrey');
    $('#Ciudad').css('border-color', 'lightgrey');

    $.ajax({
        url: "/Usuario/Get/" + userId,
        typr: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            clearTextBox(result.TipoDocumento);
            $('#UserId').val(result.UserId);
            $('#NombreCompleto').val(result.NombreCompleto);
            $('#Direccion').val(result.Direccion);
            var myDate = new Date(result.FechaNacimiento);
            var mes = myDate.getMonth() + 1;
            if (mes.toString().length == 1)
                mes = "0" + mes;
            var dia = myDate.getDate();
            if (dia.toString().length == 1)
                dia = "0" + dia;
            $('#FechaNacimiento').val(myDate.getFullYear() + "-" + mes + "-" + dia);
            $('#NumeroDocumento').val(result.NumeroDocumento);
            $('#Pais').val(result.Pais);
            $('#Departamento').val(result.Departamento);
            $('#Ciudad').val(result.Ciudad);
            $('#myModal').modal('show');
            $('#btnUpdate').show();
            $('#btnAdd').hide();
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
    return false;
}

function Update() {
    var res = validate();
    if (res == false) {
        return false;
    }
    var tipoDocumento = {
        Id: $('#TipoDocumento').val(),
        TipoDocumento: $("#TipoDocumento option:selected").text(),
    };
    var usuarioObj = {
        UserId: $('#UserId').val(),
        NombreCompleto: $('#NombreCompleto').val(),
        Direccion: $('#Direccion').val(),
        FechaNacimiento: $('#FechaNacimiento').val(),
        TipoDocumento: $('#TipoDocumento').val(),
        TipoDocumentoSelecionado: tipoDocumento,
        NumeroDocumento: $('#NumeroDocumento').val(),
        Pais: $('#Pais').val(),
        Departamento: $('#Departamento').val(),
        Ciudad: $('#Ciudad').val()
    };
    $.ajax({
        url: "/Usuario/Update",
        data: JSON.stringify(usuarioObj),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            if (result == "false") {
                $('#myModal').modal('hide');
                alert("Ocurrió un error al Actualizar el Usuario");
            }
            else {
                loadData();
                $('#myModal').modal('hide');
                $('#UserId').val("");
                $('#NombreCompleto').val("");
                $('#Direccion').val("");
                $('#FechaNacimiento').val("");
                $('#TipoDocumento').val("");
                $('#NumeroDocumento').val("");
                $('#Pais').val("");
                $('#Departamento').val("");
                $('#Ciudad').val("");
            }
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function Delele(ID) {
    var ans = confirm("Está seguro de borrar el usuario?");
    if (ans) {
        $.ajax({
            url: "/Usuario/Delete/" + ID,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                loadData();
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
}

function clearTextBox(tipoDocumentoSeleccionado) {
    $.ajax({
        url: "/Usuario/ListTiposDocumentos",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            html += '<option value="volvo">--Seleccione--</option>';
            $.each(result, function (key, item) {
                html += '<option value="' + item.Id + '">' + item.TipoDocumento + '</option>';
            });
            $("#TipoDocumento").html(html);
            if (tipoDocumentoSeleccionado != null) {
                $('#TipoDocumento').val(tipoDocumentoSeleccionado);
            }
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });


    $('#NombreCompleto').val("");
    $('#Direccion').val("");
    $('#FechaNacimiento').val("");
    $('#TipoDocumento').val("");
    $('#NumeroDocumento').val("");
    $('#Pais').val("");
    $('#Departamento').val("");
    $('#Ciudad').val("");
    $('#btnUpdate').hide();
    $('#btnAdd').show();
    $('#NombreCompleto').css('border-color', 'lightgrey');
    $('#Direccion').css('border-color', 'lightgrey');
    $('#FechaNacimiento').css('border-color', 'lightgrey');
    $('#TipoDocumento').css('border-color', 'lightgrey');
    $('#Pais').css('border-color', 'lightgrey');
    $('#Departamento').css('border-color', 'lightgrey');
    $('#Ciudad').css('border-color', 'lightgrey');
}

function validate() {
    var isValid = true;
    if ($('#NombreCompleto').val().trim() == "") {
        $('#NombreCompleto').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#NombreCompleto').css('border-color', 'lightgrey');
    }
    if ($('#Direccion').val().trim() == "") {
        $('#Direccion').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#Direccion').css('border-color', 'lightgrey');
    }
    if ($('#FechaNacimiento').val().trim() == "") {
        $('#FechaNacimiento').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#FechaNacimiento').css('border-color', 'lightgrey');
    }
    if ($('#TipoDocumento').val().trim() == "" || $('#TipoDocumento').val().trim() == "--Seleccione--") {
        $('#TipoDocumento').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#TipoDocumento').css('border-color', 'lightgrey');
    }
    if ($('#NumeroDocumento').val().trim() == "") {
        $('#NumeroDocumento').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#NumeroDocumento').css('border-color', 'lightgrey');
    }
    if ($('#Pais').val().trim() == "") {
        $('#Pais').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#Pais').css('border-color', 'lightgrey');
    }
    if ($('#Departamento').val().trim() == "") {
        $('#Departamento').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#Departamento').css('border-color', 'lightgrey');
    }
    if ($('#Ciudad').val().trim() == "") {
        $('#Ciudad').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#Ciudad').css('border-color', 'lightgrey');
    }
    return isValid;
}
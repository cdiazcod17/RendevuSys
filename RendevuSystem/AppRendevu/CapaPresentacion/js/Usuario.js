
var tabla;
function addRowDT(data) {
    tabla = $("#tbl_Usuarios").DataTable();
    for (var i = 0; i < data.length; i++) {
        tabla.fnAddData([
            data[i].Id_Usuario,
            data[i].Nombres,
            (data[i].Apellido1 + " " + data.Apellido2),
            data[i].Edad,
            ((data[i].Sexo == "M") ? "Masculino" : "Femenino"),
            data[i].Direccion,
            data[i].Email,
            data[i].Telefono,
            ((data[i].Estado == true) ? "Activo":"Inactivo"),
            '<button value="Actualizar" title="Actualizar" class="btn btn-primary btn-edit"><i class="fas fa-edit"></i></button>@nbsp;' +
            '<button value="Eliminar" title="Eliminar" class="btn btn-danger btn-delete"><i class="fas fa-exclamation-circle"></i></button>'

        ]);
    }
    //((data[i].Estado == true) ? "Activo" : "Inactivo")
}
function sendDataAjax() {
    $.ajax({
        type:"POST" ,
        url:"RegistrarUsuario.aspx/ListaUsuarios",
        data: {},
        contentType:'application/json; charset=utf-8',
        error: function(xhr, ajaxOptions, throwError) {
            console.log(xhr.status + " \n" + xhr.responseText, "\n" + throwError);
        },
        success: function (data) {
            console.log(data.d);
            addRowDT(data.d);
        }
    });
}

$(document).on('click', '.btn-edit', function (e) {
    e.preventDefault();
    $(this).parent().parent().children().first().text;
});

$(document).on('click', '.btn-delete', function (e) {
    e.preventDefault();
    var row = $(this).parent().parent()[0];
    var datos = tabla.fnGetData(row);

});
sendDataAjax();
function actualizar_form(){

    let select = document.querySelector("#selectFiltroEmpresa").selectedIndex;
    let input = document.querySelector("#inputFiltroEmpresa");
    let button = document.querySelector("#botonFiltroEmpresa");

    if(select === 0){

        input.disabled = true;
        input.value = "";
    } else {

        input.disabled = false;
    }
}

function actualizarFiltroCliente(){
    let selectCliente = document.querySelector("#selectFiltroCliente").selectedIndex;
    let inputCliente = document.querySelector("#inputFiltroCliente");
    let buttonCliente = document.querySelector("#botonFiltroCliente");

    if(selectCliente === 0){
        inputCliente.disabled = true;
        inputCliente.value = "";
    } else{
        inputCliente.disabled = false;
    }
}

function onLoad(){
    actualizar_form();
    actualizarFiltroCliente();
}
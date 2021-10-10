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

function onLoad(){

    actualizar_form();
}
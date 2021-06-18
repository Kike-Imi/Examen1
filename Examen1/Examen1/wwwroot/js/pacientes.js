function pacientes_search() {
    const search = document.getElementById("txt-search").value;

    const courrentURL = window.location.href.substring(
        window.location.href.lastIndexOf('/') + 1
    ).split("?")[0];
    window.location = `${courrentURL}?search=${search}`;
}

const paciente_input_serch = document.getElementById("txt-search");
paciente_input_serch.addEventListener("keyup", function (event) {
    if (event.keyCode == 13) {
        event.preventDefault();
        pacientes_search();
    }
});
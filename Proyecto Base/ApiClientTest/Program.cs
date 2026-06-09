using ApiClientLibrary.Services;

F1_ConfiguracionInicial servicio = new F1_ConfiguracionInicial();
//var response = await servicio.RegistrarEstadoSID(new ApiClientLibrary.Models.EstadoSIDDTO
//{
//    Estado = "EN_ESPERA"
//});
//Console.WriteLine(response);

var response = await servicio.RegistrarNormaSID(new ApiClientLibrary.Models.NormaDTO
{
    Id = string.Empty,
    Clave = "E0000-05",
    Nombre = "CONDUCTORES DUPLEX CON AISLAMIENTO TERMOPLÁSTICO 5",
    Edicion = "SEPTIEMBRE 2001",
    Estatus = "VIGENTE",
    EsCFE = true,
    FechaRegistro = DateTime.Now
});
Console.WriteLine(response);
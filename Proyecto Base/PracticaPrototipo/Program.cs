using ApiClientLibrary.Services;

F1_ConfiguracionInicial servicio = new F1_ConfiguracionInicial();

var response = await servicio.RegistrarPrototipo(new ApiClientLibrary.Models.PrototipoDTO
{
    Id = string.Empty,
    Numero = "K311P-11-E/9999",
    FechaEmision = DateTime.Parse("2023-09-09T17:49:04.197Z"),
    FechaVencimiento = DateTime.Parse("2027-09-09T17:49:04.197Z"),
    UrlArchivo = "https://imgv2-1-f.scribdassets.com/img/document/422175705/original/36ec59ed0c/1?v=1",
    MD5 = string.Empty,
    Estatus = "VIGENTE",
    FechaRegistro = DateTime.Now
});
Console.WriteLine(response);
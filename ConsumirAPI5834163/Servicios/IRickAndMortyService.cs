using ConsumirAPI5834163.Modelo;

namespace ConsumirAPI5834163.Servicios
{
    public interface IRickAndMortyService
    {
        public Task<List<PersonajesResponse>> Obtener();


    }
}

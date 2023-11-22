using Entidades.Enumerados;

namespace Entidades.Interfaces
{
    public interface IDeporte
    {
        /// <summary>
        /// Obtiene el nombre de un deporte especifico.
        /// </summary>
        EDeporte Deporte { get; }

        /// <summary>
        /// Obtiene y establece el nivel de profesionalidad en un deporte especifico.
        /// </summary>
        ENivel Nivel { get; set; }
    }
}

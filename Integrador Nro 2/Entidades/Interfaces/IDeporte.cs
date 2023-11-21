using Entidades;
using Entidades.Enumerados;

namespace Entidades.Interfaces
{
    public interface IDeporte
    {
        /// <summary>
        /// Obtiene el nombre del deporte.
        /// </summary>
        EDeporte Deporte { get; }

        /// <summary>
        /// Obtiene y establece la categoria del deporte.
        /// </summary>
        Enum Categoria { get; set; }
    }
}

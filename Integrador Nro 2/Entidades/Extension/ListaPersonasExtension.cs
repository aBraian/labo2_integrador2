using System.Runtime.CompilerServices;

namespace Entidades.Modelos
{
    public static class ListaPersonasExtension
    {
        public static List<Persona> Ordenar(this List<Persona> lista)
        {
            lista.Sort((persona1, persona2) =>
            {
                int comparacionApellido = persona1.Apellido.CompareTo(persona2.Apellido);
                if (comparacionApellido != 0)
                {
                    return comparacionApellido;
                }
                int comparacionNombre = persona1.Nombre.CompareTo(persona2.Nombre);
                if (persona1.Nombre.CompareTo(persona2.Nombre) != 0)
                {
                    return comparacionNombre;
                }
                int comparacionDni = persona1.Dni.CompareTo(persona2.Dni);
                if (comparacionDni != 0)
                {
                    return comparacionDni;
                }
                return persona1.Turno.CompareTo(persona2.Turno);
            });
            return lista;
        }
    }
}

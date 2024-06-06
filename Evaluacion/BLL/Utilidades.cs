namespace BLL
{
    public class Utilidades
    {
        public static string CalcularFechaDevolucion(DateTime fecha)
        {
            if(fecha < DateTime.Now)
            {
                return $"Entrego a tiempo";
            }
            else
            {
                return  $"No lo entrego a tiempo";
            }

        }
    }
}
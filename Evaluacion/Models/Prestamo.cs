using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Prestamo
    {
		private DateTime _fechaInicio;

		public DateTime FechaInicio
		{
			get { return _fechaInicio; }
			set { _fechaInicio = value; }
		}
		private DateTime _fechaEntrega;

		public DateTime FechaEntrega
		{
			get { return _fechaEntrega; }
			set { _fechaEntrega = value; }
		}

        public Prestamo(DateTime _fechaInicio, DateTime _fechaEntrega)
        {
            FechaInicio = _fechaInicio;
			FechaEntrega = _fechaEntrega;
        }

		public string ToString()
		{
			return $"La fecha de entrega: {FechaEntrega}, y  fecha de inicio: {FechaInicio}";
		}

    }
}

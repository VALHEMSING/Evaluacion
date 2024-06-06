
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Autor : Persona
    {
		private string _nombreAutor;

		public string NombreAutor
		{
			get { return _nombreAutor; }
			set { _nombreAutor = value; }
		}

        public override string MostrarDatos()
        {
            return $"Nombre del autor del libro: {NombreAutor}";
        }
    }
}

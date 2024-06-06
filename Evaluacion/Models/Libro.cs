
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Libro
    {
		private string _tituloLibro;

		public string TituloLibro
		{
			get { return _tituloLibro; }
			set { _tituloLibro = value; }
		}
		private int  _capitulos;

		public int  Capitulos
		{
			get { return _capitulos; }
			set { _capitulos = value; }
		}
		private int _numeroPaginas;

		public int NumeroPaginas
		{
			get { return _numeroPaginas; }
			set { _numeroPaginas = value; }
		}



	}
}

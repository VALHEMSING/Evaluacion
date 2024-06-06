
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Usuario : Persona, IRegistrable, IBuscable
    {
		private string  _nombreUsuario;
        private string _emailUsuario;

        public string EmailUsuario
        {
            get { return _emailUsuario; }
            set { _emailUsuario = value; }
        }


        public string  NombreUsuario
		{
			get { return _nombreUsuario; }
			set { _nombreUsuario = value; }
		}
        public Usuario(string _nombre, string _email, string _nombreUsuario, string _emailUsuario)
        {
            NombreUsuario = _nombreUsuario;
        }

        public override string MostrarDatos()
        {
            return $"Nombre del usuario: {NombreUsuario}, e e-amail  {EmailUsuario} .";
        }

        public string Registrar()
        {
            throw new NotImplementedException();
        }

        public string Eliminar()
        {
            throw new NotImplementedException();
        }

        public string BuscarPorTitulo()
        {
            throw new NotImplementedException();
        }
    }
}

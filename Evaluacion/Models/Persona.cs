namespace Models
{
    public abstract class Persona
    {
		private string _nombre;
        private string _email;

        public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}

		public Persona() { }


		public abstract string MostrarDatos();

	}
}
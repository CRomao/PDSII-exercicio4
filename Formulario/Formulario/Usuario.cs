using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario
{
	using System;

	public class Usuario
	{

		private string usuario, senha;

		public Usuario(string usuario, string senha)
		{
			this.usuario = usuario;
			this.senha = senha;
		}

		public string getUsuario()
		{
			return usuario;
		}

		public void setUsuario(string usuario)
		{
			this.usuario = usuario;
		}

		public string getSenha()
		{
			return senha;
		}

		public void setSenha(string senha)
		{
			this.senha = senha;
		}
	}

}

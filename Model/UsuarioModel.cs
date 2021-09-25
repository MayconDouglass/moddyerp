using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Model
{
    class UsuarioModel
    {
        private int id_usuario;
        private int idPerfil;
        private string login;
        private string nome;
        private string sobrenome;
        private string password;
        private int status;
        private DateTime data_cad;
        private DateTime data_alt;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int IdPerfil { get => idPerfil; set => idPerfil = value; }
        public string Login { get => login; set => login = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public string Password { get => password; set => password = value; }
        public int Status { get => status; set => status = value; }
        public DateTime Data_cad { get => data_cad; set => data_cad = value; }
        public DateTime Data_alt { get => data_alt; set => data_alt = value; }
    }
}

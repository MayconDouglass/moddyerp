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
        private int idEmpresa;
        private int idPerfil;
        private string nome;
        private string sobrenome;
        private string avatar;
        private string email;
        private string password;
        private int status;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
        public int IdPerfil { get => idPerfil; set => idPerfil = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int Status { get => status; set => status = value; }
    }
}

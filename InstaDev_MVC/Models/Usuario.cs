using System;

namespace InstaDev_MVC.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public string Nome { get; set; }

        public string Foto { get; set; }

        public DateTime DataNascimento { get; set; }

        public int[] Seguidos { get; set; }

        public string Email { get; set; }
        
        public string Username { get; set; }
        
        public string Senha { get; set; }


        public void CadastrarUsuario(){

        }
        public void MostrarUsuario()
        {

        }
        public void EditarUsuario()
        {

        }

        public void DeletarUsuario()
        {

        }
        public void ListarUsuario()
        {

        }
        public void Logar()
        {

        }
        public void Seguir()
        {

        }

    }
}
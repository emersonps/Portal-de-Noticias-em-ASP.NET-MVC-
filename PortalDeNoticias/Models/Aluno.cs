using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Aluno(int id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }
    }
}
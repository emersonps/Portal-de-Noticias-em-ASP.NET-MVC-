using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalDeNoticias.Models
{
    public class AlunosController : Controller
    {
        private List<Aluno> alunos = new List<Aluno>(new[]
        {
            new Aluno(1, "João Carlos", "joao@gmail.com" ),
            new Aluno(2, "Carlos da Silva", "carlos@gmail.com"),
            new Aluno(3, "Maria Pinheiro", "maria@gmail.com"),
            new Aluno(4, "Paulo Gama", "paulo@gmail.com"),
            new Aluno(5, "Letícia dos Santos", "letici@gmail.com"),
            new Aluno(6, "Alessandro Henrique", "alessandro@gmail.com"),
            new Aluno(7, "Emilly de Souza", "emilly@gmail.com")
        });

        // GET: Alunos
        public ActionResult Index()
        {
            //String
            ViewBag.Mensagem1 = "Atenção! Faltam 3 dias para do fechamento do semestre!";

            //Objeto complexo
            ViewBag.Mensagem2 = new Notificacao(1, "Atenção! Falatam 3 dias para o fechamento do semestre");

            return View(alunos);
        }
    }
}
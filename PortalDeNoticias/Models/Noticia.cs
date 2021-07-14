using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.Models
{
    public class Noticia
    {
        public int Id { get; set; }
        public string Título { get; set; }
        public string Autor { get; set; }
        public DateTime Data { get; set; }
        public string Conteudo { get; set; }
    }
}
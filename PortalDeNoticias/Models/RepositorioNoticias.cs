using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.Models
{
    public class RepositorioNoticias
    {
        private static List<Noticia> noticias;

        public static List<Noticia> Noticias
        {
            get
            {
                if(noticias == null)
                    CriarNoticias();
                return noticias;
                
            }

        }

        private static void CriarNoticias()
        {
            noticias = new List<Noticia>();

            noticias.Add(new Noticia
            {
                Id = 1,
                Título = "Meu primeiro post",
                Autor = "Emerson Pinheiro de Souza",
                Data = DateTime.Today,
                Conteudo = "In publishing and graphic design, Lorem ipsum is a placeholder text commonly used to demonstrate the visual form of a document or a typeface without relying on meaningful content.",
            });

            noticias.Add(new Noticia
            {
                Id = 2,
                Título = "Meu segundo post",
                Autor = "Emerson P. de Souza",
                Data = DateTime.Today,
                Conteudo = "In publishing and graphic design, Lorem ipsum is a placeholder text commonly used to demonstrate the visual form of a document or a typeface without relying on meaningful content.",
            });

            noticias.Add(new Noticia
            {
                Id = 3,
                Título = "Meu terceiro post",
                Autor = "Emerson de Souza",
                Data = DateTime.Today,
                Conteudo = "In publishing and graphic design, Lorem ipsum is a placeholder text commonly used to demonstrate the visual form of a document or a typeface without relying on meaningful content.",
            });

            noticias.Add(new Noticia
            {
                Id = 4,
                Título = "Meu quarto post",
                Autor = "Emerson P. Souza",
                Data = DateTime.Today,
                Conteudo = "In publishing and graphic design, Lorem ipsum is a placeholder text commonly used to demonstrate the visual form of a document or a typeface without relying on meaningful content.",
            });

            noticias.Add(new Noticia
            {
                Id = 5,
                Título = "Meu quinto post",
                Autor = "Emerson S.",
                Data = DateTime.Today,
                Conteudo = "In publishing and graphic design, Lorem ipsum is a placeholder text commonly used to demonstrate the visual form of a document or a typeface without relying on meaningful content.",
            });
        }
    }
}
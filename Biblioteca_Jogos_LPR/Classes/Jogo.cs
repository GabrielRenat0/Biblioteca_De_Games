using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Jogos_LPR.Classes
{
    internal class Jogo
    {
        public string titulo;
        public string genero;
        public int ano;
        public int maxJogadores;
        public int notaMetaCritic;

        public Jogo( string titulo, string genero, int ano, int maxJogadores, int notaMetaCritic)
            {
            this.titulo = titulo;
            this.genero = genero;
            this.ano = ano;
            this.maxJogadores = maxJogadores;
            this.notaMetaCritic = notaMetaCritic;
            }
        public Jogo(String titulo, int ano, String genero, int maxJogadores)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.ano = ano;
            this.maxJogadores = maxJogadores;
        }


        public void setTitulo(string titulo)
        {
            if(titulo != "")
            this.titulo = titulo;
        }
        public void setGenero(string genero)
        {
            if(genero != "")
            this.genero = genero;
           
        }
        public void setAno(int ano)
        {
            if(ano >= 1950)
            this.ano = ano;
        }
        public void setNotaMetaCritic (int notaMetaCritic)
        {
            if (notaMetaCritic >= 0 && notaMetaCritic <= 100)
            this.notaMetaCritic = notaMetaCritic;
        }
        public void setMaxJogadores(int maxJogadores)
        {
            this.maxJogadores = maxJogadores;
        }



        public string getTitulo()
        {
            return this.titulo;
        }
        public int getAno()
        {
            return this.ano;
        }
        public string getGenero()
        {
            return this.genero;
        }
        public int getNotaMetaCritic()
        {
            return this.notaMetaCritic;
        }
        public int getMaxJogadores()
        {
            return this.maxJogadores ;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FecapStudyPOO
{
    internal class Disciplina
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public int cargaHorariaSemanalHoras { get; set; }

        // Construtor
        public Disciplina(string c, string n, string cat, int ch)
        {
            Codigo = c;
            Nome = n;
            Categoria = cat;
            if (ch <= 0)
            {
                ch = 2;
            }
            cargaHorariaSemanalHoras = ch;
        }

        // Método
        public int CalcularCargaEmMinutos()
        {
            return cargaHorariaSemanalHoras * 60;
        }

        // Método 2
        public string ExibirResumo()
        {
            return $"[{Codigo}] {Nome} ({Categoria}) — {cargaHorariaSemanalHoras}h/semana ({CalcularCargaEmMinutos()} min)";
        }
    }
}
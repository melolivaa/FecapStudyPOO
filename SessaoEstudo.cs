using System;
using System.Collections.Generic;
using System.Text;

namespace FecapStudyPOO
{
    internal abstract class SessaoEstudo
    {
        protected Disciplina disciplina;
        protected int duracaoMinutos;

        protected SessaoEstudo(Disciplina disciplina, int duracaoMinutos)
        {
            this.disciplina = disciplina;
            this.duracaoMinutos = duracaoMinutos;
        }

        public abstract string ObterModalidade();

        public abstract int CalcularXp();

        public virtual string GerarFeedback()
        {
            return ObterModalidade() + " em " + disciplina.GetNome() +
                   " (" + duracaoMinutos + " min) -> +" + CalcularXp() + " XP";
        }
    }

    public class SessaoPomodoro : SessaoEstudo
    {
        private int ciclosCompletos;

        public SessaoPomodoro(Disciplina disciplina, int duracaoMinutos, int ciclosCompletos)
            : base(disciplina, duracaoMinutos)
        {
            this.ciclosCompletos = ciclosCompletos;
        }

        public override string ObterModalidade()
        {
            return "Pomodoro";
        }

        public override int CalcularXp()
        {
            return duracaoMinutos * 2 + (ciclosCompletos * 15);
        }

        public override string GerarFeedback()
        {
            return base.GerarFeedback() +
                   " | Ciclos completos: " + ciclosCompletos;
        }
    }

    public class SessaoExercicios : SessaoEstudo
    {
        private int totalQuestoes;
        private int acertos;

        public SessaoExercicios(Disciplina disciplina, int duracaoMinutos,
                               int totalQuestoes, int acertos)
            : base(disciplina, duracaoMinutos)
        {
            this.totalQuestoes = totalQuestoes;
            this.acertos = acertos;
        }

        public override string ObterModalidade()
        {
            return "Lista de Exercícios";
        }

        public override int CalcularXp()
        {
            return duracaoMinutos + (acertos * 10);
        }

        public override string GerarFeedback()
        {
            double porcentagem = 0;

            if (totalQuestoes > 0)
            {
                porcentagem = (double)acertos / totalQuestoes * 100;
            }

            return base.GerarFeedback() +
                   " | Acertos: " + porcentagem.ToString("F1") + "%";
        }
    }

    public class SessaoLeitura : SessaoEstudo
    {
        private int paginasLidas;
        private bool fezResumo;

        public SessaoLeitura(Disciplina disciplina, int duracaoMinutos,
                             int paginasLidas, bool fezResumo)
            : base(disciplina, duracaoMinutos)
        {
            this.paginasLidas = paginasLidas;
            this.fezResumo = fezResumo;
        }

        public override string ObterModalidade()
        {
            return "Leitura e Resumo";
        }

        public override int CalcularXp()
        {
            return duracaoMinutos + (paginasLidas * 3) + (fezResumo ? 25 : 0);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Considere que "disciplina" já foi criada.

            List<SessaoEstudo> sessoes = new List<SessaoEstudo>();

            sessoes.Add(new SessaoPomodoro(disciplina, 50, 2));
            sessoes.Add(new SessaoExercicios(disciplina, 30, 10, 8));
            sessoes.Add(new SessaoLeitura(disciplina, 40, 15, true));

            int xpTotal = 0;

            foreach (SessaoEstudo sessao in sessoes)
            {
                Console.WriteLine(sessao.GerarFeedback());
                xpTotal += sessao.CalcularXp();
            }

            Console.WriteLine("XP total: " + xpTotal);
        }
    }
}
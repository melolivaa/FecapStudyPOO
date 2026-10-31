using System;
using System.Collections.Generic;
using System.Text;

namespace FecapStudyPOO
{
    public abstract class Usuario
    {
        private int id;
        private string nome;
        private string email;
        private string senha;

        public int Id
        {
            get { return id; }
        }

        public string Nome
        {
            get { return nome; }
        }

        public string Email
        {
            get { return email; }
        }

        // Construtor
        protected Usuario(int id, string nome, string email, string senha)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }

        public bool Autenticar(string senhaDigitada)
        {
            return senha == senhaDigitada;
        }

        // Métodos abstratos
        public abstract void ObterTipoPerfil();

        public abstract string GerarPainelResumo();
    }

    internal class Administrador : Usuario
    {
        public string cargo { get; set; }

        public Administrador(int id, string nome, string email, string senha, string cargo)
            : base(id, nome, email, senha)
        {
            this.cargo = cargo;
        }

        public override void ObterTipoPerfil()
        {
            Console.WriteLine("Administrador");
        }

        public override string GerarPainelResumo()
        {
            return "Nome: " + Nome +
                   "\nEmail: " + Email +
                   "\nCargo: " + cargo;
        }
    }

    internal class Responsavel : Usuario
    {
        public string parentesco { get; set; }

        public Responsavel(int id, string nome, string email, string senha, string parentesco)
            : base(id, nome, email, senha)
        {
            this.parentesco = parentesco;
        }

        public override void ObterTipoPerfil()
        {
            Console.WriteLine("Responsável");
        }

        public override string GerarPainelResumo()
        {
            return "Nome: " + Nome +
                   "\nEmail: " + Email +
                   "\nParentesco: " + parentesco;
        }
    }

    internal class Discente : Usuario
    {
        public string ra { get; set; }
        public int xpTotal = 0;

        private List<SessaoEstudo> historico = new List<SessaoEstudo>();

        public Discente(int id, string nome, string email, string senha, string ra)
            : base(id, nome, email, senha)
        {
            this.ra = ra;
        }

        // Forma 1: registra uma sessão pronta
        public void RegistrarEstudo(SessaoEstudo sessao)
        {
            historico.Add(sessao);
            xpTotal += sessao.CalcularXp();
        }

        // Forma 2: atalho rápido com Pomodoro
        public void RegistrarEstudo(Disciplina d, int minutos)
        {
            int ciclos = minutos / 25;

            if (ciclos < 1)
            {
                ciclos = 1;
            }

            SessaoPomodoro sessao = new SessaoPomodoro(d, minutos, ciclos);

            RegistrarEstudo(sessao);
        }

        // Forma 3: registra uma leitura por horário
        public void RegistrarEstudo(Disciplina d, int horaInicio, int horaFim, int paginasLidas)
        {
            int minutos = (horaFim - horaInicio) * 60;

            SessaoLeitura sessao = new SessaoLeitura(d, minutos, paginasLidas, true);

            RegistrarEstudo(sessao);
        }

        public override void ObterTipoPerfil()
        {
            Console.WriteLine("Discente");
        }

        public override string GerarPainelResumo()
        {
            return "Nome: " + Nome +
                   "\nEmail: " + Email +
                   "\nRA: " + ra +
                   "\nXP Total: " + xpTotal;
        }
    }
}
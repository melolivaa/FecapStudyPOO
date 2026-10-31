using System;
using System.Collections.Generic;
using System.Text;

namespace FecapStudyPOO
{
    internal class MetaEstudo
    {
        private int metaMinutosSemana;
        private int minutosCumpridos = 0;
    }

    // Construtor
    public MetaEstudo(int meta)
    {
        RedefinirMeta(metaMinutosSemana);
    }

        public bool RegistrarAvanco(int minutos)
    {
        if (minutos <= 0 || minutos > 480)
         {
           return false;
         }

         minutosCumpridos += minutos;
         return true;
    }
       
    public void RedefinirMeta(int novaMeta)
        {
            if (novaMeta < 30)
            {
                novaMeta = 30;
            }
            if (novaMeta > 3000)
            {
                novaMeta = 3000;
            }
            metaMinutosSemana = novaMeta;
        }

    // Método 3
    public double CalcularPercentual()
    {
       double percentual = (double)minutosCumpridos / metaMinutosSemana * 100;

        if (percentual > 100)
        {
           percentual = 100;
        }

        return percentual;
    }

    // Método 4
    public bool EstaCumprida()
    {
       return minutosCumpridos >= metaMinutosSemana;
    }
}
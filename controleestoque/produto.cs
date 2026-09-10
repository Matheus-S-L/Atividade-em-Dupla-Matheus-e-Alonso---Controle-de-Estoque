using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleestoque
{
    internal class produto { 
            public string nome { get; set; }

            public int quantidade { get; set; }

            public double valor { get; set; }

        public produto()
        {
            nome = "Desconhecido";
            quantidade = 0;
            valor = 0.0;
        }

        public produto(string nome, double valor)
        {
            this.nome = nome;
            this.valor = valor;
            this.quantidade = 0;
        }

        public produto(string nome, double valor, int quantidade)
        {
            this.nome = nome;
            this.valor = valor;
            setQuantidade(quantidade);
        }

        public void setQuantidade(int quantidade)
        {
            if (quantidade >= 0)
            {
                this.quantidade = quantidade;
            }
        }

        public int getQuantidade()
        {
            return quantidade;
        }
    }
}
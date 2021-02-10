using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_3
{
    public abstract class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        protected IPromocao promocao;

        public Produto(IPromocao _promocao)
        {
            promocao = _promocao;
        }

        public virtual decimal DescontoPromocao()
        {
            return promocao.Desconto();
        }

        public virtual decimal PrecoVenda()
        {
            return Preco - (Preco * DescontoPromocao());
        }
    }
}

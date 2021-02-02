using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloAnemico1
{
    class Item
    {
        //MODELO ANEMICO
        //public int ItemId { get; set; }
        //public int PedidoId { get; set; }
        //public string ItemNome { get; set; }
        //public decimal ItemPreco{get; set;}

        //MODELO RICO
        private string itemNome;
        private decimal itemPreco;

        public int ItemId { get; private set; }
        public int PedidoId { get; private set; }
        public string ItemNome 
        {
            get => this.itemNome;
            private set
            {
                this.itemNome = (value.Length > 100) ? throw new ArgumentOutOfRangeException(nameof(ItemNome), "O nome do item não pode exceder 100 caracteres") : value;
            }
        }
        public decimal ItemPreco 
        {
            get => this.itemPreco;
            private set
            {
                this.itemPreco = (value <= 0) ? throw new ArgumentOutOfRangeException(nameof(ItemPreco), "O preço deve ser maior que zero") : value;
            }
        }


        public Item(int pItemId, int pPedidoId, string pItemNome, decimal pItemPreco)
        {
            if (pItemId >= 0)
            {
                throw new ArgumentException("O código do Item deve ser informado com valor maior que zero");
            }
            if (pPedidoId >= 0)
            {
                throw new ArgumentException("O código do Pedido deve ser informado com valor maior que zero");
            }

            this.ItemId = pItemId;
            this.PedidoId = pPedidoId;
            this.ItemNome = pItemNome;
            this.ItemPreco = pItemPreco;
        }
    }
}

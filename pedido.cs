using System.Collections.Generic;
using System.Linq;
using System;

namespace atv1
{
    public class Pedido
    {
        private List<ItemPedido> itemPedidos;

        public Pedido(){
            itemPedidos = new List<ItemPedido>();
        } // construtor da classe
        
        public void addItem(string descricao, double quantidade, double valor){

            ItemPedido item = new ItemPedido(); 
            item.descricao = descricao; 
            item.quantidade = quantidade;
            item.valor = valor;
            itemPedidos.Add(item); // adicionou um item de pedido dentro do pedido (lista)
        }

        public double TotalPedido()
        {
            double totalPedido = 0;
            foreach (var item in itemPedidos)
            {
                var valorItem = item.quantidade * item.valor;
                totalPedido = totalPedido + valorItem;

            }

            return totalPedido;
        }
    }
}
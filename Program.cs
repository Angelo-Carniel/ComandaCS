using System;
using System.Collections.Generic;
using System.Linq;


namespace atv1
{
    public class Program
    {
        static void Main()
        {
            string descricao;
            double quantidade;
            double valor;
            char continua ='s';
            
            Pedido p0 = new Pedido();

            do{

            Console.WriteLine("___Comanda___");

            Console.WriteLine("Insira a descrição do produto:");
            descricao = Console.ReadLine();
            
            Console.WriteLine("Insira a quantidade:");
            quantidade = double.Parse(Console.ReadLine()); 
            
            Console.WriteLine("insira o valor:");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Deseja continuar? (s/n)");
            continua = Convert.ToChar(Console.ReadLine());

            p0.addItem(descricao, quantidade, valor);

            }while (continua == 's');

            Console.WriteLine("Total: " + p0.TotalPedido());
        }
    }      
}
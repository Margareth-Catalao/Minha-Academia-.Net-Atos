using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Academia_.Net_Lista7_Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*5 - Identifique as classes     e implemente  um programa    para a   seguinte especificação:	
             "O	supermercado	 vende	 diferentes	 tipos	 de	 produtos.	 Cada	 produto	 tem	" +
             " um	 preço	 e	 uma	quantidade	em	estoque.	" +
             "Um pedido	de	um	cliente	é	composto	de	itens,	onde	cada	item	especifica" +
             "o	produto	que	o	cliente	deseja	e	a	respectiva	quantidade." +
             "Esse	pedido	pode	ser	pago	em	dinheiro,	cheque	ou	cartão."*/

            Cliente cliente = new Cliente();
            cliente.nome = "Suely";
           // cliente.nome = Console.ReadLine();
            Console.WriteLine(cliente.nome);
         
            Produto produto = new Produto();
            produto.preço = 21;
            Console.WriteLine("Preço do produto R$ " +produto.preço);
            produto.qtdEstoque = 50;
            Console.WriteLine("Quantidade em estoque: " +produto.qtdEstoque);

            Pedido pedido = new Pedido();
            pedido.item = "café";
            Console.WriteLine("Item do pedido: " +pedido.item);
            pedido.qntPedido = 1;
            Console.WriteLine("Unidades: " +pedido.qntPedido);
            pedido.formPagamento = "Dinheiro";
            Console.WriteLine("Forma de pagamento: " +pedido.formPagamento);

            pedido.produto = produto;
            pedido.cliente = cliente;




        }

    }
}
using System;

namespace SistemaDeProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produtoNome = new string [10];
            float[] preco = new float [10];
            string[] promocao = new string [10];
            int escolha;
            int i = 0; //cont
            Console.Clear();
            Console.WriteLine("-----Sistema de Produtos-----");

             do
            {
                Console.WriteLine("Menu Inicial");
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("[1] - Cadastrar Produto");
                Console.WriteLine("[2] - Listar Produtos");
                Console.WriteLine("[3] - Sair da aplicação");
                Console.WriteLine("[0] - Mostrar Menu");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                    //Cadastro dos Produtos
                    string resposta;
                    
                        do
                        {
                            if (i < 10)
                            {
                                Console.Clear();
                                Console.Write($"Digite o nome do {i+1}° Produto: ");
                                produtoNome[i] = Console.ReadLine();
                                Console.Write($"Digite o preço do {i+1}° Produto: ");
                                preco[i] = float.Parse(Console.ReadLine());
                                Console.WriteLine($"O produto {produtoNome[i]} está em promoção? \n [T] = SIM \n [F] = NÃO");
                                promocao[i] = Console.ReadLine();
                                Promocao(promocao[i]);
                                i++;
                            }
    
                            Console.WriteLine("Gostaria de cadastrar um novo produto? (s/n)");
                            resposta = Console.ReadLine();
                        }while(resposta == "s");
                        break;
                    case 2:
                    //Listar Produtos
                        for (var cont = 0; cont < produtoNome.Length; cont++)
                        {
                            Console.WriteLine($"Produto: {produtoNome[i]}");
                            Console.WriteLine($"Preco: R${preco[i]}");
                        }
                        break;
                    case 0:
                    //menu
                        break;
                    
                    case 3:
                        Console.WriteLine("Obrigado! Volte Sempre.");
                        return;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                

            } while (escolha == 0 || escolha !=0);

            bool Promocao(string SN){
                if (SN == "T"){
                    Console.WriteLine("PARABÉNS! Você ganhou adesivos da promoção!!!");
                    return true;
                }else{
                    return false;
                }
            }
        }
    }
}

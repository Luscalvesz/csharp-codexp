using System;

namespace exercício_viagens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AGÊNCIA DE VIAGENS");
            Console.WriteLine("--------------------------------");

            string[] nome = new string [5];
            string[] origem = new string [5];
            string[] destino = new string [5];
            DateTime[] data = new DateTime [5];

            int opcao = 0, contador = 0;

            do
            {
                Console.WriteLine("selecione uma opção: ");
                Console.WriteLine("--------------------------");
                Console.WriteLine("( 1 ) - Cadastrar passagem");
                Console.WriteLine("( 2 ) - Listar passagens");
                Console.WriteLine("( 0 ) - Sair");
                Console.WriteLine("--------------------------");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                    Console.WriteLine("Vamos cadastrar agora");
                    string resposta = "";
                    do
                    {   
                        if(contador < 2){ 
                        Console.WriteLine("Digite o nome do passageiro: ");
                        nome[contador] = Console.ReadLine();

                        Console.WriteLine("Informe a origem: ");
                        origem[contador] = Console.ReadLine();

                        Console.WriteLine("Informe o destino: ");
                        destino[contador] = Console.ReadLine();

                        Console.WriteLine("Informe a data: ");
                        data[contador] = DateTime.Parse(Console.ReadLine());
                                
                        Console.WriteLine("Você deseja realizar mais um cadastro? S/N");
                        resposta = Console.ReadLine();
                        contador++;
                        }else{
                            Console.WriteLine("Número de passagens excedida");
                            break;
                        }

                    } while (resposta == "s");

                    break;

                    case 2:
                    Console.WriteLine("Listando as passagens");
                        int contadorB = 0;
                        while (contadorB < 2)
                        {
                            Console.WriteLine($"Passageiro nome: {nome[contadorB]}. Origem: {origem[contadorB]}. Destino: {destino[contadorB]}. Data: {data[contadorB]} ");
                            contadorB++;
                        }

                    break;

                    case 0:
                    Console.WriteLine("Obrigado por usar nosso sístema");
                    break;

                    default:
                    Console.WriteLine("opção inválida");
                    break;
                }

            } while (opcao != 0);

              
        }
    }
}

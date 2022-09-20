using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingame = "sim";
            string decision;

            Console.WriteLine("Cotidiano Text Adventure");
            Console.WriteLine("- by Lavie Murchio Beltrão, Maria Fernanda Paiva e Silva");
            Console.WriteLine("Para começar, pressione a tecla 'Enter'.");

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine();
                Console.WriteLine("Tecla inválida. Pressione novamente.");
                Console.WriteLine();
            }

            while (ingame == "sim")
            {
                Console.Clear();
                Console.WriteLine("Você acorda em cima da hora e precisa ir para a Univali. É o dia da entrega do projeto de Lógica de Programação.");
                Console.WriteLine();
                Console.WriteLine("Pressione (1) para se levantar e ir para a Univali.");
                Console.WriteLine("Pressione (2) para ficar em casa e matar aula.");
                decision = Console.ReadLine();
                if (decision == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Você levanta e corre para a frente de sua casa, mas já são 18:28.");
                    Console.WriteLine();
                    Console.WriteLine("Para não chegar com atraso, você poderia pegar um Uber, mas ficaria sem dinheiro para o lanche.");
                    Console.WriteLine();
                    Console.WriteLine("Pressione (3) para chamar um Uber.");
                    Console.WriteLine("Pressione (4) para ir a pé");
                    decision = Console.ReadLine();
                    if (decision == "3")
                    {
                        Console.Clear();
                        Console.WriteLine("O Uber custou R$24,76 por causa do tráfego alto. Você não ficou nada feliz.");
                        Console.WriteLine();
                        Console.WriteLine("Chegando na Univali, você consegue entrar na aula à tempo, mas seu código ainda");
                        Console.WriteLine("não está pronto e você provavelmente vai entregar ele com atraso.");
                        Console.WriteLine();
                        Console.WriteLine("Pressione (5) para tentar terminar e entregar o código o mais rápido possível.");
                        Console.WriteLine("Pressione (6) para mandar uma migué pro professor e dizer que ficou doente mas não foi ao médico então não tem atestado.");
                        decision = Console.ReadLine();
                        if (decision == "5")
                        {
                            Console.Clear();
                            Console.WriteLine("Você termina o código, mas com atraso, e fica com um 4.");
                        }
                        else if (decision == "6")
                        {
                            Console.Clear();
                            Console.WriteLine("Até eu senti vergonha vendo você escolhendo essa opção.");
                            Console.WriteLine("Na moral, isso foi patético, você realmente esperava que isso ia funcionar?");
                        }
                    }
                    else if (decision == "4")
                    {
                        Console.Clear();
                        Console.WriteLine("Você vai ficar com fome depois então melhor não.");
                        Console.WriteLine();
                        Console.WriteLine("Você começa a andar pelo percurso mais rápido até a Universidade, mas...");
                        Console.WriteLine("Ããããã...");
                        Console.WriteLine("Isso não parece ter sido uma ideia tão boa.");
                        Console.WriteLine("Acho que vai se atrasar.");
                        Console.WriteLine("Você escolheu a rota errada então fiquei sem ideia.");
                        Console.WriteLine("De qualquer maneira o jogo vai ser entregue com atraso, então...");
                    }
                }

                else if (decision == "2")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Você ficou em casa e desistiu de ir para a Univali, afinal seu quarto está uma bagunça.");
                    Console.WriteLine("Depois de você terminar de arrumar o quarto, você fica assistindo séries.");

                }
                Console.WriteLine();
                Console.WriteLine("FIM");
                Console.WriteLine();
                Console.WriteLine("Deseja jogar novamente?");
                Console.WriteLine("Digite 'sim' para jogar novamente");
                Console.WriteLine("Digite qualquer outro texto e pressione 'Enter' para fechar a janela.");
                ingame = Console.ReadLine();
                if (ingame != "sim")
                {
                    Environment.Exit(0);
                }

            }
        }
    }
}

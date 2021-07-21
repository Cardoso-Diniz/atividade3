using System;
using System.Collections.Generic;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ParticipantesShowDaVida = new List<string>();
            do
            {
                Console.WriteLine("Qual é o seu nome?");
                string nomePessoa = Console.ReadLine();

                Console.WriteLine($"Qual é a sua idade?");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 16)
                {
                    Console.WriteLine($"Parabéns, você possui a idade necessaria para participar do evento");
                    ParticipantesShowDaVida.Add(nomePessoa);
                }
                else
                {
                    Console.WriteLine($"Você não possui a idade necessaria, você estará acompanhado com alguém maior de 18 anos sim/não?");
                    string resposta = Console.ReadLine();

                    switch (resposta)
                    {
                        case "sim":
                            Console.WriteLine($"Você pode participar,porém esteja com um acompanhate");
                            ParticipantesShowDaVida.Add(nomePessoa);
                            break;

                        case "não":
                            Console.WriteLine($"Você não pode participar!!");

                            break;

                        default:
                            Console.WriteLine($"Erro coloque uma resposta valida!!");

                            break;
                    }
                    Console.WriteLine("Desejar cadastrar mais alguém sim/não?");
                    string respostadois = Console.ReadLine();

                    switch (respostadois)
                    {
                        case "sim":
                            Console.WriteLine($"Quem gostaria de cadastrar?");
                            break;

                        case "não":
                            Console.WriteLine($"Seu cadastro foi efetuado com sucesso!!");
                            break;


                        default:
                        Console.WriteLine($"Erro coloque uma resposta valida!!");
                            break;
                    }


                    Console.WriteLine("Lista de Participantes");
                    nomePessoa = Console.ReadLine().ToLower();


                }
            } while (true);
            {

            }
        }
    }
}
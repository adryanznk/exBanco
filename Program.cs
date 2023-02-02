using System;

namespace AtividadeBancoAula12
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            while (menu != 2)
            {
                Console.WriteLine("MENU INICIAL\n1 - Cadastrar conta nova\n2 - SAIR");
                menu = int.Parse(Console.ReadLine());

                if (menu == 1)
                {
                    Console.WriteLine("\nInforme o nome do titular da conta: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Informe o número da conta: ");
                    int numConta = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o valor a ser depositado: ");
                    double saldo0 = double.Parse(Console.ReadLine());
                    Conta conta = new Conta(nome, numConta, saldo0);
                    Console.WriteLine(conta.Dados());

                    int op = 0;
                    while (op != 2)
                    {
                        Console.WriteLine("Deseja realizar alguma operação?\n1 - SIM\n2 - NÃO");
                        op = int.Parse(Console.ReadLine());

                        if (op == 1)
                        {
                            Console.WriteLine("\nSAQUE ou DEPÓSITO?\n1 - SAQUE\n2 - DEPÓSITO");
                            int op1 = int.Parse(Console.ReadLine());

                            if (op1 == 1)
                            {
                                Console.WriteLine("\nQual o valor que deseja sacar?");
                                double saque = double.Parse(Console.ReadLine());
                                conta.Saque(saque);

                                Console.WriteLine(conta.Dados());
                            }
                            else if (op1 == 2)
                            {
                                Console.WriteLine("\nQual o valor que deseja depositar?");
                                double deposito = double.Parse(Console.ReadLine());
                                conta.Deposito(deposito);

                                Console.WriteLine(conta.Dados());
                            }
                            else { Console.WriteLine("\nOPÇÃO INVÁLIDA\n"); }
                        }
                    }
                }
                else if (menu == 2) { Console.WriteLine("\nObrigado por utilizar nosso sistema!"); }
                else { Console.WriteLine("\nNÚMERO INVÁLIDO\n"); }

            }

        }
    }
}
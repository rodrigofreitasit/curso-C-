using System;
using System.Globalization;

namespace ContaBancaria {
    class Program {
        static void Main(string[] args) {

            double qte;
            Movimentacao M;


            Console.Write("Digite o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do Titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            string depositoInicial = Console.ReadLine();
            if (depositoInicial == "s") {
                Console.Write("Digite o valor do depósito incial: ");
                double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                M = new Movimentacao(numeroConta, nome, valorInicial);
            }
            else {
                M = new Movimentacao(numeroConta, nome);
            }
            /*
                        if (M.sim()) {
                            Console.Write("Digite o valor do depósito incial: ");
                            M.valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        }
                        else {
                            M.nao();
                        }
            */
            Console.WriteLine();
            Console.WriteLine("Conta Criada:");
            Console.WriteLine(M);

            Console.WriteLine();
            Console.Write("Digite um valor para depósito: ");
            qte = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            M.deposito(qte);

            Console.WriteLine();
            Console.WriteLine("Conta Atualizada:");
            Console.WriteLine(M);

            Console.WriteLine();
            Console.Write("Digite um valor para saque: ");
            qte = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            M.saque(qte);

            Console.WriteLine();
            Console.WriteLine("Conta Atualizada:");
            Console.WriteLine(M);

            Console.ReadLine();
        }
    }
}

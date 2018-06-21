using System;
using System.Globalization;

namespace ContaBancaria {
    class Movimentacao {

        public string nome, depositoInicial;
        public int numeroConta { get; private set; }
        public double valorInicial;


        // CONSTRUTOR OBRIGANDO DIGITAR DADOS//

        public Movimentacao(int numeroConta, string nome, double valorInicial) {
            this.nome = nome;
            this.valorInicial = valorInicial;
            this.numeroConta = numeroConta;
        }

        public Movimentacao(int numeroConta, string nome) {
            this.nome = nome;
            valorInicial = 0.0;
            this.numeroConta = numeroConta;
        }
        //******************DEPOSITO E SAQUE************** //

        public void deposito(double qte) {
            valorInicial = valorInicial + qte;
        }
        public void saque(double qte) {
            valorInicial = valorInicial - qte - 5.0;
        }

        public override string ToString() {
            return
                "Conta " + numeroConta
               + ", Titular: " + nome
               + ", Saldo: R$ " + valorInicial.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}

// VALOR INICIAL SIM OU NAO
/*public bool sim() {
   if (depositoInicial == "s") {
       return true;
   }
   else {
       return false;
   }
}
public double nao() {
   if (sim()) {
       return valorInicial;
   }
   else
       return valorInicial = 0.0;
}
*/

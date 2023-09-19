

namespace banco.classes
{
    internal class Empresarial : Conta
    {
        public double Anuidade { get; set; }
        public double Limiteempre { get; set; }
        public double Totatlempre { get; set; }
        public double Fazeremprestimo { get; set; }

        public Empresarial (double anuidade, double limiteempre, double totatlempre, int conta, string agencia, string titular, double saldo) 
            :base(conta, agencia, titular, saldo)
        {
            this.Anuidade = anuidade;
            this.Limiteempre = limiteempre;
            this.Totatlempre = totatlempre;
           
        }

        public override void Sacar(double saque)
        {
            if (saque <= Saldo)
            {
                Saldo -= saque;

                if (saque >= 5000)
                {
                    Saldo -= 5;
                }
                else
                {
                    Console.WriteLine("Saldo negativado");
                }
            }
        }

        public void Emprestimo(double saque)
        {
            if (saque <= Limiteempre - Fazeremprestimo)
            {
                Saldo += saque;
                Fazeremprestimo += saque;
            }
            else
            {
                Console.WriteLine("Valor indisponivel ");
            }
        }

        
    }
}

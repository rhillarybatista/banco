

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
            base.Sacar(saque);
        }

        public void Emprestimo(double limiteempre,double fazeremprestimo)
        {
            if (fazeremprestimo >= limiteempre )
            {
                Console.WriteLine("Valor nao é possivel");
            }
            if (limiteempre >= fazeremprestimo)
            {
                Console.WriteLine(" ");
            }
        }
    }
}

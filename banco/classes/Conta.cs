
namespace banco.classes
{
    internal class Conta
    {
        public int Contat { get; set; }
        public string Agencia { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

       
        



        public Conta()
        {

        }


        public Conta (int conta, string agencia, string titular, double saldo)
        {
            this.Contat = conta;
            this.Agencia = agencia;
            this.Titular = titular;
            this.Saldo = saldo;
        }
        
        public virtual void Sacar ( double saque )
        {
            if ( Saldo  >= saque )
            {
                Saldo = Saldo - saque;
                Console.WriteLine(" concluido");
            }
            else 
            {
               
                Console.WriteLine(" negativo ");
            }
        }

        public void Depositar ( double deposito  )
        {
            if (deposito >= 0)
            {
                Saldo  = deposito += Saldo;
                Console.WriteLine(" deposito concluido "+ Saldo);
            }
        }

    }
}

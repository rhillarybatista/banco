

namespace banco.classes
{
    internal class Estudantil : Conta
    {
        public double Limitecheque { get; set; }
        public string Cpf { get; set; }

        public string Nomeinstituicao { get; set;}

        

        public  Estudantil (double Limitecheque, string Cpf, string Nomeinstituicao, int conta , string agencia, string titular, double saldo)
          : base ( conta,  agencia,  titular,  saldo)
        {
            
            this.Cpf = Cpf;
            this.Nomeinstituicao = Nomeinstituicao;
            this.Limitecheque = Limitecheque; 

            
        }
        public override void Sacar( double saque)
        {
            if(saque <= Saldo + Limitecheque )
            {
                Saldo += saque;
            }
            else
            {
                Console.WriteLine(" saldo insuficiente!");
            }
           
        }

      
    }
}

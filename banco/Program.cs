using banco.classes;
public class program
{
    static void Main(string[] args)
    {
        int contat = 0;
        string agencia = "jipa";
        while (true)
        {
            Console.WriteLine("Digite 1 para conta normal \n" +
           "2 para conta estudante \n" +
           "3 para conta empresarial ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o nome do titular");
            string nome = Console.ReadLine();

            
            if (opcao == 1)
            {
                Conta conta = new Conta(contat, agencia, nome, 220);
                nome += 1;
                while (true)
                {
                    Console.WriteLine("1 para depositar \n " + "2 para sair \n" + "3 sair " );
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.WriteLine("valor: ");
                        double valor  = Convert.ToDouble(Console.ReadLine());
                        conta.Depositar(valor);
                        Console.WriteLine(" Novo saldo: " + (conta.Saldo));
                    }
                    else if (opcao == 2)
                    {
                        Console.WriteLine("valor: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        conta.Sacar(valor);
                    }
                    else if (opcao == 3)
                    {
                        break;
                    }
                }
                
            }
            else if (opcao == 2)
            {
               
                Console.WriteLine("Digite seu cpf: ");
                string cpf = Console.ReadLine();

                Console.WriteLine(" informe a instituicao ");
                string institu = Console.ReadLine();


               
                Estudantil Estudante = new Estudantil(100, cpf, institu, contat, agencia, nome, 0);
                nome += 1;
                while (true)
                {
                    Console.WriteLine("1 para depositar \n" + "2 para sair \n" + "3 sair ");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.WriteLine("valor: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        Estudante.Depositar(valor);
                        Console.WriteLine(" Novo saldo: " + (Estudante.Saldo));
                    }
                    else if (opcao == 2)
                    {
                        Console.WriteLine("valor: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        Estudante.Sacar(valor);
                    }
                    
                    else if (opcao == 3)
                    {
                        break;
                    }



                }
                


            }
            else if (opcao == 3)
            {
                Empresarial empresa = new Empresarial(10, 1000, 20000, contat, agencia, nome, 0);
                nome += 1;
                while (true) 
                {
                    Console.WriteLine("1 para depositar \n  " + "2 para sair \n " + "3 emprestimo \n " + "4 sair " );
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.WriteLine("valor: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        empresa.Depositar(valor);
                        Console.WriteLine(" Novo saldo: " + (empresa.Saldo));
                    }
                    else if (opcao == 2)
                    {
                        Console.WriteLine("valor: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        empresa.Sacar(valor);
                    }
                    else if (opcao == 3)
                    {
                        Console.WriteLine("valor: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        empresa.Emprestimo(valor);
                    }
                    else if (opcao == 4)
                    {
                        break;
                    }
                }

               
            }
        }
       
      
    }
}


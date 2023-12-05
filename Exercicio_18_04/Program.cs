namespace Exercicio_18_04;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto Banco DANIEL");
        Banco b = new Banco();
      
        b.Depositar(1000);
        b.Sacar(1600);
       
        b.AjustarLimite(500);

        double valortotal = b.MostrarSaldo();

       

        Console.WriteLine("O seu saldo total é de " + valortotal);
        

        b.imprimi(b.emprestimo(12,1000));
    }
}

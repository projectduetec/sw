namespace PROJ_AGREGACAO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Trabalhando com Agregação!");
        
        //instanciando os objetos de cada classe
        CartaoCredito cdc = new CartaoCredito();
        Cliente cli = new Cliente();

        //Adicionando um nome para um cliente
        cli.Nome = "Daniel da Silva";

        //Adicionando número e validade do Cartão de Crédito
        cdc.Numero = "123654789";
        cdc.DataValidade = "10/2030";

        //Associando o cliente ao atributo de agregação em Cartão de Credito
        cdc.Cliente = cli;

        //Visualizando as informações
        Console.WriteLine("O nome do cliente é: " + cli.Nome);
        Console.WriteLine("O número do cartão é: " + cdc.Numero);
        Console.WriteLine("A data de validade é: " + cdc.DataValidade);
        Console.WriteLine("O nome do cliente agregado é: " + cdc.Cliente.Nome);

    }
}

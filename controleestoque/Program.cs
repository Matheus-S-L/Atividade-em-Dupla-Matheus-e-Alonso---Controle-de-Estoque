using controleestoque;

produto produto1 = new produto();
produto1.nome = "Air Fryer";
produto1.setQuantidade(13);
produto1.valor = 67.22;

Console.WriteLine("--- PRODUTO 1 ---");
Console.WriteLine("Nome: " + produto1.nome);
Console.WriteLine("Quantidade: " + produto1.getQuantidade());
Console.WriteLine("Valor: R$ " + produto1.valor);
Console.WriteLine("\n------------------------\n");


Console.WriteLine("--- CADASTRO DO PRODUTO 2 ---");

Console.Write("Digite o nome do produto: ");
string nomeInput = Console.ReadLine();

Console.Write("Digite o valor do produto: ");
double valorInput = double.Parse(Console.ReadLine());

Console.Write("Deseja informar a quantidade inicial em estoque? (s/n): ");
string opcao = Console.ReadLine().ToLower();

produto produto2;

if (opcao == "s")
{
    Console.Write("Digite a quantidade em estoque: ");
    int quantidadeInput = int.Parse(Console.ReadLine());

   
    produto2 = new produto(nomeInput, valorInput, quantidadeInput);
}
else
{
    
    produto2 = new produto(nomeInput, valorInput);
}

// Exibir produto
Console.WriteLine("\n--- DADOS DO PRODUTO 2 ---");
Console.WriteLine("Nome: " + produto2.nome);
Console.WriteLine("Quantidade: " + produto2.getQuantidade());
Console.WriteLine("Valor: R$ " + produto2.valor);
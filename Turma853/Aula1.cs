public class Aula1
{
    public static void Main1()
    {

        int valorInteiro = 7;

        float valorFloat = 1.74F; // 7 digitos 32 bit

        double valorDouble = 1.74; // 15-16 digitos 64 bit

        decimal valorDecimal = 1.74M; // 28-29 digitos 128 bit

        Console.WriteLine("Valor Float:" + valorInteiro / valorFloat);
        Console.WriteLine("Valor Double: " + valorInteiro / valorDouble);
        Console.WriteLine("Valor decimal: " + valorInteiro / valorDecimal);

        char valorChar = 'a';
        string valorText = "aksdaosidiojcsk";

        //control K +D para comentar
        // control K +U para
        string helloWorld = "Hello, World! 123";
        foreach (char c in helloWorld)
        {
            Console.WriteLine($"{c} é uma letra? {char.IsLetter(c)}");
            Console.WriteLine($"{c} é um número? {Char.IsNumber(c)}");
        }


        //bool? condicao = false;

        //int? valorInteiro = 0;

        //decimal? valor = 0;

        Console.WriteLine(valorInteiro);


        Console.WriteLine("Digite um sobrenome: ");
        string sobrenome = Console.ReadLine();

        sobrenome = sobrenome.Trim(); // Corta espaços do começo e do fim da var
        Console.WriteLine("Sobrenome sem espaços: " + sobrenome);

        //ToLower -> converte para minusculo
        if (sobrenome.ToLower() == "mantovani") 
        {
            Console.WriteLine("Origem italiana - igual");
        }
        else
        {
            Console.WriteLine("Não é origem italiana - diferente");
        }

        //ToUpper -> converte para maiusculo
        // Contains -> Verifica se a string possui a palavra informada, retorna true ou false
        if (sobrenome.ToUpper().Contains("SILVA"))
        {
            Console.WriteLine("Mistura brasileira");
        }

        Console.WriteLine("Digite a inscrição estadual: ");
        string inscricao = Console.ReadLine();

        inscricao = inscricao.Trim();

        inscricao.TrimStart();
        inscricao.TrimEnd();

        if (inscricao == "ISENTO")
        {
            Console.WriteLine("Cliente especial");
        }

        Console.WriteLine("Digite o nome completo: ");
        string nomeCompleto = Console.ReadLine();

        char[] separadores = new char[2] { ',', ' ' };

        //Quebra o codigo onde encontrar o caracter entre parenteses
        string[] nome = nomeCompleto.Split(' ');
        var nome2 = nomeCompleto.Split(separadores);

        foreach (string s in nome)
        {
            Console.WriteLine(s);
        }
        int tamanho = nome.Length;

        Console.WriteLine("Primeiro nome: " + nome[0]);
        Console.WriteLine("Segundo nome: " + nome[1]);


        Console.WriteLine("Digite sua altura: ");
        string alturaString = Console.ReadLine();

        alturaString = alturaString.Replace(".", ",");

        decimal altura = decimal.Parse(alturaString);

        Console.WriteLine("Altura digitada: " + altura);

        Console.WriteLine("Digite sua conta sem digito: ");
        string contaBancaria = Console.ReadLine();

        // PadLeft completa a string utilizando o valor do segundo parametro ('0')
        // deixando-a com a quantidade total de caracteres
        // informado no primeiro parametro, 
        contaBancaria = contaBancaria.PadLeft(8, '0');
        Console.WriteLine("Numero da conta completa: " + contaBancaria);

        Console.WriteLine("Digite sua conta com digito: ");
        contaBancaria = Console.ReadLine();

        contaBancaria = contaBancaria.PadLeft(9, '0');
        
        // Insere uma string em uma posição especifica
        contaBancaria = contaBancaria.Insert(8, "-");

        Console.WriteLine("Conta bancaria completa com digito: " + contaBancaria);

        Console.WriteLine("Insira a data de nascimento do usuário (dd/mm/aaaa): ");
        bool dValido = DateOnly.TryParse(Console.ReadLine(), out DateOnly data);
        data.ToString().Split('/').ToList();

        // Constantes não podem ser alterados durante o código
        const string VALOR_INVALIDO = "Dados Inválidos";

        bool valorValido;
        int idade;
        decimal altura2;
        do
        {
            Console.WriteLine("Digite sua idade: ");
            valorValido = int.TryParse(Console.ReadLine(), out idade);
            if (!valorValido)
            {
                Console.WriteLine(VALOR_INVALIDO);
            }
        } while (!valorValido);
        Console.Clear();

        do
        {
            Console.WriteLine("Digite sua altura: ");
            valorValido = decimal.TryParse(Console.ReadLine(), out altura2);
            if (!valorValido)
            {
                Console.WriteLine(VALOR_INVALIDO);
            }
        } while (!valorValido);
        Console.Clear();

        Console.WriteLine($"\n Sua idade é {idade} e sua altura é {altura2}");

    }
}
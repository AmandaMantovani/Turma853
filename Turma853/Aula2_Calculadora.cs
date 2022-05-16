

public class Aula2_Calculadora
{
	public static void Main1()
	{
		/*
		 * Calculadora
		 * Faça um sistema que possua um menu
		 * com as operações basicas da matemática
		 */

		Console.WriteLine("**Calculadora**");
		Console.WriteLine("Escolha uma opção abaixo:");
		Console.WriteLine(" 1 -> para somar ");
		Console.WriteLine(" 2 -> para subtrair ");
		Console.WriteLine(" 3 -> para dividir ");
		Console.WriteLine(" 4 -> para multiplicar ");
		Console.WriteLine(" 5 -> para identificar resto de divisão ");
		Console.WriteLine(" 6 -> para elevar o número ao quadrado ");
		Console.WriteLine(" 7 -> para raiz quadrada ");
		Console.WriteLine(" 8 -> para identificar maior número ");
		Console.WriteLine(" 9 -> para identificar menor número ");
		Console.WriteLine("10 -> área de um círculo ");
		Console.WriteLine("11 -> para sortear dois número entre um alcance ");
		
		int opcao = int.Parse(Console.ReadLine());

		Console.Clear();

		Console.WriteLine("Digite o primeiro número: ");
		double numero1 = double.Parse(Console.ReadLine());

		double numero2 = 0;
		if (opcao != 6 && opcao != 7 && opcao != 10)
		{
			Console.WriteLine("Digite o segundo número: ");
			numero2 = double.Parse(Console.ReadLine());
		}
		Console.Clear();

		double resultado = 0;
		switch(opcao)
		{
			case 1:
				resultado = numero1 + numero2;
				break;
			case 2:
				resultado = numero1 - numero2;
				break;
			case 3:
				resultado = numero1 / numero2;
				break;
			case 4:
				resultado = numero1 * numero2;
				break;
			case 5:
				resultado = numero1 % numero2; //mod
				break;
			case 6:
				resultado = Math.Pow(numero1, 2); //elevados
				break;
			case 7:
				resultado = Math.Sqrt(numero1); //raiz quadrada
				break;
			case 8:
				resultado = Math.Max(numero1, numero2); //identifica numero maior
				break;
			case 9:
				resultado = Math.Min(numero1, numero2); //identifica numero menor
				break;
			case 10:
				resultado = Math.PI * Math.Pow(numero1, 2); // valor constante PI
				break;
			case 11:
				resultado = new Random().Next((int) numero1, (int) numero2); // Random
				break;
		}

		Console.WriteLine("Resultado final: " + resultado.ToString("F")); //Corta/arredonda duas casas
		//Console.WriteLine("Resultado final: " + resultado.ToString("N2")); //Arredonda duas casas

	}
}
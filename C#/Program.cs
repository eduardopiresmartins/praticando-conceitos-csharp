using System.Globalization;
using System.Text.RegularExpressions;

var culturaPtBr = new CultureInfo("pt-BR");

while (true)
{
	ExibirMenu();
	var opcao = Console.ReadLine();

	Console.WriteLine();

	switch (opcao)
	{
		case "1":
			ExercicioBoasVindas();
			break;
		case "2":
			ExercicioNomeCompleto();
			break;
		case "3":
			ExercicioOperacoesComDouble();
			break;
		case "4":
			ExercicioContagemCaracteres();
			break;
		case "5":
			ExercicioValidacaoPlaca();
			break;
		case "6":
			ExercicioFormatosDataHora(culturaPtBr);
			break;
		case "0":
			Console.WriteLine("Encerrando o programa. Bons estudos!");
			return;
		default:
			Console.WriteLine("Opção inválida. Escolha uma opção do menu.");
			break;
	}

	Console.WriteLine();
	Console.Write("Pressione Enter para voltar ao menu...");
	Console.ReadLine();
	Console.Clear();
}

static void ExibirMenu()
{
	Console.WriteLine("=== Desafio Prático C# ===");
	Console.WriteLine("1 - Boas-vindas personalizadas");
	Console.WriteLine("2 - Concatenar nome e sobrenome");
	Console.WriteLine("3 - Operações com dois valores double");
	Console.WriteLine("4 - Contar caracteres de palavra/frase");
	Console.WriteLine("5 - Validar placa brasileira (padrão até 2018)");
	Console.WriteLine("6 - Exibir data atual em diferentes formatos");
	Console.WriteLine("0 - Sair");
	Console.Write("Escolha uma opção: ");
}

static void ExercicioBoasVindas()
{
	Console.Write("Digite seu nome: ");
	var nome = Console.ReadLine();

	if (string.IsNullOrWhiteSpace(nome))
	{
		Console.WriteLine("Nome inválido.");
		return;
	}

	Console.WriteLine($"Olá, {nome.Trim()}! Seja muito bem-vindo!");
}

static void ExercicioNomeCompleto()
{
	Console.Write("Digite seu nome: ");
	var nome = Console.ReadLine();

	Console.Write("Digite seu sobrenome: ");
	var sobrenome = Console.ReadLine();

	if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(sobrenome))
	{
		Console.WriteLine("Nome ou sobrenome inválido.");
		return;
	}

	var nomeCompleto = $"{nome.Trim()} {sobrenome.Trim()}";
	Console.WriteLine($"Nome completo: {nomeCompleto}");
}

static void ExercicioOperacoesComDouble()
{
	double valor1 = 10.5;
	double valor2 = 2.0;

	Console.Write("Deseja informar os valores manualmente? (s/n): ");
	var resposta = Console.ReadLine();

	if (resposta?.Trim().Equals("s", StringComparison.OrdinalIgnoreCase) == true)
	{
		valor1 = LerDouble("Digite o primeiro valor: ");
		valor2 = LerDouble("Digite o segundo valor: ");
	}

	Console.WriteLine($"Valores: {valor1} e {valor2}");
	Console.WriteLine($"Soma: {valor1 + valor2}");
	Console.WriteLine($"Subtração: {valor1 - valor2}");
	Console.WriteLine($"Multiplicação: {valor1 * valor2}");

	if (valor2 == 0)
	{
		Console.WriteLine("Divisão: não é possível dividir por zero.");
	}
	else
	{
		Console.WriteLine($"Divisão: {valor1 / valor2}");
	}

	Console.WriteLine($"Média: {(valor1 + valor2) / 2}");
}

static void ExercicioContagemCaracteres()
{
	Console.Write("Digite uma palavra ou frase: ");
	var texto = Console.ReadLine();

	if (string.IsNullOrEmpty(texto))
	{
		Console.WriteLine("Entrada vazia.");
		return;
	}

	var totalComEspacos = texto.Length;
	var totalSemEspacos = texto.Count(c => !char.IsWhiteSpace(c));

	Console.WriteLine($"Total de caracteres (com espaços): {totalComEspacos}");
	Console.WriteLine($"Total de caracteres (sem espaços): {totalSemEspacos}");
}

static void ExercicioValidacaoPlaca()
{
	Console.Write("Digite a placa (formato antigo, ex: ABC1234): ");
	var placa = Console.ReadLine();

	if (string.IsNullOrWhiteSpace(placa))
	{
		Console.WriteLine("Falso");
		return;
	}

	placa = placa.Trim();
	var placaValida = Regex.IsMatch(placa, "^[A-Za-z]{3}[0-9]{4}$");

	Console.WriteLine(placaValida ? "Verdadeiro" : "Falso");
}

static void ExercicioFormatosDataHora(CultureInfo cultura)
{
	var agora = DateTime.Now;

	Console.WriteLine("Formato completo:");
	Console.WriteLine(agora.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss", cultura));

	Console.WriteLine();
	Console.WriteLine("Apenas data (dd/MM/yyyy):");
	Console.WriteLine(agora.ToString("dd/MM/yyyy"));

	Console.WriteLine();
	Console.WriteLine("Apenas hora (24h):");
	Console.WriteLine(agora.ToString("HH:mm:ss"));

	Console.WriteLine();
	Console.WriteLine("Data com mês por extenso:");
	Console.WriteLine(agora.ToString("dd 'de' MMMM 'de' yyyy", cultura));
}

static double LerDouble(string mensagem)
{
	while (true)
	{
		Console.Write(mensagem);
		var entrada = Console.ReadLine();

		if (double.TryParse(entrada, NumberStyles.Float, CultureInfo.CurrentCulture, out var valor) ||
			double.TryParse(entrada, NumberStyles.Float, CultureInfo.InvariantCulture, out valor))
		{
			return valor;
		}

		Console.WriteLine("Valor inválido. Tente novamente.");
	}
}

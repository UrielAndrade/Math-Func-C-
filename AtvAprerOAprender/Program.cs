using System.Globalization;
using System.Reflection.Metadata;
using System.Diagnostics;
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;
using System.Data;
using System.Net.WebSockets;

class Program
{
  static void Main(string[] args)
  {
    int opcao;

    do
    {
      Console.WriteLine("=== MENU ===");
      Console.WriteLine("1. Verificar se um número é positivo");
      Console.WriteLine("2. Verificar se um número é nulo");
      Console.WriteLine("3. Calcular o delta de uma equação do segundo grau");
      Console.WriteLine("4. Calcular as raízes de uma equação do segundo grau");
      Console.WriteLine("5. Encontrar o maior entre dois números");
      Console.WriteLine("6. Encontrar o menor entre dois números");
      Console.WriteLine("7. Encontrar o maior entre três números");
      Console.WriteLine("8. Encontrar o menor entre três números");
      Console.WriteLine("9. Lançar um dado");
      Console.WriteLine("10. Simular 100 lançamentos de um dado");
      Console.WriteLine("11. Converter entre Celsius e Fahrenheit");
      Console.WriteLine("12. Calcular médias de notas e determinar maior/menor nota");
      Console.WriteLine("----------------DESAFIOS----------------");
      Console.WriteLine("13. Encontrar todos os números primos até 1000");
      Console.WriteLine("14. Encontrar o MDC de dois números");
      Console.WriteLine("15. Encontrar todos os números perfeitos até 1000");
      Console.WriteLine("16. Imprimir um número na ordem inversa");
      Console.WriteLine("----- ▾SAIR▾ -----");
      Console.WriteLine("0. Sair");

      Console.Write("Escolha uma opção ▶ ");
      opcao = Convert.ToInt32(Console.ReadLine());

      switch (opcao)
      {
        case 1:
          Console.Write("Digite um número ▶ ");
          double numero = Convert.ToDouble(Console.ReadLine());
          bool ehPositivo = VerificarPositivo(numero);
          Console.WriteLine($"O número é positivo? {ehPositivo}");
          Console.ReadKey();
          break;
        case 2:
          Console.Write("Digite um número ▶ ");
          double numeroEX2 = Convert.ToDouble(Console.ReadLine());
          bool ehNulo = VerificarNulo(numeroEX2);
          Console.WriteLine($"O número é nulo? {ehNulo}");
          Console.ReadKey();
          break;
        case 3:
          Console.Write("Digite o valor de A ▶ ");
          double a = Convert.ToDouble(Console.ReadLine());
          Console.Write("Digite o valor de B ▶ ");
          double b = Convert.ToDouble(Console.ReadLine());
          Console.Write("Digite o valor de C ▶ ");
          double c = Convert.ToDouble(Console.ReadLine());
          double delta = CalcularDelta(a, b, c);
          Console.WriteLine($"O valor de ▲: {delta}");
          Console.ReadKey();
          break;
        case 4:
          CalcSegundoGrau();
          Console.ReadKey();
          break;
        case 5:
          Console.Write("Digite o primeiro Numero ▶ ");
          double Case5V1 = Convert.ToDouble(Console.ReadLine());
          Console.Write("Digite o segundo Numero ▶ ");
          double Case5V2 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine($"O maior numero ▶ {MaiorValorEntreDois(Case5V1, Case5V2)}");
          Console.ReadKey();
          break;
        case 6:
          Console.Write("Digite o primeiro Numero ▶ ");
          double Case6V1 = Convert.ToDouble(Console.ReadLine());
          Console.Write("Digite o segundo Numero ▶ ");
          double Case6V2 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine($"O menor numero ▶ {MenorValorEntreDois(Case6V1, Case6V2)}");
          Console.ReadKey();
          break;
        case 7:
          Console.Write("Digite o primeiro Numero ▶ ");
          double Case7V1 = Convert.ToDouble(Console.ReadLine());
          Console.Write("Digite o segundo Numero ▶ ");
          double Case7V2 = Convert.ToDouble(Console.ReadLine());
          Console.Write("Digite o terceiro Numero ▶ ");
          double Case7V3 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine($"O maior numero ▶ {MaiorValorEntreTres(Case7V1, Case7V2, Case7V3)}");
          Console.ReadKey();
          break;
        case 8:
          Console.Write("Digite o primeiro Numero ▶ ");
          double Case8V1 = Convert.ToDouble(Console.ReadLine());
          Console.Write("Digite o segundo Numero ▶ ");
          double Case8V2 = Convert.ToDouble(Console.ReadLine());
          Console.Write("Digite o terceiro Numero ▶ ");
          double Case8V3 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine($"O maior numero ▶ {MaiorValorEntreTres(Case8V1, Case8V2, Case8V3)}");
          Console.ReadKey();
          break;
        case 9:
          Console.WriteLine($"Caiu em {Dado()}");
          Console.ReadKey();
          break;
        case 10:
          DadoCemX();
          Console.ReadKey();
          break;
        case 11:
          conversorDeTemperatura();
          Console.ReadKey();
          break;
        case 12:
          MediaComNotasAltas();
          Console.ReadKey();
          break;
        case 13:
          verificarNumeroPrimo();
          Console.ReadKey();
          break;
        case 14:
          Console.Write("digite o primeiro numero ► ");
          int numeroParaMDC1 = Convert.ToInt32(Console.ReadLine());
          Console.Write("digite o segundo numero ► ");
          int numeroParaMDC2 = Convert.ToInt32(Console.ReadLine());
          Console.Write($"O MDC eh {calcularMDC(numeroParaMDC1, numeroParaMDC2)} ! ");
          Console.ReadKey();
          break;
        case 15:
          numerosPerfeitos();
          Console.ReadKey();
          break;
        case 16:
          Console.Write("Digite um numero para invertelo ▸ ");
          int numerC16 = Convert.ToInt32(Console.ReadLine());
          Console.Write($"O numero {numerC16}, invertido fica : {inverterNUM(numerC16)}");
          Console.ReadKey();
          break;
        case 0:
          Console.WriteLine("Saindo do programa...");
          break;
        default:
          Console.WriteLine("Opção inválida!");
          break;
      }

      Console.WriteLine();
    } while (opcao != 0);
  }
  //func exercicio 1
  static bool VerificarPositivo(double n)
  {
    return n > 0;
  }
  //func exercicio 2 
  static bool VerificarNulo(double n)
  {
    return n == 0;
  }

  //func exercicio 3 

  static double CalcularDelta(double a, double b, double c)
  {
    Console.WriteLine("Calculando Delta ▲ ...");
    return (b * b) - (4 * a * c);
  }

  //func exercicio 4
  static void CalcSegundoGrau()
  {
    Console.Write("Digite o valor de A: ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite o valor de B: ");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite o valor de C: ");
    double c = Convert.ToDouble(Console.ReadLine());

    if (a == 0)
    {
      Console.WriteLine("Nao eh uma equacao do segundo grau!");

    }

    bool existe = VerificarPositivo(a);
    if (existe)
    {
      double delta = CalcularDelta(a, b, c);
      if (delta > 0) //duas raizes
      {
        double X1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double X2 = (-b - Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine($"XI = {X1}");
        Console.WriteLine($"XII = {X2}");
      }
      else if (delta < 0)// Nao ah raizes
      {
        Console.WriteLine("Nao ah raizes");
      }
      else if (delta == 0)//apenas uma raiz
      {
        double X = (-b + Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine($"X = {X}");
      }
    }
    else
    {
      Console.WriteLine("Nao existe!");
    }
    //? Ax^2 + Bx + C =0
  }
  //func exercicio 5
  static double MaiorValorEntreDois(double v1, double v2)
  {
    Double maior;
    if (v1 > v2)
      return maior = v1;
    else { }
    return maior = v2;
  }
  //! func exercicio 6
  static double MenorValorEntreDois(double v1, double v2)
  {
    double menor;
    if (v1 < v2)
      return menor = v1;
    else
      return menor = v2;

  }
  //!fuinc exercicio 7
  static double MaiorValorEntreTres(double v1, double v2, double v3)
  {
    return MaiorValorEntreDois(MaiorValorEntreDois(v1, v2), v3);
  }
  //func exercicio 8
  static double MenorValorEntreTres(double v1, double v2, double v3)
  {
    return MenorValorEntreDois(MenorValorEntreDois(v1, v2), v3);
  }
  //func exercicio 9
  static int Dado()
  {
    Random r = new Random();
    return r.Next(1, 7);
  }
  //func exercicio 10
  static void DadoCemX()
  {
    int[] LadosCaidos = new int[6];


    for (int i = 0; i < 100; i++)
    {
      int resultado = Dado();
      LadosCaidos[resultado - 1]++;
    }


    Console.WriteLine("Resultado dos lançamentos:");
    for (int i = 0; i < 6; i++)
    {
      double porcentagem = (LadosCaidos[i] / 100.0) * 100;
      Console.WriteLine($"Número {i + 1}: {LadosCaidos[i]} vezes ({porcentagem:F2}%)");
    }
  }

  //func exercicio 11
  static void conversorDeTemperatura()
  {
    Console.WriteLine("Qual medida quer usar para a transformacao");
    Console.WriteLine(" C - Celsius ▸ farenheit");
    Console.WriteLine(" F - farenheit ▸ Celsius▸");
    Console.Write(" ► ");
    string unidadeConvercao = Console.ReadLine()!.ToUpper();
    // Ultilizo a exclamação (!) pois estou no Visual Studio Code.
    // A ! é para ignorar o alerta de expressão nula.
    switch (unidadeConvercao)
    {
      case "F":
        Console.WriteLine("Digite o valor em Farenheit");
        Console.Write(" ► ");
        double F = Convert.ToDouble(Console.ReadLine());
        double valorConvertidoPcelsius = 5 * (F - 32) / 9;
        Console.WriteLine($"Valor em F {F}, em Celsisus: {valorConvertidoPcelsius}");

        break;
      case "C":
        Console.WriteLine("Digite o valor em Calsius");
        Console.WriteLine(" ► ");
        double C = Convert.ToDouble(Console.ReadLine());
        double valorConvertidoEmFire = (9 * C / 5) + 32;
        Console.WriteLine($"o valor em C {C}, em Fireheit {valorConvertidoEmFire} ");

        break;
    }


  }

  //fun exercicio 12 
  static void MediaComNotasAltas()
  {
    Console.Write("Digite sua 1 nota ▸ ");
    double nota1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite sua 2 nota ▸ ");
    double nota2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite sua 3 nota ▸ ");
    double nota3 = Convert.ToDouble(Console.ReadLine());
    double notaMenor = nota1;
    double notaMaior = nota1;
    double somaDasNotas = nota1 + nota2 + nota3;

    //Comparar maiores
    if (nota2 > notaMaior) notaMaior = nota2;
    if (nota3 > notaMaior) notaMaior = nota3;
    //parte de comparar as menores
    if (nota2 < notaMenor) notaMenor = nota2;
    if (nota3 < notaMenor) notaMenor = nota3;
    double somaDuasMaiores = somaDasNotas - notaMenor;
    double mediaDuasMaiores = somaDuasMaiores / 2;
    double mediaGeral = somaDasNotas / 3;
    Console.WriteLine($"Nota mais alta: {notaMaior}");
    Console.WriteLine($"Nota mais baixa: {notaMenor}");
    Console.WriteLine($"Média das duas notas mais altas: {mediaDuasMaiores:F2}");
    Console.WriteLine($"Média Geral das notas: {mediaGeral:F2}");
  }


  //                  func Dos Desafios 
  //verificar primo
  static void verificarNumeroPrimo()
  {
    int ateQualNum = 1000;

    Console.WriteLine($"Numeros Primos:");

    for (int i = 2; i < ateQualNum; i++)
    {
      bool isPrime = true;

      for (int divisor = 2; divisor * divisor <= i; divisor++)
      {
        if (i % divisor == 0)
        {
          isPrime = false;
          break;
        }
      }
      if (isPrime)
      {
        Console.Write($"{i}, ");
      }
    }
  }

  //Calcular MDC
  static int calcularMDC(int n1, int n2)
  {
    while (n2 != 0)
    {
      int resto = n1 % n2;
      n1 = n2;
      n2 = resto;
    }
    return n1;
  }

  //Calcular numero perfeitos

  static void numerosPerfeitos()
  {
    int limite = 1000;
    for (int n = 1; n <= limite; n++)
    {
      int somaDivisores = 0;
      for (int i = 1; i < n; i++)
      {
        if (n % i == 0)
        {
          somaDivisores += i;
        }
      }
      if (somaDivisores == n)
      {
        Console.WriteLine($"{n}");
      }
    }
  }

  //num inverso 
  static int inverterNUM(int n)
  {
    int nInverso = 0;
    while (n != 0)
    {
      int digito = n % 10;
      nInverso = nInverso * 10 + digito;
      n /= 10;
    }
    return nInverso;
  }
}

/*      
      if (i % 2 == 0) isPrime = false;
      else if (i % 3 == 0) isPrime = false;
      if (i == 2) isPrime = true;
      if (i == 3) isPrime = true;
      else if (i % 5 == 0) isPrime = false;
      else if (i % 7 == 0) isPrime = false;
      else if (i % 11 == 0) isPrime = false;
      else if (i % 13 == 0) isPrime = false;
      else if (i % 17 == 0) isPrime = false;
      else if (i % 19 == 0) isPrime = false;
      else if (i % 23 == 0) isPrime = false;
      else if (i % 29 == 0) isPrime = false;
      else if (i % 31 == 0) isPrime = false;*/
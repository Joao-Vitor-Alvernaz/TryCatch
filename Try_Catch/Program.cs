using System;

while (true)
{
    try
    {
        Console.Write("Digite o primeiro número: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double c = a / b;

        Console.WriteLine($"Seu resultado é : {c}");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Não permitido realizar divisão por zero!");
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Não permitido realizar divizão com letras!");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocorreu um erro {ex.Message}");
    }
    finally
    {
        Console.WriteLine("Aqui passa de qualquer forma!");
    }
}
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("������� �������� �����, ���������� ������ � ���� ������ ����� ������:");
        string input = Console.ReadLine();
        double result = Calculate(input);
        Console.WriteLine($"����������� �����: {result}");
    }

    public static double Calculate(string input)
    {
        string[] parts = input.Split(' ');
        double sum = double.Parse(parts[0]);
        double rate = double.Parse(parts[1]) / 100 / 12;
        int months = int.Parse(parts[2]);

        return sum * Math.Pow(1 + rate, months);
    }
}
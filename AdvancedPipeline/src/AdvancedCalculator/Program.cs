# Advanced Calculator

Простой калькулятор с дополнительными математическими функциями.

## Функции
- Базовые операции (+, -, *, /)
- Возведение в степень
- Факториал
- Проверка простых чисел
- Статистические расчеты

## Запуск
\\\ash
dotnet run
\\\

## Тестирование
\\\ash
dotnet test
\\\
"@ | Out-File -FilePath "AdvancedPipeline/docs/README.md" -Encoding UTF8

# Создаем пустой release.yml
"" | Out-File -FilePath "AdvancedPipeline/workflows/release.yml" -Encoding UTF8

Write-Host "✅ Проект полностью создан! Структура:" -ForegroundColor Green
Get-ChildItem AdvancedPipeline -Recurse | ForEach-Object { Write-Host "  " }

Write-Host "
🎯 Теперь открой папку AdvancedPipeline в PyCharm!" -ForegroundColor Cyan

# Создаем Program.cs с правильным кодом
@"
using System;

class Program
{
    static void Main()
    {
        var calculator = new Calculator();
        var stats = new StatisticsCalculator();

        Console.WriteLine(""Продвинутый Калькулятор"");
        Console.WriteLine(""=========================""");

        // Демонстрация работы
        Console.WriteLine($""5 + 3 = {calculator.Add(5, 3)}"");
        Console.WriteLine($""2^4 = {calculator.Power(2, 4)}"");
        Console.WriteLine($""5! = {calculator.Factorial(5)}"");
        Console.WriteLine($""17 простое число? {calculator.IsPrime(17)}"");
        Console.WriteLine($""Среднее [1,2,3,4,5] = {stats.CalculateAverage(1, 2, 3, 4, 5)}"");

        Console.WriteLine(""\nВсе операции выполнены успешно!"");
    }
}

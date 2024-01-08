using System.Globalization;
// See https://aka.ms/new-console-template for more information

double xA, xB, xC, yA, yB, yC;
Console.WriteLine("Entre com as medidas do triângulo X: ");
xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triângulo Y: ");

yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double p = (xA + xB + xC) / 2.0;
double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
Console.WriteLine("A área do triângulo X é: " + areaX.ToString("F4", CultureInfo.InvariantCulture));

p = (yA + yB + yC) / 2.0;
double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));
Console.WriteLine("A área do triângulo y é: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if (areaX > areaY)
  Console.WriteLine("O triângulo com a área maior é :" + areaX);
else
  Console.WriteLine("O triângulo com a área maior é :" + areaY);
const double PESO1 = 3.5;
const double PESO2 = 7.5;
double A = double.Parse(System.Console.ReadLine().Trim());
double B = double.Parse(System.Console.ReadLine().Trim());
double Media = ((A * PESO1) + (B * PESO2)) / (PESO1 + PESO2);
Media = Math.Round(Media, 5);
System.Console.WriteLine($"MEDIA = {Media.ToString("#0.00000")}");
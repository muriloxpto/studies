using System.Text;
//quantidade de LEDs necessários para formar o indice correspondente
int[] leds = {6, 2, 5, 5, 4, 5, 6, 3, 7, 6};
int qtdTestes = Int32.Parse(System.Console.ReadLine().Trim());
for (int caso = 1; caso <= qtdTestes; caso++)
{
    int qtdLEDs = 0;
    string entrada = Convert.ToString(Console.ReadLine().Trim());
    for (int digito = 0; digito < entrada.Length; digito++)
    {
        var led = Convert.ToInt32(entrada[digito]) - 48;
        qtdLEDs += leds[led];
    }
    System.Console.WriteLine($"{qtdLEDs} leds");
}
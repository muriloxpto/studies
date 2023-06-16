int casos = Int32.Parse(System.Console.ReadLine().Trim());
for (int caso = 1; caso <= casos; caso++)
{
    string mensagem = System.Console.ReadLine().Trim();
    char[] etapa1 = mensagem.ToCharArray();
    int qtdChars = mensagem.Length;
    //----- 1° Etapa -----
    //Letras minúsculas e maiúsculas devem ser deslocadas 3 posições para a direita
    for (int index = 0; index < qtdChars; index++)
    {
        int asciiCode = Convert.ToInt32(mensagem[index]);
        //Verificando se é uma letra
        if ((asciiCode >= 65 && asciiCode <= 90) || (asciiCode >= 97 && asciiCode <= 122))
        {
            asciiCode += 3;
            etapa1[index] = Convert.ToChar(asciiCode);
        }
    }
    //----- 2° Etapa -----
    //Inverter a ordem da mensagem
    char[] etapa2 = new char[qtdChars];
    for (int index = 0; index < qtdChars; index++)
    {
        //Indo do fim da fila para o inicio
        int posicao = (qtdChars-1) - index;
        etapa2[posicao] = etapa1[index];
    }
    //----- 3° Etapa -----
    //Todo e qualquer caractere a partir da metade em diante (truncada) devem ser deslocados uma posição para a esquerda na tabela ASCII.
    char[] etapa3 = etapa2;
    int metade = qtdChars/2;
    for (int index = metade; index < qtdChars; index++)
    {
        int asciiCode = Convert.ToInt32(etapa3[index]) - 1;
        etapa3[index] = Convert.ToChar(asciiCode);
    }
    System.Console.WriteLine(etapa3);
}
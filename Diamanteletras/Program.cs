namespace Diamanteletras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Informe uma letra ou Exit");
                String s = Console.ReadLine();
                if (s.Equals("") || s == null)
                {
                    Console.WriteLine("Favor digitar uma letra");
                    Console.WriteLine();
                    continue;
                }
                else if (s.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }
                else
                {
                    // 65~90 codigo int dos CHAR de A a Z
                    int codc = 65; //== A
                    s.ToUpper();
                    int tamanho = (Convert.ToInt32(Convert.ToChar(s[0]))) - 64;
                    
                    tamanho = (tamanho * 2)-1;
                    String[,] diamante = new String[tamanho, tamanho];
                    int meio = tamanho/2;
                    tamanho--;
                    int inicio = meio;
                    int fim = meio;
                    int letra = codc;

                    for(int linha=0; linha<=meio; linha++)
                    {
                        for(int coluna=0; coluna<=tamanho; coluna++)
                        {
                            if(coluna == inicio || coluna == fim)
                            {
                                diamante[linha, coluna] = Convert.ToString(Convert.ToChar(letra));
                            }
                            else
                            {
                                diamante[linha, coluna] = " ";
                            }
                        }
                        letra++;
                        inicio--;
                        fim++;
                    }
                    letra--;
                    inicio++;
                    fim--;
                    for (int linha = meio; linha <= tamanho; linha++)
                    {
                        for (int coluna = 0; coluna <= tamanho; coluna++)
                        {
                            if (coluna == inicio || coluna == fim)
                            {
                                diamante[linha, coluna] = Convert.ToString(Convert.ToChar(letra));
                            }
                            else
                            {
                                diamante[linha, coluna] = " ";
                            }
                        }
                        letra--;
                        inicio++;
                        fim--;
                    }
                    for (int l = 0; l <= tamanho; l++)
                    {
                        for (int c = 0; c <= tamanho; c++)
                        {
                            Console.Write($"{diamante[l, c]}");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
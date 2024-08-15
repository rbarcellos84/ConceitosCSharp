using System;
using System.Globalization;

namespace Conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 22;
            string texto = numero.ToString();  //saida "22"
            Console.WriteLine(texto);
            //--------------------------------------------------------
            string valorString = "1234.5678";
            double valorDouble = double.Parse(valorString);
            //ou
            double valorDouble2 = Convert.ToDouble(valorString);

            string formatoN2 = valorDouble.ToString("N2");  //saída: 1.234,57
            string formatoF2 = valorDouble.ToString("F2");  //saída: 1234.57
            string formatoC2 = valorDouble.ToString("C2");  //saída: R$ 1.234,57 (pode variar dependendo da cultura)
            string formatoP2 = (valorDouble / 100).ToString("P2");  //saída: 123,46%

            Console.WriteLine(formatoN2);
            Console.WriteLine(formatoF2);
            Console.WriteLine(formatoC2);
            Console.WriteLine(formatoP2);
            //--------------------------------------------------------
            texto = "22";
            numero = int.Parse(texto);  //saida 22
            Console.WriteLine(numero);
            //--------------------------------------------------------
            DateTime dataHora = DateTime.Now;
            string dataFormatada = dataHora.ToString("dd/MM/yyyy HH:mm");
            Console.WriteLine(dataFormatada);

            string dataHoraString = "02/08/2024 12:22";

            // Define o formato da data e hora
            string formato = "dd/MM/yyyy HH:mm";

            // Tenta converter a string para DateTime
            if (DateTime.TryParseExact(dataHoraString, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out dataHora))
            {
                Console.WriteLine("Data e hora convertida com sucesso:");
                Console.WriteLine(dataHora);
            }
            else
            {
                Console.WriteLine("Formato de data e hora inválido.");
            }
            //--------------------------------------------------------
            var dados = "1234";
            if (int.TryParse(dados, out int numeroConvertido))
                Console.WriteLine("numero convertido");

            //--------------------------------------------------------
            
            //ToUpper
            string texto1 = "Olá, mundo!";
            string textoMaiusculo = texto1.ToUpper();
            Console.WriteLine(textoMaiusculo); // Saída: OLÁ, MUNDO!

            //ToLower
            string texto2 = "Olá, mundo!";
            string textoMinusculo = texto2.ToLower();
            Console.WriteLine(textoMinusculo); // Saída: olá, mundo!

            //Substring
            string frase1 = "Olá, mundo! Tudo bem?";
            string palavra1 = frase1.Substring(7, 5); // Começa no índice 7 e pega 5 caracteres
            Console.WriteLine(palavra1); // Saída: mundo
            string palavra2 = frase1.Substring(5); // Começa no índice 7 e pega 5 caracteres
            Console.WriteLine(palavra2); // Saída: mundo! Tudo bem?

            //range
            string frase = "Olá, mundo!";
            string subfrase = frase[2..7]; // Extrai da posição 2 (incluindo) até a posição 7 (excluindo)
            Console.WriteLine(subfrase); // Saída: lá, m

            string frase2 = "Olá, mundo!";
            string ultimaPalavra = frase2[^5..]; // Extrai os últimos 5 caracteres
            Console.WriteLine(ultimaPalavra); // Saída: mundo!

            string frase3 = "Olá, mundo!";
            string meioDaFrase = frase3[4..^4]; // Extrai do meio, excluindo os 4 primeiros e os 4 últimos
            Console.WriteLine(meioDaFrase); // Saída: , mund

            //contains
            string texto3 = "O gato subiu na árvore.";
            string palavraProcurada = "gato";

            if (texto3.Contains(palavraProcurada))
            {
                Console.WriteLine("A palavra '{0}' foi encontrada no texto.", palavraProcurada);
            }
            else
            {
                Console.WriteLine("A palavra '{0}' não foi encontrada.", palavraProcurada);
            }

            //trim, trimEnd e trimStart
            string textoComEspacos = "   Olá, mundo!   ";

            // Removendo todos os espaços em branco
            string textoSemEspacos = textoComEspacos.Trim();
            Console.WriteLine(textoSemEspacos); // Saída: Olá, mundo!

            string textoComEspacos2 = "**Olá, mundo!**";
            Console.WriteLine(textoComEspacos2.Trim('*')); // Saída: Olá, mundo!
            Console.WriteLine(textoComEspacos2.TrimStart()); // Saída: Olá, mundo!**
            Console.WriteLine(textoComEspacos2.TrimEnd()); // Saída: **Olá, mundo!

            //StartsWith/EndsWith
            string texto4 = "Olá, mundo!";

            // Verifica se o texto começa com "Olá"
            bool iniciaComOla = texto4.StartsWith("Olá");
            if (iniciaComOla)
            {
                Console.WriteLine("O texto começa com 'Olá'.");
            }
            else
            {
                Console.WriteLine("O texto não começa com 'Olá'.");
            }

            string arquivo = "imagem.jpg";
            // Verifica se o arquivo tem a extensão ".jpg"
            bool ehUmaImagemJpg = arquivo.EndsWith(".jpg");
            if (ehUmaImagemJpg)
            {
                Console.WriteLine("É um arquivo JPG.");
            }
            else
            {
                Console.WriteLine("Não é um arquivo JPG.");
            }

            //Replace
            string texto5 = "Olá, mundo! O mundo é muito grande.";
            string novoTexto = texto5.Replace("mundo", "universo");
            Console.WriteLine(novoTexto); // Saída: Olá, universo! O universo é muito grande.

            //Length
            string frase4 = "Olá, mundo!";
            int numeroDeCaracteres = frase4.Length;
            Console.WriteLine("A frase tem " + numeroDeCaracteres + " caracteres."); //A frase tem 12 caracteres.

            //dateTime
            var date1 = new DateTime(2024,08,04,19,51,36); //MM/DD/AAAA HH:MM:SS 08/04/2024 19:51:36
            var date2 = DateTime.Parse("2024/08/04 19:51:36"); //MM/DD/AAAA HH:MM:SS 08/04/2024 19:51:36
            var date3 = DateTime.Now; //MM/DD/AAAA HH:MM:SS data hora corrente da maquina ou servidor
            var date4 = DateTime.Today; //MM/DD/AAAA 00:00:00 data corrente da maquina ou servidor

            //dateTimeOffset
            var dateTimeOffset = new DateTimeOffset(DateTime.Now,new TimeSpan(-3,0,0)); //MM/DD/AAAA HH:MM:SS 08/04/2024 19:51:36
            Console.WriteLine(dateTimeOffset.LocalDateTime);  //MM/DD/AAAA HH:MM:SS data hora corrente da maquina ou servidor
            //Console.WriteLine(dateTimeOffset.Now);  //MM/DD/AAAA HH:MM:SS data hora corrente da maquina ou servidor
            Console.WriteLine(dateTimeOffset.UtcDateTime); //MM/DD/AAAA HH:MM:SS data hora corrente da maquina ou servidor em formato UTC
            //Console.WriteLine(dateTimeOffset.UtcNow); //MM/DD/AAAA HH:MM:SS data hora corrente da maquina ou servidor em formato UTC

            //subitraindo datas
            var date5 = new DateTime(2024,08,04,19,51,36); //MM/DD/AAAA HH:MM:SS 08/04/2024 19:51:36
            var date6 = DateTime.Now; //MM/DD/AAAA HH:MM:SS data hora corrente da maquina ou servidor
            var diff = date2 - date1; //ambas as formas funconam da mesma maneira
            //ou
            var diff2 = date2.Subtract(date1); //ambas as formas funconam da mesma maneira
            Console.WriteLine((int)diff.TotalDays);
            Console.WriteLine((int)diff.TotalHours);

            //adicionando mes, dia, ano, hora, minuto e segundo
            var date7 = DateTime.Now; //MM/DD/AAAA HH:MM:SS data hora corrente da maquina ou servidor
            Console.WriteLine(date1.AddDays(3).ToString("MM/dd/yyyy hh:mm:ss"));  //MM/DD/AAAA HH:MM:SS data hora corrente da maquina ou servidor
            Console.WriteLine(date1.AddMonths(3).ToString("MM/dd/yyyy hh:mm:ss"));  //MM/DD/AAAA HH:MM:SS data hora corrente da maquina ou servidor
            Console.WriteLine(date1.AddYears(3).ToString("MM/dd/yyyy hh:mm:ss"));  //MM/DD/AAAA HH:MM:SS data hora corrente da maquina ou servidor
            Console.WriteLine(date1.AddHours(3).ToString("MM/dd/yyyy hh:mm:ss"));  //MM/DD/AAAA HH:MM:SS data hora corrente da maquina ou servidor
            Console.WriteLine(date1.AddMinutes(3).ToString("MM/dd/yyyy hh:mm:ss"));  //MM/DD/AAAA HH:MM:SS data hora corrente da maquina ou servidor
            Console.WriteLine(date1.AddSeconds(3).ToString("MM/dd/yyyy hh:mm:ss"));  //MM/DD/AAAA HH:MM:SS data hora corrente da maquina ou servidor

            //recuperando o dia da semana
            var date8 = DateTime.Now; //MM/DD/AAAA HH:MM:SS data hora corrente da maquina ou servidor
            Console.WriteLine(date1.DayOfWeek);  //retorna o dia da semana

            //date only
            var onlyDate1 = new DateOnly(2024,08,04); //MM/DD/AAAA 08/04/2024
            var onlyDate2 = DateOnly.Parse("2024-08-04"); //MM/DD/AAAA 08/04/2024
            Console.WriteLine(onlyDate1.ToString("MM/dd/yyyy"));  //retorna a data
            Console.WriteLine(onlyDate2.ToString("MM/dd/yyyy"));  //retorna a data

            //TimeOnly
            var onlyTime1 = new TimeOnly(19,51,36); //HH:MM:SS 19:51:36
            var onlyTime2 = TimeOnly.Parse("19:51:36"); //HH:MM:SS 19:51:36
            Console.WriteLine(onlyDate1.ToString("hh:mm:ss"));  //retorna a hora
            Console.WriteLine(onlyDate2.ToString("hh:mm:ss"));  //retorna a hora
        }
    }
}
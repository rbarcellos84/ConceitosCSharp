using System;
using System.IO;
using System.IO.Compression;

namespace Conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivo = "C:/meuArquivo.txt";

            // Parte 1: Escrever no arquivo
            Console.WriteLine("Digite o texto que deseja salvar no arquivo:");
            string texto = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(caminhoArquivo, true))
            {
                writer.WriteLine(texto);
                Console.WriteLine("Texto salvo com sucesso!");
            }

            // Parte 2: Ler do arquivo
            Console.WriteLine("\nConteúdo do arquivo:");
            using (StreamReader reader = new StreamReader(caminhoArquivo))
            {
                string linha;
                while ((linha = reader.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }

            // Parte 3: lendo o arquivo e colocando em memoria
            var conteudo = File.ReadAllText(caminhoArquivo);
            Console.WriteLine(conteudo);

            // Parte 4: Excluindo o arquivo
            try
            {
                File.Delete(caminhoArquivo);
                Console.WriteLine("Arquivo excluído com sucesso!");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Erro ao excluir o arquivo: " + ex.Message);
            }

            // Parte 5: compactando um arquivo
            string arquivoOriginal = "C:/meuArquivo.txt";
            string arquivoZip = "C:/meuArquivo.zip";

            using (FileStream zipStream = File.Create(arquivoZip))
            using (ZipArchive archive = new ZipArchive(zipStream, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(arquivoOriginal, Path.GetFileName(arquivoOriginal));
            }

            Console.WriteLine("Arquivo compactado com sucesso!");
        }
    }
}
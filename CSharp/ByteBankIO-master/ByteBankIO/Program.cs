using ByteBankIO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";


        /*Para tratar exceções complexas, uma boa opção é usar o padrão do using. Vale lembrar que o using tem uma condição para ser aplicado: 
         * ele funciona com objetos que implementam uma interface IDisposable. 
         * Ao examinar o FileStream, reparamos que ele implementa essa interface, então podemos usar o using nesse caso!*/
        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var numeroDeBytesLidos = -1;

            var buffer = new byte[1024]; //1KB      

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
            }

            // Devoluções:
            //  O número total de bytes lidos do buffer. Isso poderá ser menor que o número de
            //  bytes solicitado se esse número de bytes não estiver disponível no momento, ou
            //  zero, se o final do fluxo for atingido


            // public override int Read(byte[] array, int offset, int count);]
            /*Anteriormente, usamos o Read para ler o nosso buffer. Agora, utilizaremos outro método associado ao fluxo de arquivos: o Close. 
             * Após exibir o buffer ao usuário, informaremos ao sistema operacional que o arquivo 
             * pode ser fechado, pois já realizamos o que queríamos. Em Main, após a leitura dos dados, vamos inserir fluxoDoArquivo.Close():*/
            fluxoDoArquivo.Close();

            Console.ReadLine();
        }
    }

    static void EscreverBuffer(byte[] buffer)
    {
        // UTF8Encoding() FAZ PARTE DA DIRETIVA SYSTEM.TEXT
        var utf8 = new UTF8Encoding();

        var texto = utf8.GetString(buffer);
        Console.Write(texto);

        /*
        foreach (var meuByte in buffer)
        {
            Console.Write(meuByte);
            Console.Write(" ");
        }
        */
    }
}
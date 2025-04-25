using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        //Teste com Nokia
         Console.WriteLine("Smartphone Nokia");
        Nokia nokia = new Nokia("123456789", "Nokia 1234", "111111111", 32);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\n");

        //Teste com iPhone
        Console.WriteLine("Smartphone iPhone");
        Iphone iphone = new Iphone("987654321", "iPhone 15", "222222222", 256);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Telegram");

    }
}
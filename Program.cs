using System;

class Program
{
    static void Main(string[] args)
    {
        Bomba bombaPrincipal = new Bomba("KSB-01", true);
        BombaSubmersivel bombaSubmersivel = new BombaSubmersivel("INKOA-08", false, 60);

        Console.WriteLine("======= BOMBA PRINCIPAL =======");
        bombaPrincipal.MostrarEstado();
        bombaPrincipal.Ligar();
        bombaPrincipal.Desligar();

        Console.WriteLine("\n======= BOMBA SUBMERSÍVEL =======");
        bombaSubmersivel.MostrarDetalhes();
        bombaSubmersivel.Ligar();
        bombaSubmersivel.Desligar();
    }
}

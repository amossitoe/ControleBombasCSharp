class BombaSubmersivel : Bomba
{
    private double profundidadeMaxima;

    public BombaSubmersivel(string idBomba, bool ligada, double profundidadeMaxima)
        : base(idBomba, ligada)
    {
        this.profundidadeMaxima = profundidadeMaxima;
    }

    public override void Ligar()
    {
        if (ligada==false)
        {
            ligada = true;
            Console.WriteLine($"A bomba {idBomba} está LIGADA à profundidade {profundidadeMaxima} m");
        }
        else
        {
            Console.WriteLine($"A bomba {idBomba} já está em funcionamento");
        }
    }

    public override void Desligar()
    {
        if (ligada==true)
        {
            ligada = false;
            Console.WriteLine($"A bomba {idBomba} está DESLIGADA à profundidade {profundidadeMaxima} m");
        }
        else
        {
            Console.WriteLine($"A bomba {idBomba} já está parada");
        }
    }

    public void MostrarDetalhes()
    {
        MostrarEstado();
        Console.WriteLine($"Profundidade máxima de operação: {profundidadeMaxima} m");
    }
}

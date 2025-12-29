using System;

class Bomba
{
    protected string idBomba;
    protected bool ligada;

    public Bomba(string idBomba, bool ligada)
    {
        this.idBomba = idBomba;
        this.ligada = ligada;
    }

    public bool GetLigada()
    {
        return ligada;
    }

    public virtual void Ligar()
    {
        if (!ligada)
        {
            ligada = true;
            Console.WriteLine($"A bomba {idBomba} está LIGADA");
        }
        else
        {
            Console.WriteLine($"A bomba {idBomba} já está em funcionamento");
        }
    }

    public virtual void Desligar()
    {
        if (ligada)
        {
            ligada = false;
            Console.WriteLine($"A bomba {idBomba} está DESLIGADA");
        }
        else
        {
            Console.WriteLine($"A bomba {idBomba} já está parada");
        }
    }

    public void MostrarEstado()
    {
       if(ligada==true){
         Console.WriteLine($"A bomba {idBomba} está LIGADA");
       }else{
        Console.WriteLine($"A bomba {idBomba} está DESLIGADA");
    }
}
}

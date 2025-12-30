using System;
class Valvula {
    
    protected string id;
    protected bool aberta;
    
    public Valvula(string id, bool aberta){
        this.id=id;
        this.aberta=aberta;
    }
    public bool getAberta(){
        return aberta;
    }
    public virtual void abrir(){
        if(aberta==false){
            aberta=true;
            Console.WriteLine($"A válvula {id} está ABERTA");
        }else{
            Console.WriteLine($"A válvula {id} já foi ABERTA");
        }
    }
     public virtual void fechar(){
        if(aberta==true){
            aberta=false;
            Console.WriteLine($"A válvula {id} está FECHADA");
        }else{
            Console.WriteLine($"A válvula {id} já foi FECHADA");
        }
    }
    public void mostrarEstado(){
        if(aberta==true){
            Console.WriteLine($"A válvula {id} está ABERTA");
        }else{
            Console.WriteLine($"A válvula {id} está FECHADA");
        }
    }
}  
class Comporta:Valvula{
    
    private string material;
    
    public Comporta(string id, bool aberta, string material): base(id, aberta){
        this.material=material;
    }
    public override void abrir(){
       base.abrir(); 
    Console.WriteLine($"Material: {material}");
    }
     public override void fechar(){
        if(aberta==true){
            aberta=false;
            Console.WriteLine($"A válvula {id} está FECHADA");
        }else{
            Console.WriteLine($"A válvula {id} já foi FECHADA");
        }
    }
    public void mostrarDetalhes(){
        mostrarEstado();
            Console.WriteLine($"Material da válvula {id}: {material}");
}  
}
    class ValvulaTeste{
  static void Main(string[]args) {
    
    Valvula v1=new Valvula("Monovar 01", true);
    Comporta c1=new Comporta("Mural", false, "Aco Inox");
    
    Console.WriteLine("=========válvula Principal========");
    v1.mostrarEstado();
    v1.abrir();
    v1.fechar();

    Console.WriteLine("=========Comporta========");
    c1.mostrarDetalhes();
    c1.abrir();
    c1.fechar();
  }
}

public class Carro:Veiculo{
    
    public override void acelerar(){
        velocidade+=10;
    }
    public override void frear(){
        velocidade-=5;
    }
}
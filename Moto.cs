public class Moto:Veiculo{
    public override void acelerar()
    {
        velocidade+=15;
    }
    public override void frear()
    {
        velocidade-=10;   
    }
}
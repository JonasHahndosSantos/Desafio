public abstract class Veiculo{
    protected int velocidade;
    public abstract void acelerar();
    public abstract void frear();

    public int ExibirVelocidade(){
        return velocidade;
    }
}
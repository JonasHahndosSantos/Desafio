Carro carro= new Carro();
Moto moto= new Moto();
List<Veiculo> Veiculos = new List<Veiculo>();
Veiculos.Add(moto);
Veiculos.Add(carro);
foreach(var veiculo in Veiculos) {
    
    veiculo.acelerar();
    System.Console.WriteLine("A velocidade da " + veiculo.GetType()+ " ao acelerar é: " + veiculo.ExibirVelocidade() + "km/h");    
    veiculo.frear();
    System.Console.WriteLine("A velocidade da " + veiculo.GetType()+ " ao frear é: " + veiculo.ExibirVelocidade() + "km/h");

}
namespace ex_polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Leao leao1 = new Leao("joao leao", "M", "raca baixinho..");
            leao1.ExibirInfo();

            Tigre tigre1 = new Tigre("quim tigre", "F", "mt grande");
            tigre1.ExibirInfo();
            tigre1.EmitirSom();


         List<Animal> animais = new List<Animal>
        {
            new Leao("Simba", "Masculino", "Leão Africano"),
            new Tigre("Rajah", "Feminino", "Tigre de Bengala"),
           new Tigre("asd", "Feminino", "Tigre de Bengala"),
           new Tigre("Rajklsajdlksjah", "Feminino", "Tigre de Bengala"),
           new Tigre("asdnlksa", "Feminino", "Tigre de Bengala"),
           new Tigre("2132", "Feminino", "Tigre de Bengala"),
        };

        foreach (var animal in animais)
        {
            animal.ExibirInfo();
            animal.EmitirSom();
            animal.Dormir();
            animal.Caminhar();
        }
             
        }
    }
}
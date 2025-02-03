//Written By Chloe Jensrud
//2/1/25



namespace DefenseSystems
{
    public class Program
    {
        static void Main(string[] args)
        {
           DefenseSystems aDefenseSystem = new DefenseSystems(2,7);

            Console.WriteLine("Target Row?:");
            int targetRow = (3);

            Console.WriteLine("Target Column?:");
            int targetCol = (5);
            
            
            
            Console.WriteLine(aDefenseSystem.CalcDeploy());
        }
    }
}

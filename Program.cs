namespace Boucle;

class Program
{
    static void Main(string[] args)
    {
        string[] moves = new string[32];
        int i = 0;
        while(true)
        {
            Console.Write("veuillez entrer un pas de danse: ");
            string unPas = Console.ReadLine();
            if(String.IsNullOrEmpty(unPas))
            {
                continue;
            }else{
                moves[i] = unPas;

            }

            if(unPas == "done")
                break;

            i++;
            

        }
        Console.Write("Saisissez un nombre d'itérations de la suite de pas: ");
        int nbIteration =Int32.Parse(Console.ReadLine());
        for(int j =0; j< nbIteration;j++)
        {
            int k = 0;

            while(moves[k] != "done" || k >=32)
            {
                Console.Write(moves[k] + " ");
                k++;
            }
            Console.WriteLine(" ");
        }

      
        
    }
}

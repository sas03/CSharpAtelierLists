namespace atelierCollectionsGeneriques;
public class atelierList
{
 
    static void Main(string[] args)
    {
        ListBySteph<int> nombres = new ListBySteph<int>();
        nombres.Add(10);
        nombres.Add(20);
        nombres.Add(30);

        nombres.Remove(1);
        Console.WriteLine("Count = " + nombres.Count());

        for(int i = 0; i < 4; i++){
            Console.WriteLine("values[" + i + "] = " + nombres.Get(i));
        }    

        nombres.Clear();
        Console.WriteLine("Clear");

        nombres.Add(10);
        nombres.Add(20);

        Console.WriteLine("Count = " + nombres.Count());
        Console.WriteLine("Values[1] = " + nombres.Get(1));// nombres[1] == 20

        Console.WriteLine(nombres[0]);
        ListBySteph<string> phrases = new ListBySteph<string>();
        phrases.Add("Nouvelle phrase");
    }
}

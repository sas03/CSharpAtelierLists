namespace atelierCollectionsGeneriques;
class atelierList
{
    List<int> liste { get; set; }

    public atelierList(){
        liste = new List<int>();
    }

    private void ajoutElement(int e){
        liste.Add(e);
        Console.WriteLine(e + " added");
    }
    private void supprElement(){
        while(true){
            Console.WriteLine("Type the id of the element to remove: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if(id < liste.Count && id >= 0){
                liste.Remove(id);
                Console.WriteLine("Element " + liste[id] + " with id " + id + " removed");
                Console.ReadLine();
                break;
            } else{
                Console.WriteLine("Index out of range");
            }
        } 
    }
    private void countElements(List<int> liste){
        Console.WriteLine("The number of elements in the list is: " + liste.Count);
    }
    private void viderListe(List<int> liste){
        liste.Clear();
        Console.WriteLine("The list is empty");
    }

    private void getElement(int id){
        int element = liste[id];
        if(id < liste.Count && id >= 0){
            Console.WriteLine("Element with the id " + id + " is: " + element);
        } else{
            Console.WriteLine("Index out of range");
        } 
    }
    static void Main(string[] args)
    {
        atelierList at = new atelierList();
        Console.WriteLine("-----------");
        at.ajoutElement(33);
        at.ajoutElement(95);
        at.getElement(1);
        at.supprElement();
        at.ajoutElement(34);
        at.viderListe(at.liste);
        at.ajoutElement(17);
        at.ajoutElement(112);
        at.countElements(at.liste);
    }
}

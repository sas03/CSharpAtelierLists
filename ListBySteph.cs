//Définir un type paramétré T pour la classe
public class ListBySteph<T>{
    //tableau d'éléments de type T
    private T[] values;
    private int nbValues;

    //constructeur appellé lors de l'appel de l'objet de la classe
    public ListBySteph(){
        //initialize le tableau d'objets T avec 10 cases vides(taille du tableau est fixe)
        values = new T[10];
        //initialize nbValues à 0
        nbValues = 0;
    }

    public void Add(T value){
        //si le tableau values est deja plein
        if(nbValues == values.Length){
            //créer un nouveau tableau plus grand
            T[] newArray = new T[values.Length * 2];

            //copier les valeurs de l'ancien tableau, dans le nouveau à partir de l'index 0
            values.CopyTo(newArray, 0);

            //affecter le nouveau tableau à la variable values
            values = newArray;
        }

        //Sinon, on ajoute value à l'élément du tableau values d'index nbValues
        values[nbValues] = value;
        //incremente nbValues à chaque appel de la fonction
        nbValues++;
    }
    
    public int Count(){
        return nbValues;
    }

    public void Clear(){
        Array.Clear(values);//nettoyer le tableau existant
        //pour reinitiliazer un tableau, il suffit de reinitializer un tableau avec un certain nombre de cases
        values = new T[10];
        nbValues = 0;
    }

    public T Get(int index){
        // verifier que index n'est pas < 0
        // verifier que index n'est pas >= nbValues
        return values[index];
    }

    //public void Remove(T index){
    //    
    //}

    public void Remove(int index){
        // [ , , , , , , , , ]
        // [10, 20, 30, 40, , , , ]
        // supprimer index 1. supprimer 20
        // [10, 30, 40, , , , , , ]
        for(int i = index; i < nbValues; i++){
            values[i] = values[i + 1];
        }

        nbValues--;
    }
}
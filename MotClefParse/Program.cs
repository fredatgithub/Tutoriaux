using System;
namespace MotClefParse
{
  class Program
  {
    static void Main()
    {
      Action<string> affiche = Console.WriteLine;
      // mot clef PARSE
      // Parse signifie transformer un type en un autre
      int age = 0;
      //age = Console.ReadLine(); // erreur car readline renvoit un string
      //affiche(age); // erreur car affiche attends un string
      affiche(age.ToString()); // plus d'erreur
      string age2;
      age2 = Console.ReadLine();
      affiche("L'age entré est " + age2); // age2 peut être un nombre ou un string
      //Utilisation de PARSE
      int age3;
      //age3 = int.Parse(age2); //erreur si age2 n'est pas un entier
      //affiche(age3.ToString());
      //bonne pratique :
      if (int.TryParse(age2, out age3))
      {
        affiche("vous avez bien entré un nombre " + age3);
      }
      else
      {
        affiche("erreur, ce n'est pas un nombre");
      }

      affiche("bonne pratique");
      while (!int.TryParse(Console.ReadLine(), out age3))
      {
        affiche("entrer un nombre uniquement!");
      }

      affiche("vous avez bien entré un nombre " + age3);
      Console.ReadKey();
    }
  }
}
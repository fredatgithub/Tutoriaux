using System;
using System.Collections.Generic;

namespace Dictionnaire
{
  class Program
  {
    static void Main()
    {
      Action<string> affiche = Console.WriteLine;
      // les dictionnaires
      // un dictionnaire est une liste de couple de valeurs
      // mot clef Dictionary<type1, type2>
      Dictionary<string, int> compteurdeMot = new Dictionary<string, int>();
      Dictionary<string, string> traducteur = new Dictionary<string, string>();
      Dictionary<int, int> compteurDeChiffre = new Dictionary<int, int>();
      Dictionary<string, bool> dico3 = new Dictionary<string, bool>();
      //pour ajouter un couple de valeur
      compteurdeMot.Add("un", 1);
      traducteur.Add("bonjour", "hello");
      compteurDeChiffre.Add(1, 1);

      Console.ReadKey();
    }
  }
}
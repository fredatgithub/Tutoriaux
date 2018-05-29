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
      // le premier type s'appelle la clef ou Key
      // le deuxième type s'appelle la valeur ou value
      //donc un dictionnaire est une liste de clef/valeur ou key/value
      // Dictionary<key, value>
      Dictionary<string, int> compteurdeMot = new Dictionary<string, int>();
      Dictionary<string, string> traducteur = new Dictionary<string, string>();
      Dictionary<int, int> compteurDeChiffre = new Dictionary<int, int>();
      Dictionary<string, bool> dico3 = new Dictionary<string, bool>();
      //pour ajouter un couple de valeur,on utilise la méthode Add
      compteurdeMot.Add("un", 1);
      compteurdeMot.Add("des", 1);
      traducteur.Add("bonjour", "hello");
      compteurDeChiffre.Add(1, 1);
      //mais il faut que la clef n'existe pas encore car elle est unique
      //donc il faut tester l'existence d'une clef avant de l'ajouter
      if (compteurdeMot.ContainsKey("un"))
      {
        compteurdeMot["un"]++; //vue que la valeur est integer, on peut l'incrémenter
      }
      else
      {
        compteurdeMot.Add("un", 1);
      }

      affiche("le nombre du mot UN est " + compteurdeMot["un"]);
      // pour parcourir un dictionnaire, on le parcours comme une liste
      foreach (var keyValuePair in compteurdeMot)
      {
        affiche("la clef est " + keyValuePair.Key + " et la valeur est "
                + keyValuePair.Value);
      }

      //pour changer une valeur
      compteurdeMot["des"] = 3;
      traducteur["bonjour"] = "good morning";

      //pour supprimer un élément du dictionnaire
      compteurDeChiffre.Remove(1); // pour un entier
      traducteur.Remove("bonjour"); // pour un string
      affiche("après suppression :");
      compteurdeMot.Remove("des");
      foreach (var item in compteurdeMot)
      {
        affiche("la clef est " + item.Key + " et la valeur est "
                + item.Value);
      }
      Console.ReadKey();
    }
  }
}
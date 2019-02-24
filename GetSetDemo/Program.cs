using System;
using System.Collections.Generic;

namespace GetSetDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      // Get Set
      // souvent appelé getteurs, setteurs
      // Get est un accessor, pour accéder à une propriété
      // Set est un mutator, pour changer une valeur d'une propriété (mutation de la valeur)
      // Les propriétés permettent l'encapsulation des données dans une Classe
      // On est pas obligé de définir à la fois Get et Set
      // ce qui permet de définir des propriéts real-Only, Write-Only, Readable, writeable
      // Un autre avantage est de valider des données avant de les accepter.
      //Action<string> affiche = Console.WriteLine;
      CompteBancaire compteCourant = new CompteBancaire("Bill", 110.50);
      Console.WriteLine("Votre solde est de {0} euros", compteCourant.Compte);
      compteCourant.Deposer(2000.00);
      Console.WriteLine("Votre solde est de {0} euros", compteCourant.Compte);
      compteCourant.Deposer(0.00);
      //CompteCourant.CompteEnAnomalie = false; // pas de setter donc read-only
      compteCourant.Retirer(110.5);
      Console.WriteLine("Votre solde est de {0} euros", compteCourant.Compte);

      Console.ReadKey();
    }

    public class CompteBancaire
    {
      // définition d'une propriété
      private double _compte;
      private bool _compteEnAnomalie;
      private List<string> _listeEcriture; // pas de get ni de set
      private string _ecritureTransaction;

      public bool CompteEnAnomalie
      {
        get { return _compteEnAnomalie; } // propriété read-only
      }

      public double Compte
      {
        get { return _compte; }
        private set
        {
          if (value >= 0)
          {
            _compte = value;
          }

        }
      }

      public string Nom { get; set; } // depuis Visual Studio 2010 ou .NET 4.0

      public CompteBancaire(string nom, double compte, bool compteEnAnomalie = false)
      {
        _compteEnAnomalie = compteEnAnomalie;
        Nom = nom;
        _listeEcriture = new List<string>();
        if (compte >= 0)
        {
          Compte = compte;
        }
        else
        {
          // avertir le chef pour anomalie
          _compteEnAnomalie = true;
          Compte = 0;
        }

        Console.WriteLine("{0}, votre compte bancaise vient d'être créé", Nom);
      }

      public double AfficheSolde()
      {
        return Compte;
      }

      public void Deposer(double somme)
      {
        if (somme <= 0)
        {
          Console.WriteLine("Vous ne pouvez pas déposer une somme négative ou nulle");
        }

        if (somme > 1000000)
        {
          Console.WriteLine("Avez-vous gagné au Loto ?");
        }

        Compte += somme;
      }

      public void Retirer(double somme)
      {
        if (somme > Compte)
        {
          Console.WriteLine("Vous n'avez pas de découvert authorisé, action impossible");
        }
        else
        {
          Compte -= somme;
          //Console.WriteLine("Vous venez de retirer " + somme + " euros");// pas conseillé
          Console.WriteLine("Vous venez de retirer {0} euros", somme); // bonne pratique
        }
      }

      private void EcrireTransaction(double somme)
      {
        _ecritureTransaction = DateTime.Now.ToString() + somme;
        _listeEcriture.Add(_ecritureTransaction);
      }
    }
  }
}

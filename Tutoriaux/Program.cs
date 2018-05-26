using System;
using System.Globalization;
namespace Tutoriaux
{
  class Program
  {
    static void Main()
    {
      Action<string> affiche = Console.WriteLine;
      //Il existe une énumération pour les jours de la semaine.
      DateTime aujourdhui = DateTime.Today;
      affiche("En anglais nous sommes le " + aujourdhui.DayOfWeek);
      // méthode to string non nécessaire
      affiche(aujourdhui.DayOfWeek.ToString()); // en anglais par défaut
      var culture = new CultureInfo("fr-FR");
      var jour = culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
      affiche("Aujourd'hui en français nous sommes le " + jour); // en français

      // pour les noms des mois
      affiche("Le numéro du mois est un entier : " + DateTime.Today.Month);

      var mois = culture.DateTimeFormat.GetMonthName(aujourdhui.Month);
      affiche("en français, le mois courant est " + mois); // en français
      Console.ReadKey();
    }

    private enum JoursDeLaSemaine { Lundi, Mardi, Mercredi, Jeudi, Vendredi, 
      Samedi, Dimanche }
  }
}
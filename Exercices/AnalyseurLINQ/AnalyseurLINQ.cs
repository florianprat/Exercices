using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace LINQ
{
    public class AnalyseurLINQ
    {
    	private List<DonnéesMois> _data;
    	public List<DonnéesMois> Data {
    		get { return _data; }
    	}

        public AnalyseurLINQ()
        {
            _data = new List<DonnéesMois>();
        }

        public void ChargerDonnées()
        {
            string chemin = @"..\..\DonnéesMétéoParis.txt";

            int cpt = 0;
            using (StreamReader str = new StreamReader(chemin))
            {
                string ligne;
                
                while ((ligne = str.ReadLine()) != null)
                {
                    cpt++;
                    if (cpt == 1) continue; // On n'analyse pas la première ligne car elle contient les en-têtes

                    var tab = ligne.Split('\t');
                    try
                    {
                        var donnéesMois = new DonnéesMois
                        {
                            Mois = DateTime.Parse(tab[0]),
                            TMin = double.Parse(tab[1]),
                            TMax = double.Parse(tab[2]),
                            Précipitations = double.Parse(tab[3]),
                            Ensoleillement = double.Parse(tab[4])
                        };

                        // Ajout des données du mois à la liste
                        Data.Add(donnéesMois);
                    }
                    catch (FormatException)
                    {
                        // On ignore simplement la ligne
                        Console.WriteLine("Erreur de format à la ligne suivante :\r\n{0}", ligne);
                    }
                }
            }
        }

        public void AfficherStats()
        {
            // mois de la température min la plus basse
            var res1 = Data.Min(t => t.TMin);
            var res2 = Data.Where(m => m.TMin == res1).First();

            // autre manière : Data.OrderBy(m => m.TMin).First();

            Console.WriteLine("Mois le plus froid : {0}, avec {1}°C", res2.Mois.ToString("MMMM yyyy"), res2.TMin);

            // Sommes des précipitations de l'année 2016

            //var res3 = Data.Where(a => a.Mois.Year == 2016);
            //var res4 = res3.Sum(p => p.Précipitations);

            var res3 = Data.Where(a => a.Mois.Year == 2016).Sum(d => d.Précipitations);

            Console.WriteLine("Sommes des précipitations de l'année 2016 : {0} mm", res3);

            // Durée d'ensoleillement moyenne du mois de Juillet sur toutes les années
            var res4 = Data.Where(m => m.Mois.Month == 7).Average(d => d.Ensoleillement);

            Console.WriteLine("Durée d'ensoleillement moyene du mois de Juillet sur toutes les années : {0} h", res4);

            // Précipitations moyennes par année
            var années = Data.Select(d => d.Mois.Year).Distinct();
            foreach (var an in années)
            {
                var res5 = Data.Where(a => a.Mois.Year == an).Average(d => d.Précipitations);
            }
            


        }
    }

    /// <summary>
    /// Classe contenant les données d'un mois de relevé météo
    /// </summary>
    public class DonnéesMois
    {
        public DateTime Mois { get; set; }
        public double TMin { get; set; }
        public double TMax { get; set; }
        public double Précipitations { get; set; }
        public double Ensoleillement { get; set; }
    }
}

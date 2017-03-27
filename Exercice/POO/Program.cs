using System;

namespace POO
{
	class Program
	{
		static void Main(string[] args)
		{
			//TesterCompteBancaire();
			//Console.WriteLine();

			TesterDistributeur();
			Console.ReadKey();
		}

		static void TesterCompteBancaire()
		{
			CompteBancaire[] tabComptes = new CompteBancaire[3];
			tabComptes[0] = new CompteBancaire(TypeCompte.Courant);
			DateTime dt = new DateTime(2016, 2, 25);
			tabComptes[1] = new CompteBancaire(dt, 500);
			tabComptes[2] = new CompteBancaire(TypeCompte.PEE);

			tabComptes[1].DécouvertAutorisé = -700;
			tabComptes[1].Créditer(1000);
			Console.WriteLine("Solde courant : {0}", tabComptes[1].SoldeCourant);

			tabComptes[1].Débiter(600);
			Console.WriteLine("Solde courant : {0}", tabComptes[1].SoldeCourant);

			tabComptes[1].Débiter(2000);
			Console.WriteLine("Solde courant : {0}", tabComptes[1].SoldeCourant);

		}

		static void TesterDistributeur()
		{
			DistributeurBoisson distrib = new DistributeurBoisson();
			distrib.Paiement = 0.30m; // la valeur étant de type décimal, on met un m
			try
			{
				distrib.BoissonSélectionnée = Boissons.CaféCrème;
			}
			catch(InvalidOperationException e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine();
			}

			distrib.Paiement = 1.0m;
			distrib.QuantitéSucre = 3;
			string service = distrib.ServirBoisson();
			Console.WriteLine(service);

			string rendu = distrib.RendreMonnaie();
			Console.WriteLine(rendu);

		}
	}
}

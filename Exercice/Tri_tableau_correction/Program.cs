using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriTableau
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] tabEssai = { "Vert", "Bleu", "Rouge", "Jaune" };
			AfficherTableau(tabEssai);
			string[] tabTrié = TrierTableau(tabEssai);
			AfficherTableau(tabTrié);

			Console.ReadKey();
		}

		static void AfficherTableau(string[] tab)
		{
			for (int i = 0; i < tab.Length; i++)
			{
				Console.Write(tab[i] + ", ");
			}
			Console.WriteLine();
		}

		static string[] TrierTableau(string[] tabEntrée)
		{
			string[] tab = new string[tabEntrée.Length];

			for (int i = 0; i< tabEntrée.Length; i++)
			{
				tab[i] = tabEntrée[i];
			}

			bool auMoinsUnePermut = true;

			while (auMoinsUnePermut == true)
			{
				auMoinsUnePermut = false;
				for (int i = 0; i < tab.Length; i++)
				{
					if (i == 0) continue;

					int resComp = tab[i - 1].CompareTo(tab[i]);
					if (resComp > 0)
					{
						string temp = tab[i];
						tab[i] = tab[i - 1];
						tab[i - 1] = temp;
						auMoinsUnePermut = true;
					}
				}
			}

			return tab;
		}
	}
}

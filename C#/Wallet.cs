// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

class WalletApp
{
    static void Main()
    {
        double solde = 200000;
        List<string> historiqueTransactions = new List<string>();

        while (true)
        {
            Console.Write("1. Versement 2. Retrait 3. Consultation du solde 4. Historique des transactions 5. Quitter Choisissez une option : ");
            int menu;

            if (!int.TryParse(Console.ReadLine(), out menu))
            {
                Console.WriteLine("Veuillez entrer une option valide.");
                continue;
            }
             
             int[] validOptions = { 1, 2, 3, 4, 5 };

            if (!validOptions.Contains(menu))
            {
                Console.WriteLine("Veuillez saisir une option valable");
                continue;
            }

            if (menu == 1)
            {
                Console.Write("Combien souhaitez-vous verser : ");
                if (double.TryParse(Console.ReadLine(), out double versement) && versement > 0)
                {
                    solde += versement;
                    historiqueTransactions.Add($"Versement de {versement}");
                    Console.WriteLine("Versement effectué avec succès !");
                }
                else
                {
                    Console.WriteLine("Veuillez entrer un montant valide.");
                }
            }
            else if (menu == 2)
            {
                Console.Write("Combien souhaitez-vous retirer : ");
                if (double.TryParse(Console.ReadLine(), out double retrait)  && retrait > 0)
                {
                    if (retrait > solde)
                    {
                        Console.WriteLine("Désolé, votre solde est insuffisant pour ce retrait");
                    }
                    else
                    {
                        solde -= retrait;
                        historiqueTransactions.Add($"Retrait de {retrait}");
                        Console.WriteLine("Retrait effectué avec succès !");
                    }
                }
                else
                {
                    Console.WriteLine("Veuillez entrer un montant valide.");
                }
            }
            else if (menu == 3)
            {
                Console.WriteLine($"Votre solde est : {solde}");
            }
            else if (menu == 4)
            {
                Console.WriteLine("Historique des transactions :");
                foreach (string transaction in historiqueTransactions)
                {
                    Console.WriteLine(transaction);
                }
            }
            else if (menu == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Veuillez saisir une option valable");
            }
        }
    }
}

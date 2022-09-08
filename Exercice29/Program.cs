/**
 * températures au dessus de la moyenne des températures saisies
 * author : wajih
 * date : 08/09/2022
 */
using System;

namespace Temperatures
{
    class Program
    {
        static void Main(string[] args)
        {
            // taille du tableau
            int taille = 10;
            // Déclarations
            float[] t = new float[taille]; // tableau des températures
            float moyenne, cumul = 0;
            // saisie des températures et cumul
            for (int k=0; k < taille; k++)
            {
                Console.Write("Entrez la température n°" + (k + 1) + " = ");
                t[k] = float.Parse(Console.ReadLine());
                cumul = cumul + t[k];
            }
            // calcul de la moyenne
            moyenne = cumul / taille;
            // calcul du nombre de températures au dessus de la moyenne
            int nbsup = 0;
            for (int k = 0; k < taille; k++)
            {
                if (t[k] > moyenne)
                {
                    nbsup++;
                }
            }
            // affichage du résultat
            Console.WriteLine("nbre de t° au-dessus de la moyenne = " + nbsup);
            Console.ReadLine();
        }
    }
}

using System;

namespace calculatrice_simple
{
    class Program
    {
        static void Main(string[] args)
        {
            // Appeler la méthode demanderEntier() depuis la classe InteractionUtilisateur
            int nombre1 = InteractionUtilisateur.demanderEntier();
            int nombre2 = InteractionUtilisateur.demanderEntier();
            Console.WriteLine("Veuillez choisir une opération entre '+', '-', '*' et '/': ");
            String operationChoisie = Console.ReadLine();
            if (operationChoisie == "+")
            {
                int resultat = Operation.addition(nombre1, nombre2);
                Console.WriteLine($"le résultat de l'addition de {nombre1} + {nombre2} = {resultat}.");
            }
            else if (operationChoisie == "-")
            {
                int resultat = Operation.soustraction(nombre1, nombre2);
                Console.WriteLine($"le résultat de la soustraction de {nombre1} - {nombre2} = {resultat}.");            
            }
            else if (operationChoisie == "*")
            {
                int resultat = Operation.multiplication(nombre1, nombre2);
                Console.WriteLine($"le résultat de la multiplication de {nombre1} * {nombre2} = {resultat}.");  
            }
            else if (operationChoisie == "/")
            {
                int resultat = Operation.division(nombre1, nombre2);
                Console.WriteLine($"le résultat de la division de {nombre1} / {nombre2} = {resultat}.");  
            }
            else
            {
                Console.WriteLine("Mauvais choix fin du programme... 🛑");
            }
        }
    }
}


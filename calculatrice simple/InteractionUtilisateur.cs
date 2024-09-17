namespace calculatrice_simple;

public class InteractionUtilisateur
{
    public static int demanderEntier()
    {
        bool conversionReussi = false;
        int nombreEntier=0;

        while (!conversionReussi)
        {
            Console.WriteLine("Entrez un nombre de entier: ");
            string saisieUtilisateur = Console.ReadLine();
            try
            {
                nombreEntier = int.Parse(saisieUtilisateur);
                conversionReussi = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("ERREUR🛑: veuillez saisir un nombre entier correct.");
                continue;
            }
        }
        return nombreEntier;
    }
}
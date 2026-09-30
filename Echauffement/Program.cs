using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("je m'appelle thomas, mon jeu pref est persona 5 royal");
        // Etape 2 : demandez à l'utilisateur son prénom et son âge
        Console.WriteLine("what's your name");
        string name = Console.ReadLine();
        Console.WriteLine("what is your age?");
        int age = int.Parse(Console.ReadLine());
        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateu

        if (age < 18)
            Console.WriteLine("you are a minor");
        else
            Console.WriteLine("you are not a minor");
        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)
        Console.WriteLine("how much money do you have?");
        float argents = float.Parse(Console.ReadLine());
        Console.WriteLine($"you have {argents} euros");
        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
        if (age > 18)
        {
            Console.WriteLine("choose your weapon( write the number of the weapon you want)");
            float priceOfGun = 50;
            Console.WriteLine($"1gun = {priceOfGun}");
            float priceOfSword = 25;
            Console.WriteLine($"2sword = {priceOfSword}");
            float priceOfKnife = 10;
            string sword;
            Console.WriteLine($"3.knife = {priceOfKnife}");
            float priceOfBow = 15;
            string bow;
            Console.WriteLine($"4.bow = {priceOfBow}");
            string response = Console.ReadLine();
            if (response == "1" && argents > 0 && age > 18)
            {

                Console.WriteLine("you bought a gun");
                Console.WriteLine($"you have {argents - priceOfGun}");
            }
            else if (response == "2")
            {
                Console.WriteLine("you bought a sword");
                Console.WriteLine($"you have {argents - priceOfSword}");
            }
            else if (response == "3")
            {
                Console.WriteLine("you bought a gun");
                Console.WriteLine($"you have {argents - priceOfKnife}");
            }
            else if (response == "4")
            {
                Console.WriteLine("you bought a gun");
                Console.WriteLine($"you have {argents - priceOfBow}");
            }
            else
            {
                Console.WriteLine("you don't have enought money");
            }
        }
        else
            Console.WriteLine("you are a minor, you can't buy a weapon");
        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4

        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4

        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}
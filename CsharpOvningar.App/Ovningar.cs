using Challenge.App;
using CsharpOvningar.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOvningar.App
{
    public static class Ovningar
    {
        // addera
        public static int SimpleExampleWithAddingTwoNumbers(int n1, int n2)
        {
            return 0;
        }

        /**
         * returnera en ny ienumerable utifrån numbers med tal större än number      
         **/
        public static IEnumerable<int> Challenge1(IEnumerable<int> numbers, int number)
        {
            // ändra denna
            return Enumerable.Empty<int>();
        }


        /**
         * Returnera en ny sträng utifrån input 
        * rensat på engelska vokaler, dvs enbart konsonanter. "Hallo" blir t ex "hll"
        * */
        public static string Challenge2(string input)
        {

            return string.Empty;
        }


        /**
         * Kolla så att listan är sorterad i stigande ordning ([1, 2, 4, 66, 100, ...n]) 
         * och returnera bool
         **/
        public static bool Challenge3(List<int> numbers)
        {
            return true;
        }


        /**
         * Maskera betalkortsnumret så att "4556364607935616" --> "############5616" 
         * Dvs de maskera allt utom de fyra sista siffrorna
         * */
        public static string Challenge4(string creditCard)
        {
            return string.Empty;
        }


        /**
         *  I en lista med personer av typen Person
         *  hitta och returnera personen som har id som matchar input id.
         *  i varje person i listan finns en lista med personer. listan är alltså nästlad i flera nivåer. 
         *  Tips för lösning: använd rekursion.
        * */
        public static Person ExtraChallenge1(List<Person> persons, Guid id)
        {
            return new Person();
        }


        /**
         *  Låtsas att du handlar med silver. Inputen api har två metoder: GetNumberOfTradingDays() och GetPriceOfDay(int day)
         *  
         *  Den första dagen utgår från 1. 
         *  Returnera en tuple (int, int) 
         *  med det dagarna (köp, sälj) som ger den högsta vinsten, alltså den största mellanskillnaden mellan köp och sälj. 
         *  t ex, dagarna [35, 2, 5, 9, 4] ska returnera (1, 4), dvs talen 2 och 9 ger den största vinsten.
         *  [50, 100, 1, 50] ska returnera (1, 2), alltså 50 och 100
         *  sälj måste såklart alltid ligga efter köp
        **/
        public static (int, int) ExtraChallenge2(API api)
        {
            return (-1, -1);
        }
    }
}

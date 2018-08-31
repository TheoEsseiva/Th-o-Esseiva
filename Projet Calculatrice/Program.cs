using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Projet_Calculatrice
{
    class Program
    {
        #region private attributes
        private static char[] operateur = new char[] { ' ', '+', '-', '*', '/' };
        private static int swicthop = 1;
        private static float operateur1 = 0;
        private static float operateur2 = 0;
        private static float resultat = 0;
        #endregion private attributes

        static void Main(string[] args)
        {
            Console.Write("Donnez un premier chiffre : ");
            operateur1 = Console.Read();
            Console.Write("Donnez un deuxieme chiffre : ");
            operateur2 = Console.Read();
            for (swicthop = 1; swicthop < 5 ; swicthop++) {
                Console.Write("Le résultat du calcul " + operateur1 + operateur[swicthop] + operateur2 + " = ");
                resultat = Operation(operateur1, operateur2);
                Console.Write(resultat + "\n");
                 }

            Console.ReadLine();

        }

       private static float Operation (float op1, float op2)
        {
            switch (swicthop)

            { 
                case 1 :
                   
                return op1 + op2;
                case 2 :
             
                    return op1 - op2;
                case 3 :
                  
                    return op1 * op2 ;
                case 4:
                    return op1 / op2;
                default :
                    return -1;   

            }
            
        }

       



    }
}

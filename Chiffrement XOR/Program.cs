using System;

namespace Chiffrement_XOR
{
    class alphabet
    {
        public string rendu; 
        public string lettre;
        public string clef = "01001";
        public string[] Alpha = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", ".", "!", "?", "," ," ", "test" };
        public string[] binaire = { "00001", "00010", "00011", "00100", "00101", "00110", "00111", "01000", "01001", "01010", "01011", "01100", "01101", "01110", "01111", "10000", "10001", "10011","10100","10101","10110","10111","11000","11001","11010","11011","11100","11101","11110","11111" , " ", "test" };
        

        public string chiffrement(string mot)
        {
            for (int i = 0; i <= 30; i++) // reconnaissance de la lettre
            {
                if( mot == Alpha[i] )
                {
                    lettre =  binaire[i];
                    
                }
            };
           Console.WriteLine(lettre);
            for(int i=0; i <= 4;i++) // chiffrement XOR
               {
               if(lettre.Substring(i,1) == clef.Substring(i,1))
               {
                   if(lettre.Substring(i, 1) == "1")
                    {
                        rendu = rendu + "0";
                    }
                    else
                    {
                        rendu = rendu + "0";
                    }
                }
                else if (lettre.Substring(i, 1) == "1" || clef.Substring(i, 1) == "1")
                {
                    rendu = rendu + "1";
                }
                else
                {
                    rendu = rendu + lettre.Substring(i, 1);
                }


                }
            ;
            Console.WriteLine(rendu);
            return rendu;
        }

        public string restitution(string mot)
        {
          
            for (int i = 0; i <= 30; i++) // attribution du resultat du chiffrement a une lettre
            {
                if (mot == binaire[i])
                {
                    rendu = Alpha[i];
                }
            };
            return rendu;
        }
    }




    class Program
    {
        
        static void Main(string[] args)
        {
            alphabet tra = new alphabet();
            Console.WriteLine("Bienvenue Entrez une lettre pour le chiifre en XOR");
            string test = Console.ReadLine();
            Console.WriteLine(tra.restitution(tra.chiffrement(test)));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Bet
    {
        [Key]
        public int BetId { get; set; }
        public int Amount { get; set; }
        public UserRound UserRound { get; set; }
        public int UserRoundId { get; set; }

        //Dani
        /*
         * enum SpecialBet { Color, Parity, FirstHalf, SecondHalf, FourColums, Line, };

         SpecialBet fogad; 
         List<Mezo> fogadottmezok; 

        public void BetType()
        {
            fogadottmezok = new List<Mezo>();

            if (fogad.Equals(SpecialBet.Color))
            {
                String color = Console.ReadLine();
                if (color == "Red")
                {
                    fogadottmezok[0].Color = "Red";
                }
                else if (color == "Black")
                {
                    fogadottmezok[0].Color = "Black";
                }
                else
                {
                    fogadottmezok[0].Color = null;
                }

            }

            if (fogad.Equals(SpecialBet.Parity))
            {
                String parity = Console.ReadLine();
                if (parity == "Odd")
                {
                    fogadottmezok[0].parity = "Odd";
                }
                else if (parity == "Even")
                {
                    fogadottmezok[0].parity = "Even";
                }
                else
                {
                    fogadottmezok[0].parity = null;
                }


                if (fogad.Equals(SpecialBet.Line))
                {
                    int linenum = Convert.ToInt32(Console.ReadLine());
                    if (linenum == 1)
                    {
                        fogadottmezok[0].Linenumber = 1;
                    }
                    else if (linenum == 2)
                    {
                        fogadottmezok[0].Linenumber = 2;
                    }
                    else if (linenum == 3)
                    {
                        fogadottmezok[0].Linenumber = 3;
                    }
                    else
                    {
                        fogadottmezok[0].Linenumber = -1;
                    }
                }


                if (fogad.Equals(SpecialBet.FourColums))
                {
                    int columnnumber = Convert.ToInt32(Console.ReadLine());
                    if (columnnumber == 1)
                    {
                        fogadottmezok[0].Column = 1;
                    }
                    if (columnnumber == 2)
                    {
                        fogadottmezok[0].Column = 2;
                    }
                    if (columnnumber == 3)
                    {
                        fogadottmezok[0].Column = 3;
                    }
                    else
                    {
                        fogadottmezok[0].parity = null;
                    }

                }
         */

    }
}

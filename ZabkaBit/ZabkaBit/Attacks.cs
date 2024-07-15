using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabkaBit
{
    internal class Attacks
    {
        public const ulong not_a_file = 18374403900871474942UL;
        public const ulong not_h_file = 9187201950435737471UL;
        public const ulong not_hg_file = 4557430888798830399UL;
        public const ulong not_ab_file = 18229723555195321596UL;

        // pawn attacks table [side][square]
        public ulong[,] pawnAttacks = new ulong[2, 64];
        // generate pawn attacks
        public ulong maskPawnAttacks(int side, int square)
        {

            //result attacks bitboard
            ulong attacks = 0UL;


            // piece bitboard
            ulong bitboard = 0UL;

            // set piece on board
            BitBoard bitBoard = new BitBoard();
            bitBoard.SetBit(ref bitboard, square);

            Console.WriteLine();
            //white Pawns
            if (side == 0)
            {
                if ((bitboard >> 7 & not_a_file) != 0) 
                { 
                    attacks |= (bitboard >> 7);
                }
                if((bitboard >> 9 & not_h_file) != 0) 
                {
                    attacks |= (bitboard >> 9);
                }
            }

            //black Pawns
            else
            {
                if ((bitboard << 7 & not_h_file) != 0)
                {
                    attacks |= (bitboard << 7);
                }
                if ((bitboard << 9 & not_a_file) != 0)
                {
                    attacks |= (bitboard << 9);
                }
            }

            // return attack map 
            return attacks;
        }
        // init leaper pieces attacks 
        public void InitLeaperAttacks() 
        {
            for (int square = 0; square < 64; square++) 
            {
                // init pawn attacks
                pawnAttacks[(int)BitBoard.Color.white,square] = maskPawnAttacks((int)BitBoard.Color.white, square);
                pawnAttacks[(int)BitBoard.Color.black,square] = maskPawnAttacks((int)BitBoard.Color.black, square);
            }
        }
    }

}

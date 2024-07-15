using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabkaBit
{
    internal class BitBoard
    {

        //enum board squares

        public enum BoardSquares{
            a8, b8, c8, d8, e8, f8, g8, h8,
            a7, b7, c7, d7, e7, f7, g7, h7,
            a6, b6, c6, d6, e6, f6, g6, h6,
            a5, b5, c5, d5, e5, f5, g5, h5,
            a4, b4, c4, d4, e4, f4, g4, h4,
            a3, b3, c3, d3, e3, f3, g3, h3,
            a2, b2, c2, d2, e2, f2, g2, h2,
            a1, b1, c1, d1, e1, f1, g1, h1
        }
        // set,get,pop macros
        public void SetBit(ref ulong bitboard, BoardSquares square)
        {
            bitboard |= 1UL << (int)square;
        }
        private bool GetBit(ulong bitboard, int square)
        {
            
            return (bitboard & (1UL << square)) != 0;
        }
        public void PopBit(ref ulong bitboard, BoardSquares square)
        {
            if (GetBit(bitboard, (int)square))
            {
                bitboard ^= 1UL << (int)square;
            }
        }
        public void printBitboard(ulong bitboard)
        {
            Console.WriteLine();
            // loop over board ranks
            for (int rank = 0; rank < 8; rank++)
            {
                // loop over board files
                for (int file = 0; file < 8; file++)
                {
                    // convert file and rank into square index
                    int square = rank * 8 + file;

                    // print ranks 
                    if (file == 0)
                    {
                        Console.Write(" " + (8 - rank) + "  ");
                    }


                    //print board state (either 1 or 0)
                    Console.Write(GetBit(bitboard, square) ? 1 : 0);
                    Console.Write(" ");
                }
                // print new line every rank
                Console.WriteLine();
            }
            //print board files
            Console.WriteLine("\n    a b c d e f g h ");

            //print unsinged decimal value
            Console.WriteLine("    BitBoard: " + bitboard);

            //for (int rank = 8; rank >= 1; rank--) 
            //{
            //    Console.WriteLine($"a{rank},b{rank},c{rank},d{rank},e{rank},f{rank},g{rank},h{rank}");
            //}

        }
    }
}

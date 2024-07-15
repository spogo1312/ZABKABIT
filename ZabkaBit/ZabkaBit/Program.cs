using ZabkaBit;


BitBoard bitBoard = new BitBoard();
Attacks attacks = new Attacks();
bitBoard.printBitboard(attacks.maskPawnAttacks((int)BitBoard.Color.black, (int)BitBoard.BoardSquares.h4));
//define bitboard
//ulong bitboard = 0UL;

////Set some bits
//bitBoard.SetBit(ref bitboard, (int)BitBoard.BoardSquares.e4);
//bitBoard.SetBit(ref bitboard, (int)BitBoard.BoardSquares.c3);
//bitBoard.SetBit(ref bitboard, (int)BitBoard.BoardSquares.f2);

//bitBoard.printBitboard(bitboard);

////reset bit
//bitBoard.PopBit(ref bitboard, BitBoard.BoardSquares.e4);


//bitBoard.printBitboard(bitboard);
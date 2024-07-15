using ZabkaBit;


BitBoard bitBoard = new BitBoard();
//define bitboard
ulong bitboard = 0UL;

//Set some bits
bitBoard.SetBit(ref bitboard, BitBoard.BoardSquares.e4);
bitBoard.SetBit(ref bitboard, BitBoard.BoardSquares.c3);
bitBoard.SetBit(ref bitboard, BitBoard.BoardSquares.f2);

bitBoard.printBitboard(bitboard);

//reset bit
bitBoard.PopBit(ref bitboard, BitBoard.BoardSquares.e4);


bitBoard.printBitboard(bitboard);
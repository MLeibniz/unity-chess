using UnityEngine;

public class Rook : Piece
{
    public override void SetLegalSize()
    {
        moves = new LegalMove[16];
    } 
    public override void GetLegalMoves()
    {
        for(int i = 0; i < 8; i++) // horizontal moves
        {
            if(i == file)
            {
                moves[i] = new LegalMove(-1,-1);
            }
            else
            {
                moves[i] = new LegalMove(i, rank);
            }
        }

        for(int i = 8; i < 16; i++) // vertical moves
        {
            if(i - 8 == rank)
            {
                moves[i] = new LegalMove(-1,-1);
            }
            else
            {
                moves[i] = new LegalMove(file, i -8);
            }
        }

        RemoveOffBoardMoves();
    }
}

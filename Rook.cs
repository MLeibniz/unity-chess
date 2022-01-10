using UnityEngine;

public class Rook : Piece
{
    public override void SetLegalSize()
    {
        moves = new Move[16];
    } 
    public override void GetMoves()
    {
        for(int i = 0; i < 8; i++) // horizontal moves
        {
            if(i == file)
            {
                moves[i] = new Move(-1,-1);
            }
            else
            {
                moves[i] = new Move(i, rank);
            }
        }

        for(int i = 8; i < 16; i++) // vertical moves
        {
            if(i - 8 == rank)
            {
                moves[i] = new Move(-1,-1);
            }
            else
            {
                moves[i] = new Move(file, i -8);
            }
        }
    }
}

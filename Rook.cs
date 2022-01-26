using UnityEngine;

public class Rook : Piece
{
    public override void SetMaxMoves()
    {
        moves = new Square[16];
    } 
    public override void GetMoves()
    {
        for(int i = 0; i < 8; i++) // horizontal moves
        {
            try
            {
                if(i == file)
                {
                    moves[i] = board.squares[-1,-1].GetComponent<Square>();
                }
                else
                {
                    moves[i] = board.squares[i, rank];
                }
            }
            catch
            {
                moves[i] = null;
            }

        }

        for(int i = 8; i < 16; i++) // vertical moves
        {
            try
            {
                if(i - 8 == rank)
                {
                    moves[i] = board.squares[-1,-1];
                }
                else
                {
                    moves[i] = board.squares[file, i -8];
                }
            }
            catch
            {
                moves[i] = null;
            }
        }
    }
}

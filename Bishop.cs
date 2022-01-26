using UnityEngine;

public class Bishop : Piece
{
    public override void SetMaxMoves()
    {
        moves = new Square[14];
    }
    int moveIndex; 
    bool blocked;
    public override void GetMoves()
    {
        /*
        moveIndex = 0;
     
        Diagonal(1, 1); //Up - Right -> limit rank 7, file 7
        Diagonal(-1, 1); //Down - Right -> limit rank 0, file 7
        Diagonal(-1, -1); //Down - Left -> limit rank 0, file 0
        Diagonal(1, -1); //Up - Left -> limit rank 7, file 0

        Invalidate();
        */
    }

    void Diagonal(int upFactor, int rightFactor)
    {
        for(int i = 1; i < 8; i++)
        {
            moves[moveIndex] = board.squares[file + (i*rightFactor), rank + (i*upFactor)];
            // moves[moveIndex] = new Move( file + (i*rightFactor), rank + (i*upFactor));
        }
    }

    void Invalidate()
    {
        for(int i = moveIndex; i < 16; i++)
        {
            moves[i] = null;
        }
    }
}

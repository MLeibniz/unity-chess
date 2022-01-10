using UnityEngine;

public class Bishop : Piece
{
    public override void SetMaxMoves()
    {
        moves = new Move[14];
    }
    int moveIndex; 
    bool blocked;
    public override void GetMoves()
    {
        moveIndex = 0;
     
        Diagonal(true, true); //Up - Right -> limit rank 7, file 7
        Diagonal(false, true); //Down - Right -> limit rank 0, file 7
        Diagonal(false, false); //Down - Left -> limit rank 0, file 0
        Diagonal(true, false); //Up - Left -> limit rank 7, file 0

        Invalidate();
    }

    void Diagonal(bool up, bool right)
    {
        int count = 0;
        int higher = rank > file ? rank : file;
        int lower = rank > file ? file : rank;

    }

    void Invalidate()
    {
        for(int i = moveIndex; i < 16; i++)
        {
            moves[i] = new Move(-1,-1);
        }
    }
}

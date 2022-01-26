using UnityEngine;

public class King : Piece
{
    public override void SetMaxMoves()
    {
        moves = new Square[9];
    } 
        
    public override void GetMoves()
    {
        moves[4] = null;
        int count = 0;
        for (int r = -1; r < 2; r++)
        {
            for (int f = -1; f < 2; f++)
            {
                if(count == 4){count++ ; continue;}
                AddMove(count,file + f, rank + r);
                count++;
            }       
        }
    }
}
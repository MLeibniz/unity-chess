using UnityEngine;

public class King : Piece
{
    public override void SetLegalSize()
    {
        moves = new Move[9];
    } 
        
    public override void GetMoves()
    {
        moves[4] = new Move(-1,-1);
        int count = 0;
        for (int m = -1; m < 3; m++)
        {
            for (int f = -1; f < 3; f++)
            {
                if(count == 4){continue;}
                moves[count] = new Move(m, f);
            }       
        }
    }
}
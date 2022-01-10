using UnityEngine;

public class Knight : Piece
{
    public override void SetLegalSize()
    {
        moves = new Move[8];
    } 
        
    public override void GetMoves()
    {
        int colorFactor = bottomPlayer? 1 : -1;

        moves[0] = new Move (file + 1, rank + 2);
        moves[1] = new Move (file + 1, rank - 2);
        moves[2] = new Move (file + 2, rank - 1);
        moves[3] = new Move (file + 2, rank + 1);
        moves[4] = new Move (file - 1, rank + 2);
        moves[5] = new Move (file - 1, rank - 2);
        moves[6] = new Move (file - 2, rank - 1);
        moves[7] = new Move (file - 2, rank + 1);
    }

    void CheckOccupiedMoves()
    {
        foreach(Move m in moves)
        {
            
        }
    }
}

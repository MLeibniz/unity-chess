using UnityEngine;

public class Knight : Piece
{
    public override void SetLegalSize()
    {
        moves = new LegalMove[8];
    } 
        
    public override void GetLegalMoves()
    {
        int colorFactor = bottomPlayer? 1 : -1;

        moves[0] = new LegalMove (file + 1, rank + 2);
        moves[1] = new LegalMove (file + 1, rank - 2);
        moves[2] = new LegalMove (file + 2, rank - 1);
        moves[3] = new LegalMove (file + 2, rank + 1);
        moves[4] = new LegalMove (file - 1, rank + 2);
        moves[5] = new LegalMove (file - 1, rank - 2);
        moves[6] = new LegalMove (file - 2, rank - 1);
        moves[7] = new LegalMove (file - 2, rank + 1);

        RemoveOffBoardMoves();
    }
}

using UnityEngine;

public class CheckersPiece : Piece
{
    public override void GetLegalMoves()
    {
        int colorFactor = bottomPlayer? 1 : -1;

        moves[0] = new LegalMove (file + 1, rank + 1 * colorFactor);
        moves[1] = new LegalMove (file + 2, rank + 2 * colorFactor);
        moves[2] = new LegalMove (file - 1, rank + 1 * colorFactor);
        moves[3] = new LegalMove (file - 2, rank + 2 * colorFactor);

        RemoveOffBoardMoves();
    }
    public override void SetLegalSize()
    {
        moves = new LegalMove[4];
    }
}

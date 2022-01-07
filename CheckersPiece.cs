using UnityEngine;

public class CheckersPiece : Piece
{
    public override void GetMoves()
    {
        int colorFactor = bottomPlayer? 1 : -1;

        moves[0] = new Move (file + 1, rank + 1 * colorFactor);
        moves[1] = new Move (file + 2, rank + 2 * colorFactor);
        moves[2] = new Move (file - 1, rank + 1 * colorFactor);
        moves[3] = new Move (file - 2, rank + 2 * colorFactor);

        RemoveOffBoardMoves();
    }
    public override void SetLegalSize()
    {
        moves = new Move[4];
    }
}

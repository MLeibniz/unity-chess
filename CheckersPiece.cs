using UnityEngine;

public class CheckersPiece : Piece
{
    public override void GetMoves()
    {
        int colorFactor = bottomPlayer? 1 : -1;

        AddMove(0, file + 1, rank + 1 * colorFactor);
        AddMove(1, file + 2, rank + 2 * colorFactor);
        AddMove(2, file - 1, rank + 1 * colorFactor);
        AddMove(3, file - 2, rank + 2 * colorFactor);
    }
    public override void SetMaxMoves()
    {
        moves = new Square[4];
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckersPiece : Piece
{
    public override void GetLegalMoves()
    {
        int colorFactor = bottomPlayer? 1 : -1;

        legal[0] = new Vector2 (file + 1, rank + 1 * colorFactor);
        legal[1] = new Vector2 (file + 2, rank + 2 * colorFactor);
        legal[2] = new Vector2 (file - 1, rank + 1 * colorFactor);
        legal[3] = new Vector2 (file - 2, rank + 2 * colorFactor);

        RemoveOffBoardMoves();
    }
    public override void SetLegalSize()
    {
        legal = new Vector2[4];
    }
}

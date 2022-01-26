using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckersPiece : Piece
{
    public override Vector2[] GetLegalMoves(Vector2 curPos, bool isBlack)
    {
        int colorFactor = isBlack? 1 : -1;
        Vector2[] legal = new Vector2[4];
        legal[0] = new Vector2 (curPos.x + 1, curPos.y + 1 * colorFactor);
        legal[1] = new Vector2 (curPos.x + 2, curPos.y + 2 * colorFactor);
        legal[2] = new Vector2 (curPos.x - 1, curPos.y + 1 * colorFactor);
        legal[3] = new Vector2 (curPos.x - 2, curPos.y + 2 * colorFactor);

        for (int i = 0; i < 4; i++)
        {
            int x = (int) legal[i].x;
            int y = (int) legal[i].y;
            if(x < 0 || x > 7 || y < 0 || y > 7)
            {
                legal[i] = new Vector2(-1,-1);
            }
        }
        return legal;
    }

    // Start is called before the first frame update
}

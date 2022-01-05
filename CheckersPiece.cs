using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckersPiece : Piece
{
    public override Vector2[] GetLegalMoves(Vector2 curPos)
    {
        Vector2[] legal = new Vector2[8];
        legal[0] = new Vector2 (curPos.x + 1, curPos.y + 1);
        legal[1] = new Vector2 (curPos.x + 2, curPos.y + 2);
        legal[2] = new Vector2 (curPos.x + 1, curPos.y - 1);
        legal[3] = new Vector2 (curPos.x + 2, curPos.y - 2);
        legal[4] = new Vector2 (curPos.x - 1, curPos.y - 1);
        legal[5] = new Vector2 (curPos.x - 2, curPos.y - 2);
        legal[6] = new Vector2 (curPos.x - 1, curPos.y + 1);
        legal[7] = new Vector2 (curPos.x - 2, curPos.y + 2);

        for (int i = 0; i < 8; i++)
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

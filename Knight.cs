using UnityEngine;

public class Knight : Piece
{
    public override void SetLegalSize()
    {
        legal = new Vector2[8];
    } 
        
    public override void GetLegalMoves()
    {
        int colorFactor = bottomPlayer? 1 : -1;

        legal[0] = new Vector2 (file + 1, rank + 2);
        legal[1] = new Vector2 (file + 1, rank - 2);
        legal[2] = new Vector2 (file + 2, rank - 1);
        legal[3] = new Vector2 (file + 2, rank + 1);
        legal[4] = new Vector2 (file - 1, rank + 2);
        legal[5] = new Vector2 (file - 1, rank - 2);
        legal[6] = new Vector2 (file - 2, rank - 1);
        legal[7] = new Vector2 (file - 2, rank + 1);

        RemoveOffBoardMoves();
    }
}

using UnityEngine;

public class Rook : Piece
{
    public override void SetLegalSize()
    {
        legal = new Vector2[16];
    } 
    public override void GetLegalMoves()
    {
        Debug.Log("Torre está na coluna " + file + " e na linha " + rank);
        Debug.Log("Position in X,Y = " + transform.position.x + ", " + transform.position.y);

        for(int i = 0; i < 8; i++) // horizontal moves
        {
            if(i == file)
            {
                legal[i] = new Vector2(-1,-1);
            }
            else
            {
                legal[i] = new Vector2(i, rank);
            }
        }

        for(int i = 8; i < 16; i++) // vertical moves
        {
            if(i - 8 == rank)
            {
                legal[i] = new Vector2(-1,-1);
            }
            else
            {
                legal[i] = new Vector2(file, i -8);
            }
        }

        RemoveOffBoardMoves();
    }
}

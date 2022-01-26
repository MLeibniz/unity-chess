using UnityEngine;

public class Pawn : Piece
{
    public override void SetMaxMoves()
    {
        moves = new Square[4];
    } 
        
    public override void GetMoves()
    {
        int colorFactor = bottomPlayer? 1 : -1;

        AddMove(0, file, rank + 1 * colorFactor); // pra frente
        AddMove(1, file + 1, rank + 1 * colorFactor); // captura direita / En Passant
        AddMove(2, file -1, rank + 1 * colorFactor); // captura esquerda / En Passant

        if ((rank == 1 && bottomPlayer)|| (rank == 6 && !bottomPlayer))
        {
            AddMove(3, file, rank + 2 * colorFactor);
        }
        else
        {
            moves[3] = null;
        }
    }
}

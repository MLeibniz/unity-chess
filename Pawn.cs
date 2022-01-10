using UnityEngine;

public class Pawn : Piece
{
    public override void SetMaxMoves()
    {
        moves = new Move[4];
    } 
        
    public override void GetMoves()
    {
        int colorFactor = bottomPlayer? 1 : -1;

        moves[0] = new Move (file, rank + 1 * colorFactor); // pra frente
        moves[1] = new Move (file + 1, rank + 1 * colorFactor); // captura direita / En Passant
        moves[2] = new Move (file -1, rank + 1 * colorFactor); // captura esquerda / En Passant
        moves[3] = ((rank == 1 && bottomPlayer)|| (rank == 6 && !bottomPlayer)) ? new Move (file, rank + 2 * colorFactor) : moves[3] = new Move(-1,-1); //Avanço Duplo
    }
}

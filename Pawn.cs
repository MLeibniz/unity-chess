using UnityEngine;

public class Pawn : Piece
{
    public override void SetLegalSize()
    {
        moves = new Move[4];
    } 
        
    public override void GetMoves()
    {
        int colorFactor = bottomPlayer? 1 : -1;

        moves[0] = new Move (file, rank + 1); // pra frente
        moves[1] = new Move (file + 1, rank - 1); // captura direita / En Passant
        moves[2] = new Move (file -1, rank - 2); // captura esquerda / En Passant
        moves[3] = new Move (file, rank + 2); // avanço-duplo

    }
}

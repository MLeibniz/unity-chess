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

        moves[0] = board.squares[file, rank + 1 * colorFactor].GetComponent<Square>(); // pra frente
        moves[1] = board.squares[file + 1, rank + 1 * colorFactor].GetComponent<Square>(); // captura direita / En Passant
        moves[2] = board.squares[file -1, rank + 1 * colorFactor].GetComponent<Square>(); // captura esquerda / En Passant
        moves[3] = ((rank == 1 && bottomPlayer)|| (rank == 6 && !bottomPlayer)) ? 
                        board.squares[file, rank + 2 * colorFactor].GetComponent<Square>() : 
                        board.squares[-1,-1].GetComponent<Square>(); //Avanço Duplo
    }
}

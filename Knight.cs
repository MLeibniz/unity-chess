using UnityEngine;

public class Knight : Piece
{
    public override void SetMaxMoves()
    {
        moves = new Square[8];
    } 
        
    public override void GetMoves()
    {
        int colorFactor = bottomPlayer? 1 : -1;

        moves[0] = board.squares[file + 1, rank + 2].GetComponent<Square>();
        moves[1] = board.squares[file + 1, rank - 2].GetComponent<Square>();
        moves[2] = board.squares[file + 2, rank - 1].GetComponent<Square>();
        moves[3] = board.squares[file + 2, rank + 1].GetComponent<Square>();
        moves[4] = board.squares[file - 1, rank + 2].GetComponent<Square>();
        moves[5] = board.squares[file - 1, rank - 2].GetComponent<Square>();
        moves[6] = board.squares[file - 2, rank - 1].GetComponent<Square>();
        moves[7] = board.squares[file - 2, rank + 1].GetComponent<Square>();
    }
}

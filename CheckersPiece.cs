using UnityEngine;

public class CheckersPiece : Piece
{
    public override void GetMoves()
    {
        int colorFactor = bottomPlayer? 1 : -1;

        moves[0] = board.squares[file + 1, rank + 1 * colorFactor].GetComponent<Square>();
        moves[1] = board.squares[file + 2, rank + 2 * colorFactor].GetComponent<Square>();
        moves[2] = board.squares[file - 1, rank + 1 * colorFactor].GetComponent<Square>();
        moves[3] = board.squares[file - 2, rank + 2 * colorFactor].GetComponent<Square>();

        RemoveOffBoardMoves();
    }
    public override void SetMaxMoves()
    {
        moves = new Square[4];
    }
}

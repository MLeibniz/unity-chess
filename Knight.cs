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

        AddMove(0, file + 1, rank + 2);
        AddMove(1, file + 1, rank - 2);
        AddMove(2, file + 2, rank - 1);
        AddMove(3, file + 2, rank + 1);
        AddMove(4, file - 1, rank + 2);
        AddMove(5, file - 1, rank - 2);
        AddMove(6, file - 2, rank - 1);
        AddMove(7, file - 2, rank + 1);
    }

    void AddMove(int index, int x, int y)
    {
        try
        {
            moves[index] = board.squares[x,y];
        }
        catch
        {
            moves[index] = null;
        }
    }
}

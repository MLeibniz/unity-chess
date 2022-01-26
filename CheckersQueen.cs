using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckersQueen : Piece
{
    public override void GetMoves()
    {
        /*
        int colorFactor = bottomPlayer? 1 : -1;
        Square[] legal = new Square[4];
        legal[0] = board.squares[file + 1, rank + 1 * colorFactor];
        legal[1] = board.squares[file + 2, rank + 2 * colorFactor];
        legal[2] = board.squares[file - 1, rank + 1 * colorFactor];
        legal[3] = board.squares[file - 2, rank + 2 * colorFactor];
        */
    }

    public override void SetMaxMoves()
    {
        // set array for moves
    }
}

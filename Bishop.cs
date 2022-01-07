using UnityEngine;

public class Bishop : Piece
{
    public override void SetLegalSize()
    {
        moves = new Move[16];
    } 
    public override void GetMoves()
    {

    }
}
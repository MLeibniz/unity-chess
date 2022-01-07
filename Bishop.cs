using UnityEngine;

public class Bishop : Piece
{
    public override void SetLegalSize()
    {
        moves = new LegalMove[16];
    } 
    public override void GetLegalMoves()
    {

        RemoveOffBoardMoves();
    }
}
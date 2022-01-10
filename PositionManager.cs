using UnityEngine;

public class PositionManager : MonoBehaviour
{
    [SerializeField] Board board;
    [SerializeField] GameObject[] pieces;
    [SerializeField] string chessPos;
    
    /* 
        0: K = King
        1: Q = Queen
        2: R = Rook
        3: B = bishop
        4: N = Knight
        5: P = Pawn        
       
        lower = black
        UPPER = white;
        digit = space;
    */

    private void Start() {
        LoadPosition(chessPos);
    }
    public void LoadPosition(string pos)
    {
        int count = 0;
        char[] squares = pos.ToCharArray();

        for (int rank = 0; rank < 8; rank++)
        {
            for(int file = 0; file < 8; file++)
            {
                char c = squares[count];
                GameObject piece = CharToPiece(c);
                Vector3 piecePos = new Vector3(file, rank, -2);

                if(char.IsDigit(squares[count])) //is space?
                {
                    file += c;
                }
                else if(char.IsLower(c) && piece) // is black?
                {
                    InstantiatePiece(piece, piecePos, false);
                }
                else if(piece)
                {
                    InstantiatePiece(piece,piecePos, true);
                }
                count++;
            }
        }
    }

    void InstantiatePiece(GameObject piece, Vector3 piecePos, bool bottomPlayer)
    {
        GameObject g = Instantiate(piece, piecePos, Quaternion.identity);
        g.GetComponent<Piece>().SetPlayer(bottomPlayer);
    }

    GameObject CharToPiece(char c)
    {
        switch(char.ToLower(c))
        {
            case 'k':
                return pieces[0];
            case 'q':
                return pieces[1];
            case 'r':
                return pieces[2];
            case 'b':
                return pieces[3];
            case 'n':
                return pieces[4];
            case 'p':
                return pieces[5];
            default: 
                Debug.Log("Char: " + c + "was identified as null");
                return null;
        }
    }
}
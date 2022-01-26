using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] GameObject square;
    public Square[,] squares;
    Transform board;
    void Start()
    {
        Cache();
        SetUp();
    }
    void Cache()
    {   
        board = this.GetComponent<Transform>();     
        squares = new Square[8,8];
    }
    void SetUp()
    {
        for(int rank = 0; rank < 8; rank++)
        {
            for (int file = 7; file >= 0; file--)
            {
                Vector3 pos = new Vector3(rank,file, 0);
                squares[rank,file] = Instantiate(square,pos,Quaternion.identity,board).GetComponent<Square>();
            }
        }
    }
    public void DisplaySymbolOnSquares(Square[] move)
    {
        for(int i = 0; i < move.Length; i++)
        {
            int x  = (int) move[i].x;
            int y = (int) move[i].y;
        }
    }
}

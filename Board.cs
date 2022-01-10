using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] GameObject square;
    public GameObject[,] squares;
    Transform board;
    void Start()
    {
        Cache();
        SetUp();
    }
    void Cache()
    {   
        board = this.GetComponent<Transform>();     
        squares = new GameObject[8,8];
    }
    void SetUp()
    {
        for(int rank = 0; rank < 8; rank++)
        {
            for (int file = 7; file >= 0; file--)
            {
                Vector3 pos = new Vector3(rank,file, 0);
                squares[rank,file] = Instantiate(square,pos,Quaternion.identity,board);
            }
        }
    }
    public void DisplaySymbolOnSquares(Move[] squares)
    {
        for(int i = 0; i < squares.Length; i++)
        {
            int x  = (int) squares[i].x;
            int y = (int) squares[i].y;
            if(!squares[i].offBoard)
            {
                this.squares[x, y].GetComponent<Square>().DisplayLegalSymbol();
            }
        }
    }
}

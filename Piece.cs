using UnityEngine;

public abstract class Piece : MonoBehaviour
{
    Camera cam;
    Board board;
    [SerializeField] protected bool bottomPlayer;
    [SerializeField] Sprite bottomPlayerSprite, topPlayerSprite;
    SpriteRenderer sr;
    protected Move[] moves;
    protected int rank, file; // current position

    void Start()
    {
        Cache();
        SetRankAndFile();
        SetLegalSize();
        GetMoves();
        SetSprite();
    }

    public void SetPlayer(bool b)
    {
        bottomPlayer = b;
    }

    void SetSprite()
    {
        sr.sprite = bottomPlayer? bottomPlayerSprite : topPlayerSprite;
    }
    void Cache()
    {
        sr = GetComponent<SpriteRenderer>();
        cam = Camera.main;
        board = FindObjectOfType<Board>();
    }

    void OnMouseDown() {
        DisplayLegalMoves();
        AdjustLayer(1);
    }

    void OnMouseDrag() {
        Vector3 newPos = cam.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPos.x, newPos.y, transform.position.z);
    }

    void OnMouseUpAsButton() {
        Vector3 newPos = cam.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3((int) (newPos.x + 0.5f), (int) (newPos.y + 0.5f), transform.position.z);

        SetRankAndFile();
        AdjustLayer(-1);
        Chess.TriggerSelector();
    }

    void AdjustLayer(int layer)
    {
        GetComponent<SpriteRenderer>().sortingOrder += layer;
    }

    void DisplayLegalMoves()
    {
        if(moves == null)
        {
            Debug.Log("Nada a mostrar");
        }
        GetMoves();
        board.DisplaySymbolOnSquares(moves);
    }

    void SetRankAndFile()
    {
        file = (int) transform.position.x;
        rank = (int) transform.position.y;
    }

    protected void RemoveOffBoardMoves()
    {
        for (int i = 0; i < moves.Length; i++)
        {
            if(moves[i].x < 0 || moves[i].x > 7 || moves[i].y < 0 || moves[i].y > 7) //marca a posição como ilegal
            {
                moves[i] = new Move(-1,-1);
            }
        }
    }

    public abstract void GetMoves();

    public abstract void SetLegalSize();
}

using UnityEngine;

public abstract class Piece : MonoBehaviour
{
    Camera cam;
    [SerializeField] protected bool bottomPlayer;
    [SerializeField] Sprite bottomPlayerSprite, topPlayerSprite;
    SpriteRenderer sr;
    protected Board board;
    protected Square[] moves;
    protected int rank, file; // current position
    

    void Start()
    {
        Cache();
        SetRankAndFile();
        SetMaxMoves();
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

    bool selected, deselecting = false;
    void OnMouseDown() {
        if(!selected)
        {
            DisplayLegalMoves();
            AdjustLayer(1);
        }
        else
        {
            deselecting = true;
        }
    }

    void OnMouseDrag() {
        Vector3 newPos = cam.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPos.x, newPos.y, transform.position.z);
    }

    [SerializeField] bool setup = true;
    void OnMouseUp() {
        Vector3 newPos = cam.ScreenToWorldPoint(Input.mousePosition);

        bool legalmove = CheckLegal(newPos);

        if( setup || legalmove) //setup bool only for debugging
        {
            
            transform.position = new Vector3((int) (newPos.x + 0.5f), (int) (newPos.y + 0.5f), transform.position.z);
            SetRankAndFile();
        }
        else
        {
            ResetPos();
        }

        AdjustLayer(-1);
        Chess.TriggerSelector();
    }

    bool CheckLegal(Vector3 pos)
    {
        foreach(Square m in moves)
        {
            if(m.x == (int)(pos.x + 0.5f) && m.y == (int)(pos.y + 0.5f)) return true;
        }

        return false;
    }

    void ResetPos()
    {
        transform.position = new Vector3(file, rank, transform.position.z);
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
                moves[i] = null;
            }
        }
    }

    public abstract void GetMoves();

    public abstract void SetMaxMoves();
}

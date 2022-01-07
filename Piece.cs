using UnityEngine;

public abstract class Piece : MonoBehaviour
{
    Camera cam;
    Board board;
    [SerializeField] protected bool bottomPlayer;

    protected LegalMove[] moves;
    protected int rank, file; // current position

    void Start()
    {
        Cache();
        SetPos();
        SetLegalSize();
        GetLegalMoves();
    }

    void Cache()
    {
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

        SetPos();
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
        GetLegalMoves();
        board.DisplaySymbolOnSquares(moves);
    }

    void SetPos()
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
                moves[i] = new LegalMove(-1,-1);
            }
        }
    }

    public abstract void GetLegalMoves();

    public abstract void SetLegalSize();
}

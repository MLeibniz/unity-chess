using UnityEngine;

public abstract class Piece : MonoBehaviour
{
    Camera cam;
    Board board;
    [SerializeField] bool isBlack;

    // Start is called before the first frame update
    void Start()
    {
        Cache();
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
        AdjustLayer(-1);
        Chess.TriggerSelector();
    }

    void AdjustLayer(int layer)
    {
        GetComponent<SpriteRenderer>().sortingOrder += layer;
    }

    void DisplayLegalMoves()
    {
        board.DisplaySymbolOnSquares(
                GetLegalMoves(
                    new Vector2(transform.position.x, transform.position.y) , isBlack));
    }

    public abstract Vector2[] GetLegalMoves(Vector2 pos, bool isBlack );
}

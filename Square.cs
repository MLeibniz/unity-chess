using UnityEngine;
using System;

public class Square : MonoBehaviour
{
    [SerializeField] GameObject legalSymbol;
    bool blackSquare;
    GameObject curSymbol;

    void Start()
    {
        Cache();
        SetUpColor();
    }
    SpriteRenderer sr;
    public int x, y;
    void Cache()
    {
        sr = GetComponent<SpriteRenderer>();
        x = (int)GetComponent<Transform>().position.x;
        y = (int)GetComponent<Transform>().position.y;
    }

    public bool offBoard;

    public Move(int x, int y)
    {
        this.x = x;
        this.y = y;
        Status();
    }
    void Status()
    {
        if(x < 0 || x > 7 || y < 0 || y > 7){
            offBoard = true;
        }
    }    


    Color mainColor, selectedColor;
    void SetUpColor()
    {
        blackSquare = (x + y) % 2 == 0 ? true : false;
        mainColor = blackSquare? ChessConfig.BlackSquareColor : ChessConfig.WhiteSquareColor;
        selectedColor = blackSquare ? ChessConfig.SelectedBlackSquareColor : ChessConfig.SelectedWhiteSquareColor;
        ChangeColor(mainColor);
    }

    public void DisplayLegalSymbol()
    {
        Debug.Log("Square at " + x + ", " + y + "will display a sign of legal move");
        curSymbol = Instantiate(legalSymbol, transform.position, Quaternion.identity, transform);
        Chess.OnSelection += Deselect;
    }

    bool selected = false, deselecting = false;    
    void OnMouseDown() 
    {
        deselecting = selected? true : false;
        Chess.TriggerSelector();
        Chess.OnSelection += Deselect;
        selected = true;
        ChangeColor(selectedColor);
    }

    void OnMouseUpAsButton() 
    {
        if(deselecting)
        {
            Chess.TriggerSelector();
            selected = false;
            Chess.OnSelection -= Deselect; 
        }
    }

    void Deselect(object sender, EventArgs e)
    {
        selected = false;
        ChangeColor(mainColor);
        if(curSymbol != null) { Debug.Log("CurSymbol not null, destroying it") ; Destroy(curSymbol);}
        else {Debug.Log("CurSymbol null");}
        Chess.OnSelection -= Deselect;
    }

    void ChangeColor(Color color)
    {
        sr.color = color;
    }
}

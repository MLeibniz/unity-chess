using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    
    [SerializeField] Board board;
    SpriteRenderer sr;
    int x;
    int y;
    bool blackSquare;

    void Start()
    {
        Cache();
        SetColor();
    }

    void Update()
    {
        
    }

    void Cache()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void SetColor()
    {
        x = (int)GetComponent<Transform>().position.x;
        y = (int)GetComponent<Transform>().position.y;
        blackSquare = x + y % 2 == 0 ? true : false;
    }

    private void OnMouseDown() 
    {
        Debug.Log(x + "," + y);
        if(blackSquare)
        {
            SetColor(ChessConfig.SelectedBlackSquareCollor);
        }
        else
        {
            SetColor(ChessConfig.SelectedWhiteSquareCollor);
        }
    }

    private void OnMouseUp() 
    {
        ResetColor();    
    }

    void SetColor(Color color)
    {
        sr.color = color;
    }

    void ResetColor()
    {
        sr.color = blackSquare? ChessConfig.BlackSquareColor : ChessConfig.WhiteSquareCollor;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    [SerializeField] Board board;
    SpriteRenderer sr;
    Color mainColor, selectedColor;
    int x;
    int y;
    bool blackSquare;

    void Start()
    {
        Cache();
        ConfigColor();
    }

    void Cache()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void ConfigColor()
    {
        x = (int)GetComponent<Transform>().position.x;
        y = (int)GetComponent<Transform>().position.y;
        blackSquare = (x + y) % 2 == 0 ? true : false;
        mainColor = blackSquare? ChessConfig.BlackSquareColor : ChessConfig.WhiteSquareColor;
        selectedColor = blackSquare ? ChessConfig.SelectedBlackSquareColor : ChessConfig.SelectedWhiteSquareColor;
        ResetColor();
    }

    private void OnMouseDown() 
    {
        ChangeColor(selectedColor);
    }

    private void OnMouseUp() 
    {
        ResetColor();    
    }

    void ChangeColor(Color color)
    {
        sr.color = color;
    }

    void ResetColor()
    {
        sr.color = mainColor;
    }
}

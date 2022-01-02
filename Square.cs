using UnityEngine;
using System;

public class Square : MonoBehaviour
{
    bool blackSquare;

    void Start()
    {
        Cache();
        SetUpColor();
    }

    SpriteRenderer sr;
    int x, y;
    void Cache()
    {
        sr = GetComponent<SpriteRenderer>();
        x = (int)GetComponent<Transform>().position.x;
        y = (int)GetComponent<Transform>().position.y;
    }

    Color mainColor, selectedColor;
    void SetUpColor()
    {
        blackSquare = (x + y) % 2 == 0 ? true : false;
        mainColor = blackSquare? ChessConfig.BlackSquareColor : ChessConfig.WhiteSquareColor;
        selectedColor = blackSquare ? ChessConfig.SelectedBlackSquareColor : ChessConfig.SelectedWhiteSquareColor;
        ChangeColor(mainColor);
    }

    bool selected = false, deselecting = false, legalmove = false;    
    void OnMouseDown() 
    {
        // condição teste
        if(!legalmove)
        {
            deselecting = selected? true : false;
            Debug.Log("Quadrado clicado com selected: " + selected);
            Chess.TriggerSelector();
            Chess.OnSelection += Deselect;
            selected = true;
            ChangeColor(selectedColor);
        }
        else
        {
            //TODO método para mover a peça,
        }
    }

    void OnMouseUpAsButton() 
    {
        if(deselecting)
        {
            Debug.Log("Square is being deselectd");
            Chess.TriggerSelector();
            selected = false;
            Chess.OnSelection -= Deselect; 
        }
    }

    void Deselect(object sender, EventArgs e)
    {
        selected = false;
        ChangeColor(mainColor);
        Chess.OnSelection -= Deselect;
    }

    void ChangeColor(Color color)
    {
        sr.color = color;
    }
}

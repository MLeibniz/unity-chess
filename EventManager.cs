using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
        [SerializeField] Color BlackSquareColor, 
        SelectedBlackSquareCollor,
        WhiteSquareCollor, 
        SelectedWhiteSquareColor;
    // Start is called before the first frame update
    void Start()
    {
        ConfigColors();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ConfigColors()
    {
        ChessConfig.BlackSquareColor = BlackSquareColor;
        ChessConfig.WhiteSquareColor = WhiteSquareCollor;
        ChessConfig.SelectedBlackSquareColor = BlackSquareColor;
        ChessConfig.SelectedWhiteSquareColor = SelectedWhiteSquareColor;
    }
}

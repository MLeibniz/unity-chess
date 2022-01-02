using UnityEngine;

public class EventManager : MonoBehaviour
{
    [SerializeField] Color BlackSquareColor, 
    SelectedBlackSquareColor,
    WhiteSquareCollor, 
    SelectedWhiteSquareColor;
    // Start is called before the first frame update
    void Start()
    {
        ConfigColors();
    }

    void ConfigColors()
    {
        ChessConfig.BlackSquareColor = BlackSquareColor;
        ChessConfig.WhiteSquareColor = WhiteSquareCollor;
        ChessConfig.SelectedBlackSquareColor = SelectedBlackSquareColor;
        ChessConfig.SelectedWhiteSquareColor = SelectedWhiteSquareColor;
    }
}

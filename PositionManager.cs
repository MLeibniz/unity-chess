using UnityEngine;

public class PositionManager
{
    [SerializeField] Board board;
    [SerializeField] string pos;
    
    private void Start() {
        LoadPosition(pos);
    }
    public void LoadPosition(string pos)
    {

    }
}
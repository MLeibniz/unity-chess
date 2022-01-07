public class Move{
    public int x;
    public int y;

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
}
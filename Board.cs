using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] GameObject square;
    public GameObject[,] squares;
    Transform board;

    void Start()
    {
        Cache();
        SetUp();
    }

    void Cache()
    {   
        board = this.GetComponent<Transform>();     
        squares = new GameObject[8,8];
    }
    void SetUp()
    {
        for(int i = 0; i < 8; i++)
        {
            for (int j = 8 - 1; j >= 0; j--)
            {
                Vector3 pos = new Vector3(i,j, 0);
                squares[i,j] = Instantiate(square,pos,Quaternion.identity,board);
            }
        }
    }
}

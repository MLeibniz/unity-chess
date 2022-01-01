using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] GameObject square;
    [SerializeField] Color color1, color2;
    GameObject[,] squares;
    Transform board;
    // Start is called before the first frame update
    void Start()
    {
        Cache();
        SetUpTable();
    }

    void Cache()
    {   
        board = this.GetComponent<Transform>();     
        squares = new GameObject[8,8];
    }
    void SetUpTable()
    {
        bool color = true;
        for(int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Vector3 pos = new Vector3(i,j, 0);
                squares[i,j] = Instantiate(square, pos, Quaternion.identity, board);
                squares[i,j].GetComponent<SpriteRenderer>().color = color? color1 : color2;
                color = !color;
            }
            color = !color;
        }
    }
}

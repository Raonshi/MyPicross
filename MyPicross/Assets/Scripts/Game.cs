using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject[,] grid;
    public int gridSize;
    public Transform startingPoint;

    public enum Size
    {
        Five = 5,
        Ten = 10,
        Fifteen = 15,
        Twenty = 20,
        Thirty = 30,
    }
    public Size size;

    // Start is called before the first frame update
    void Start()
    {

        InitGrid();
    }

    public void InitGrid()
    {
        switch(size)
        {
            case Size.Five:
                gridSize = 5;
                startingPoint.position = new Vector3(4, -3);
                break;
            case Size.Ten:
                gridSize = 10;
                break;
            case Size.Fifteen:
                gridSize = 15;
                break;
            case Size.Twenty:
                gridSize = 20;
                break;
            case Size.Thirty:
                gridSize = 30;
                break;
            default:
                Debug.LogError("Error : Size Error");
                break;
        }

        grid = new GameObject[gridSize, gridSize];

        for(int x = 0; x < gridSize; x++)
        {
            for(int y = 0; y < gridSize; y++)
            {

            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject[,] grid;
    public GameObject tile;
    public int gridSize;
    public Transform startingPoint;

    // Start is called before the first frame update
    void Start()
    {
        tile = Resources.Load<GameObject>("Prefabs/Tile");

        InitGrid();
        InitHint();
    }

    public void InitGrid()
    {
        grid = new GameObject[gridSize, gridSize];

        for(int x = 0; x < gridSize; x++)
        {
            for(int y = 0; y < gridSize; y++)
            {
                GameObject obj = Instantiate(tile, GameObject.Find("Game/Grid").transform);
                obj.transform.position = new Vector3(startingPoint.position.x + x, startingPoint.position.y + y, 0);
                obj.name = string.Format("Tile[{0}, {1}]", x, y);
            }
        }
    }

    public void InitHint()
    {

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

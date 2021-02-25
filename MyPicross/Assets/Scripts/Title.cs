using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnClickStart(int level)
    {
        switch(level)
        {
            case 0:
                Debug.Log("Level1 : 5x5 ");
                break;

            case 1:
                Debug.Log("Level2 : 10x10 ");
                break;

            case 2:
                Debug.Log("Level3 : 15x15 ");
                break;

            case 3:
                Debug.Log("Level4 : 20x20 ");
                break;

            case 4:
                Debug.Log("Level5 : 30x30 ");
                break;
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEditorTest : MonoBehaviour {

    [SerializeField]
    GameObject block;

    [SerializeField]
    int gridX = 10;

    [SerializeField]
    int gridY = 10;

    int[,] blockCoordinates;
    Vector3 blockPosition;


    void Start () {
        blockCoordinates = new int[gridX,gridY];
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            blockCoordinates[Mathf.RoundToInt(ray.origin.x), Mathf.RoundToInt(ray.origin.y)] = 1;

            Debug.Log(ray.origin);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int j = 0; j < gridY; j++)
            {
                for (int i = 0; i < gridX; i++)
                {
                    if (blockCoordinates[i, j] == 1)
                        Instantiate(block, blockPosition = new Vector3(i, j, 0), block.transform.rotation);
                }
            }

        }

    }
}

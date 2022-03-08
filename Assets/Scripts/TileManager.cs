using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    int maxRows = 21;
    int maxColumns = 13;
    float yPos = -6f;
    float xPos;
    float xOffset = 1.75f;
    float yOffset = 0.5f;
    [SerializeField] GameObject tile;

    // Awake 
    void Awake()
    {
        for (int rows = 0; rows <= maxRows; rows++)
        {
            if (rows % 2 == 0) // Determine the initial X position for each row.
            {
                xPos = -11f;
            }
            else
            {
                xPos = -10.125f;
            }
            yPos += yOffset;
            for (int columns = 0; columns <= maxColumns; columns++)
            {
                Vector3 position = new Vector3(xPos, yPos, 0);
                Instantiate(tile, position, transform.rotation, transform.transform);

                xPos += xOffset;
            }
        }
    }

    
}

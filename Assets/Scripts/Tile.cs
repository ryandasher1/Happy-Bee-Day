using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] GameObject building;

    // Start is called before the first frame update
    void Start()
    {
        if (transform.position.x <= 1.5 && transform.position.x >= -1 && transform.position.y <= 1 && transform.position.y >= -1)
        {
            GetComponent<SpriteRenderer>().color = new Color32(173, 161, 9, 255);
        }
    }

    void OnMouseDown()
    {
        Instantiate(building, this.transform);
    }
}

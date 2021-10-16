using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class house2Script : MonoBehaviour
{
    public SpriteRenderer sprite;
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (door.GetComponent<doorScript>().doorOpen)
        {
            sprite.sortingOrder = 5;
        }
    }
}

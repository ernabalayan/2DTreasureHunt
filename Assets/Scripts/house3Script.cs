using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class house3Script : MonoBehaviour
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
        if (door.GetComponent<door3Script>().doorOpen)
        {
            sprite.sortingOrder = 5;
        }
    }
}

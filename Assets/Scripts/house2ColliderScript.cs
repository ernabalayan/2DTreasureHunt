using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class house2ColliderScript : MonoBehaviour
{
    public GameObject door;
    public PolygonCollider2D Collider;
    // Start is called before the first frame update
    void Start()
    {
        Collider.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (door.GetComponent<door2Script>().doorOpen)
        {
            Collider.enabled = false;

        }
    }
}

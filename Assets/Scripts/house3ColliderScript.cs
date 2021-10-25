using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class house3ColliderScript : MonoBehaviour
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
        if (door.GetComponent<door3Script>().doorOpen)
        {
            Collider.enabled = false;

        }
    }
}

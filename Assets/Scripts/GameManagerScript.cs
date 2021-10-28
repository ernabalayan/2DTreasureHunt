using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public List<GameObject> boxList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        boxList[Random.Range(0, boxList.Count)].tag = "theBox";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

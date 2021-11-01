using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goodEndScript : MonoBehaviour
{
    public Sprite lastFrame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<SpriteRenderer>().sprite == lastFrame)
        {
            SceneManager.LoadScene(0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playScript : MonoBehaviour
{
    public Sprite hovered;
    public Sprite notHovered;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().sprite = hovered;
        
       
    }
    private void OnMouseDown()
    {
        SceneManager.LoadScene(1);
    }
    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().sprite = notHovered;
    }
    // Update is called once per frame
    void Update()
    {
      
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerscript : MonoBehaviour
{
    public float moveSpeed = 3f;
    public GameObject player;
    public bool moveLeft;
    public bool moveRight;
    public bool moveUp;
    public bool moveDown;

    public void Start()
    {
        
        
        GetComponent<Animator>().enabled = false;
        
    }

    // Start is called before the first frame update
   
 
    void MoveControls()
    {
        if(Input.GetKey(KeyCode.D))
        {
            moveRight = true;
            GetComponent<Animator>().enabled = true;
            GetComponent<Animator>().Play("moveRightAnim");
           
    
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        }
        if(Input.GetKey(KeyCode.A))
        {
            moveLeft = true;
            GetComponent<Animator>().enabled = true;
            GetComponent<Animator>().Play("moveLeftAnim");
   
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.W))
        {
            moveUp = true;
            GetComponent<Animator>().enabled = true;
            GetComponent<Animator>().Play("moveForwardAnim");
        
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDown = true;
            GetComponent<Animator>().enabled = true;
            GetComponent<Animator>().Play("moveDownAnim");
         
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

        }
        if (!Input.anyKey)
        {
            GetComponent<Animator>().enabled = false;
       }
    }

    // Update is called once per frame

    void Update()
    {
        
            MoveControls();
        
   
    }
}

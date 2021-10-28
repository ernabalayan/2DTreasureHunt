using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerscript : MonoBehaviour
{
    public float moveSpeed = 50f;
    public GameObject player;
    public bool moveLeft;
    public bool moveRight;
    public bool moveUp;
    public bool moveDown;
    public int score = 0;
    public bool touchingCoin;

    public void Start()
    {
        
        
        GetComponent<Animator>().enabled = false;
    }

    // Start is called before the first frame update


    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "coin")
        {
            touchingCoin = true;
            score++;
            Debug.Log(score);
        }
    }
    
  
    void MoveControls()
    {
        if(Input.GetKey(KeyCode.D))
        {
            moveRight = true;
            GetComponent<Animator>().enabled = true;
            GetComponent<Animator>().Play("moveRightAnim");
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            
        }
        
       else if(Input.GetKey(KeyCode.A))
        {
            moveLeft = true;
            GetComponent<Animator>().enabled = true;
            GetComponent<Animator>().Play("moveLeftAnim");
   
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        }
        else if (Input.GetKey(KeyCode.W))
        {
            moveUp = true;
            GetComponent<Animator>().enabled = true;
            GetComponent<Animator>().Play("moveForwardAnim");
        
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        }
       else if (Input.GetKey(KeyCode.S))
        {
            moveDown = true;
            GetComponent<Animator>().enabled = true;
            GetComponent<Animator>().Play("moveDownAnim");
         
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

        }
       else if (!Input.anyKey)
        {
            GetComponent<Animator>().enabled = false;
       }
    }

    // Update is called once per frame

    void Update()
    {
        Debug.Log(score);
        if (!Input.GetKey(KeyCode.D))
        {
            moveRight = false;
        }
       
            MoveControls();

        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }
}

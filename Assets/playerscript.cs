using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    public int score =0;
    public float moveSpeed = 3f;
    Color colorStart = Color.white;
    Color colorRed = Color.red;
    Color colorBlue = Color.blue;
    Color colorGreen = Color.green;
    float duration = 4.0f;
    public GameObject player;
    public GameObject redKnob;
    public GameObject blueKnob;
    public GameObject greenKnob;
   
  
    

    public void Start()
    {
        
        
        GetComponent<Animator>().enabled = false;
        
    }

    // Start is called before the first frame update
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "RedKnob")
        {
           
            Debug.Log("red knob");
            //float lerp = Mathf.PingPong(Time.time, duration) / duration;
            //rend.material.color = Color.Lerp(colorStart, colorRed, lerp);
          
        }
        if (collision.gameObject.tag == "BlueKnob")
        {
           
            Debug.Log("blue knob");
            //float lerp = Mathf.PingPong(Time.time, duration) / duration;
            //rend.material.color = Color.Lerp(colorStart, colorBlue, lerp);
            
        }
    
        if (collision.gameObject.tag == "GreenKnob")
        {
            
            Debug.Log("green knob");
            //float lerp = Mathf.PingPong(Time.time, duration) / duration;
            //rend.material.color = Color.Lerp(colorStart, colorGreen, lerp);
        }
    
       
    }
    void MoveControls()
    {
        if(Input.GetKey(KeyCode.D))
        {
            GetComponent<Animator>().enabled = true;
            GetComponent<Animator>().Play("moveRightAnim");
           
    
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        }
        if(Input.GetKey(KeyCode.A))
        {
            GetComponent<Animator>().enabled = true;
            GetComponent<Animator>().Play("moveLeftAnim");
   
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Animator>().enabled = true;
            GetComponent<Animator>().Play("moveForwardAnim");
        
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.S))
        {
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

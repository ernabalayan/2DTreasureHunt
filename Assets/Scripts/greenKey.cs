using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class greenKey : MonoBehaviour
{
    public GameObject player;
    public GameObject greenDoor;
    public GameObject greenDoor1;
    public GameObject Lock;
    public bool pressingE;
    public bool hasKey;
    public bool goodAnim;
    public bool badAnim;
    public int i;
    
   
    // Start is called before the first frame update
    void Start()

    {
        i = Random.Range(0, 2);
        if(i == 0)
        {
            Debug.Log("goodanim");
            goodAnim = true;
        }
        if(i == 1)
        {
            Debug.Log("badanim");
            badAnim = true;
        }
        GetComponent<AudioSource>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (pressingE)
        {
            GetComponent<AudioSource>().enabled = true;
            this.transform.parent = player.transform;
            this.transform.localPosition = new Vector2(-2, -2);
            hasKey = true;
            

            if (collision.gameObject.tag == "greenDoor")
            {

                greenDoor.GetComponent<BoxCollider2D>().enabled = false;
                greenDoor1.GetComponent<SpriteRenderer>().enabled = false;
                Lock.GetComponent<SpriteRenderer>().enabled = false;

                if (goodAnim)
                {
                    SceneManager.LoadScene(3);
                }
                if (badAnim)
                {
                    SceneManager.LoadScene(4);
                }
                Destroy(this.gameObject);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

        if (GameObject.Find("greedyNPC4").GetComponent<bossScript>().greenKeyActivated)
        {
            GetComponent<BoxCollider2D>().enabled = true;
            GetComponent<SpriteRenderer>().enabled = true;

        }
        if (Input.GetKey(KeyCode.E))
        {
            pressingE = true;
        }
        if (Input.GetKey(KeyCode.R))
        {
            this.transform.parent = null;
        }
    }
}

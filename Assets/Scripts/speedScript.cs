using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speedScript : MonoBehaviour
{
    public RectTransform sliderParent;
    public RectTransform sliderChild;
    public float sliderValue;
    public static speedScript instance;
    public Color color1;
    public Color color2;
    public Color color3;
    public float timer = 30f;
    public bool pressed;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        pressed = true;
        GameObject.Find("Player").GetComponent<playerscript>().moveSpeed = 100f;
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
    }
    //
    // Update is called once per frame
    void Update()
    {
        if (pressed)
        {
            timer -= Time.deltaTime;
            speedScript.instance.sliderParent.gameObject.SetActive(true);
            speedScript.instance.sliderValue = timer / 30;
        }

        if (sliderValue > 0.5f)
        {
            sliderChild.GetComponent<Image>().color = Color.Lerp(color2,color1,(sliderValue - 0.5f) * 2f);
        }
        else
        {
            sliderChild.GetComponent<Image>().color = Color.Lerp(color3, color2, (sliderValue * 2f));
        }
        sliderChild.sizeDelta = new Vector2(sliderParent.sizeDelta.x * sliderValue, sliderChild.sizeDelta.y);
        if (timer <= 0.0f)
        {
            pressed = false;
            GameObject.Find("Player").GetComponent<playerscript>().moveSpeed = 50f;
            speedScript.instance.sliderParent.gameObject.SetActive(false);
            timer = 30.0f;
            GameObject.Find("speed").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("speed").GetComponent<BoxCollider2D>().enabled = true;
        }



    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ströga : MonoBehaviour
{

     public float speed = 1f;

     static public bool dialog = false;

     private TMP_TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        text = FindObjectOfType<TextMEshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0,0, speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.S)){
            transform.position += new Vector3(0,0, -speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D)){
            transform.position += new Vector3(speed * Time.deltaTime,0,0);
        }

        if(Input.GetKey(KeyCode.A)){
            transform.position += new Vector3(-speed * Time.deltaTime,0,0);
        }


        
    }
}

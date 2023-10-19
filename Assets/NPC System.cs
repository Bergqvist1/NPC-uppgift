using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCSystem : MonoBehaviour
{


    bool player_detect = false;
    public string line;

    private TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player_detect && Input.GetKeyDown(KeyCode.E))
        {
            text.text = line;
        }
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            player_detect = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        player_detect = false;
        text.text = "";
    }
}

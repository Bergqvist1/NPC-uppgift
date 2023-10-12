using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCSystem : MonoBehaviour
{


    bool player_detect = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player_detect && Input.GetKeyDown(KeyCode.E))
        {
            print("Tjenis du har GIGANTUS BENIS");
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
    }
}

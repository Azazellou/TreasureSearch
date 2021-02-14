using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{


    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player = GameObject.Find("Player")) // poursuivre
        {
            transform.LookAt(player.transform);
            GetComponent<Rigidbody>().velocity = transform.forward * 2;
        }
        else // patrouille
        {
            GetComponent<Rigidbody>().velocity = transform.forward;
        }
        
    }

   

}

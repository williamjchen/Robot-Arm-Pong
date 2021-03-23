using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isLeft;

    public GameObject manager;
    public GameObject Bot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            if(isLeft)
            {
                manager.GetComponent<Manager>().P2Score();
                Bot.GetComponent<Player>().reward(0.1f);
            }
            else
            {
                manager.GetComponent<Manager>().P1Score();
            }
        }
    }
}

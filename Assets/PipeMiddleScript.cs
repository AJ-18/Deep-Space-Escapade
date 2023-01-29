using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    //Create a reference to logic script
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {

        //Sets the reference to the GameObject with the tag "Logic" that was added earlier, and gets the Logic Script from that object.
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Checks if the spaceship is on the correct layer, and ensures that only when the spaceship crosses through, the score is incremented
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
    }
}

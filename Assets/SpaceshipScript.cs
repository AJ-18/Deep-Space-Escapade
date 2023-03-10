using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jetStrength;
    public LogicScript logic;
    public bool spaceshipIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        //Sets the reference to the GameObject with the tag "Logic" that was added earlier, and gets the Logic Script from that object.
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && spaceshipIsAlive)
        {
            myRigidbody.velocity = Vector2.up * jetStrength;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        spaceshipIsAlive = false;
    }
}

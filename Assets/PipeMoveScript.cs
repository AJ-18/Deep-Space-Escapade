using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Since  Unity is a 3D engine, the Z value is the object's depth even in a 2D game environment
        //Entire transform has to change in one go, have to use Vector3 for the reason mentioned above
        //Need to multiply it by Time.deltaTime to ensure that framerate doesn't tie to speed alone, and it's multiplied the same everywhere
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}

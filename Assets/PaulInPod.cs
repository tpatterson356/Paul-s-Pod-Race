using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PaulInPod : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float boostStrength;
    public LogicScript logic;
    public bool shipIsSafe = true;


    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && shipIsSafe)
        {
            myRigidbody.velocity = Vector2.up * boostStrength;
        }
        if (Input.GetKeyDown(KeyCode.N) == true)
        {
            myRigidbody.velocity = Vector2.up * boostStrength * 2;
        }
        if (transform.position.y > 8 || transform.position.y < -8)
        {
            logic.gameOver();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        shipIsSafe = false;
    }
}



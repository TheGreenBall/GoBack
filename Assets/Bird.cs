using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Bird : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript Logic;
    public bool birdIsAlive = true;
    public int deadplace = -21;
    public int placedead = 21;

    
    
    
    // Start is called before the first frame update
    void Start()
    {


        Logic = GameObject.FindWithTag("Logic").GetComponent<LogicScript>();

        

       

    }

    // Update is called once per frame
    void Update()
    {

       

        // controller
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;

            FindObjectOfType<AudioManager>().Play("Flap");

        }

        // death if fallen off game area
        if (transform.position.y < deadplace)
        {

           

            Debug.Log("Bird Deleted");
            Object.Destroy(gameObject);
            Logic.gameOver();
            birdIsAlive = false;




        }

        // death if to high
        if (transform.position.y > placedead)
        {



            Debug.Log("Bird Deleted");
            Object.Destroy(gameObject);
            Logic.gameOver();
            birdIsAlive = false;




        }


    }

    private void OnCollisionEnter2D(Collision2D collison)
    {

       
        Logic.gameOver();
        birdIsAlive = false;
    }

    

   

    
}

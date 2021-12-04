using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] playerMovement character;
    bool isSlowDownOn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D()
    {
        Debug.Log("hello");
        if (!isSlowDownOn)
        {
            StartCoroutine(ExampleCoroutine()); 
        }
      


    }
    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        float normalSpeed = character.movementSpeed;
        character.movementSpeed = character.movementSpeed - 9;
        isSlowDownOn = true;

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        character.movementSpeed = normalSpeed;
        isSlowDownOn = false;

    }
    //Start the coroutine we define below named ExampleCoroutine.

}

   

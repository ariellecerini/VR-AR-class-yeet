using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{   //List variables
        
        public float speed = 1f;    //Variable for speed of pacman movement
        public GameObject spawn_1; 
        public int dotsLeft; //variable for scoring parameters 
        public GameObject startPoint; //used to return player to their original location 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("dotsLeft"); //this will print hoW MANY DOTS ARE LEFT IN OUR GAME 
        ShowDots(); //run function ShowDots 

     if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * -speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * -speed * Time.deltaTime;
        }
    }
    void OnTriggerEnter(Collider gate)
{

if(gate.gameObject.tag == "Gate-1")
{
    transform.position = spawn_1.transform.position;
}

}

void OnCollisionEnter(Collision collision)
{
    if(collision.gameObject.tag =="Dots"){
        dotsLeft--;
    } else if (collision.gameObject.tag == "Ghost"){
        transform.position = startPoint.transform.position; 
    }
}

void ShowDots()
{
    if(dotsLeft == 0){
        Debug.Log("You Win!"); 
    }
}
}

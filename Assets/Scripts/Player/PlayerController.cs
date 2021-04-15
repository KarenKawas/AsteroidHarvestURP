using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;


[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float tilt;

// public GameObject myShipModel to tilt just the ship model. 

    public Boundary boundary;

    //ATTACK SYSTEM 
    public GameObject shot;
    public GameObject destroyer;
    public GameObject shotSpawn;

    public GameObject destroyerSpawn;

    public float fireRate;

    private float nextFire;


    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {

            GameObject clone;
            clone = Instantiate(shot) as GameObject;
            nextFire = Time.time + fireRate;

            clone.transform.position = shotSpawn.transform.position;

           GetComponent<AudioSource>().Play();

        }

        if (Input.GetButton("Jump") && Time.time > nextFire)
        {
            GameObject clone;
            clone = Instantiate(destroyer) as GameObject;
            nextFire = Time.time + fireRate;

            clone.transform.position = destroyerSpawn.transform.position;

           GetComponent<AudioSource>().Play();

        }

       
    }


    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); //
    }

    void FixedUpdate()  //Character movement! 
    {
        
        float moveHorizontal = Input.GetAxis("Horizontal"); 
        float moveVertical = Input.GetAxis("Vertical");
        

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed, ForceMode.Impulse); //We were adding velocity to the rigid body but NOW we are adding an impulse. 



        //clamping rigid body position and setting boundaries with minimum and maximum values for the screen but you can't respawn.
        rb.position = new Vector3(
         Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
         0.0f,
         Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
        );
        
        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);

        // transform. rotation on a reference to the ship model. 

    }
}

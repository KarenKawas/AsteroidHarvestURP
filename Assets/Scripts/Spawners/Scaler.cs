using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
     public float speed = 50;

     private Vector3 scaleChange;

     private void Update()
    {
           
       scaleChange = transform.localScale;

       scaleChange.x += Time.deltaTime;
       scaleChange.y += Time.deltaTime;
       scaleChange.z += Time.deltaTime;

       transform.localScale = scaleChange;
          
    }
}

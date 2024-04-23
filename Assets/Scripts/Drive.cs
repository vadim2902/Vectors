using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
   public float Speed = 10.0f;
   public float RotationSpeed = 100.0f;

   private void Update()
   {
      float translation = Input.GetAxis("Vertical") * Speed;
      float rotation = Input.GetAxis("Horizontal") * RotationSpeed;

      translation *= Time.deltaTime;
      rotation *= Time.deltaTime;
      
      transform.Translate(0, 0, translation);
      
      transform.Rotate(0, rotation, 0);
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zonaMuerte : MonoBehaviour
{
    johnMovimiento pm;

    private void Start()
    {
        pm = FindObjectOfType<johnMovimiento>();
    }

   private void OnTriggerEnter2D(Collider2D collision)
   {
       if (collision.gameObject.CompareTag("Player"))
       {
           pm.resetPosicion();
       }
   }
}

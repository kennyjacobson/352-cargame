using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrifterCollision : MonoBehaviour
{
    [SerializeField] float destroyDelay = 0.05f;
    private void OnTriggerEnter2D(Collider2D other) {
       
        if (other.gameObject.tag == "Drifter" ){
            Debug.Log("Drifter Safely Delivered");
            SpriteRenderer spriteR = other.gameObject.GetComponent<SpriteRenderer>();
            spriteR.color = Color.red ;
            Destroy(other.gameObject, destroyDelay);
        }
        
    }
}

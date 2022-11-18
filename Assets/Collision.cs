using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);
    SpriteRenderer spriteRenderer;
    bool hasPackage = false;
    float destroyDelay = 0.5f;
    
    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
        // if (other.tag == "Package" && !hasPackage){
        //     Debug.Log("Package Picked Up");
        //     hasPackage = true;
        //     Destroy(other, destroyDelay);
        // }
        // if (other.tag == "Customer" && hasPackage){
        //     Debug.Log("Package Delivered");
        //     hasPackage = false;
        // }
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        // if (other.gameObject.tag == "Package"){
        //     Debug.Log("Package Picked Up");
        //     Destroy(other.gameObject, 0.5f);
        // }
    }

}

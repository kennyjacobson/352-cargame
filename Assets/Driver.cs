using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] Sprite spriteUp;
    [SerializeField] Sprite spriteDown;
    [SerializeField] Sprite spriteRight;
    [SerializeField] Sprite spriteLeft;

    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    Sprite spriteDefault;
    SpriteRenderer spriteRenderer; 
    // Start is called before the first frame update
    void Start()
    {
            spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
            spriteDefault = spriteRenderer.sprite;

    }

    // Update is called once per frame
    void Update()
    {
        // float steerAmount = Input.GetAxis("Horizontal") * steerSpeed;
        // float moveAmount = Input.GetAxis("Vertical") * moveSpeed;
        // transform.Rotate(0,0,-steerAmount);
        // transform.Translate(0,moveAmount,0);

        


        float rotation = Input.GetAxis("Horizontal");
        float acceleration = Input.GetAxis("Vertical");
        GetComponent<Rigidbody2D>().AddTorque(rotation * steerSpeed * Time.deltaTime);

        // if(rotation > 0){
        //     spriteRenderer.sprite = spriteRight;
        // }
        // else if (rotation == 0){
        //     spriteRenderer.sprite = spriteDefault;
        // }
        // else{
        //     spriteRenderer.sprite = spriteLeft;
        // }

        if (acceleration > 0){
            GetComponent<Rigidbody2D>().AddForce( transform.up * -acceleration  * moveSpeed/2 * Time.deltaTime);
            spriteRenderer.sprite = spriteDown;
            
        }
        else if (acceleration == 0){
            spriteRenderer.sprite = spriteDefault;
            if(rotation > 0){
                spriteRenderer.sprite = spriteRight;
            }
            else if (rotation == 0){
                spriteRenderer.sprite = spriteDefault;
            }
            else {
                spriteRenderer.sprite = spriteLeft;
            }
        }
        else{
            GetComponent<Rigidbody2D>().AddForce( transform.up * -acceleration  * moveSpeed * Time.deltaTime);
            spriteRenderer.sprite = spriteUp;
        }
        
        
        if(transform.position.x > 40){
            transform.SetPositionAndRotation(new Vector3(-39,transform.position.y,transform.position.z), transform.rotation );
        }
        if(transform.position.x < -40){
            transform.SetPositionAndRotation(new Vector3(39,transform.position.y,transform.position.z), transform.rotation);
        }
        if(transform.position.y > 25){
            transform.SetPositionAndRotation(new Vector3(transform.position.x,-24,transform.position.z), transform.rotation);
        }
        if(transform.position.y < -25){
            transform.SetPositionAndRotation(new Vector3(transform.position.x,24,transform.position.z), transform.rotation);
        }
  
    }
}

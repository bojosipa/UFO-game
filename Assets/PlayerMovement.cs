using System.Collections;
using UnityEngine;
using UnityEngine.UI; // Ovo omogućava rad sa UI elementima

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    
    public float moveSpeed = 10f; // Speed of the player


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
      
   
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * moveSpeed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pickup"))
        {
            
            Destroy(other.gameObject);
        }
    }

   
}

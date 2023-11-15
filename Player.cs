using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float verticalForce = 400f;
    [SerializeField] private Color orangeColor;
    [SerializeField] private Color violetColor;
    [SerializeField] private Color cyanColor;
    [SerializeField] private Color pinkColor;

    //Color currently
    private string currentColor;


    Rigidbody2D playerRb;  // Corregido aquí
    SpriteRenderer playerSR;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerSR = GetComponent<SpriteRenderer>();

        ChangeColor();

    }

  
    // =    ()     <>    p
    // Update is called once per frame
    void Update()
    {
       
       if(Input.GetKeyDown(KeyCode.Space))
        {
        playerRb.velocity = Vector2.zero;
        playerRb.AddForce(new Vector2(0, verticalForce));
        }
    }

    /*
     private void OnCollisionEnter2D(Collision2D collision)
   {
    Debug.Log("Colision with " + collision.gameObject.name);
   }
   */

 
     private void OnTriggerEnter2D(Collider2D collision)
   {
   
    if(!collision.gameObject.CompareTag(currentColor))
    {
        Debug.Log("Lo colores no coinciden GAME OVER");
    }
   }
  

   void ChangeColor()
   {
    int randomNumber = Random.Range(0,4);
    Debug.Log(randomNumber);

    if(randomNumber == 0)
    {
        playerSR.color = orangeColor;
        currentColor = "Orange";
    }
    else if(randomNumber == 1)
    {
        playerSR.color = violetColor;
           currentColor = "Violet";
    }
     else if(randomNumber == 2)
    {
        playerSR.color = cyanColor;
           currentColor = "Cyan";
    }
    else if(randomNumber == 3)
    {
        playerSR.color = pinkColor;
           currentColor = "Pink";
    }
   }
}

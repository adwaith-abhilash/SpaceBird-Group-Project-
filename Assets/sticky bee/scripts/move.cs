using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewBehaviourScript1 : MonoBehaviour
{
    
    public Rigidbody2D rb;
    public GameObject GameOver1;
    public GameObject goo;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //GameOver2 = GameObject.Find("GameOver1");
        //GameOver2.SetActive(false);
        //goo.SetActive(false);


        //FindObjectOfType<gamemanager>().Play();

    }

    // Update is called once per frame
    void Update()
    {
        FindObjectOfType<gamemanager>().Play();
        GameOver1.SetActive(false);

        rb.velocity = new Vector2(5, rb.velocity.y);

        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(rb.velocity.x, 7);
        }
    }

    


    
}
    



    
//unwanted code:
 //   private void OnTriggerEnter2D(Collider2D other)
 //   {
 //       if (other.gameObject.tag == "obstacle"){
 //           FindObjectOfType<gamemanager>().GameOver();
 //       }
 //   }

//    private void OnCollisionEnter2D(Collision2D collision)
//    {
//        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
//    }

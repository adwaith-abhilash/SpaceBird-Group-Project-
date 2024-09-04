using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Transform target;
    private gamemanager gameManager; // Reference to the gamemanager script

    void Start()
    {
        // Find the player transform
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        // Find the gamemanager script in the scene
        gameManager = FindObjectOfType<gamemanager>();

        if (gameManager == null)
        {
            Debug.LogError("gamemanager not found in the scene!");
        }
    }

    void Update()
    {
        // Move towards the player
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    // Detect collision with the player
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Call the GameOver method from the gamemanager script
            if (gameManager != null)
            {
                gameManager.GameOver();
            }
        }
    }
}

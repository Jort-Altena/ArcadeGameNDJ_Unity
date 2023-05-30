using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] Rigidbody2D RB;

    [SerializeField] float jumpPower = 300f;
    [SerializeField] float speed = 0.1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "HitCollisionTag")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void Update()  
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RB.AddForce(transform.up * jumpPower);
        }

    }

    private void FixedUpdate()
    {
        RB.transform.Translate(Vector2.right * speed);
    }
}

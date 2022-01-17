using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour
{
    public float moveSpeed;

    public Rigidbody2D rb;

    private Vector2 moveDirection;

    [SerializeField] GameObject arma;

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
        atacar();
    }

    private void FixedUpdate()
    {
        Move();
        
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY);
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed*Time.deltaTime, moveDirection.y * moveSpeed*Time.deltaTime);
    }

    void atacar()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(arma,this.gameObject.transform);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{

  public float speed;


  private Rigidbody2D rb;
  private Vector2 moveVelocity;

  // Use this for initialization
  void Start()
  {
    rb = GetComponent<Rigidbody2D>();

  }

  void PositionMo()
  {
    if (rb.position.y < -6)
    {
      rb.gravityScale = -15;
    }
    else
    {
      rb.gravityScale = 15;
    }
  }

  // Update is called once per frame
  void Update()
  {
    Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    moveVelocity = moveInput.normalized * speed;
  }

  private void FixedUpdate()
  {
    rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    PositionMo();
  }

}

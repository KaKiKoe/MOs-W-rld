using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{

  public Animator animator;
  public ParticleSystem bubbles;

  public Sprite MoUnderWater;
  public Sprite None;

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
    if (rb.position.y < -5.5)
    {
      rb.gravityScale = -15;
      this.GetComponent<SpriteRenderer>().sprite = MoUnderWater;
    }
    else
    {
      rb.gravityScale = 15;

      if (rb.position.y > -5.0)
      {
        this.GetComponent<SpriteRenderer>().sprite = None;
      }

      if(rb.position.y >-5.5 && rb.position.y < -5.2)
    {
        rb.gravityScale = 0; 
    }
    }
  }

  // Update is called once per frame
  void Update()
  {
    Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    moveVelocity = moveInput.normalized * speed;

    if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
    {
      //Animation abspielen
      animator.SetBool("RotatingLeft", true);
      //animator.SetBool("RoatingRight", false);
    }

    if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
    {
      animator.SetBool("RotatingRight", true);
      animator.SetBool("RotatingLeft", false);
    }

    if (rb.position.y < -10.5)
    {
      bubbles.Play();

    }

    else
    {
      bubbles.Pause();
      
    }
  }


  private void FixedUpdate()
  {
    rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    PositionMo();

  }
}

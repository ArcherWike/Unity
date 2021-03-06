using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float heroSpeed;
    public float jumpForce;
    public Transform groundTester;
    public LayerMask layersToTest;

    Animator anim;
    Rigidbody2D rgdBody;
    bool dirToRight = true;
    public Transform startPoint;

    private bool onTheGround;
    private float radius = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rgdBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo (0).IsName ("grzybContact"))
        {
            rgdBody.velocity = Vector2.zero;
            return;
        }
        onTheGround = Physics2D.OverlapCircle (groundTester.position,radius, layersToTest);

        float horizontalMove = Input.GetAxis("Horizontal");
        rgdBody.velocity = new Vector2(horizontalMove * heroSpeed, rgdBody.velocity.y);

        if (Input.GetKeyDown(KeyCode.UpArrow) && onTheGround)
        {
            rgdBody.AddForce(new Vector2 (0f, jumpForce));
            anim.SetTrigger("jump");
        }

        anim.SetFloat("speed", Mathf.Abs(horizontalMove));

        if (horizontalMove < 0 && dirToRight)
        {
            Flip();
        }
        if (horizontalMove > 0 && !dirToRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        dirToRight = !dirToRight;
        Vector3 heroScale = gameObject.transform.localScale;
        heroScale.x *= -1;
        gameObject.transform.localScale = heroScale;
    }

    public void RestartHero()
    {
        gameObject.transform.position = startPoint.position;
    }
}


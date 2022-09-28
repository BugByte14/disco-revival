using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rig2d;
    public SpriteRenderer sprite;
    public Animator anim;

    public float speed = 5f;
    public Vector2 movement;
    private Dictionary<string, KeyCode> keys = new Dictionary<string, KeyCode>();

    void Start()
    {
        rig2d = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        keys.Add("Finger Bang", KeyCode.E);
        anim.SetBool("IsBanging", false);
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("RunningX", Math.Abs(movement.x));
        anim.SetFloat("RunningY", Math.Abs(movement.y));

        //sprite flipper
        if (movement.x >= 0.1f)
        {
            sprite.flipX = false;
        } else if (movement.x <= -0.1f)
        {
            sprite.flipX = true;
        }
    }

    void FixedUpdate()
    {
        rig2d.MovePosition(rig2d.position + movement * speed * Time.fixedDeltaTime);
        if (rig2d.velocity.x < 0)
        {
            sprite.flipX = true;
        }
        if (Input.GetKey(keys["Finger Bang"]))
        {
            anim.SetBool("IsBanging", true);
        }
        else
        {
            anim.SetBool("IsBanging", false);
        }
    }
}

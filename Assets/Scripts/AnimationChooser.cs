using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChooser : MonoBehaviour
{
    public int AnimationAmount;

    SpriteRenderer sprite;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        int rand = Random.Range(0, AnimationAmount);
        Debug.Log(rand);

        anim.SetInteger("WhichDance", rand);

        if (Random.Range(0, 4) <= 1)
        {
            sprite.flipX = true;
        }
    }
}

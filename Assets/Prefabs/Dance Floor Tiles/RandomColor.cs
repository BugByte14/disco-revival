using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    public Sprite[] sprite;
    public int spriteAmount;

    Random rand;
    SpriteRenderer spriteRen;

    // Start is called before the first frame update
    void Start()
    {
        spriteRen = GetComponent<SpriteRenderer>();

        StartCoroutine(timetoswitch());
    }
    // Update is called once per frame
    IEnumerator timetoswitch()
    {
        float randtime = Random.Range(.1f, 3f);

        yield return new WaitForSeconds(randtime);

        int rand = Random.Range(0, spriteAmount);

        spriteRen.sprite = sprite[rand];

        StartCoroutine(timetoswitch());
    }
}

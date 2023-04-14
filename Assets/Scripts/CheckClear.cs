using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckClear : MonoBehaviour
{
    private Animator animator;
    private bool finish;
    GameObject Player;
    Character character;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        finish = false;
        Player = GameObject.Find("Player");
        character = Player.GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        if(character.Clear==true && finish == false)
        {
            animator.SetBool("Clear", true);
            transform.position += new Vector3(0, 0.2f, 0);
            finish = true;
        }
    }
}

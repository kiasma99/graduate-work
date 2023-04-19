using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_6_1 : MonoBehaviour
{
    GameObject GOmonster;
    Monster monster;

    // Start is called before the first frame update
    void Start()
    {
        GOmonster = GameObject.Find("Monster_6_1");
        monster = GOmonster.GetComponent<Monster>();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (monster.MoveFront)
        {
            monster.MoveFront = false;
            monster.MoveBackLeft = true;
        }
        else
        {
            monster.MoveFrontRight = false;
            monster.MoveBack = true;
        }
    }
}

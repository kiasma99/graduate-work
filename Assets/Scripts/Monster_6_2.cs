using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_6_2 : MonoBehaviour
{
    GameObject GOmonster;
    Monster monster;

    // Start is called before the first frame update
    void Start()
    {
        GOmonster = GameObject.Find("Monster_6_2");
        monster = GOmonster.GetComponent<Monster>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (monster.MoveBackLeft)
        {
            monster.MoveBackLeft = false;
            monster.MoveFrontLeft = true;
        }
        else
        {
            monster.MoveBackRight = false;
            monster.MoveFrontRight = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_5 : MonoBehaviour
{
    GameObject GOmonster;
    Monster monster;

    // Start is called before the first frame update
    void Start()
    {
        GOmonster = GameObject.Find("Monster_5");
        monster = GOmonster.GetComponent<Monster>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (monster.MoveFront)
        {
            monster.MoveFront = false;
            monster.MoveBack = true;
        }
        else
        {
            monster.MoveFront = true;
            monster.MoveBack = false;
        }
    }
}

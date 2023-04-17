using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_6 : MonoBehaviour
{
    GameObject GOmonster1, GOmonster2;
    Monster monster1, monster2;
    // Start is called before the first frame update
    void Start()
    {
        GOmonster1 = GameObject.Find("Monster_6_1");
        monster1 = GOmonster1.GetComponent<Monster>();
        GOmonster2 = GameObject.Find("Monster_6_2");
        monster2 = GOmonster2.GetComponent<Monster>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (monster1.MoveBack)
        {
            monster1.MoveBack = false;
            monster1.MoveFront = true;
        }
        else if(monster1.MoveBackLeft)
        {
            monster1.MoveBackLeft = false;
            monster1.MoveFrontRight = true;
        }
        if (monster2.MoveFrontRight)
        {
            monster2.MoveFrontRight = false;
            monster2.MoveBackLeft = true;
        }
        else if(monster2.MoveFrontLeft)
        {
            monster2.MoveFrontLeft = false;
            monster2.MoveBackRight = true;
        }
    }
}

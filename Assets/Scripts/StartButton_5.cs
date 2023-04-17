using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton_5 : MonoBehaviour
{
    Button btn;
    GameObject GOmonster;
    Monster monster;

    // Start is called before the first frame update
    void Start()
    {
        btn = this.transform.GetComponent<Button>();
        if (btn != null) btn.onClick.AddListener(start);
        GOmonster = GameObject.Find("Monster_5");
        monster = GOmonster.GetComponent<Monster>();
    }

    public void start()
    {
        monster.MoveFront = true;
    }
}

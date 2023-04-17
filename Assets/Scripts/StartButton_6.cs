using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton_6 : MonoBehaviour
{
    Button btn;
    GameObject GOmonster1, GOmonster2;
    Monster monster1, monster2;

    // Start is called before the first frame update
    void Start()
    {
        btn = this.transform.GetComponent<Button>();
        if (btn != null) btn.onClick.AddListener(start);
        GOmonster1 = GameObject.Find("Monster_6_1");
        monster1 = GOmonster1.GetComponent<Monster>();
        GOmonster2 = GameObject.Find("Monster_6_2");
        monster2 = GOmonster2.GetComponent<Monster>();
    }

    public void start()
    {
        monster1.MoveFront = true;
        monster2.MoveBackLeft = true;
    }
}

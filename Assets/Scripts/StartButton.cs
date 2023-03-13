using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    Button btn;
    GameObject Player;
    Character character;

    // Start is called before the first frame update
    void Start()
    {
        btn = this.transform.GetComponent<Button>();
        if (btn != null) btn.onClick.AddListener(start);
        Player = GameObject.Find("Player");
        character = Player.GetComponent<Character>();
    }

    public void start()
    {
        character.MoveFront = true;
        character.LeftRight = true;
    }
}

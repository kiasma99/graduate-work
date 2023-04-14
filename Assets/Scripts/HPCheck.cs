using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HPCheck : MonoBehaviour
{
    private TextMeshProUGUI text;
    GameObject Player;
    Character character;
    private int hp;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        character = Player.GetComponent<Character>();
        hp = character.HP;
        text = GetComponent<TextMeshProUGUI>();
        text.text = "X " + hp.ToString();
    }

    void Update()
    {
        if (character.HP != hp)
        {
            hp = character.HP;
            text.text = "X " + hp.ToString();
        }
    }
}

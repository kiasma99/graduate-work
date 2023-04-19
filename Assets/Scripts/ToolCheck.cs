using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToolCheck : MonoBehaviour
{
    private TextMeshProUGUI text;
    GameObject Player;
    Character character;
    private int tool;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        character = Player.GetComponent<Character>();
        tool = character.Tool;
        text = GetComponent<TextMeshProUGUI>();
        text.text = "X " + tool.ToString();
    }

    void Update()
    {
        if (character.Tool != tool)
        {
            tool = character.Tool;
            text.text = "X " + tool.ToString();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FoodCheck : MonoBehaviour
{
    private TextMeshProUGUI text;
    GameObject Player;
    Character character;
    private int food;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        character = Player.GetComponent<Character>();
        food = character.Food;
        text = GetComponent<TextMeshProUGUI>();
        text.text = "X " + food.ToString();
    }

    void Update()
    {
        if (character.Food != food)
        {
            food=character.Food;
            text.text = "X " + food.ToString();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageClearPanel : MonoBehaviour
{
    GameObject Player;
    Character character;
    private bool finish;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        character = Player.GetComponent<Character>();
        GameObject.Find("Canvas").transform.Find("StageClearPanel").gameObject.SetActive(false);
        finish = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(character.Clear && !finish)
        {
            GameObject.Find("Canvas").transform.Find("StageClearPanel").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.Find("PauseButton").gameObject.SetActive(false);
            finish = true;
        }
    }
}

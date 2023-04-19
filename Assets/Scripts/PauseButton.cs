using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    Button btn;
    GameObject Player;
    Character character;

    // Start is called before the first frame update
    void Start()
    {
        btn = this.transform.GetComponent<Button>();
        if (btn != null) btn.onClick.AddListener(Click);
        Player = GameObject.Find("Player");
        character = Player.GetComponent<Character>();
    }

    public void Click()
    {
        GameObject.Find("Canvas").transform.Find("PauseButton").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("StagePausePanel").gameObject.SetActive(true);
        character.moveSpeed = 0;
        character.Pause = true;
    }
}

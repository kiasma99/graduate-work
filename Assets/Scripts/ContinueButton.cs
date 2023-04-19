using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueButton : MonoBehaviour
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
        GameObject.Find("Canvas").transform.Find("PauseButton").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("StagePausePanel").gameObject.SetActive(false);
        character.moveSpeed = 0.3f;
        character.Pause = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftCheck : MonoBehaviour
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
        GameObject.Find("ControlPanel").transform.Find("Left_Check").gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void Click()
    {
        GameObject.Find("ControlPanel").transform.Find("Right_Check").gameObject.SetActive(false);
        GameObject.Find("ControlPanel").transform.Find("Left_Check").gameObject.SetActive(true);
        character.CrossWalk_2 = true;
    }
}

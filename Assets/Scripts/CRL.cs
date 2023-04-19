using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CRL : MonoBehaviour
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
        GameObject.Find("ControlPanel").transform.Find("CRL_Check").gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void Click()
    {
        GameObject.Find("ControlPanel").transform.Find("RCL_Check").gameObject.SetActive(false);
        GameObject.Find("ControlPanel").transform.Find("RLC_Check").gameObject.SetActive(false);
        GameObject.Find("ControlPanel").transform.Find("CRL_Check").gameObject.SetActive(true);
        GameObject.Find("ControlPanel").transform.Find("CLR_Check").gameObject.SetActive(false);
        GameObject.Find("ControlPanel").transform.Find("LRC_Check").gameObject.SetActive(false);
        GameObject.Find("ControlPanel").transform.Find("LCR_Check").gameObject.SetActive(false);
        character.CrossWalk_3 = 5;
    }
}
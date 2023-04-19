using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnMenu : MonoBehaviour
{
    Button btn;

    // Start is called before the first frame update
    void Start()
    {
        btn = this.transform.GetComponent<Button>();
        if (btn != null) btn.onClick.AddListener(Return_menu);
    }

    // Update is called once per frame
    public void Return_menu()
    {
        GameObject.Find("Canvas").transform.Find("ShowMap").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("ControlPanel").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("StageStartPanel").gameObject.SetActive(true);
    }
}

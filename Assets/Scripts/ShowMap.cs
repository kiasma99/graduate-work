using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowMap : MonoBehaviour
{
    Button btn;

    // Start is called before the first frame update
    void Start()
    {
        btn = this.transform.GetComponent<Button>();
        if (btn != null) btn.onClick.AddListener(Show_map);
        GameObject.Find("Canvas").transform.Find("ShowMap").gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void Show_map()
    {
        GameObject.Find("Canvas").transform.Find("StageStartPanel").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("ShowMap").gameObject.SetActive(true);
    }
}

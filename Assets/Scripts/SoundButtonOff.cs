using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButtonOff : MonoBehaviour
{
    Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn = this.transform.GetComponent<Button>();
        if (btn != null) btn.onClick.AddListener(Click);
    }

    // Update is called once per frame
    public void Click()
    {
        AudioListener.volume = 0;
        GameObject.Find("Canvas").transform.Find("SoundBtnOff").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("SoundBtnOn").gameObject.SetActive(true);
    }
}

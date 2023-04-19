using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (AudioListener.volume == 1) GameObject.Find("Canvas").transform.Find("SoundBtnOff").gameObject.SetActive(true);
        else GameObject.Find("Canvas").transform.Find("SoundBtnOn").gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

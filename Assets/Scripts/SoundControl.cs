using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public AudioSource bgm;

    private void Awake()
    {
        var soundManagers = FindObjectsOfType<SoundControl>();
        if(soundManagers.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        bgm.Play();
    }
}

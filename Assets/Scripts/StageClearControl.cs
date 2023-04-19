using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageClearControl : MonoBehaviour
{
    public bool[] stageClear = new bool[6] {false, false, false, false, false, false};
    private void Awake()
    {
        var stageClearManagers = FindObjectsOfType<StageClearControl>();
        if (stageClearManagers.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

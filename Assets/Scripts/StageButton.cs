using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageButton : MonoBehaviour
{
    public void Start_Stage1()
    {
        SceneManager.LoadScene("Stage1");
    }
}

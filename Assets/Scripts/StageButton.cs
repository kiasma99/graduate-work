using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageButton : MonoBehaviour
{
    public void MainPage()
    {
        SceneManager.LoadScene("MainPage");
    }
    public void Select_Stage()
    {
        SceneManager.LoadScene("SelectStage");
    }
    public void Start_Stage1()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void Start_Stage2()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void Start_Stage3()
    {
        SceneManager.LoadScene("Stage3");
    }
    public void Start_Stage4()
    {
        SceneManager.LoadScene("Stage4");
    }
    public void Start_Stage5()
    {
        SceneManager.LoadScene("Stage5");
    }
    public void Start_Stage6()
    {
        SceneManager.LoadScene("Stage6");
    }

}

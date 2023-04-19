using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageClearStar : MonoBehaviour
{
    GameObject Object;
    StageClearControl stageClearControl;

    // Start is called before the first frame update
    void Start()
    {
        Object = GameObject.Find("StageClearController");
        stageClearControl = Object.GetComponent<StageClearControl>();
        if (stageClearControl.stageClear[0])
        {
            GameObject.Find("Stage1").transform.Find("Stage1_Star").gameObject.SetActive(true);
        }
        if (stageClearControl.stageClear[1])
        {
            GameObject.Find("Stage2").transform.Find("Stage2_Star").gameObject.SetActive(true);
        }
        if (stageClearControl.stageClear[2])
        {
            GameObject.Find("Stage3").transform.Find("Stage3_Star").gameObject.SetActive(true);
        }
        if (stageClearControl.stageClear[3])
        {
            GameObject.Find("Stage4").transform.Find("Stage4_Star").gameObject.SetActive(true);
        }
        if (stageClearControl.stageClear[4])
        {
            GameObject.Find("Stage5").transform.Find("Stage5_Star").gameObject.SetActive(true);
        }
        if (stageClearControl.stageClear[5])
        {
            GameObject.Find("Stage6").transform.Find("Stage6_Star").gameObject.SetActive(true);
        }
    }
}

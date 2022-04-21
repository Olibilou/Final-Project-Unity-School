using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    [SerializeField]
    private Text timer;

    float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timelevel();
        time = returntime();
        timer.text = "time: " + time;
        //Debug.Log(time);
    }

    public void timelevel()
    {
        CurrentLevel.timer += Time.deltaTime;
    }
    public float returntime()
    {
        return CurrentLevel.timer;
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowCompleteTime : MonoBehaviour
{

//    [SerializeField]
    private TMP_Text timer;

    float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        timer = GetComponent<TMP_Text>();


        time = returntime();
        timer.text = "" + time;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float returntime()
    {
        return CurrentLevel.timer;
    }
}

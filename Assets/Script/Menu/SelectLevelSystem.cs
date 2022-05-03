using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SelectLevelSystem : MonoBehaviour
{
    [SerializeField]
    private int level;

    [SerializeField]
    private TMP_Text number;



    // Start is called before the first frame update
    void Start()
    {
        if (CurrentLevel.arr[level] == false)
        {
            number.color = Color.red;
        }
        if (CurrentLevel.arr[level] == true)
        {
            number.color = Color.blue;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selectLevel()
    {
        if (CurrentLevel.arr[level] == true)
        {
            CurrentLevel.CurrentLevels = level;
            AllowSkipLevel.skipLevel = 2;
            CurrentLevel.timer = 0f;
            SceneManager.LoadScene(level);
        }
    }
}

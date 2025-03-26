using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Main_Menu_scr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change_Level_1()
    {
        SceneManager.LoadScene("level_1");
    }

    public void Change_Level_2()
    {
        SceneManager.LoadScene("level_2");
    }

    public void Change_Level_Main_Menu()
    {
        SceneManager.LoadScene("main_menu");
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    private void Awake()
    {
        OptionDontDestroy();
        MoneyManagerDontDestroy();
    }

    private void OptionDontDestroy()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Option");

        if (objs.Length == 1) { DontDestroyOnLoad(objs[0]); }
        
        else
        {
            for (int index = 1; index <= objs.Length; index++)
            {
                Destroy(objs[index]); 
            }
        }
    }

    private void MoneyManagerDontDestroy()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("MoneyManager");

        if (objs.Length == 1) { DontDestroyOnLoad(objs[0]); }

        else
        {
            for (int index = 1; index <= objs.Length; index++)
            {
                Destroy(objs[index]);
            }
        }
    }
}

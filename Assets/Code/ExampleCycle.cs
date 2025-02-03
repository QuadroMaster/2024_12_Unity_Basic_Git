using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cycle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      //ExampleDoWhile();
      //ExampleWhile();
      ExampleForeach();
    }

    

    private void ExampleFor()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.LogError("Mom");
        }
    }

    private void ExampleDoWhile()
    {
        int n = -10;
        int i = 0;
        do
        {
            i++;
            n -= 10;
        } while (n >= 0);
        
        Debug.LogError(i);
    }

    private void ExampleWhile()
    {
        int n = -10;
        int i = 0;
        while (n >= 0)
        {
            i++;
            n -= 10;
        }
        Debug.LogError(i);
    }

    private void ExampleForeach()
    {
        string nik = "Roman";
        foreach (char i in nik)
        {
            if (i == 'm')
            {
                //continue;
                //break;
                return;
            }
            Debug.LogError(i);
        }
        Debug.LogError(nik);
    }
    
    
    
}

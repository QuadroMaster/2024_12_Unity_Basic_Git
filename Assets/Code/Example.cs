using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{

    public int A;
    public int B;

    private void OnValidate()
    {
        //First();
        Second();
    }

    private void First()
    {
        bool t = A > B;
        if (t)
        {
            Debug.LogError("A more B");
        }
        
    }

    #region MyRegion

    private void Second()
        {
            if (A >= B)
            {
                Debug.LogError("A more B");
            }
            else
            {
                Debug.LogError("B more A");
            }
        }

    #endregion


    private void Fifth()
    {
        int max = 0;
        if (A > B)
        {
            max = A;
        }
        else
        {
            {
                max = B;
            }
        }

        Debug.LogError(max);

        max = A > B ? A : B;

        Debug.LogError(max);
    }


    public int C;


    private void Sixth()
    {
        int maxOne = A > B ? A > C ? A : C : B > C ? B : C;

        int maxTwo = 0;

        if (A > B)
        {
            if (A > C)
            {
                maxTwo = A;
            }
            else
            {
                maxTwo = C;
            }
        } else if (B > C)
        {
            maxTwo = B;
        }
        else
        {
            maxTwo = C;
        }
    }



}
    
    
    


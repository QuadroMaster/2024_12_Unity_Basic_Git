using UnityEngine;

public class Example : MonoBehaviour
{
    private void IsEqual(float playerHp, float enemyHp)
    {
        if (playerHp == enemyHp)
        {
            //win
        }
        
        float epsilon = 0.00001f;
        float epsilonByMathf = Mathf.Epsilon;
        if (Mathf.Abs(playerHp - enemyHp) < epsilon)
        {
            //win
        }

        if (Mathf.Approximately(playerHp, enemyHp))
        {
            //win
        }
    }

    private int GetMaxOrMin(int i, int j, int k, int t, bool isMax)
    {
        return isMax ? Mathf.Max(i, j, k, t) : Mathf.Min(i, j, k, t);
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    // Get Set ¾²±â ±ÍÂ÷´Æ...
    public static int money = 100;
    private int gameClearMoney = 100000;
    private int gameOverMoney = -50000;

    private void Update()
    {
        if (money >= gameClearMoney)
        {
            // GameClear();
            print("GameClear!");
        }

        else if (money <= gameOverMoney)
        {
            // GameOver();
            print("GameOver!");
        }
    }
}

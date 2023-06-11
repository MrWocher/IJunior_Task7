using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static event Action<int> IncreasedCoins;

    public static void OnIncreaseCoins(int coins)
    {
        IncreasedCoins?.Invoke(coins);
    }
}

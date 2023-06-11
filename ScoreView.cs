using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreView : MonoBehaviour
{
    public static event Action<int> IncreasedCoins;

    public static int Coins;

    [SerializeField] private Text _coins_txt;

    private void OnEnable()
    {
        IncreasedCoins += IncreaseCoinsAmount;
    }

    public static void OnIncreaseCoins(int coins)
    {
        IncreasedCoins?.Invoke(coins);
    }

    public void IncreaseCoinsAmount(int coins)
    {
        Coins += coins;
        _coins_txt.text = "Coins: " + Coins.ToString();
    }
}

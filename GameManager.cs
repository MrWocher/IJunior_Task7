using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public static int Coins;

    [SerializeField] private Text _coins_txt;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        EventManager.IncreasedCoins += IncreaseCoinsAmount;
    }

    public void IncreaseCoinsAmount(int coins)
    {
        Coins += coins;
        _coins_txt.text = "Coins: " + Coins.ToString();
    }
}

using UnityEngine;

public class CoinsSpawner : MonoBehaviour
{
    [SerializeField] private Coin _coinObject;

    private void Start()
    {
        SpawnCoins();
    }

    private void SpawnCoins()
    {
        for(int i = 0; i < transform.childCount; ++i)
        {
            Transform _coinPos = transform.GetChild(i).transform;
            Coin _coinObj = Instantiate(_coinObject);
            _coinObj.Initialize(_coinPos.position, Quaternion.identity);
            _coinObj.transform.SetParent(_coinPos, true);
        }
    }

}

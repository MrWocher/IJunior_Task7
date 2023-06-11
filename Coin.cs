using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _coinsAmount;

    public void Initialize(Vector3 pos, Quaternion quaternion)
    {
        transform.position = pos;
        transform.rotation = quaternion;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Player player))
        {
            EventManager.OnIncreaseCoins(_coinsAmount);
            Destroy(gameObject);
        }
    }

}

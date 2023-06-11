using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _reward;

    public void Initialize(Vector3 pos, Quaternion quaternion)
    {
        transform.position = pos;
        transform.rotation = quaternion;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Player player))
        {
            ScoreView.OnIncreaseCoins(_reward);
            Destroy(gameObject);
        }
    }

}

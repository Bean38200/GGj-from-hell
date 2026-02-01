using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int value;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            CollectibleCounter.instance.IncreaseCollectibles(value);
        }

    }
}
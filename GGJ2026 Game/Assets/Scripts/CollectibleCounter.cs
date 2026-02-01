using UnityEngine;
using TMPro;

public class CollectibleCounter : MonoBehaviour
{
    public static CollectibleCounter instance;

    public TMP_Text collectibleText;
    public int currentCollectibles = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        collectibleText.text = "Collectibles:" + currentCollectibles.ToString();
    }

    public void IncreaseCollectibles(int v)
    {
        currentCollectibles += v;
        collectibleText.text = "Collectibles:" + currentCollectibles.ToString();
    }
}
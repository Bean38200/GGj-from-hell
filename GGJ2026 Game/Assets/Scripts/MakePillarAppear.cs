using UnityEngine;

public class MakePillarAppear : MonoBehaviour
{
    public GameObject objectToAppear; 

    void Start()
    {
        if (objectToAppear != null)
        {
            objectToAppear.SetActive(false);
        }
    }

    void Update()
    {
        
    }

    void RevealObject()
    {
        if (objectToAppear != null)
        {
            objectToAppear.SetActive(true);
            Debug.Log("Object has appeared!");
        }
    }
    
}
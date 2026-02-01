using UnityEngine;
using TMPro;
using System;
public class Displaytext : MonoBehaviour

{
    public TextMeshProUGUI textMesh;
    public string message = "message";
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("CollectibleObject"))
        {
            textMesh.text = message;
        }
    }
}

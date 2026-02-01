using System.Data.Common;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MaskMeadowDesert : MonoBehaviour
{
    public Transform player;
    void Start()
    {

    }

    void Update()
    {
        if (player)
        {
            float dist = Vector3.Distance(player.position, transform.position);
            if(dist < 3)
            {
                // Check for player interaction
            if (Input.GetKeyDown(KeyCode.E))
                {
                    Interact();
                }
            }
        }
    }
    void Interact()
     {
         // Implement interaction logic
         //Debug.Log("Object interacted!");
         SceneManager.LoadScene("Level1Desert");


     }
}
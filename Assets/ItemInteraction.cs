using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : MonoBehaviour
{
    public GameObject player;
    public GameObject takeIt;
    public GameObject torchWall;

    void Start()
    {
        // Make sure the necessary objects are assigned in the Unity Editor
        if (player == null || takeIt == null || torchWall == null)
        {
            Debug.LogError("Player, TakeIt, or TorchWall not assigned in the inspector!");
        }
    }

    void Update()
    {
        // Check for mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // Create a ray from the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Check if the ray hits the ground (you can customize this condition)
                if (hit.collider.CompareTag("Ground"))
                {
                    // Deactivate the Torch_Wall child object
                    torchWall.SetActive(false);

                    // Activate the TakeIt GameObject
                    takeIt.SetActive(true);
                }
                else if (hit.collider.gameObject == takeIt)
                {
                    // Activate the Torch_Wall child object
                    torchWall.SetActive(true);

                    // Deactivate the TakeIt GameObject
                    takeIt.SetActive(false);
                }
            }
        }
    }
}

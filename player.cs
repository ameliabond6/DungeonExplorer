using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float openAngle = 90f; // The angle the door opens to
    public float closeAngle = 0f; // The angle when the door is closed
    public float openSpeed = 2f; // Speed of door rotation
    private bool isOpen = false; // Track door state
    private bool playerNearby = false; // Check if player is near

    void Update()
    {
        // Check if player is near and presses "E"
        if (playerNearby && Input.GetKeyDown(KeyCode.E))
        {
            isOpen = !isOpen; // Toggle door state
        }

        // Rotate the door smoothly
        float targetAngle = isOpen ? openAngle : closeAngle;
        Quaternion targetRotation = Quaternion.Euler(0, targetAngle, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * openSpeed);
    }

    // Detect if the player enters the interaction area
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Make sure player has the "Player" tag
        {
            playerNearby = true;
            Debug.Log("Press 'E' to Open/Close the Door.");
        }
    }

    // Detect if the player leaves the interaction area
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = false;
        }
    }
}

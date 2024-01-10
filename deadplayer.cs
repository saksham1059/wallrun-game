using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public string deathSceneName = "DeadScene"; // Set the name of your death scene in the Unity Editor
    public string winSceneName = "WinScene"; // Set the name of your win scene in the Unity Editor
    public LayerMask deathLayer; // Set the death layer in the Unity Editor
    public LayerMask winLayer; // Set the win layer in the Unity Editor

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object is on the death layer
        if (((1 << collision.gameObject.layer) & deathLayer) != 0)
        {
            // Player collided with an object on the death layer
            // You can add any additional logic here for handling player death, such as playing an animation or sound effect

            // Unlock and show the mouse cursor
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            // Load the death scene
            SceneManager.LoadScene(deathSceneName);
        }
        // Check if the colliding object is on the win layer
        else if (((1 << collision.gameObject.layer) & winLayer) != 0)
        {
            // Player collided with an object on the win layer
            // You can add any additional logic here for handling player win, such as playing an animation or sound effect

            // Unlock and show the mouse cursor
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            // Load the win scene
            SceneManager.LoadScene(winSceneName);
        }
    }
}

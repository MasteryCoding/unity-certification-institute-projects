using UnityEngine;

public class InputHandler : MonoBehaviour
{
  [SerializeField] CameraController camControl;
  private Movement playerMovement;

  private void Awake()
  {
    GameObject player = GameObject.FindGameObjectWithTag("Player");
    if (player == null)
    {
      Debug.LogError("No GameObject with 'Player' tag in scene.");
      return;
    }
    playerMovement = player.GetComponent<Movement>();
    if (playerMovement == null)
    {
      Debug.LogError("Player exists but does not have a Movement component.");
      return;
    }
  }

  private void FixedUpdate()
  {
    // Get Movement Input Axes 
    float x = Input.GetAxis("Horizontal");
    float y = Input.GetAxis("Vertical");

    Vector3 moveRelativeToCamera = camControl.transform.TransformDirection(new Vector3(x, 0, y));

    // Send inputs 
    playerMovement.Move(moveRelativeToCamera);
  }

  void LateUpdate()
  {
    // Gets Mouse Axes
    float mouseX = Input.GetAxis("Mouse X");
    float mouseY = -Input.GetAxis("Mouse Y"); // Inverted

    // Sends Mouse Axes to Look() method
    camControl.Look(new Vector2(mouseX, mouseY));
  }



 
}


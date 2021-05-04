using UnityEngine;

// Attach to empty GameObject on Scene
// Handles update and communicates to Move and Camera scripts in scene.
public class UserInput : MonoBehaviour
{
  [SerializeField] Movement playerMovement;
  [SerializeField] CameraControl cameraControl;

  private void Awake()
  {
    if (playerMovement == null)
    {
      throw new System.Exception("No player controller found attached to UserInput class");
    }
    if (cameraControl == null)
    {
      throw new System.Exception("No camera controller found attached to UserInput class");
    }
  }

  // For Physics, Player Movement
  void FixedUpdate()
  {
    // Get Movement Input Axes 
    float x = Input.GetAxis("Horizontal");
    float y = Input.GetAxis("Vertical");

    // Send inputs relative to camera
    playerMovement.Move(cameraControl.transform.TransformDirection(new Vector3(x, 0, y)));
    
    // Jump if key is pressed
    if (Input.GetAxis("Jump") > 0) playerMovement.Jump();
  }

  // For Camera
  void LateUpdate()
  {
    float mouseX = Input.GetAxis("Mouse X");
    float mouseY = -Input.GetAxis("Mouse Y");
    float mouseScrollDelta = Input.mouseScrollDelta.y;

    cameraControl.Look(new Vector2(mouseX, mouseY));
    cameraControl.Scroll(mouseScrollDelta);
  }

}
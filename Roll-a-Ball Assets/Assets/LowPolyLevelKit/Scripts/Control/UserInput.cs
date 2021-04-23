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

  // For Physics
  void FixedUpdate()
  {
    float x = Input.GetAxis("Horizontal");
    float y = Input.GetAxis("Vertical");
    playerMovement.Move(cameraControl.transform.InverseTransformDirection(new Vector3(x, 0, y)));
  }

  // For Camera
  void LateUpdate()
  {
    float mouseX = Input.GetAxis("Mouse X");
    float mouseY = -Input.GetAxis("Mouse Y");
    cameraControl.Look(new Vector2(mouseX, mouseY));
  }

}

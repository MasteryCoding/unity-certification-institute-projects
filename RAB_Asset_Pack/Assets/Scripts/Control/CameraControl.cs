using UnityEngine;


// Attach to Camera
// Look is called by UserInput
public class CameraControl : MonoBehaviour
{
  [SerializeField] private float lookSpeed;
  [SerializeField] private float distance;
  private GameObject player;

  private void Awake() {
    player = GameObject.FindGameObjectWithTag("Player");
    if (player == null) {
      throw new System.Exception("No GameObject with player tag in scene.");
    }
  }

  private void Start() {
    Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
  }

  public void Look(Vector2 mouseVector) {
    transform.LookAt(player.transform.position);
    transform.RotateAround(player.transform.position, Vector3.up, mouseVector.x);
    transform.RotateAround(player.transform.position, Vector3.right, mouseVector.y);
  }

}
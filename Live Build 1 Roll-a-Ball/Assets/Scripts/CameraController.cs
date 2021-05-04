using UnityEngine;

public class CameraController : MonoBehaviour
{
  [SerializeField] private float lookSensitivity;
  private Camera cam;
  private GameObject player;
  const float MIN_X_ROT = 0;
  const float MAX_X_ROT = 90;

  private void Awake()
  {
    // Get the Camera in children.
    cam = GetComponentInChildren<Camera>();
    if (cam == null)
    {
      Debug.LogError("No Camera component was found in children.");
      return;
    }

    player = GameObject.FindGameObjectWithTag("Player");
    if (player == null)
    {
      Debug.LogError("No GameObject with 'Player' tag in scene.");
      return;
    }
  }

  private void Start() {
    Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
  }

  private void LateUpdate()
  {
    transform.position = player.transform.position;
    cam.transform.LookAt(player.transform.position);
  }
  
  public void Look(Vector2 mouseVector)
  {
    // Clamp the xRot between MIN and MAX angles
    float xRot = transform.eulerAngles.x + mouseVector.y * lookSensitivity;
    xRot = Mathf.Clamp(xRot, MIN_X_ROT, MAX_X_ROT);

    float yRot = transform.eulerAngles.y + mouseVector.x * lookSensitivity;

    transform.eulerAngles = new Vector3(xRot, yRot, 0);
  }
}

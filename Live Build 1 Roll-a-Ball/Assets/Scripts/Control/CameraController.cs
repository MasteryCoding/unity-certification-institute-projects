using UnityEngine;

public class CameraController : MonoBehaviour
{
  [Header("Control Settings")]
  [SerializeField] private float lookSensitivity;
  [SerializeField] float minX = 10;
  [SerializeField] float maxX = 80;

  [Header("Camera Position")]
  [Range(5f, 20f)]
  [SerializeField] float distance = 15f;

  [Range(1f, 3f)]
  [SerializeField] float height = 4f;

  private Camera cam;
  private GameObject player;

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

  private void AvoidWalls() {
    while (!hasLineOfSight()) {
      cam.transform.localPosition += Vector3.forward * 0.1f;
    }
  }

  // Checks if camera has line of sight to player.
  private bool hasLineOfSight() {
    RaycastHit hitInfo;

    // Raycast towards the player
    bool hit = Physics.Raycast(
      cam.transform.position,
      player.transform.position - cam.transform.position,
      out hitInfo
    );
    
    if (!hit || !hitInfo.transform.CompareTag("Player")) return false;
    return true;
  }

  private void LateUpdate()
  {
    transform.position = player.transform.position;
    cam.transform.LookAt(player.transform.position);
    cam.transform.localPosition = new Vector3(0, height, -distance);
    AvoidWalls();
  }
  
  public void Look(Vector2 mouseVector)
  {
    // Clamp the xRot between MIN and MAX angles
    float xRot = transform.eulerAngles.x + mouseVector.y * lookSensitivity;
    xRot = Mathf.Clamp(xRot, minX, maxX);

    float yRot = transform.eulerAngles.y + mouseVector.x * lookSensitivity;

    transform.eulerAngles = new Vector3(xRot, yRot, 0);
  }
}

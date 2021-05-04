using UnityEngine;

// Attach to Camera
// Look is called by UserInput
public class CameraControl : MonoBehaviour
{
  private const float MIN_X_ROT = 0;
  private const float MAX_X_ROT = 70;

  [SerializeField] private float lookSensitivity;
  [SerializeField] private float scrollSensitivity;
  [SerializeField] private float minOffset = 3;
  [SerializeField] private float maxOffset = 8;
  [SerializeField] private float elevation = 1;

  private GameObject player;
  private Camera cam;

  private void Awake()
  {
    // Get the Camera in children.
    cam = GetComponentInChildren<Camera>();
  }

  private void Start()
  {
    // Hide Cursor
    Cursor.visible = false;
    // Lock Cursor in place
    Cursor.lockState = CursorLockMode.Locked;
  }

  private void Update()
  {
    transform.position = player.transform.position;
    cam.transform.LookAt(player.transform.position);
  }

  public void Look(Vector2 mouseVector)
  {
    float xRot = Mathf.Clamp(transform.eulerAngles.x + mouseVector.y * lookSensitivity, MIN_X_ROT, MAX_X_ROT);
    float yRot = transform.eulerAngles.y + mouseVector.x * lookSensitivity;
    transform.eulerAngles = new Vector3(xRot, yRot, 0);
  }

  public void Scroll(float scroll)
  {
    float cameraOffset = Mathf.Clamp(cam.transform.localPosition.z + scroll, -maxOffset, -minOffset);
    cam.transform.localPosition = new Vector3(0, elevation, cameraOffset);
  }
}
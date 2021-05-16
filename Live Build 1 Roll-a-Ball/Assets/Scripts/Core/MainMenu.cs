using UnityEngine;

public class MainMenu : MonoBehaviour
{

  private void OnEnable() {
    Cursor.visible = true;
    Cursor.lockState = CursorLockMode.Confined;
    Time.timeScale = 0;
  }

  private void OnDisable() {
    Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
    Time.timeScale = 1;
  }
}

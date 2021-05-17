using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  [Header("Menu")]
  public MainMenu menu;
  bool paused = true;

  // Singleton Pattern https://www.tutorialspoint.com/design_pattern/singleton_pattern.htm
  // Allows other scripts to reference a top-level class by setting a static instance of itself.
  public static GameManager gm; // GameManager Singleton
  public static AudioManager am; // Audio Manager Singleton

  private void Awake() {
    if (gm == null) {
      gm = this;
    } else {
      Destroy(gameObject); // If gm already exists, the GO and all its children are deleted.
      return;
    }
    am = GetComponent<AudioManager>(); // Also include reference to AudioManager for easer of access.
    DontDestroyOnLoad(gameObject);
  }
  // End of Singleton Pattern

  public void PlayPause() {
    paused = !paused;
    if (paused) {
      am.Play("Menu");
      menu.gameObject.SetActive(true);
    } else {
      menu.gameObject.SetActive(false);
    }
  }

  public void SelectLevel(string levelName) {
    SceneManager.LoadScene(levelName);
    am.Play("Click");
    PlayPause();
    GetComponentInChildren<Movement>().Respawn();
  }

}

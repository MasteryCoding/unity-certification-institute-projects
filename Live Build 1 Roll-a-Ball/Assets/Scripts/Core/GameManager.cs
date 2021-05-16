using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  [Header("Menu")]
  public MainMenu menu;
  bool paused = true;

  public static GameManager gm;
  public static AudioManager am;

  private void Awake() {
    if (gm == null) {
      gm = this;
    } else {
      Destroy(gameObject);
    }
    am = GetComponent<AudioManager>();
    DontDestroyOnLoad(gameObject);
  }

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

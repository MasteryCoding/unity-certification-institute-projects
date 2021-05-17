using UnityEngine;

public class AudioManager : MonoBehaviour
{
  public Sound[] sounds;

  private void Awake() {
    foreach (Sound s in sounds) {
      s.source = gameObject.AddComponent<AudioSource>();
      s.source.clip = s.clip;
      s.source.volume = s.volume;
      s.source.pitch = s.pitch;
      s.source.loop = s.loop;
    }
  }

  private void Start() {
    Play("Theme"); // Play's background music
  }

  public void Play(string name) {
    // Use linear search to find the sound and play it.
    for (int i = 0; i < sounds.Length; i++)
    {
      if (sounds[i].name == name) sounds[i].source.Play();
    }
  }
}

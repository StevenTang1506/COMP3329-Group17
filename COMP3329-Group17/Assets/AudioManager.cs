using UnityEngine;
namespace Dypsloom.DypThePenguin.Scripts.Game
{
    public class AudioManager : MonoBehaviour
    {
        [Header("Audio Source")]
        [SerializeField] private AudioSource musicSource;
        [SerializeField] private AudioSource soundSource;

        [Header("Audio Clip")]
        public AudioClip background;
        public AudioClip jump;

        private void Start()
        {
            musicSource.clip = background;
            musicSource.Play();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                soundSource.clip = jump;
                soundSource.Play();
            }
        }

        public void PauseAudio()
        {
            musicSource.Pause();
            soundSource.Pause(); // Assuming you want all sounds paused
        }

        public void ResumeAudio()
        {
            musicSource.Play();
            soundSource.UnPause(); // If you want to continue any ongoing sound effects exactly where they left off
        }
    }
}
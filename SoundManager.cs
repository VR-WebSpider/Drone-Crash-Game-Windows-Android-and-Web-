using UnityEngine;
using UnityEngine.EventSystems;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;

    void Update()
    {
        if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) && !IsPointerOverUI())
        {
            PlaySound();
        }
    }

    public void PlaySound()
    {

        if (audioSource != null && audioSource.clip != null)
        {
            audioSource.Play();
        }

    }
    private bool IsPointerOverUI()
    {
        return EventSystem.current != null && EventSystem.current.IsPointerOverGameObject();
    }
}

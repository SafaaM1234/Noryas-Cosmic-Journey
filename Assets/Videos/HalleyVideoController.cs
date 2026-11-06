
using UnityEngine;
using UnityEngine.Video;
using Vuforia;

public class HalleyVideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Renderer videoRenderer;

    private ObserverBehaviour observer;

    void Start()
    {
        observer = GetComponent<ObserverBehaviour>();

        // Cacher l'ecran video au demarrage
        videoRenderer.enabled = false;

        // Attendre la detection de la carte
        observer.OnTargetStatusChanged += OnTargetStatusChanged;
    }

    private void OnTargetStatusChanged(
        ObserverBehaviour behaviour,
        TargetStatus status)
    {
        if (status.Status == Status.TRACKED ||
            status.Status == Status.EXTENDED_TRACKED)
        {
            // Carte detectee
            videoRenderer.enabled = true;
            videoPlayer.Play();
        }
        else
        {
            // Carte perdue
            videoPlayer.Stop();
            videoRenderer.enabled = false;
        }
    }

    private void OnDestroy()
    {
        if (observer != null)
        {
            observer.OnTargetStatusChanged -= OnTargetStatusChanged;
        }
    }
}

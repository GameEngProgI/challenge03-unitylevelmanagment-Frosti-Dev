using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject level01;
    public GameObject level02;
    
    private GameObject currentActiveLevel;

    private GameObject player;

    private void Start()
    {
        player = ServiceHub.Instance.playerController.gameObject;

        currentActiveLevel = level01;

        level01.SetActive(true);
        level02.SetActive(false);
    }

    public void LevelChange(GameObject Level, Transform SpawnPoint)
    {
        currentActiveLevel.SetActive(false);
        currentActiveLevel = Level;
        Level.SetActive(true);
        player.transform.position = SpawnPoint.position;
    }
}

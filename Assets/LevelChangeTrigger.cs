using UnityEngine;

public class LevelChangeTrigger : MonoBehaviour
{
    public LevelManager levelManager;

    private void Start()
    {
       levelManager = ServiceHub.Instance.levelManager;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered level change trigger");

            //change levels

            //ServiceHub.Instance.levelManager.LevelChange(); //(kinda tedious)

            levelManager.LevelChange();
        }
    }
}

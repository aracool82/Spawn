using UnityEngine;

public class DestroyOject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Enemy enemy))
            DisableEnemy(other.gameObject);
    }

    private void DisableEnemy(GameObject enemy)
    {
        enemy.SetActive(false);
    }
}

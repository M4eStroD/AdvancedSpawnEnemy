using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Movement _movement;

    public void Init(Transform target)
    {
        _movement.SetTarget(target);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<Pylon>(out Pylon pylon))
            Destroy(gameObject);
    }
}

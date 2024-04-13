using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Movement _movement;

    public void Init(Transform target)
    {
        _movement.SetDirection(target);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Pylon>() != null)
            Destroy(gameObject);
    }
}

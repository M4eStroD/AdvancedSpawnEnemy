using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;

    private Vector3 _direction;

    public void SetDirection(Transform target)
    {
        _direction = (target.position - transform.position).normalized;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(_direction * _speed * Time.deltaTime);
    }
}

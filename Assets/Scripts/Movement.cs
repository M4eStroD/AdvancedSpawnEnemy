using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;

    private Transform _target;
    private Vector3 _direction;

    public void SetTarget(Transform target)
    {
        _target = target;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _direction = (_target.position - transform.position).normalized;
        transform.Translate(_direction * _speed * Time.deltaTime);
    }
}

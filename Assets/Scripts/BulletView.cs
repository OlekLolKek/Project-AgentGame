using UnityEngine;


namespace DefaultNamespace
{
    public class BulletView : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private float _shotPower = 500.0f;

        private const float DESTROY_TIME = 10.0f;

        public void Shoot(Vector3 direction)
        {
            transform.parent = null;
            _rigidbody.AddForce(transform.up * _shotPower, ForceMode.Impulse);
            Destroy(gameObject, DESTROY_TIME);
        }
    }
}
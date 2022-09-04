using UnityEngine;

namespace valeryHarbatouski
{
    public class WheelRotator : MonoBehaviour
    {
        [SerializeField] private WheelCollider _wheelCollider;
        Vector3 _position;
        Quaternion _rotation;

        private void Update()
        {
            _wheelCollider.GetWorldPose(out _position, out _rotation);
            transform.rotation = _rotation;
        }
    }
}

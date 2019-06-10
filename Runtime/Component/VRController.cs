using UnityEngine;
using UnityEngine.XR;

namespace Knowit.VR.Component
{
    [DisallowMultipleComponent]
    [AddComponentMenu("VR/VR Controller")]
    [RequireComponent(typeof(Rigidbody))]
    public class VRController : VRBehaviour
    {
        public XRNode Input;

        private void Start()
        {
            trackedNode = Input;
        }

        private void Reset()
        {
            GetComponent<Rigidbody>().useGravity = false;
        }

        private void Update()
        {
            var rigidbody = GetComponent<Rigidbody>();
            rigidbody.position = motionState.position;
            rigidbody.angularVelocity = motionState.angularVelocity;
            rigidbody.rotation = motionState.rotation;
            rigidbody.velocity = motionState.velocity;
            rigidbody.angularVelocity = motionState.angularVelocity;
        }
    }
}


using UnityEngine;
using UnityEngine.XR;

namespace Knowit.VR.Input
{
    public class VRMotionState
    {
        private XRNodeState _state;

        public VRMotionState(XRNodeState state)
        {
            _state = state;
        }

        public Vector3 position => _state.TryGetPosition(out var pos) ? pos : Vector3.zero;
        public Quaternion rotation => _state.TryGetRotation(out var rot) ? rot : Quaternion.identity;
        public Vector3 velocity => _state.TryGetVelocity(out var vel) ? vel : Vector3.zero;
        public Vector3 acceleration => _state.TryGetAcceleration(out var acc) ? acc : Vector3.zero;
        public Vector3 angularAcceleration => _state.TryGetAngularAcceleration(out var acc) ? acc : Vector3.zero;
        public Vector3 angularVelocity => _state.TryGetAngularVelocity(out var vel) ? vel : Vector3.zero;

    }
}

using UnityEngine;
using UnityEngine.XR;

namespace Knowit.VR.Input
{
    public class VRInputTracker : MonoBehaviour
    {
        [HideInInspector]
        public XRNode Node = XRNode.GameController;

        public VRInputState trackedDevice => new VRInputState(InputDevices.GetDeviceAtXRNode(Node));
    }
}
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR;
using Knowit.VR.Input;

namespace Knowit.VR
{
    [RequireComponent(typeof(VRMotionTracker), typeof(VRInputTracker))]
    public abstract class VRBehaviour : MonoBehaviour
    {
        [SerializeField]
        public XRNode trackedNode
        {
            set
            {
                GetComponent<VRInputTracker>().Node = value;
                GetComponent<VRMotionTracker>().Node = value;
            }
        }

        public VRMotionTracker motionTracker => GetComponent<VRMotionTracker>();
        public VRInputTracker inputTracker => GetComponent<VRInputTracker>();

        public VRMotionState motionState => motionTracker.trackedDevice;
        public VRInputState inputState => inputTracker.trackedDevice;
    }
}



using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR;

namespace Knowit.VR.Input
{
    public class VRMotionTracker : MonoBehaviour
    {
        [HideInInspector]
        public XRNode Node = XRNode.GameController;


        public VRMotionState trackedDevice
        {
            get
            {
                var nodeStates = new List<XRNodeState>();
                InputTracking.GetNodeStates(nodeStates);
                return new VRMotionState(nodeStates.SingleOrDefault(x => x.tracked && x.nodeType == Node));
            }
        }

        public void Recenter() =>
            InputTracking.Recenter();

    }
}
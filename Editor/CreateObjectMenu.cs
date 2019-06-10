using System;
using Knowit.VR;
using Knowit.VR.Component;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR;

namespace Knowit.VR.Editor 
{
    public static class CreateObjectMenu
    {
        [MenuItem("GameObject/VR/Player", false, 0)]
        public static GameObject CreateVRPlayer()
        {
            var mainGameObject = new GameObject("Player", typeof(VRPlayer));
            mainGameObject.tag = "Player";

            var cameraGameObject = new GameObject("Camera", typeof(VRCameraControl));
            cameraGameObject.transform.SetParent(mainGameObject.transform);
            cameraGameObject.tag = "MainCamera";

            var leftHandGameObject = new GameObject("Left Hand", typeof(VRController));
            leftHandGameObject.GetComponent<VRController>().Input = XRNode.LeftHand;
            leftHandGameObject.transform.SetParent(mainGameObject.transform);

            var rightHandGameObject = new GameObject("Right Hand", typeof(VRController));
            rightHandGameObject.GetComponent<VRController>().Input = XRNode.RightHand;
            rightHandGameObject.transform.SetParent(mainGameObject.transform);

            return mainGameObject;
        }
    }
}


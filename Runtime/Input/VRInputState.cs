using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

namespace Knowit.VR.Input
{
    public enum VRButton
    {
        Trigger, Menu, Grip, Primary, Secondary
    }

    public enum VRAxis
    {
        Primary, Secondary
    }

    public class VRInputState
    {
        private InputDevice _inputDevice;

        private readonly Dictionary<VRButton, InputFeatureUsage<bool>> ButtonMap =
            new Dictionary<VRButton, InputFeatureUsage<bool>>
            {
                {VRButton.Trigger, CommonUsages.triggerButton},
                {VRButton.Menu, CommonUsages.menuButton},
                {VRButton.Grip, CommonUsages.gripButton},
                {VRButton.Primary, CommonUsages.primaryButton},
                {VRButton.Secondary, CommonUsages.secondaryButton}
            };

        private readonly Dictionary<VRAxis, InputFeatureUsage<Vector2>> AxisMap =
            new Dictionary<VRAxis, InputFeatureUsage<Vector2>>
            {
                {VRAxis.Primary, CommonUsages.primary2DAxis},
                {VRAxis.Secondary, CommonUsages.secondary2DAxis}
            };


        public VRInputState(InputDevice inputDevice)
        {
            _inputDevice = inputDevice;
        }

        public bool GetButton(VRButton button) => _inputDevice.TryGetFeatureValue(ButtonMap[button], out var state) ? state : false;

        public Vector2 GetAxis(VRAxis axis) => _inputDevice.TryGetFeatureValue(AxisMap[axis], out var val) ? val : Vector2.zero;
    }
}

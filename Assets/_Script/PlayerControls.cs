//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/_Script/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""VR"",
            ""id"": ""fa31024a-c3ea-4f81-a3d8-57239ace8853"",
            ""actions"": [
                {
                    ""name"": ""Left_Grip"",
                    ""type"": ""Button"",
                    ""id"": ""07f99a56-9410-40f1-b0e7-77e675d627ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Right_Grip"",
                    ""type"": ""Button"",
                    ""id"": ""3ef120c9-e628-42cc-83f9-cbb0296cd603"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Left_Gas"",
                    ""type"": ""Button"",
                    ""id"": ""2858d25d-df05-4e5d-8822-2d4430ae2620"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Right_Gas"",
                    ""type"": ""Button"",
                    ""id"": ""f71c3309-681d-4939-b3d2-3100b81b9a6c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Break"",
                    ""type"": ""Button"",
                    ""id"": ""53205ad5-7a07-4635-825c-785c81bbbd5f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""L_X"",
                    ""type"": ""Button"",
                    ""id"": ""7e1de6a7-6adb-4908-b92a-5ecfad08df32"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2eebe9a3-3213-417b-abd8-466222c0691c"",
                    ""path"": ""<OculusTouchController>{LeftHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left_Grip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0a14cd6-adcc-4162-b595-a74f24b0a5e4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left_Grip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""141964c5-1bac-46a4-99de-14a26c38257d"",
                    ""path"": ""<OculusTouchController>{LeftHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left_Gas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef3af4b5-6f8e-479e-a9e0-7ec27f8a9767"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left_Gas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8342603-2810-456c-a98d-bba7bd2278ce"",
                    ""path"": ""<OculusTouchController>/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Break"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6da3077a-6f23-47d7-8177-846424401013"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Break"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dcf15b71-479f-4fa8-9322-770f85be13fb"",
                    ""path"": ""<OculusTouchController>/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L_X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78a4799d-710f-476d-bd5a-74730f878676"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L_X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9063c5cf-955a-4894-a4a6-70a01de6e2c3"",
                    ""path"": ""<OculusTouchController>{RightHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right_Grip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f70bf720-1aeb-433a-9b8b-066f55ad823c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right_Grip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64f22217-1197-433c-bd50-21fe3df4f58f"",
                    ""path"": ""<OculusTouchController>{RightHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right_Gas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf1691ba-0a4f-4829-8bb4-cc80a7eb23f6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right_Gas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""id"": ""b57964dd-d2f7-422c-a30e-6cfd46636a3e"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""c6155e95-5bd2-4aaa-bf6c-a1d70d812992"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""540840f3-d542-4140-b0ff-07c03674ec32"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""e8d8e5e5-ad8a-4d88-a8a8-9cbfc2f73132"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""edffdbcf-4b07-4c95-bc46-2decb83c4e13"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""9d9eefe4-ecdb-420e-af2c-c0b3dd4cde28"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""bf97bc61-227c-4e14-b4ae-a443b710b35f"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""3f9334d4-21df-490a-838b-60de7710468f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2c2d9dbc-b3a2-4349-9026-e78edcca08a1"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""082ab0c7-ade9-4ecf-94b3-feb9729708db"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""eb790753-6c71-44bc-8a03-e4c54e9f5d91"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c72c4024-c777-4d00-99e2-6371fbe22475"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // VR
        m_VR = asset.FindActionMap("VR", throwIfNotFound: true);
        m_VR_Left_Grip = m_VR.FindAction("Left_Grip", throwIfNotFound: true);
        m_VR_Right_Grip = m_VR.FindAction("Right_Grip", throwIfNotFound: true);
        m_VR_Left_Gas = m_VR.FindAction("Left_Gas", throwIfNotFound: true);
        m_VR_Right_Gas = m_VR.FindAction("Right_Gas", throwIfNotFound: true);
        m_VR_Break = m_VR.FindAction("Break", throwIfNotFound: true);
        m_VR_L_X = m_VR.FindAction("L_X", throwIfNotFound: true);
        // Keyboard
        m_Keyboard = asset.FindActionMap("Keyboard", throwIfNotFound: true);
        m_Keyboard_Move = m_Keyboard.FindAction("Move", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // VR
    private readonly InputActionMap m_VR;
    private IVRActions m_VRActionsCallbackInterface;
    private readonly InputAction m_VR_Left_Grip;
    private readonly InputAction m_VR_Right_Grip;
    private readonly InputAction m_VR_Left_Gas;
    private readonly InputAction m_VR_Right_Gas;
    private readonly InputAction m_VR_Break;
    private readonly InputAction m_VR_L_X;
    public struct VRActions
    {
        private @PlayerControls m_Wrapper;
        public VRActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Left_Grip => m_Wrapper.m_VR_Left_Grip;
        public InputAction @Right_Grip => m_Wrapper.m_VR_Right_Grip;
        public InputAction @Left_Gas => m_Wrapper.m_VR_Left_Gas;
        public InputAction @Right_Gas => m_Wrapper.m_VR_Right_Gas;
        public InputAction @Break => m_Wrapper.m_VR_Break;
        public InputAction @L_X => m_Wrapper.m_VR_L_X;
        public InputActionMap Get() { return m_Wrapper.m_VR; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VRActions set) { return set.Get(); }
        public void SetCallbacks(IVRActions instance)
        {
            if (m_Wrapper.m_VRActionsCallbackInterface != null)
            {
                @Left_Grip.started -= m_Wrapper.m_VRActionsCallbackInterface.OnLeft_Grip;
                @Left_Grip.performed -= m_Wrapper.m_VRActionsCallbackInterface.OnLeft_Grip;
                @Left_Grip.canceled -= m_Wrapper.m_VRActionsCallbackInterface.OnLeft_Grip;
                @Right_Grip.started -= m_Wrapper.m_VRActionsCallbackInterface.OnRight_Grip;
                @Right_Grip.performed -= m_Wrapper.m_VRActionsCallbackInterface.OnRight_Grip;
                @Right_Grip.canceled -= m_Wrapper.m_VRActionsCallbackInterface.OnRight_Grip;
                @Left_Gas.started -= m_Wrapper.m_VRActionsCallbackInterface.OnLeft_Gas;
                @Left_Gas.performed -= m_Wrapper.m_VRActionsCallbackInterface.OnLeft_Gas;
                @Left_Gas.canceled -= m_Wrapper.m_VRActionsCallbackInterface.OnLeft_Gas;
                @Right_Gas.started -= m_Wrapper.m_VRActionsCallbackInterface.OnRight_Gas;
                @Right_Gas.performed -= m_Wrapper.m_VRActionsCallbackInterface.OnRight_Gas;
                @Right_Gas.canceled -= m_Wrapper.m_VRActionsCallbackInterface.OnRight_Gas;
                @Break.started -= m_Wrapper.m_VRActionsCallbackInterface.OnBreak;
                @Break.performed -= m_Wrapper.m_VRActionsCallbackInterface.OnBreak;
                @Break.canceled -= m_Wrapper.m_VRActionsCallbackInterface.OnBreak;
                @L_X.started -= m_Wrapper.m_VRActionsCallbackInterface.OnL_X;
                @L_X.performed -= m_Wrapper.m_VRActionsCallbackInterface.OnL_X;
                @L_X.canceled -= m_Wrapper.m_VRActionsCallbackInterface.OnL_X;
            }
            m_Wrapper.m_VRActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Left_Grip.started += instance.OnLeft_Grip;
                @Left_Grip.performed += instance.OnLeft_Grip;
                @Left_Grip.canceled += instance.OnLeft_Grip;
                @Right_Grip.started += instance.OnRight_Grip;
                @Right_Grip.performed += instance.OnRight_Grip;
                @Right_Grip.canceled += instance.OnRight_Grip;
                @Left_Gas.started += instance.OnLeft_Gas;
                @Left_Gas.performed += instance.OnLeft_Gas;
                @Left_Gas.canceled += instance.OnLeft_Gas;
                @Right_Gas.started += instance.OnRight_Gas;
                @Right_Gas.performed += instance.OnRight_Gas;
                @Right_Gas.canceled += instance.OnRight_Gas;
                @Break.started += instance.OnBreak;
                @Break.performed += instance.OnBreak;
                @Break.canceled += instance.OnBreak;
                @L_X.started += instance.OnL_X;
                @L_X.performed += instance.OnL_X;
                @L_X.canceled += instance.OnL_X;
            }
        }
    }
    public VRActions @VR => new VRActions(this);

    // Keyboard
    private readonly InputActionMap m_Keyboard;
    private IKeyboardActions m_KeyboardActionsCallbackInterface;
    private readonly InputAction m_Keyboard_Move;
    public struct KeyboardActions
    {
        private @PlayerControls m_Wrapper;
        public KeyboardActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Keyboard_Move;
        public InputActionMap Get() { return m_Wrapper.m_Keyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardActions instance)
        {
            if (m_Wrapper.m_KeyboardActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_KeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public KeyboardActions @Keyboard => new KeyboardActions(this);
    public interface IVRActions
    {
        void OnLeft_Grip(InputAction.CallbackContext context);
        void OnRight_Grip(InputAction.CallbackContext context);
        void OnLeft_Gas(InputAction.CallbackContext context);
        void OnRight_Gas(InputAction.CallbackContext context);
        void OnBreak(InputAction.CallbackContext context);
        void OnL_X(InputAction.CallbackContext context);
    }
    public interface IKeyboardActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}

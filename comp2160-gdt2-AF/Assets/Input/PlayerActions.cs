//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Input/PlayerActions.inputactions
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

public partial class @PlayerActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""Moving"",
            ""id"": ""4134a4e1-d693-4070-9187-f137f2851b0a"",
            ""actions"": [
                {
                    ""name"": ""movement"",
                    ""type"": ""Value"",
                    ""id"": ""9f01cba2-6cf3-4944-9e37-20e0fc5edf12"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""running"",
                    ""type"": ""Button"",
                    ""id"": ""b3cfab6c-63b3-4672-aed7-b35af29afdc6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""fa9cbf7b-012f-4a86-b372-8ecdd05c2c4c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""63840216-054d-4edd-84c5-c183e9311e50"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e13814c6-480d-45c6-bff5-3f0436175077"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bc12db24-82e9-41d6-aec4-87399b113e7f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6197633d-6c90-420e-90e7-c30a2670fce7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8b598b3c-478b-44bf-8fdc-00b0931dabdf"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""running"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""kick"",
            ""id"": ""49a3292c-6d38-4a59-a4fd-c2bb624d1c50"",
            ""actions"": [
                {
                    ""name"": ""Kick"",
                    ""type"": ""Button"",
                    ""id"": ""627e5e9d-94f6-4230-b3d2-f99f0fe48939"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Grab"",
                    ""type"": ""Button"",
                    ""id"": ""0e4a023d-a7e3-4556-a7ef-38efe9b2858c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""92309b0b-30a8-4b4d-be8a-5a43f2b0bd68"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Kick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""897b0de3-99cc-445a-a918-a6c02782639a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Moving
        m_Moving = asset.FindActionMap("Moving", throwIfNotFound: true);
        m_Moving_movement = m_Moving.FindAction("movement", throwIfNotFound: true);
        m_Moving_running = m_Moving.FindAction("running", throwIfNotFound: true);
        // kick
        m_kick = asset.FindActionMap("kick", throwIfNotFound: true);
        m_kick_Kick = m_kick.FindAction("Kick", throwIfNotFound: true);
        m_kick_Grab = m_kick.FindAction("Grab", throwIfNotFound: true);
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

    // Moving
    private readonly InputActionMap m_Moving;
    private IMovingActions m_MovingActionsCallbackInterface;
    private readonly InputAction m_Moving_movement;
    private readonly InputAction m_Moving_running;
    public struct MovingActions
    {
        private @PlayerActions m_Wrapper;
        public MovingActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @movement => m_Wrapper.m_Moving_movement;
        public InputAction @running => m_Wrapper.m_Moving_running;
        public InputActionMap Get() { return m_Wrapper.m_Moving; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovingActions set) { return set.Get(); }
        public void SetCallbacks(IMovingActions instance)
        {
            if (m_Wrapper.m_MovingActionsCallbackInterface != null)
            {
                @movement.started -= m_Wrapper.m_MovingActionsCallbackInterface.OnMovement;
                @movement.performed -= m_Wrapper.m_MovingActionsCallbackInterface.OnMovement;
                @movement.canceled -= m_Wrapper.m_MovingActionsCallbackInterface.OnMovement;
                @running.started -= m_Wrapper.m_MovingActionsCallbackInterface.OnRunning;
                @running.performed -= m_Wrapper.m_MovingActionsCallbackInterface.OnRunning;
                @running.canceled -= m_Wrapper.m_MovingActionsCallbackInterface.OnRunning;
            }
            m_Wrapper.m_MovingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @movement.started += instance.OnMovement;
                @movement.performed += instance.OnMovement;
                @movement.canceled += instance.OnMovement;
                @running.started += instance.OnRunning;
                @running.performed += instance.OnRunning;
                @running.canceled += instance.OnRunning;
            }
        }
    }
    public MovingActions @Moving => new MovingActions(this);

    // kick
    private readonly InputActionMap m_kick;
    private IKickActions m_KickActionsCallbackInterface;
    private readonly InputAction m_kick_Kick;
    private readonly InputAction m_kick_Grab;
    public struct KickActions
    {
        private @PlayerActions m_Wrapper;
        public KickActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Kick => m_Wrapper.m_kick_Kick;
        public InputAction @Grab => m_Wrapper.m_kick_Grab;
        public InputActionMap Get() { return m_Wrapper.m_kick; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KickActions set) { return set.Get(); }
        public void SetCallbacks(IKickActions instance)
        {
            if (m_Wrapper.m_KickActionsCallbackInterface != null)
            {
                @Kick.started -= m_Wrapper.m_KickActionsCallbackInterface.OnKick;
                @Kick.performed -= m_Wrapper.m_KickActionsCallbackInterface.OnKick;
                @Kick.canceled -= m_Wrapper.m_KickActionsCallbackInterface.OnKick;
                @Grab.started -= m_Wrapper.m_KickActionsCallbackInterface.OnGrab;
                @Grab.performed -= m_Wrapper.m_KickActionsCallbackInterface.OnGrab;
                @Grab.canceled -= m_Wrapper.m_KickActionsCallbackInterface.OnGrab;
            }
            m_Wrapper.m_KickActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Kick.started += instance.OnKick;
                @Kick.performed += instance.OnKick;
                @Kick.canceled += instance.OnKick;
                @Grab.started += instance.OnGrab;
                @Grab.performed += instance.OnGrab;
                @Grab.canceled += instance.OnGrab;
            }
        }
    }
    public KickActions @kick => new KickActions(this);
    public interface IMovingActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnRunning(InputAction.CallbackContext context);
    }
    public interface IKickActions
    {
        void OnKick(InputAction.CallbackContext context);
        void OnGrab(InputAction.CallbackContext context);
    }
}

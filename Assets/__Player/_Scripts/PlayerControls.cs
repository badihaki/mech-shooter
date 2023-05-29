//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/__Player/_Scripts/PlayerControls.inputactions
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
            ""name"": ""Mecha"",
            ""id"": ""1ca6b6f8-d69e-4f2d-bc38-611d98c91307"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""a5bd7f2d-d80d-43ff-95bd-a660bc11b517"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""50af537c-2e81-48ea-9ae3-3dfce6bd05f2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Special"",
                    ""type"": ""Button"",
                    ""id"": ""52175838-0ed8-493e-8f8b-ebd61960604e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""13fc6f91-7121-496d-9ebe-bdfef95e57e8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d47d42f6-46e4-4b1c-9c6c-c55330eb5d5a"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2,ScaleVector2"",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""c3a767f1-f800-42da-bad5-57a7d62240f6"",
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
                    ""id"": ""01ed55e9-a720-4ded-8411-f42956a71e61"",
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
                    ""id"": ""57119603-c7b5-49af-be67-c66a01680979"",
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
                    ""id"": ""7d09012b-936c-409c-a2e9-c4629dace8c7"",
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
                    ""id"": ""35ece6d9-640f-4d3f-bba6-11db7014dafc"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""33c1d722-0a9b-4464-9940-b5bff4542abd"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c97ffdd1-ba94-4dab-b438-eec0af556c0f"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2657a549-387a-4e3b-a4f6-0dbe0e9e63a7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c07f75cd-fb58-419e-895c-71dcf0168bb9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e26c1482-257c-4907-b053-60e9872ebf07"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70cfe1be-9a37-4817-a214-f8a27bae90a8"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Mecha
        m_Mecha = asset.FindActionMap("Mecha", throwIfNotFound: true);
        m_Mecha_Move = m_Mecha.FindAction("Move", throwIfNotFound: true);
        m_Mecha_Attack = m_Mecha.FindAction("Attack", throwIfNotFound: true);
        m_Mecha_Special = m_Mecha.FindAction("Special", throwIfNotFound: true);
        m_Mecha_Pause = m_Mecha.FindAction("Pause", throwIfNotFound: true);
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

    // Mecha
    private readonly InputActionMap m_Mecha;
    private IMechaActions m_MechaActionsCallbackInterface;
    private readonly InputAction m_Mecha_Move;
    private readonly InputAction m_Mecha_Attack;
    private readonly InputAction m_Mecha_Special;
    private readonly InputAction m_Mecha_Pause;
    public struct MechaActions
    {
        private @PlayerControls m_Wrapper;
        public MechaActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Mecha_Move;
        public InputAction @Attack => m_Wrapper.m_Mecha_Attack;
        public InputAction @Special => m_Wrapper.m_Mecha_Special;
        public InputAction @Pause => m_Wrapper.m_Mecha_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Mecha; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MechaActions set) { return set.Get(); }
        public void SetCallbacks(IMechaActions instance)
        {
            if (m_Wrapper.m_MechaActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MechaActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MechaActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MechaActionsCallbackInterface.OnMove;
                @Attack.started -= m_Wrapper.m_MechaActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_MechaActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_MechaActionsCallbackInterface.OnAttack;
                @Special.started -= m_Wrapper.m_MechaActionsCallbackInterface.OnSpecial;
                @Special.performed -= m_Wrapper.m_MechaActionsCallbackInterface.OnSpecial;
                @Special.canceled -= m_Wrapper.m_MechaActionsCallbackInterface.OnSpecial;
                @Pause.started -= m_Wrapper.m_MechaActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_MechaActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_MechaActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_MechaActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Special.started += instance.OnSpecial;
                @Special.performed += instance.OnSpecial;
                @Special.canceled += instance.OnSpecial;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public MechaActions @Mecha => new MechaActions(this);
    public interface IMechaActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnSpecial(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}

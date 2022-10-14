//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/InputManager.inputactions
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

public partial class @InputManager : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputManager"",
    ""maps"": [
        {
            ""name"": ""Default"",
            ""id"": ""a70141c8-702f-4944-9960-14206650b233"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""ce621adc-b7ac-490c-b143-637305a28421"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Button"",
                    ""id"": ""790a7892-3f46-4fc9-a9c6-d5c03fe5d796"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FlipCamera"",
                    ""type"": ""Button"",
                    ""id"": ""0ee94676-abb9-4901-88ce-0e300b324f25"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""df16c8f0-98b2-48f1-88e0-34b6b81da75a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2c7b9f6f-4461-4eef-8d31-76da9a353cfa"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""45b0cf5b-de92-4262-9814-800dfeae434a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5a1f4e90-d79c-48ee-9fbc-2238cf8f2fe3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3ec1f250-1a70-4ee3-8419-77b54faa5d14"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""23c10c27-1a9c-45b0-9799-68325ed98214"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d22902d-9ddc-4c58-8114-d5b515cc802b"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Celeste"",
            ""id"": ""57795ece-d5b3-4e9e-b1b3-076682996471"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""25aecbaf-e99a-4bbe-9581-c441cf6a47d3"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""62f95c63-6aa3-48d1-a1ab-63c9a1d4381c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""34c9f690-ae95-4d0d-b846-63dd3030e38c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""HorizontalMov"",
                    ""id"": ""67df805d-74b1-44db-8793-ec646be10f33"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f190da07-7f79-4370-9270-5f519e31e30d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f1b6b5d3-1b1d-4322-b1ce-d5d9dbb2e325"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow"",
                    ""id"": ""26eca002-768f-41e4-ad37-8d15da57f6b5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""de6aa792-5439-452f-84fd-a4297b8b1098"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""81791d79-6298-42e8-ad03-1e75d1d9cfb8"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""146ef98c-1ba8-48f2-91ab-1d87bb5b4559"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94a5b745-e2e0-4b51-8cf0-a6960e2e7a4a"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Default
        m_Default = asset.FindActionMap("Default", throwIfNotFound: true);
        m_Default_Movement = m_Default.FindAction("Movement", throwIfNotFound: true);
        m_Default_Accelerate = m_Default.FindAction("Accelerate", throwIfNotFound: true);
        m_Default_FlipCamera = m_Default.FindAction("FlipCamera", throwIfNotFound: true);
        // Celeste
        m_Celeste = asset.FindActionMap("Celeste", throwIfNotFound: true);
        m_Celeste_Walk = m_Celeste.FindAction("Walk", throwIfNotFound: true);
        m_Celeste_Jump = m_Celeste.FindAction("Jump", throwIfNotFound: true);
        m_Celeste_Dash = m_Celeste.FindAction("Dash", throwIfNotFound: true);
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

    // Default
    private readonly InputActionMap m_Default;
    private IDefaultActions m_DefaultActionsCallbackInterface;
    private readonly InputAction m_Default_Movement;
    private readonly InputAction m_Default_Accelerate;
    private readonly InputAction m_Default_FlipCamera;
    public struct DefaultActions
    {
        private @InputManager m_Wrapper;
        public DefaultActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Default_Movement;
        public InputAction @Accelerate => m_Wrapper.m_Default_Accelerate;
        public InputAction @FlipCamera => m_Wrapper.m_Default_FlipCamera;
        public InputActionMap Get() { return m_Wrapper.m_Default; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
        public void SetCallbacks(IDefaultActions instance)
        {
            if (m_Wrapper.m_DefaultActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMovement;
                @Accelerate.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnAccelerate;
                @FlipCamera.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnFlipCamera;
                @FlipCamera.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnFlipCamera;
                @FlipCamera.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnFlipCamera;
            }
            m_Wrapper.m_DefaultActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
                @FlipCamera.started += instance.OnFlipCamera;
                @FlipCamera.performed += instance.OnFlipCamera;
                @FlipCamera.canceled += instance.OnFlipCamera;
            }
        }
    }
    public DefaultActions @Default => new DefaultActions(this);

    // Celeste
    private readonly InputActionMap m_Celeste;
    private ICelesteActions m_CelesteActionsCallbackInterface;
    private readonly InputAction m_Celeste_Walk;
    private readonly InputAction m_Celeste_Jump;
    private readonly InputAction m_Celeste_Dash;
    public struct CelesteActions
    {
        private @InputManager m_Wrapper;
        public CelesteActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_Celeste_Walk;
        public InputAction @Jump => m_Wrapper.m_Celeste_Jump;
        public InputAction @Dash => m_Wrapper.m_Celeste_Dash;
        public InputActionMap Get() { return m_Wrapper.m_Celeste; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CelesteActions set) { return set.Get(); }
        public void SetCallbacks(ICelesteActions instance)
        {
            if (m_Wrapper.m_CelesteActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_CelesteActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_CelesteActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_CelesteActionsCallbackInterface.OnWalk;
                @Jump.started -= m_Wrapper.m_CelesteActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CelesteActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CelesteActionsCallbackInterface.OnJump;
                @Dash.started -= m_Wrapper.m_CelesteActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_CelesteActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_CelesteActionsCallbackInterface.OnDash;
            }
            m_Wrapper.m_CelesteActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
            }
        }
    }
    public CelesteActions @Celeste => new CelesteActions(this);
    public interface IDefaultActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnAccelerate(InputAction.CallbackContext context);
        void OnFlipCamera(InputAction.CallbackContext context);
    }
    public interface ICelesteActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
    }
}
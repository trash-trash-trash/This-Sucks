//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Prefabs/PlayerControls.inputactions
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
            ""name"": ""MainMenu"",
            ""id"": ""d4a02f5d-f109-4736-b032-0cf9b5b1bcda"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""e8451242-e5b0-4b90-88a4-9dfc44910e6b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""402bb349-1d0a-4689-b661-bf67e4dfe367"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""InGame"",
            ""id"": ""448294eb-2d09-4d5a-9aa7-5494fbef0b31"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""12f2362b-aaf1-450c-9da0-9810ed7ea694"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""341cc1ea-078b-403c-8190-6bba54f3345a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Trick 1"",
                    ""type"": ""Button"",
                    ""id"": ""3ae4a57d-bbf3-46e8-807d-c6780dfc0a34"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Trick 2"",
                    ""type"": ""Button"",
                    ""id"": ""d154f05e-147a-4f04-94e5-5c05cdb6dffd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""895d24bd-840f-4c67-871d-659b526f4a5d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""da12a7ce-961a-45b7-af75-92bdafd647be"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""25c28d2e-d0ae-442c-9fc3-1a8d014f7956"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d629df42-09ec-43e8-82dd-218ebb6f2404"",
                    ""path"": ""<SwitchProControllerHID>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4bc41c97-9c27-4120-b1ce-2e76b0e664ad"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""45bc5634-223f-47dd-a05a-87da47c1abc3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2911a882-7aec-4824-b4df-e9ef176920cb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""24e05f87-d734-4fbe-b257-47c7429eda94"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3f8cfc9d-4dab-42bf-b6db-fcb646da018c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9da752e2-4ab5-4501-8458-46a05bb5fa2f"",
                    ""path"": ""<Keyboard>/D"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1a1a1275-d3bb-4cda-bc4c-de932df16a65"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bb3abf3e-688f-44c8-9a55-3bf074ef3178"",
                    ""path"": ""<SwitchProControllerHID>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e5d616a-9f58-45ec-a7df-26cab5d14b3d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90e2edb6-18e6-470f-a1c5-170d7e92e662"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Trick 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f9f7dc8-5fd1-4a62-bbff-e9de6a4fceee"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Trick 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MainMenu
        m_MainMenu = asset.FindActionMap("MainMenu", throwIfNotFound: true);
        m_MainMenu_Newaction = m_MainMenu.FindAction("New action", throwIfNotFound: true);
        // InGame
        m_InGame = asset.FindActionMap("InGame", throwIfNotFound: true);
        m_InGame_Newaction = m_InGame.FindAction("New action", throwIfNotFound: true);
        m_InGame_Jump = m_InGame.FindAction("Jump", throwIfNotFound: true);
        m_InGame_Trick1 = m_InGame.FindAction("Trick 1", throwIfNotFound: true);
        m_InGame_Trick2 = m_InGame.FindAction("Trick 2", throwIfNotFound: true);
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

    // MainMenu
    private readonly InputActionMap m_MainMenu;
    private IMainMenuActions m_MainMenuActionsCallbackInterface;
    private readonly InputAction m_MainMenu_Newaction;
    public struct MainMenuActions
    {
        private @PlayerControls m_Wrapper;
        public MainMenuActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_MainMenu_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_MainMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainMenuActions set) { return set.Get(); }
        public void SetCallbacks(IMainMenuActions instance)
        {
            if (m_Wrapper.m_MainMenuActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_MainMenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public MainMenuActions @MainMenu => new MainMenuActions(this);

    // InGame
    private readonly InputActionMap m_InGame;
    private IInGameActions m_InGameActionsCallbackInterface;
    private readonly InputAction m_InGame_Newaction;
    private readonly InputAction m_InGame_Jump;
    private readonly InputAction m_InGame_Trick1;
    private readonly InputAction m_InGame_Trick2;
    public struct InGameActions
    {
        private @PlayerControls m_Wrapper;
        public InGameActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_InGame_Newaction;
        public InputAction @Jump => m_Wrapper.m_InGame_Jump;
        public InputAction @Trick1 => m_Wrapper.m_InGame_Trick1;
        public InputAction @Trick2 => m_Wrapper.m_InGame_Trick2;
        public InputActionMap Get() { return m_Wrapper.m_InGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InGameActions set) { return set.Get(); }
        public void SetCallbacks(IInGameActions instance)
        {
            if (m_Wrapper.m_InGameActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnNewaction;
                @Jump.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnJump;
                @Trick1.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnTrick1;
                @Trick1.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnTrick1;
                @Trick1.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnTrick1;
                @Trick2.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnTrick2;
                @Trick2.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnTrick2;
                @Trick2.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnTrick2;
            }
            m_Wrapper.m_InGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Trick1.started += instance.OnTrick1;
                @Trick1.performed += instance.OnTrick1;
                @Trick1.canceled += instance.OnTrick1;
                @Trick2.started += instance.OnTrick2;
                @Trick2.performed += instance.OnTrick2;
                @Trick2.canceled += instance.OnTrick2;
            }
        }
    }
    public InGameActions @InGame => new InGameActions(this);
    public interface IMainMenuActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface IInGameActions
    {
        void OnNewaction(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnTrick1(InputAction.CallbackContext context);
        void OnTrick2(InputAction.CallbackContext context);
    }
}

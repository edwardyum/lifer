﻿#pragma checksum "C:\Users\e.yumagulov\Desktop\системы\lifen\lifen\pages\Lists.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F2BB75D17F3D4590E959F2D488C04AD73AD01B376E7B173FEFB35ECB92CF85A9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lifen
{
    partial class BlankPage1 : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Shapes_Shape_Fill(global::Windows.UI.Xaml.Shapes.Shape obj, global::Windows.UI.Xaml.Media.Brush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.Brush) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Brush), targetNullValue);
                }
                obj.Fill = value;
            }
            public static void Set_Windows_UI_Xaml_Automation_AutomationProperties_Name(global::Windows.UI.Xaml.DependencyObject obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                global::Windows.UI.Xaml.Automation.AutomationProperties.SetName(obj, value);
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class BlankPage1_obj3_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IBlankPage1_Bindings
        {
            private global::Windows.UI.Xaml.Media.SolidColorBrush dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj3;
            private global::Windows.UI.Xaml.Shapes.Rectangle obj4;
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj3NameDisabled = false;
            private static bool isobj4FillDisabled = false;
            private static bool isobj5TextDisabled = false;

            public BlankPage1_obj3_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 24 && columnNumber == 54)
                {
                    isobj3NameDisabled = true;
                }
                else if (lineNumber == 25 && columnNumber == 55)
                {
                    isobj4FillDisabled = true;
                }
                else if (lineNumber == 26 && columnNumber == 32)
                {
                    isobj5TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // pages\Lists.xaml line 24
                        this.obj3 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.StackPanel)target);
                        break;
                    case 4: // pages\Lists.xaml line 25
                        this.obj4 = (global::Windows.UI.Xaml.Shapes.Rectangle)target;
                        break;
                    case 5: // pages\Lists.xaml line 26
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj3.Target as global::Windows.UI.Xaml.Controls.StackPanel).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::Windows.UI.Xaml.Media.SolidColorBrush) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IBlankPage1_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Windows.UI.Xaml.Media.SolidColorBrush)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Windows.UI.Xaml.Media.SolidColorBrush obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Color(obj.Color, phase);
                    }
                }
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // pages\Lists.xaml line 25
                    if (!isobj4FillDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Shapes_Shape_Fill(this.obj4, obj, null);
                    }
                }
            }
            private void Update_Color(global::Windows.UI.Color obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // pages\Lists.xaml line 24
                    if (!isobj3NameDisabled)
                    {
                        if ((this.obj3.Target as global::Windows.UI.Xaml.Controls.StackPanel) != null)
                        {
                            XamlBindingSetters.Set_Windows_UI_Xaml_Automation_AutomationProperties_Name((this.obj3.Target as global::Windows.UI.Xaml.Controls.StackPanel), obj.ToString(), null);
                        }
                    }
                    // pages\Lists.xaml line 26
                    if (!isobj5TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj5, obj.ToString(), null);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 6: // pages\Lists.xaml line 38
                {
                    this.Projects = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 7: // pages\Lists.xaml line 152
                {
                    this.Today = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 3: // pages\Lists.xaml line 24
                {                    
                    global::Windows.UI.Xaml.Controls.StackPanel element3 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                    BlankPage1_obj3_Bindings bindings = new BlankPage1_obj3_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element3.DataContext);
                    element3.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element3, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element3, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}


﻿#pragma checksum "C:\Files\GitHub\CSharp\Drawing\Drawing\DrawingPad.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "84C7B0B066FEAF438BB5282BFD52ADC9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Drawing
{
    partial class DrawingPad : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.drawingCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                    #line 20 "..\..\..\DrawingPad.xaml"
                    ((global::Windows.UI.Xaml.Controls.Canvas)this.drawingCanvas).Tapped += this.drawingCanvas_Tapped;
                    #line 20 "..\..\..\DrawingPad.xaml"
                    ((global::Windows.UI.Xaml.Controls.Canvas)this.drawingCanvas).RightTapped += this.drawingCanvas_RightTapped;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}


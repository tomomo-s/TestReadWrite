// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace TestReadWrite
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        AppKit.NSTextField textReadPath { get; set; }

        [Outlet]
        AppKit.NSTextField textReadValue { get; set; }

        [Outlet]
        AppKit.NSTextView textviewReadValue { get; set; }

        [Outlet]
        AppKit.NSTextView textviewWriteValue { get; set; }

        [Outlet]
        AppKit.NSTextField textWritePath { get; set; }

        [Outlet]
        AppKit.NSTextField textWriteValue { get; set; }

        [Outlet]
        AppKit.NSScrollView viewReadValue { get; set; }

        [Outlet]
        AppKit.NSScrollView viewWriteValue { get; set; }

        [Action ("btnRead:")]
        partial void btnRead (Foundation.NSObject sender);

        [Action ("btnWrite:")]
        partial void btnWrite (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (textReadPath != null) {
                textReadPath.Dispose ();
                textReadPath = null;
            }

            if (textReadValue != null) {
                textReadValue.Dispose ();
                textReadValue = null;
            }

            if (textWritePath != null) {
                textWritePath.Dispose ();
                textWritePath = null;
            }

            if (textWriteValue != null) {
                textWriteValue.Dispose ();
                textWriteValue = null;
            }

            if (viewReadValue != null) {
                viewReadValue.Dispose ();
                viewReadValue = null;
            }

            if (viewWriteValue != null) {
                viewWriteValue.Dispose ();
                viewWriteValue = null;
            }

            if (textviewReadValue != null) {
                textviewReadValue.Dispose ();
                textviewReadValue = null;
            }

            if (textviewWriteValue != null) {
                textviewWriteValue.Dispose ();
                textviewWriteValue = null;
            }
        }
    }
}

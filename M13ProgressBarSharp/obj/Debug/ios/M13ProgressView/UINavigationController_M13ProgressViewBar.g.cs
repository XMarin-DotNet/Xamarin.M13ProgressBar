//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace M13ProgressView {
	public unsafe static partial class UINavigationController_M13ProgressViewBar  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("UINavigationController");
		
		[Export ("cancelProgress")]
		[CompilerGenerated]
		public static void CancelProgress (this global::UIKit.UINavigationController This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("cancelProgress"));
		}
		
		[Export ("finishProgress")]
		[CompilerGenerated]
		public static void FinishProgress (this global::UIKit.UINavigationController This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("finishProgress"));
		}
		
		[Export ("setIndeterminate:")]
		[CompilerGenerated]
		public static void SetIndeterminate (this global::UIKit.UINavigationController This, bool indeterminate)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setIndeterminate:"), indeterminate);
		}
		
		[Export ("setPrimaryColor:")]
		[CompilerGenerated]
		public static void SetPrimaryColor (this global::UIKit.UINavigationController This, global::UIKit.UIColor primaryColor)
		{
			if (primaryColor == null)
				throw new ArgumentNullException ("primaryColor");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setPrimaryColor:"), primaryColor.Handle);
		}
		
		[Export ("setProgress:animated:")]
		[CompilerGenerated]
		public static void SetProgress (this global::UIKit.UINavigationController This, global::System.nfloat progress, bool animated)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nfloat_bool (This.Handle, Selector.GetHandle ("setProgress:animated:"), progress, animated);
		}
		
		[Export ("setProgressTitle:")]
		[CompilerGenerated]
		public static void SetProgressTitle (this global::UIKit.UINavigationController This, string title)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			var nstitle = NSString.CreateNative (title);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setProgressTitle:"), nstitle);
			NSString.ReleaseNative (nstitle);
			
		}
		
		[Export ("setSecondaryColor:")]
		[CompilerGenerated]
		public static void SetSecondaryColor (this global::UIKit.UINavigationController This, global::UIKit.UIColor secondaryColor)
		{
			if (secondaryColor == null)
				throw new ArgumentNullException ("secondaryColor");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSecondaryColor:"), secondaryColor.Handle);
		}
		
		[Export ("showProgress")]
		[CompilerGenerated]
		public static void ShowProgress (this global::UIKit.UINavigationController This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("showProgress"));
		}
		
		[CompilerGenerated]
		public virtual bool Indeterminate {
			[Export ("getIndeterminate")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("getIndeterminate"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getIndeterminate"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsShowingProgressBar {
			[Export ("isShowingProgressBar")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isShowingProgressBar"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isShowingProgressBar"));
				}
			}
			
		}
		
	} /* class UINavigationController_M13ProgressViewBar */
}

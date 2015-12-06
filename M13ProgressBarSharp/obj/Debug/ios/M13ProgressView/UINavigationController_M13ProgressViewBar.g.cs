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
	[Register("UINavigationController_M13ProgressViewBar", true)]
	public unsafe partial class UINavigationController_M13ProgressViewBar : global::UIKit.UINavigationController {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("UINavigationController_M13ProgressViewBar");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UINavigationController_M13ProgressViewBar () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public UINavigationController_M13ProgressViewBar (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected UINavigationController_M13ProgressViewBar (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal UINavigationController_M13ProgressViewBar (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("cancelProgress")]
		[CompilerGenerated]
		public virtual void CancelProgress ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancelProgress"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancelProgress"));
			}
		}
		
		[Export ("finishProgress")]
		[CompilerGenerated]
		public virtual void FinishProgress ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("finishProgress"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("finishProgress"));
			}
		}
		
		[Export ("setPrimaryColor:")]
		[CompilerGenerated]
		public virtual void SetPrimaryColor (global::UIKit.UIColor primaryColor)
		{
			if (primaryColor == null)
				throw new ArgumentNullException ("primaryColor");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPrimaryColor:"), primaryColor.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPrimaryColor:"), primaryColor.Handle);
			}
		}
		
		[Export ("setProgress:animated:")]
		[CompilerGenerated]
		public virtual void SetProgress (global::System.nfloat progress, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nfloat_bool (this.Handle, Selector.GetHandle ("setProgress:animated:"), progress, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat_bool (this.SuperHandle, Selector.GetHandle ("setProgress:animated:"), progress, animated);
			}
		}
		
		[Export ("setProgressTitle:")]
		[CompilerGenerated]
		public virtual void SetProgressTitle (string title)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			var nstitle = NSString.CreateNative (title);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setProgressTitle:"), nstitle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setProgressTitle:"), nstitle);
			}
			NSString.ReleaseNative (nstitle);
			
		}
		
		[Export ("setSecondaryColor:")]
		[CompilerGenerated]
		public virtual void SetSecondaryColor (global::UIKit.UIColor secondaryColor)
		{
			if (secondaryColor == null)
				throw new ArgumentNullException ("secondaryColor");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSecondaryColor:"), secondaryColor.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSecondaryColor:"), secondaryColor.Handle);
			}
		}
		
		[Export ("showProgress")]
		[CompilerGenerated]
		public virtual void ShowProgress ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("showProgress"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showProgress"));
			}
		}
		
		[CompilerGenerated]
		public virtual bool Indeterminate {
			[Export ("indeterminate")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("indeterminate"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("indeterminate"));
				}
			}
			
			[Export ("setIndeterminate:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIndeterminate:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIndeterminate:"), value);
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

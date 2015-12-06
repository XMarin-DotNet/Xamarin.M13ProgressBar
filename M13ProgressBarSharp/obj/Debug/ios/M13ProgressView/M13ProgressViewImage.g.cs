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
	[Register("M13ProgressViewImage", true)]
	public unsafe partial class M13ProgressViewImage : M13ProgressView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("M13ProgressViewImage");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public M13ProgressViewImage () : base (NSObjectFlag.Empty)
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
		public M13ProgressViewImage (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected M13ProgressViewImage (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal M13ProgressViewImage (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual bool DrawGreyscaleBackground {
			[Export ("drawGreyscaleBackground")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("drawGreyscaleBackground"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("drawGreyscaleBackground"));
				}
			}
			
			[Export ("setDrawGreyscaleBackground:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDrawGreyscaleBackground:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDrawGreyscaleBackground:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual M13ProgressViewImageProgressDirection ProgressDirection {
			[Export ("progressDirection", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (M13ProgressViewImageProgressDirection) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("progressDirection"));
				} else {
					return (M13ProgressViewImageProgressDirection) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("progressDirection"));
				}
			}
			
			[Export ("setProgressDirection:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setProgressDirection:"), (UInt32)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setProgressDirection:"), (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_ProgressImage_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIImage ProgressImage {
			[Export ("progressImage", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("progressImage")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("progressImage")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ProgressImage_var = ret;
				return ret;
			}
			
			[Export ("setProgressImage:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setProgressImage:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setProgressImage:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ProgressImage_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ProgressImage_var = null;
			}
		}
		public partial class M13ProgressViewImageAppearance : global::M13ProgressView.M13ProgressView.M13ProgressViewAppearance {
			protected internal M13ProgressViewImageAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new M13ProgressViewImageAppearance Appearance {
			get { return new M13ProgressViewImageAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new M13ProgressViewImageAppearance GetAppearance<T> () where T: M13ProgressViewImage {
			return new M13ProgressViewImageAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new M13ProgressViewImageAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new M13ProgressViewImageAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new M13ProgressViewImageAppearance GetAppearance (UITraitCollection traits) {
			return new M13ProgressViewImageAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new M13ProgressViewImageAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new M13ProgressViewImageAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new M13ProgressViewImageAppearance GetAppearance<T> (UITraitCollection traits) where T: M13ProgressViewImage {
			return new M13ProgressViewImageAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new M13ProgressViewImageAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: M13ProgressViewImage{
			return new M13ProgressViewImageAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class M13ProgressViewImage */
}

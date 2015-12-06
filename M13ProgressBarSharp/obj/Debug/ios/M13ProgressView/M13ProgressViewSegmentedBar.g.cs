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
	[Register("M13ProgressViewSegmentedBar", true)]
	public unsafe partial class M13ProgressViewSegmentedBar : M13ProgressView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("M13ProgressViewSegmentedBar");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public M13ProgressViewSegmentedBar () : base (NSObjectFlag.Empty)
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
		public M13ProgressViewSegmentedBar (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected M13ProgressViewSegmentedBar (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal M13ProgressViewSegmentedBar (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual global::System.nfloat CornerRadius {
			[Export ("cornerRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("cornerRadius"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cornerRadius"));
				}
			}
			
			[Export ("setCornerRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setCornerRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setCornerRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_FailureColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor FailureColor {
			[Export ("failureColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("failureColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("failureColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FailureColor_var = ret;
				return ret;
			}
			
			[Export ("setFailureColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFailureColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFailureColor:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_FailureColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nint NumberOfSegments {
			[Export ("numberOfSegments")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfSegments"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("numberOfSegments"));
				}
			}
			
			[Export ("setNumberOfSegments:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setNumberOfSegments:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setNumberOfSegments:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_PrimaryColors_var;
		[CompilerGenerated]
		public virtual NSObject[] PrimaryColors {
			[Export ("primaryColors", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("primaryColors")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("primaryColors")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PrimaryColors_var = ret;
				return ret;
			}
			
			[Export ("setPrimaryColors:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPrimaryColors:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPrimaryColors:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_PrimaryColors_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual M13ProgressViewSegmentedBarProgressDirection ProgressDirection {
			[Export ("progressDirection", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (M13ProgressViewSegmentedBarProgressDirection) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("progressDirection"));
				} else {
					return (M13ProgressViewSegmentedBarProgressDirection) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("progressDirection"));
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
		object __mt_SecondaryColors_var;
		[CompilerGenerated]
		public virtual NSObject[] SecondaryColors {
			[Export ("secondaryColors", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secondaryColors")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("secondaryColors")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SecondaryColors_var = ret;
				return ret;
			}
			
			[Export ("setSecondaryColors:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSecondaryColors:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSecondaryColors:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_SecondaryColors_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat SegmentSeparation {
			[Export ("segmentSeparation")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("segmentSeparation"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("segmentSeparation"));
				}
			}
			
			[Export ("setSegmentSeparation:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setSegmentSeparation:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setSegmentSeparation:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual M13ProgressViewSegmentedBarSegmentShape SegmentShape {
			[Export ("segmentShape", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (M13ProgressViewSegmentedBarSegmentShape) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("segmentShape"));
				} else {
					return (M13ProgressViewSegmentedBarSegmentShape) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("segmentShape"));
				}
			}
			
			[Export ("setSegmentShape:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setSegmentShape:"), (UInt32)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setSegmentShape:"), (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_SuccessColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor SuccessColor {
			[Export ("successColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("successColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("successColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SuccessColor_var = ret;
				return ret;
			}
			
			[Export ("setSuccessColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSuccessColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSuccessColor:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_SuccessColor_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_FailureColor_var = null;
				__mt_PrimaryColors_var = null;
				__mt_SecondaryColors_var = null;
				__mt_SuccessColor_var = null;
			}
		}
		public partial class M13ProgressViewSegmentedBarAppearance : global::M13ProgressView.M13ProgressView.M13ProgressViewAppearance {
			protected internal M13ProgressViewSegmentedBarAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new M13ProgressViewSegmentedBarAppearance Appearance {
			get { return new M13ProgressViewSegmentedBarAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new M13ProgressViewSegmentedBarAppearance GetAppearance<T> () where T: M13ProgressViewSegmentedBar {
			return new M13ProgressViewSegmentedBarAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new M13ProgressViewSegmentedBarAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new M13ProgressViewSegmentedBarAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new M13ProgressViewSegmentedBarAppearance GetAppearance (UITraitCollection traits) {
			return new M13ProgressViewSegmentedBarAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new M13ProgressViewSegmentedBarAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new M13ProgressViewSegmentedBarAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new M13ProgressViewSegmentedBarAppearance GetAppearance<T> (UITraitCollection traits) where T: M13ProgressViewSegmentedBar {
			return new M13ProgressViewSegmentedBarAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new M13ProgressViewSegmentedBarAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: M13ProgressViewSegmentedBar{
			return new M13ProgressViewSegmentedBarAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class M13ProgressViewSegmentedBar */
}

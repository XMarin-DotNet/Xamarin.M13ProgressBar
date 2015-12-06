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
	[Register("M13ProgressViewRing", true)]
	public unsafe partial class M13ProgressViewRing : M13ProgressView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("M13ProgressViewRing");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public M13ProgressViewRing () : base (NSObjectFlag.Empty)
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
		public M13ProgressViewRing (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected M13ProgressViewRing (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal M13ProgressViewRing (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual global::System.nfloat BackgroundRingWidth {
			[Export ("backgroundRingWidth")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("backgroundRingWidth"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backgroundRingWidth"));
				}
			}
			
			[Export ("setBackgroundRingWidth:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setBackgroundRingWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setBackgroundRingWidth:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat ProgressRingWidth {
			[Export ("progressRingWidth")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("progressRingWidth"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("progressRingWidth"));
				}
			}
			
			[Export ("setProgressRingWidth:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setProgressRingWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setProgressRingWidth:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowPercentage {
			[Export ("showPercentage")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showPercentage"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showPercentage"));
				}
			}
			
			[Export ("setShowPercentage:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowPercentage:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowPercentage:"), value);
				}
			}
		}
		
		public partial class M13ProgressViewRingAppearance : global::M13ProgressView.M13ProgressView.M13ProgressViewAppearance {
			protected internal M13ProgressViewRingAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new M13ProgressViewRingAppearance Appearance {
			get { return new M13ProgressViewRingAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new M13ProgressViewRingAppearance GetAppearance<T> () where T: M13ProgressViewRing {
			return new M13ProgressViewRingAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new M13ProgressViewRingAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new M13ProgressViewRingAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new M13ProgressViewRingAppearance GetAppearance (UITraitCollection traits) {
			return new M13ProgressViewRingAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new M13ProgressViewRingAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new M13ProgressViewRingAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new M13ProgressViewRingAppearance GetAppearance<T> (UITraitCollection traits) where T: M13ProgressViewRing {
			return new M13ProgressViewRingAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new M13ProgressViewRingAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: M13ProgressViewRing{
			return new M13ProgressViewRingAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class M13ProgressViewRing */
}

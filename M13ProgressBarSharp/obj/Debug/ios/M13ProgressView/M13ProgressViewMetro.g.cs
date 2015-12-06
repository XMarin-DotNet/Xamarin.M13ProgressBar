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
	[Register("M13ProgressViewMetro", true)]
	public unsafe partial class M13ProgressViewMetro : M13ProgressView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("M13ProgressViewMetro");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public M13ProgressViewMetro () : base (NSObjectFlag.Empty)
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
		public M13ProgressViewMetro (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected M13ProgressViewMetro (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal M13ProgressViewMetro (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("beginAnimating")]
		[CompilerGenerated]
		public virtual void BeginAnimating ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("beginAnimating"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("beginAnimating"));
			}
		}
		
		[Export ("stopAnimating")]
		[CompilerGenerated]
		public virtual void StopAnimating ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stopAnimating"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopAnimating"));
			}
		}
		
		[CompilerGenerated]
		public virtual M13ProgressViewMetroAnimationShape AnimationShape {
			[Export ("animationShape", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (M13ProgressViewMetroAnimationShape) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("animationShape"));
				} else {
					return (M13ProgressViewMetroAnimationShape) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("animationShape"));
				}
			}
			
			[Export ("setAnimationShape:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setAnimationShape:"), (UInt32)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setAnimationShape:"), (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual CGSize DotSize {
			[Export ("dotSize", ArgumentSemantic.UnsafeUnretained)]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("dotSize"));
						} else {
							global::ApiDefinition.Messaging.CGSize_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("dotSize"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("dotSize"));
					} else {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("dotSize"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dotSize"));
						} else {
							global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("dotSize"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dotSize"));
					} else {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dotSize"));
					}
				}
				return ret;
			}
			
			[Export ("setDotSize:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("setDotSize:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGSize (this.SuperHandle, Selector.GetHandle ("setDotSize:"), value);
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
		public virtual bool IsAnimating {
			[Export ("isAnimating")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAnimating"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isAnimating"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_MetroDot_var;
		[CompilerGenerated]
		public virtual M13ProgressViewMetroDot MetroDot {
			[Export ("metroDot", ArgumentSemantic.Retain)]
			get {
				M13ProgressViewMetroDot ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<M13ProgressViewMetroDot> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("metroDot")));
				} else {
					ret =  Runtime.GetNSObject<M13ProgressViewMetroDot> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("metroDot")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_MetroDot_var = ret;
				return ret;
			}
			
			[Export ("setMetroDot:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMetroDot:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMetroDot:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_MetroDot_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint NumberOfDots {
			[Export ("numberOfDots")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfDots"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("numberOfDots"));
				}
			}
			
			[Export ("setNumberOfDots:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setNumberOfDots:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setNumberOfDots:"), value);
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
				__mt_MetroDot_var = null;
				__mt_SuccessColor_var = null;
			}
		}
		public partial class M13ProgressViewMetroAppearance : global::M13ProgressView.M13ProgressView.M13ProgressViewAppearance {
			protected internal M13ProgressViewMetroAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new M13ProgressViewMetroAppearance Appearance {
			get { return new M13ProgressViewMetroAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new M13ProgressViewMetroAppearance GetAppearance<T> () where T: M13ProgressViewMetro {
			return new M13ProgressViewMetroAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new M13ProgressViewMetroAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new M13ProgressViewMetroAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new M13ProgressViewMetroAppearance GetAppearance (UITraitCollection traits) {
			return new M13ProgressViewMetroAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new M13ProgressViewMetroAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new M13ProgressViewMetroAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new M13ProgressViewMetroAppearance GetAppearance<T> (UITraitCollection traits) where T: M13ProgressViewMetro {
			return new M13ProgressViewMetroAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new M13ProgressViewMetroAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: M13ProgressViewMetro{
			return new M13ProgressViewMetroAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class M13ProgressViewMetro */
}

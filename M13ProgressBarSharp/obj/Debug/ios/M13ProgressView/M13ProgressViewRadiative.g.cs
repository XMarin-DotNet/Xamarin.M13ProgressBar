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
	[Register("M13ProgressViewRadiative", true)]
	public unsafe partial class M13ProgressViewRadiative : M13ProgressView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("M13ProgressViewRadiative");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public M13ProgressViewRadiative () : base (NSObjectFlag.Empty)
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
		public M13ProgressViewRadiative (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected M13ProgressViewRadiative (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal M13ProgressViewRadiative (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual global::System.nuint NumberOfRipples {
			[Export ("numberOfRipples")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfRipples"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("numberOfRipples"));
				}
			}
			
			[Export ("setNumberOfRipples:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setNumberOfRipples:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setNumberOfRipples:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual CGPoint OriginationPoint {
			[Export ("originationPoint", ArgumentSemantic.UnsafeUnretained)]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("originationPoint"));
						} else {
							global::ApiDefinition.Messaging.CGPoint_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("originationPoint"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("originationPoint"));
					} else {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("originationPoint"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("originationPoint"));
						} else {
							global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("originationPoint"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("originationPoint"));
					} else {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("originationPoint"));
					}
				}
				return ret;
			}
			
			[Export ("setOriginationPoint:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setOriginationPoint:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("setOriginationPoint:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ProgressOutwards {
			[Export ("progressOutwards")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("progressOutwards"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("progressOutwards"));
				}
			}
			
			[Export ("setProgressOutwards:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setProgressOutwards:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setProgressOutwards:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint PulseWidth {
			[Export ("pulseWidth")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("pulseWidth"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pulseWidth"));
				}
			}
			
			[Export ("setPulseWidth:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setPulseWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setPulseWidth:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat RipplesRadius {
			[Export ("ripplesRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("ripplesRadius"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("ripplesRadius"));
				}
			}
			
			[Export ("setRipplesRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setRipplesRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setRipplesRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat RippleWidth {
			[Export ("rippleWidth")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("rippleWidth"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rippleWidth"));
				}
			}
			
			[Export ("setRippleWidth:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setRippleWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setRippleWidth:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual M13ProgressViewRadiativeShape Shape {
			[Export ("shape", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (M13ProgressViewRadiativeShape) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("shape"));
				} else {
					return (M13ProgressViewRadiativeShape) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shape"));
				}
			}
			
			[Export ("setShape:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setShape:"), (UInt32)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setShape:"), (UInt32)value);
				}
			}
		}
		
		public partial class M13ProgressViewRadiativeAppearance : global::M13ProgressView.M13ProgressView.M13ProgressViewAppearance {
			protected internal M13ProgressViewRadiativeAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new M13ProgressViewRadiativeAppearance Appearance {
			get { return new M13ProgressViewRadiativeAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new M13ProgressViewRadiativeAppearance GetAppearance<T> () where T: M13ProgressViewRadiative {
			return new M13ProgressViewRadiativeAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new M13ProgressViewRadiativeAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new M13ProgressViewRadiativeAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new M13ProgressViewRadiativeAppearance GetAppearance (UITraitCollection traits) {
			return new M13ProgressViewRadiativeAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new M13ProgressViewRadiativeAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new M13ProgressViewRadiativeAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new M13ProgressViewRadiativeAppearance GetAppearance<T> (UITraitCollection traits) where T: M13ProgressViewRadiative {
			return new M13ProgressViewRadiativeAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new M13ProgressViewRadiativeAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: M13ProgressViewRadiative{
			return new M13ProgressViewRadiativeAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class M13ProgressViewRadiative */
}

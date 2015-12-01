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
	[Register("M13ProgressViewLetterpress", true)]
	public unsafe partial class M13ProgressViewLetterpress : M13ProgressView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("M13ProgressViewLetterpress");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public M13ProgressViewLetterpress () : base (NSObjectFlag.Empty)
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
		public M13ProgressViewLetterpress (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected M13ProgressViewLetterpress (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal M13ProgressViewLetterpress (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual global::System.nfloat DampingCoefficient {
			[Export ("dampingCoefficient")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("dampingCoefficient"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dampingCoefficient"));
				}
			}
			
			[Export ("setDampingCoefficient:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setDampingCoefficient:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setDampingCoefficient:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat Mass {
			[Export ("mass")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("mass"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mass"));
				}
			}
			
			[Export ("setMass:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setMass:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setMass:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual CGSize NotchSize {
			[Export ("notchSize", ArgumentSemantic.UnsafeUnretained)]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("notchSize"));
						} else {
							global::ApiDefinition.Messaging.CGSize_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("notchSize"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("notchSize"));
					} else {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("notchSize"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("notchSize"));
						} else {
							global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("notchSize"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("notchSize"));
					} else {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("notchSize"));
					}
				}
				return ret;
			}
			
			[Export ("setNotchSize:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("setNotchSize:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGSize (this.SuperHandle, Selector.GetHandle ("setNotchSize:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual CGPoint NumberOfGridPoints {
			[Export ("numberOfGridPoints", ArgumentSemantic.UnsafeUnretained)]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfGridPoints"));
						} else {
							global::ApiDefinition.Messaging.CGPoint_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("numberOfGridPoints"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfGridPoints"));
					} else {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfGridPoints"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("numberOfGridPoints"));
						} else {
							global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("numberOfGridPoints"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("numberOfGridPoints"));
					} else {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("numberOfGridPoints"));
					}
				}
				return ret;
			}
			
			[Export ("setNumberOfGridPoints:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setNumberOfGridPoints:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("setNumberOfGridPoints:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual M13ProgressViewLetterpressPointShape PointShape {
			[Export ("pointShape", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (M13ProgressViewLetterpressPointShape) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("pointShape"));
				} else {
					return (M13ProgressViewLetterpressPointShape) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pointShape"));
				}
			}
			
			[Export ("setPointShape:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setPointShape:"), (UInt32)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setPointShape:"), (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat PointSpacing {
			[Export ("pointSpacing")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("pointSpacing"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pointSpacing"));
				}
			}
			
			[Export ("setPointSpacing:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setPointSpacing:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setPointSpacing:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat SpringConstant {
			[Export ("springConstant")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("springConstant"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("springConstant"));
				}
			}
			
			[Export ("setSpringConstant:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setSpringConstant:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setSpringConstant:"), value);
				}
			}
		}
		
		public partial class M13ProgressViewLetterpressAppearance : global::M13ProgressView.M13ProgressView.M13ProgressViewAppearance {
			protected internal M13ProgressViewLetterpressAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new M13ProgressViewLetterpressAppearance Appearance {
			get { return new M13ProgressViewLetterpressAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new M13ProgressViewLetterpressAppearance GetAppearance<T> () where T: M13ProgressViewLetterpress {
			return new M13ProgressViewLetterpressAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new M13ProgressViewLetterpressAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new M13ProgressViewLetterpressAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new M13ProgressViewLetterpressAppearance GetAppearance (UITraitCollection traits) {
			return new M13ProgressViewLetterpressAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new M13ProgressViewLetterpressAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new M13ProgressViewLetterpressAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new M13ProgressViewLetterpressAppearance GetAppearance<T> (UITraitCollection traits) where T: M13ProgressViewLetterpress {
			return new M13ProgressViewLetterpressAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new M13ProgressViewLetterpressAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: M13ProgressViewLetterpress{
			return new M13ProgressViewLetterpressAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class M13ProgressViewLetterpress */
}

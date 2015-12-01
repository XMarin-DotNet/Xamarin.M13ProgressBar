using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace M13ProgressView
{
	// @interface M13ProgressView : UIView
	[BaseType (typeof(UIView))]
	interface M13ProgressView
	{
		// @property (retain, nonatomic) UIColor * primaryColor;
		[Export ("primaryColor", ArgumentSemantic.Retain)]
		UIColor PrimaryColor { get; set; }

		// @property (retain, nonatomic) UIColor * secondaryColor;
		[Export ("secondaryColor", ArgumentSemantic.Retain)]
		UIColor SecondaryColor { get; set; }

		// @property (assign, nonatomic) BOOL indeterminate;
		[Export ("indeterminate")]
		bool Indeterminate { get; set; }

		// @property (assign, nonatomic) CGFloat animationDuration;
		[Export ("animationDuration")]
		nfloat AnimationDuration { get; set; }

		// @property (readonly, nonatomic) CGFloat progress;
		[Export ("progress")]
		nfloat Progress { get; }

		// -(void)setProgress:(CGFloat)progress animated:(BOOL)animated;
		[Export ("setProgress:animated:")]
		void SetProgress (nfloat progress, bool animated);

		// -(void)performAction:(M13ProgressViewAction)action animated:(BOOL)animated;
		[Export ("performAction:animated:")]
		void PerformAction (M13ProgressViewAction action, bool animated);
	}

	// @interface M13ProgressViewBar : M13ProgressView
	[BaseType (typeof(M13ProgressView))]
	interface M13ProgressViewBar
	{
		// @property (assign, nonatomic) M13ProgressViewBarProgressDirection progressDirection;
		[Export ("progressDirection", ArgumentSemantic.Assign)]
		M13ProgressViewBarProgressDirection ProgressDirection { get; set; }

		// @property (assign, nonatomic) CGFloat progressBarThickness;
		[Export ("progressBarThickness")]
		nfloat ProgressBarThickness { get; set; }

		// @property (assign, nonatomic) CGFloat progressBarCornerRadius;
		[Export ("progressBarCornerRadius")]
		nfloat ProgressBarCornerRadius { get; set; }

		// @property (retain, nonatomic) UIColor * successColor;
		[Export ("successColor", ArgumentSemantic.Retain)]
		UIColor SuccessColor { get; set; }

		// @property (retain, nonatomic) UIColor * failureColor;
		[Export ("failureColor", ArgumentSemantic.Retain)]
		UIColor FailureColor { get; set; }

		// @property (assign, nonatomic) BOOL showPercentage;
		[Export ("showPercentage")]
		bool ShowPercentage { get; set; }

		// @property (assign, nonatomic) M13ProgressViewBarPercentagePosition percentagePosition;
		[Export ("percentagePosition", ArgumentSemantic.Assign)]
		M13ProgressViewBarPercentagePosition PercentagePosition { get; set; }
	}

	// @interface M13ProgressViewBorderedBar : M13ProgressView
	[BaseType (typeof(M13ProgressView))]
	interface M13ProgressViewBorderedBar
	{
		// @property (assign, nonatomic) M13ProgressViewBorderedBarProgressDirection progressDirection;
		[Export ("progressDirection", ArgumentSemantic.Assign)]
		M13ProgressViewBorderedBarProgressDirection ProgressDirection { get; set; }

		// @property (assign, nonatomic) M13ProgressViewBorderedBarCornerType cornerType;
		[Export ("cornerType", ArgumentSemantic.Assign)]
		M13ProgressViewBorderedBarCornerType CornerType { get; set; }

		// @property (assign, nonatomic) CGFloat cornerRadius;
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; set; }

		// @property (assign, nonatomic) CGFloat borderWidth;
		[Export ("borderWidth")]
		nfloat BorderWidth { get; set; }

		// @property (retain, nonatomic) UIColor * successColor;
		[Export ("successColor", ArgumentSemantic.Retain)]
		UIColor SuccessColor { get; set; }

		// @property (retain, nonatomic) UIColor * failureColor;
		[Export ("failureColor", ArgumentSemantic.Retain)]
		UIColor FailureColor { get; set; }
	}

	// @interface M13ProgressViewFilteredImage : M13ProgressView
	[BaseType (typeof(M13ProgressView))]
	interface M13ProgressViewFilteredImage
	{
		// @property (retain, nonatomic) UIImage * progressImage;
		[Export ("progressImage", ArgumentSemantic.Retain)]
		UIImage ProgressImage { get; set; }

		// @property (retain, nonatomic) UIImageView * progressView;
		[Export ("progressView", ArgumentSemantic.Retain)]
		UIImageView ProgressView { get; set; }

		// @property (retain, nonatomic) NSArray * filters;
		[Export ("filters", ArgumentSemantic.Retain)]
		NSObject[] Filters { get; set; }

		// @property (retain, nonatomic) NSArray * filterParameters;
		[Export ("filterParameters", ArgumentSemantic.Retain)]
		NSObject[] FilterParameters { get; set; }
	}

	// @interface M13ProgressViewImage : M13ProgressView
	[BaseType (typeof(M13ProgressView))]
	interface M13ProgressViewImage
	{
		// @property (retain, nonatomic) UIImage * progressImage;
		[Export ("progressImage", ArgumentSemantic.Retain)]
		UIImage ProgressImage { get; set; }

		// @property (assign, nonatomic) M13ProgressViewImageProgressDirection progressDirection;
		[Export ("progressDirection", ArgumentSemantic.Assign)]
		M13ProgressViewImageProgressDirection ProgressDirection { get; set; }

		// @property (assign, nonatomic) BOOL drawGreyscaleBackground;
		[Export ("drawGreyscaleBackground")]
		bool DrawGreyscaleBackground { get; set; }
	}

	// @interface M13ProgressViewLetterpress : M13ProgressView
	[BaseType (typeof(M13ProgressView))]
	interface M13ProgressViewLetterpress
	{
		// @property (assign, nonatomic) CGPoint numberOfGridPoints;
		[Export ("numberOfGridPoints", ArgumentSemantic.Assign)]
		CGPoint NumberOfGridPoints { get; set; }

		// @property (assign, nonatomic) M13ProgressViewLetterpressPointShape pointShape;
		[Export ("pointShape", ArgumentSemantic.Assign)]
		M13ProgressViewLetterpressPointShape PointShape { get; set; }

		// @property (assign, nonatomic) CGFloat pointSpacing;
		[Export ("pointSpacing")]
		nfloat PointSpacing { get; set; }

		// @property (assign, nonatomic) CGSize notchSize;
		[Export ("notchSize", ArgumentSemantic.Assign)]
		CGSize NotchSize { get; set; }

		// @property (assign, nonatomic) CGFloat springConstant;
		[Export ("springConstant")]
		nfloat SpringConstant { get; set; }

		// @property (assign, nonatomic) CGFloat dampingCoefficient;
		[Export ("dampingCoefficient")]
		nfloat DampingCoefficient { get; set; }

		// @property (assign, nonatomic) CGFloat mass;
		[Export ("mass")]
		nfloat Mass { get; set; }
	}

	// @interface M13ProgressViewMetroDot : CALayer
	[BaseType (typeof(CALayer))]
	interface M13ProgressViewMetroDot
	{
		// @property (assign, nonatomic) BOOL highlighted;
		[Export ("highlighted")]
		bool Highlighted { get; set; }

		// @property (retain, nonatomic) UIColor * successColor;
		[Export ("successColor", ArgumentSemantic.Retain)]
		UIColor SuccessColor { get; set; }

		// @property (retain, nonatomic) UIColor * failureColor;
		[Export ("failureColor", ArgumentSemantic.Retain)]
		UIColor FailureColor { get; set; }

		// @property (retain, nonatomic) UIColor * primaryColor;
		[Export ("primaryColor", ArgumentSemantic.Retain)]
		UIColor PrimaryColor { get; set; }

		// @property (retain, nonatomic) UIColor * secondaryColor;
		[Export ("secondaryColor", ArgumentSemantic.Retain)]
		UIColor SecondaryColor { get; set; }

		// -(void)performAction:(M13ProgressViewAction)action animated:(BOOL)animated;
		[Export ("performAction:animated:")]
		void PerformAction (M13ProgressViewAction action, bool animated);
	}

	// @interface M13ProgressViewMetro : M13ProgressView
	[BaseType (typeof(M13ProgressView))]
	interface M13ProgressViewMetro
	{
		// @property (assign, nonatomic) NSUInteger numberOfDots;
		[Export ("numberOfDots")]
		nuint NumberOfDots { get; set; }

		// @property (assign, nonatomic) M13ProgressViewMetroAnimationShape animationShape;
		[Export ("animationShape", ArgumentSemantic.Assign)]
		M13ProgressViewMetroAnimationShape AnimationShape { get; set; }

		// @property (assign, nonatomic) CGSize dotSize;
		[Export ("dotSize", ArgumentSemantic.Assign)]
		CGSize DotSize { get; set; }

		// @property (retain, nonatomic) M13ProgressViewMetroDot * metroDot;
		[Export ("metroDot", ArgumentSemantic.Retain)]
		M13ProgressViewMetroDot MetroDot { get; set; }

		// @property (retain, nonatomic) UIColor * successColor;
		[Export ("successColor", ArgumentSemantic.Retain)]
		UIColor SuccessColor { get; set; }

		// @property (retain, nonatomic) UIColor * failureColor;
		[Export ("failureColor", ArgumentSemantic.Retain)]
		UIColor FailureColor { get; set; }

		// -(BOOL)isAnimating;
		[Export ("isAnimating")]
		bool IsAnimating { get; }

		// -(void)beginAnimating;
		[Export ("beginAnimating")]
		void BeginAnimating ();

		// -(void)stopAnimating;
		[Export ("stopAnimating")]
		void StopAnimating ();
	}

	// @interface M13ProgressViewMetroDotPolygon : M13ProgressViewMetroDot
	[BaseType (typeof(M13ProgressViewMetroDot))]
	interface M13ProgressViewMetroDotPolygon
	{
		// @property (assign, nonatomic) NSUInteger numberOfSides;
		[Export ("numberOfSides")]
		nuint NumberOfSides { get; set; }

		// @property (assign, nonatomic) CGFloat radius;
		[Export ("radius")]
		nfloat Radius { get; set; }
	}

	// @interface M13ProgressViewPie : M13ProgressView
	[BaseType (typeof(M13ProgressView))]
	interface M13ProgressViewPie
	{
		// @property (assign, nonatomic) CGFloat backgroundRingWidth;
		[Export ("backgroundRingWidth")]
		nfloat BackgroundRingWidth { get; set; }
	}

	// @interface M13ProgressViewRadiative : M13ProgressView
	[BaseType (typeof(M13ProgressView))]
	interface M13ProgressViewRadiative
	{
		// @property (assign, nonatomic) CGPoint originationPoint;
		[Export ("originationPoint", ArgumentSemantic.Assign)]
		CGPoint OriginationPoint { get; set; }

		// @property (assign, nonatomic) CGFloat ripplesRadius;
		[Export ("ripplesRadius")]
		nfloat RipplesRadius { get; set; }

		// @property (assign, nonatomic) CGFloat rippleWidth;
		[Export ("rippleWidth")]
		nfloat RippleWidth { get; set; }

		// @property (assign, nonatomic) M13ProgressViewRadiativeShape shape;
		[Export ("shape", ArgumentSemantic.Assign)]
		M13ProgressViewRadiativeShape Shape { get; set; }

		// @property (assign, nonatomic) NSUInteger numberOfRipples;
		[Export ("numberOfRipples")]
		nuint NumberOfRipples { get; set; }

		// @property (assign, nonatomic) NSUInteger pulseWidth;
		[Export ("pulseWidth")]
		nuint PulseWidth { get; set; }

		// @property (assign, nonatomic) BOOL progressOutwards;
		[Export ("progressOutwards")]
		bool ProgressOutwards { get; set; }
	}

	// @interface M13ProgressViewRing : M13ProgressView
	[BaseType (typeof(M13ProgressView))]
	interface M13ProgressViewRing
	{
		// @property (assign, nonatomic) CGFloat backgroundRingWidth;
		[Export ("backgroundRingWidth")]
		nfloat BackgroundRingWidth { get; set; }

		// @property (assign, nonatomic) CGFloat progressRingWidth;
		[Export ("progressRingWidth")]
		nfloat ProgressRingWidth { get; set; }

		// @property (assign, nonatomic) BOOL showPercentage;
		[Export ("showPercentage")]
		bool ShowPercentage { get; set; }
	}

	// @interface M13ProgressViewSegmentedBar : M13ProgressView
	[BaseType (typeof(M13ProgressView))]
	interface M13ProgressViewSegmentedBar
	{
		// @property (assign, nonatomic) M13ProgressViewSegmentedBarProgressDirection progressDirection;
		[Export ("progressDirection", ArgumentSemantic.Assign)]
		M13ProgressViewSegmentedBarProgressDirection ProgressDirection { get; set; }

		// @property (assign, nonatomic) M13ProgressViewSegmentedBarSegmentShape segmentShape;
		[Export ("segmentShape", ArgumentSemantic.Assign)]
		M13ProgressViewSegmentedBarSegmentShape SegmentShape { get; set; }

		// @property (assign, nonatomic) CGFloat cornerRadius;
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; set; }

		// @property (assign, nonatomic) NSInteger numberOfSegments;
		[Export ("numberOfSegments")]
		nint NumberOfSegments { get; set; }

		// @property (assign, nonatomic) CGFloat segmentSeparation;
		[Export ("segmentSeparation")]
		nfloat SegmentSeparation { get; set; }

		// @property (retain, nonatomic) UIColor * successColor;
		[Export ("successColor", ArgumentSemantic.Retain)]
		UIColor SuccessColor { get; set; }

		// @property (retain, nonatomic) UIColor * failureColor;
		[Export ("failureColor", ArgumentSemantic.Retain)]
		UIColor FailureColor { get; set; }

		// @property (retain, nonatomic) NSArray * primaryColors;
		[Export ("primaryColors", ArgumentSemantic.Retain)]
		NSObject[] PrimaryColors { get; set; }

		// @property (retain, nonatomic) NSArray * secondaryColors;
		[Export ("secondaryColors", ArgumentSemantic.Retain)]
		NSObject[] SecondaryColors { get; set; }
	}

	// @interface M13ProgressViewSegmentedRing : M13ProgressView
	[BaseType (typeof(M13ProgressView))]
	interface M13ProgressViewSegmentedRing
	{
		// @property (assign, nonatomic) CGFloat progressRingWidth;
		[Export ("progressRingWidth")]
		nfloat ProgressRingWidth { get; set; }

		// @property (assign, nonatomic) NSInteger numberOfSegments;
		[Export ("numberOfSegments")]
		nint NumberOfSegments { get; set; }

		// @property (assign, nonatomic) CGFloat segmentSeparationAngle;
		[Export ("segmentSeparationAngle")]
		nfloat SegmentSeparationAngle { get; set; }

		// @property (assign, nonatomic) M13ProgressViewSegmentedRingSegmentBoundaryType segmentBoundaryType;
		[Export ("segmentBoundaryType", ArgumentSemantic.Assign)]
		M13ProgressViewSegmentedRingSegmentBoundaryType SegmentBoundaryType { get; set; }

		// @property (assign, nonatomic) BOOL showPercentage;
		[Export ("showPercentage")]
		bool ShowPercentage { get; set; }
	}

	// @interface M13ProgressViewStripedBar : M13ProgressView
	[BaseType (typeof(M13ProgressView))]
	interface M13ProgressViewStripedBar
	{
		// @property (assign, nonatomic) M13ProgressViewStripedBarCornerType cornerType;
		[Export ("cornerType", ArgumentSemantic.Assign)]
		M13ProgressViewStripedBarCornerType CornerType { get; set; }

		// @property (assign, nonatomic) CGFloat cornerRadius;
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; set; }

		// @property (assign, nonatomic) CGFloat stripeWidth;
		[Export ("stripeWidth")]
		nfloat StripeWidth { get; set; }

		// @property (assign, nonatomic) BOOL animateStripes;
		[Export ("animateStripes")]
		bool AnimateStripes { get; set; }

		// @property (assign, nonatomic) BOOL showStripes;
		[Export ("showStripes")]
		bool ShowStripes { get; set; }

		// @property (retain, nonatomic) UIColor * stripeColor;
		[Export ("stripeColor", ArgumentSemantic.Retain)]
		UIColor StripeColor { get; set; }

		// @property (assign, nonatomic) CGFloat borderWidth;
		[Export ("borderWidth")]
		nfloat BorderWidth { get; set; }
	}
}

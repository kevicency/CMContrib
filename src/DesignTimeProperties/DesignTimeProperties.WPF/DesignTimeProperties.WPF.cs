












using System.ComponentModel;
using System.Windows;

namespace DesignTimeProperties
{
	public static class d
	{
		static bool? inDesignMode;

        /// <summary>
        /// Indicates whether or not the framework is in design-time mode. (Caliburn.Micro implementation)
        /// </summary>
        private static bool InDesignMode {
            get {
                if(inDesignMode == null) {
                    var prop = DesignerProperties.IsInDesignModeProperty;
                    inDesignMode = (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;

                    if(!inDesignMode.GetValueOrDefault(false) && System.Diagnostics.Process.GetCurrentProcess().ProcessName.StartsWith("devenv", System.StringComparison.Ordinal))
                        inDesignMode = true;
                }

                return inDesignMode.GetValueOrDefault(false);
            }
        }


		
		public static DependencyProperty HasAnimatedPropertiesProperty = DependencyProperty.RegisterAttached( "HasAnimatedProperties", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HasAnimatedPropertiesChanged)));
        public static System.Boolean GetHasAnimatedProperties(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(HasAnimatedPropertiesProperty);
        }
        public static void SetHasAnimatedProperties(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(HasAnimatedPropertiesProperty, value);
        }
		private static void HasAnimatedPropertiesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("HasAnimatedProperties").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty InputBindingsProperty = DependencyProperty.RegisterAttached( "InputBindings", typeof(System.Windows.Input.InputBindingCollection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(InputBindingsChanged)));
        public static System.Windows.Input.InputBindingCollection GetInputBindings(DependencyObject dependencyObject)
        {
            return (System.Windows.Input.InputBindingCollection)dependencyObject.GetValue(InputBindingsProperty);
        }
        public static void SetInputBindings(DependencyObject dependencyObject, System.Windows.Input.InputBindingCollection value)
        {
            dependencyObject.SetValue(InputBindingsProperty, value);
        }
		private static void InputBindingsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("InputBindings").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CommandBindingsProperty = DependencyProperty.RegisterAttached( "CommandBindings", typeof(System.Windows.Input.CommandBindingCollection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CommandBindingsChanged)));
        public static System.Windows.Input.CommandBindingCollection GetCommandBindings(DependencyObject dependencyObject)
        {
            return (System.Windows.Input.CommandBindingCollection)dependencyObject.GetValue(CommandBindingsProperty);
        }
        public static void SetCommandBindings(DependencyObject dependencyObject, System.Windows.Input.CommandBindingCollection value)
        {
            dependencyObject.SetValue(CommandBindingsProperty, value);
        }
		private static void CommandBindingsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CommandBindings").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AllowDropProperty = DependencyProperty.RegisterAttached( "AllowDrop", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AllowDropChanged)));
        public static System.Boolean GetAllowDrop(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(AllowDropProperty);
        }
        public static void SetAllowDrop(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(AllowDropProperty, value);
        }
		private static void AllowDropChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AllowDrop").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DesiredSizeProperty = DependencyProperty.RegisterAttached( "DesiredSize", typeof(System.Windows.Size), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DesiredSizeChanged)));
        public static System.Windows.Size GetDesiredSize(DependencyObject dependencyObject)
        {
            return (System.Windows.Size)dependencyObject.GetValue(DesiredSizeProperty);
        }
        public static void SetDesiredSize(DependencyObject dependencyObject, System.Windows.Size value)
        {
            dependencyObject.SetValue(DesiredSizeProperty, value);
        }
		private static void DesiredSizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DesiredSize").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsMeasureValidProperty = DependencyProperty.RegisterAttached( "IsMeasureValid", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsMeasureValidChanged)));
        public static System.Boolean GetIsMeasureValid(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsMeasureValidProperty);
        }
        public static void SetIsMeasureValid(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsMeasureValidProperty, value);
        }
		private static void IsMeasureValidChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsMeasureValid").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsArrangeValidProperty = DependencyProperty.RegisterAttached( "IsArrangeValid", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsArrangeValidChanged)));
        public static System.Boolean GetIsArrangeValid(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsArrangeValidProperty);
        }
        public static void SetIsArrangeValid(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsArrangeValidProperty, value);
        }
		private static void IsArrangeValidChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsArrangeValid").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RenderSizeProperty = DependencyProperty.RegisterAttached( "RenderSize", typeof(System.Windows.Size), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RenderSizeChanged)));
        public static System.Windows.Size GetRenderSize(DependencyObject dependencyObject)
        {
            return (System.Windows.Size)dependencyObject.GetValue(RenderSizeProperty);
        }
        public static void SetRenderSize(DependencyObject dependencyObject, System.Windows.Size value)
        {
            dependencyObject.SetValue(RenderSizeProperty, value);
        }
		private static void RenderSizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RenderSize").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RenderTransformProperty = DependencyProperty.RegisterAttached( "RenderTransform", typeof(System.Windows.Media.Transform), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RenderTransformChanged)));
        public static System.Windows.Media.Transform GetRenderTransform(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Transform)dependencyObject.GetValue(RenderTransformProperty);
        }
        public static void SetRenderTransform(DependencyObject dependencyObject, System.Windows.Media.Transform value)
        {
            dependencyObject.SetValue(RenderTransformProperty, value);
        }
		private static void RenderTransformChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RenderTransform").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RenderTransformOriginProperty = DependencyProperty.RegisterAttached( "RenderTransformOrigin", typeof(System.Windows.Point), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RenderTransformOriginChanged)));
        public static System.Windows.Point GetRenderTransformOrigin(DependencyObject dependencyObject)
        {
            return (System.Windows.Point)dependencyObject.GetValue(RenderTransformOriginProperty);
        }
        public static void SetRenderTransformOrigin(DependencyObject dependencyObject, System.Windows.Point value)
        {
            dependencyObject.SetValue(RenderTransformOriginProperty, value);
        }
		private static void RenderTransformOriginChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RenderTransformOrigin").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsMouseDirectlyOverProperty = DependencyProperty.RegisterAttached( "IsMouseDirectlyOver", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsMouseDirectlyOverChanged)));
        public static System.Boolean GetIsMouseDirectlyOver(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsMouseDirectlyOverProperty);
        }
        public static void SetIsMouseDirectlyOver(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsMouseDirectlyOverProperty, value);
        }
		private static void IsMouseDirectlyOverChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsMouseDirectlyOver").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsMouseOverProperty = DependencyProperty.RegisterAttached( "IsMouseOver", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsMouseOverChanged)));
        public static System.Boolean GetIsMouseOver(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsMouseOverProperty);
        }
        public static void SetIsMouseOver(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsMouseOverProperty, value);
        }
		private static void IsMouseOverChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsMouseOver").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsStylusOverProperty = DependencyProperty.RegisterAttached( "IsStylusOver", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsStylusOverChanged)));
        public static System.Boolean GetIsStylusOver(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsStylusOverProperty);
        }
        public static void SetIsStylusOver(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsStylusOverProperty, value);
        }
		private static void IsStylusOverChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsStylusOver").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsKeyboardFocusWithinProperty = DependencyProperty.RegisterAttached( "IsKeyboardFocusWithin", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsKeyboardFocusWithinChanged)));
        public static System.Boolean GetIsKeyboardFocusWithin(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsKeyboardFocusWithinProperty);
        }
        public static void SetIsKeyboardFocusWithin(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsKeyboardFocusWithinProperty, value);
        }
		private static void IsKeyboardFocusWithinChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsKeyboardFocusWithin").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsMouseCapturedProperty = DependencyProperty.RegisterAttached( "IsMouseCaptured", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsMouseCapturedChanged)));
        public static System.Boolean GetIsMouseCaptured(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsMouseCapturedProperty);
        }
        public static void SetIsMouseCaptured(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsMouseCapturedProperty, value);
        }
		private static void IsMouseCapturedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsMouseCaptured").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsMouseCaptureWithinProperty = DependencyProperty.RegisterAttached( "IsMouseCaptureWithin", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsMouseCaptureWithinChanged)));
        public static System.Boolean GetIsMouseCaptureWithin(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsMouseCaptureWithinProperty);
        }
        public static void SetIsMouseCaptureWithin(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsMouseCaptureWithinProperty, value);
        }
		private static void IsMouseCaptureWithinChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsMouseCaptureWithin").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsStylusDirectlyOverProperty = DependencyProperty.RegisterAttached( "IsStylusDirectlyOver", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsStylusDirectlyOverChanged)));
        public static System.Boolean GetIsStylusDirectlyOver(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsStylusDirectlyOverProperty);
        }
        public static void SetIsStylusDirectlyOver(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsStylusDirectlyOverProperty, value);
        }
		private static void IsStylusDirectlyOverChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsStylusDirectlyOver").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsStylusCapturedProperty = DependencyProperty.RegisterAttached( "IsStylusCaptured", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsStylusCapturedChanged)));
        public static System.Boolean GetIsStylusCaptured(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsStylusCapturedProperty);
        }
        public static void SetIsStylusCaptured(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsStylusCapturedProperty, value);
        }
		private static void IsStylusCapturedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsStylusCaptured").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsStylusCaptureWithinProperty = DependencyProperty.RegisterAttached( "IsStylusCaptureWithin", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsStylusCaptureWithinChanged)));
        public static System.Boolean GetIsStylusCaptureWithin(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsStylusCaptureWithinProperty);
        }
        public static void SetIsStylusCaptureWithin(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsStylusCaptureWithinProperty, value);
        }
		private static void IsStylusCaptureWithinChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsStylusCaptureWithin").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsKeyboardFocusedProperty = DependencyProperty.RegisterAttached( "IsKeyboardFocused", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsKeyboardFocusedChanged)));
        public static System.Boolean GetIsKeyboardFocused(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsKeyboardFocusedProperty);
        }
        public static void SetIsKeyboardFocused(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsKeyboardFocusedProperty, value);
        }
		private static void IsKeyboardFocusedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsKeyboardFocused").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsInputMethodEnabledProperty = DependencyProperty.RegisterAttached( "IsInputMethodEnabled", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsInputMethodEnabledChanged)));
        public static System.Boolean GetIsInputMethodEnabled(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsInputMethodEnabledProperty);
        }
        public static void SetIsInputMethodEnabled(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsInputMethodEnabledProperty, value);
        }
		private static void IsInputMethodEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsInputMethodEnabled").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty OpacityProperty = DependencyProperty.RegisterAttached( "Opacity", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(OpacityChanged)));
        public static System.Double GetOpacity(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(OpacityProperty);
        }
        public static void SetOpacity(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(OpacityProperty, value);
        }
		private static void OpacityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Opacity").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty OpacityMaskProperty = DependencyProperty.RegisterAttached( "OpacityMask", typeof(System.Windows.Media.Brush), typeof(d), new PropertyMetadata(new PropertyChangedCallback(OpacityMaskChanged)));
        public static System.Windows.Media.Brush GetOpacityMask(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Brush)dependencyObject.GetValue(OpacityMaskProperty);
        }
        public static void SetOpacityMask(DependencyObject dependencyObject, System.Windows.Media.Brush value)
        {
            dependencyObject.SetValue(OpacityMaskProperty, value);
        }
		private static void OpacityMaskChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("OpacityMask").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty BitmapEffectProperty = DependencyProperty.RegisterAttached( "BitmapEffect", typeof(System.Windows.Media.Effects.BitmapEffect), typeof(d), new PropertyMetadata(new PropertyChangedCallback(BitmapEffectChanged)));
        public static System.Windows.Media.Effects.BitmapEffect GetBitmapEffect(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Effects.BitmapEffect)dependencyObject.GetValue(BitmapEffectProperty);
        }
        public static void SetBitmapEffect(DependencyObject dependencyObject, System.Windows.Media.Effects.BitmapEffect value)
        {
            dependencyObject.SetValue(BitmapEffectProperty, value);
        }
		private static void BitmapEffectChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("BitmapEffect").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty EffectProperty = DependencyProperty.RegisterAttached( "Effect", typeof(System.Windows.Media.Effects.Effect), typeof(d), new PropertyMetadata(new PropertyChangedCallback(EffectChanged)));
        public static System.Windows.Media.Effects.Effect GetEffect(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Effects.Effect)dependencyObject.GetValue(EffectProperty);
        }
        public static void SetEffect(DependencyObject dependencyObject, System.Windows.Media.Effects.Effect value)
        {
            dependencyObject.SetValue(EffectProperty, value);
        }
		private static void EffectChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Effect").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty BitmapEffectInputProperty = DependencyProperty.RegisterAttached( "BitmapEffectInput", typeof(System.Windows.Media.Effects.BitmapEffectInput), typeof(d), new PropertyMetadata(new PropertyChangedCallback(BitmapEffectInputChanged)));
        public static System.Windows.Media.Effects.BitmapEffectInput GetBitmapEffectInput(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Effects.BitmapEffectInput)dependencyObject.GetValue(BitmapEffectInputProperty);
        }
        public static void SetBitmapEffectInput(DependencyObject dependencyObject, System.Windows.Media.Effects.BitmapEffectInput value)
        {
            dependencyObject.SetValue(BitmapEffectInputProperty, value);
        }
		private static void BitmapEffectInputChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("BitmapEffectInput").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CacheModeProperty = DependencyProperty.RegisterAttached( "CacheMode", typeof(System.Windows.Media.CacheMode), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CacheModeChanged)));
        public static System.Windows.Media.CacheMode GetCacheMode(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.CacheMode)dependencyObject.GetValue(CacheModeProperty);
        }
        public static void SetCacheMode(DependencyObject dependencyObject, System.Windows.Media.CacheMode value)
        {
            dependencyObject.SetValue(CacheModeProperty, value);
        }
		private static void CacheModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CacheMode").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty UidProperty = DependencyProperty.RegisterAttached( "Uid", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(UidChanged)));
        public static System.String GetUid(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(UidProperty);
        }
        public static void SetUid(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(UidProperty, value);
        }
		private static void UidChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Uid").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty VisibilityProperty = DependencyProperty.RegisterAttached( "Visibility", typeof(System.Windows.Visibility), typeof(d), new PropertyMetadata(new PropertyChangedCallback(VisibilityChanged)));
        public static System.Windows.Visibility GetVisibility(DependencyObject dependencyObject)
        {
            return (System.Windows.Visibility)dependencyObject.GetValue(VisibilityProperty);
        }
        public static void SetVisibility(DependencyObject dependencyObject, System.Windows.Visibility value)
        {
            dependencyObject.SetValue(VisibilityProperty, value);
        }
		private static void VisibilityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Visibility").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ClipToBoundsProperty = DependencyProperty.RegisterAttached( "ClipToBounds", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ClipToBoundsChanged)));
        public static System.Boolean GetClipToBounds(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(ClipToBoundsProperty);
        }
        public static void SetClipToBounds(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(ClipToBoundsProperty, value);
        }
		private static void ClipToBoundsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ClipToBounds").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ClipProperty = DependencyProperty.RegisterAttached( "Clip", typeof(System.Windows.Media.Geometry), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ClipChanged)));
        public static System.Windows.Media.Geometry GetClip(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Geometry)dependencyObject.GetValue(ClipProperty);
        }
        public static void SetClip(DependencyObject dependencyObject, System.Windows.Media.Geometry value)
        {
            dependencyObject.SetValue(ClipProperty, value);
        }
		private static void ClipChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Clip").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SnapsToDevicePixelsProperty = DependencyProperty.RegisterAttached( "SnapsToDevicePixels", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SnapsToDevicePixelsChanged)));
        public static System.Boolean GetSnapsToDevicePixels(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(SnapsToDevicePixelsProperty);
        }
        public static void SetSnapsToDevicePixels(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(SnapsToDevicePixelsProperty, value);
        }
		private static void SnapsToDevicePixelsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SnapsToDevicePixels").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsFocusedProperty = DependencyProperty.RegisterAttached( "IsFocused", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsFocusedChanged)));
        public static System.Boolean GetIsFocused(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsFocusedProperty);
        }
        public static void SetIsFocused(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsFocusedProperty, value);
        }
		private static void IsFocusedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsFocused").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsEnabledProperty = DependencyProperty.RegisterAttached( "IsEnabled", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsEnabledChanged)));
        public static System.Boolean GetIsEnabled(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsEnabledProperty);
        }
        public static void SetIsEnabled(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsEnabledProperty, value);
        }
		private static void IsEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsEnabled").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsHitTestVisibleProperty = DependencyProperty.RegisterAttached( "IsHitTestVisible", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsHitTestVisibleChanged)));
        public static System.Boolean GetIsHitTestVisible(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsHitTestVisibleProperty);
        }
        public static void SetIsHitTestVisible(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsHitTestVisibleProperty, value);
        }
		private static void IsHitTestVisibleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsHitTestVisible").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsVisibleProperty = DependencyProperty.RegisterAttached( "IsVisible", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsVisibleChanged)));
        public static System.Boolean GetIsVisible(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsVisibleProperty);
        }
        public static void SetIsVisible(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsVisibleProperty, value);
        }
		private static void IsVisibleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsVisible").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty FocusableProperty = DependencyProperty.RegisterAttached( "Focusable", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(FocusableChanged)));
        public static System.Boolean GetFocusable(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(FocusableProperty);
        }
        public static void SetFocusable(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(FocusableProperty, value);
        }
		private static void FocusableChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Focusable").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty PersistIdProperty = DependencyProperty.RegisterAttached( "PersistId", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(PersistIdChanged)));
        public static System.Int32 GetPersistId(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(PersistIdProperty);
        }
        public static void SetPersistId(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(PersistIdProperty, value);
        }
		private static void PersistIdChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("PersistId").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsManipulationEnabledProperty = DependencyProperty.RegisterAttached( "IsManipulationEnabled", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsManipulationEnabledChanged)));
        public static System.Boolean GetIsManipulationEnabled(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsManipulationEnabledProperty);
        }
        public static void SetIsManipulationEnabled(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsManipulationEnabledProperty, value);
        }
		private static void IsManipulationEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsManipulationEnabled").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AreAnyTouchesOverProperty = DependencyProperty.RegisterAttached( "AreAnyTouchesOver", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AreAnyTouchesOverChanged)));
        public static System.Boolean GetAreAnyTouchesOver(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(AreAnyTouchesOverProperty);
        }
        public static void SetAreAnyTouchesOver(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(AreAnyTouchesOverProperty, value);
        }
		private static void AreAnyTouchesOverChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AreAnyTouchesOver").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AreAnyTouchesDirectlyOverProperty = DependencyProperty.RegisterAttached( "AreAnyTouchesDirectlyOver", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AreAnyTouchesDirectlyOverChanged)));
        public static System.Boolean GetAreAnyTouchesDirectlyOver(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(AreAnyTouchesDirectlyOverProperty);
        }
        public static void SetAreAnyTouchesDirectlyOver(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(AreAnyTouchesDirectlyOverProperty, value);
        }
		private static void AreAnyTouchesDirectlyOverChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AreAnyTouchesDirectlyOver").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AreAnyTouchesCapturedWithinProperty = DependencyProperty.RegisterAttached( "AreAnyTouchesCapturedWithin", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AreAnyTouchesCapturedWithinChanged)));
        public static System.Boolean GetAreAnyTouchesCapturedWithin(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(AreAnyTouchesCapturedWithinProperty);
        }
        public static void SetAreAnyTouchesCapturedWithin(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(AreAnyTouchesCapturedWithinProperty, value);
        }
		private static void AreAnyTouchesCapturedWithinChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AreAnyTouchesCapturedWithin").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AreAnyTouchesCapturedProperty = DependencyProperty.RegisterAttached( "AreAnyTouchesCaptured", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AreAnyTouchesCapturedChanged)));
        public static System.Boolean GetAreAnyTouchesCaptured(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(AreAnyTouchesCapturedProperty);
        }
        public static void SetAreAnyTouchesCaptured(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(AreAnyTouchesCapturedProperty, value);
        }
		private static void AreAnyTouchesCapturedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AreAnyTouchesCaptured").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TouchesCapturedProperty = DependencyProperty.RegisterAttached( "TouchesCaptured", typeof(System.Collections.Generic.IEnumerable<System.Windows.Input.TouchDevice>), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TouchesCapturedChanged)));
        public static System.Collections.Generic.IEnumerable<System.Windows.Input.TouchDevice> GetTouchesCaptured(DependencyObject dependencyObject)
        {
            return (System.Collections.Generic.IEnumerable<System.Windows.Input.TouchDevice>)dependencyObject.GetValue(TouchesCapturedProperty);
        }
        public static void SetTouchesCaptured(DependencyObject dependencyObject, System.Collections.Generic.IEnumerable<System.Windows.Input.TouchDevice> value)
        {
            dependencyObject.SetValue(TouchesCapturedProperty, value);
        }
		private static void TouchesCapturedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("TouchesCaptured").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TouchesCapturedWithinProperty = DependencyProperty.RegisterAttached( "TouchesCapturedWithin", typeof(System.Collections.Generic.IEnumerable<System.Windows.Input.TouchDevice>), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TouchesCapturedWithinChanged)));
        public static System.Collections.Generic.IEnumerable<System.Windows.Input.TouchDevice> GetTouchesCapturedWithin(DependencyObject dependencyObject)
        {
            return (System.Collections.Generic.IEnumerable<System.Windows.Input.TouchDevice>)dependencyObject.GetValue(TouchesCapturedWithinProperty);
        }
        public static void SetTouchesCapturedWithin(DependencyObject dependencyObject, System.Collections.Generic.IEnumerable<System.Windows.Input.TouchDevice> value)
        {
            dependencyObject.SetValue(TouchesCapturedWithinProperty, value);
        }
		private static void TouchesCapturedWithinChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("TouchesCapturedWithin").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TouchesOverProperty = DependencyProperty.RegisterAttached( "TouchesOver", typeof(System.Collections.Generic.IEnumerable<System.Windows.Input.TouchDevice>), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TouchesOverChanged)));
        public static System.Collections.Generic.IEnumerable<System.Windows.Input.TouchDevice> GetTouchesOver(DependencyObject dependencyObject)
        {
            return (System.Collections.Generic.IEnumerable<System.Windows.Input.TouchDevice>)dependencyObject.GetValue(TouchesOverProperty);
        }
        public static void SetTouchesOver(DependencyObject dependencyObject, System.Collections.Generic.IEnumerable<System.Windows.Input.TouchDevice> value)
        {
            dependencyObject.SetValue(TouchesOverProperty, value);
        }
		private static void TouchesOverChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("TouchesOver").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TouchesDirectlyOverProperty = DependencyProperty.RegisterAttached( "TouchesDirectlyOver", typeof(System.Collections.Generic.IEnumerable<System.Windows.Input.TouchDevice>), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TouchesDirectlyOverChanged)));
        public static System.Collections.Generic.IEnumerable<System.Windows.Input.TouchDevice> GetTouchesDirectlyOver(DependencyObject dependencyObject)
        {
            return (System.Collections.Generic.IEnumerable<System.Windows.Input.TouchDevice>)dependencyObject.GetValue(TouchesDirectlyOverProperty);
        }
        public static void SetTouchesDirectlyOver(DependencyObject dependencyObject, System.Collections.Generic.IEnumerable<System.Windows.Input.TouchDevice> value)
        {
            dependencyObject.SetValue(TouchesDirectlyOverProperty, value);
        }
		private static void TouchesDirectlyOverChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("TouchesDirectlyOver").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty StyleProperty = DependencyProperty.RegisterAttached( "Style", typeof(System.Windows.Style), typeof(d), new PropertyMetadata(new PropertyChangedCallback(StyleChanged)));
        public static System.Windows.Style GetStyle(DependencyObject dependencyObject)
        {
            return (System.Windows.Style)dependencyObject.GetValue(StyleProperty);
        }
        public static void SetStyle(DependencyObject dependencyObject, System.Windows.Style value)
        {
            dependencyObject.SetValue(StyleProperty, value);
        }
		private static void StyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Style").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty OverridesDefaultStyleProperty = DependencyProperty.RegisterAttached( "OverridesDefaultStyle", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(OverridesDefaultStyleChanged)));
        public static System.Boolean GetOverridesDefaultStyle(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(OverridesDefaultStyleProperty);
        }
        public static void SetOverridesDefaultStyle(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(OverridesDefaultStyleProperty, value);
        }
		private static void OverridesDefaultStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("OverridesDefaultStyle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty UseLayoutRoundingProperty = DependencyProperty.RegisterAttached( "UseLayoutRounding", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(UseLayoutRoundingChanged)));
        public static System.Boolean GetUseLayoutRounding(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(UseLayoutRoundingProperty);
        }
        public static void SetUseLayoutRounding(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(UseLayoutRoundingProperty, value);
        }
		private static void UseLayoutRoundingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("UseLayoutRounding").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TriggersProperty = DependencyProperty.RegisterAttached( "Triggers", typeof(System.Windows.TriggerCollection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TriggersChanged)));
        public static System.Windows.TriggerCollection GetTriggers(DependencyObject dependencyObject)
        {
            return (System.Windows.TriggerCollection)dependencyObject.GetValue(TriggersProperty);
        }
        public static void SetTriggers(DependencyObject dependencyObject, System.Windows.TriggerCollection value)
        {
            dependencyObject.SetValue(TriggersProperty, value);
        }
		private static void TriggersChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Triggers").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TemplatedParentProperty = DependencyProperty.RegisterAttached( "TemplatedParent", typeof(System.Windows.DependencyObject), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TemplatedParentChanged)));
        public static System.Windows.DependencyObject GetTemplatedParent(DependencyObject dependencyObject)
        {
            return (System.Windows.DependencyObject)dependencyObject.GetValue(TemplatedParentProperty);
        }
        public static void SetTemplatedParent(DependencyObject dependencyObject, System.Windows.DependencyObject value)
        {
            dependencyObject.SetValue(TemplatedParentProperty, value);
        }
		private static void TemplatedParentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("TemplatedParent").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ResourcesProperty = DependencyProperty.RegisterAttached( "Resources", typeof(System.Windows.ResourceDictionary), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ResourcesChanged)));
        public static System.Windows.ResourceDictionary GetResources(DependencyObject dependencyObject)
        {
            return (System.Windows.ResourceDictionary)dependencyObject.GetValue(ResourcesProperty);
        }
        public static void SetResources(DependencyObject dependencyObject, System.Windows.ResourceDictionary value)
        {
            dependencyObject.SetValue(ResourcesProperty, value);
        }
		private static void ResourcesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Resources").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DataContextProperty = DependencyProperty.RegisterAttached( "DataContext", typeof(System.Object), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DataContextChanged)));
        public static System.Object GetDataContext(DependencyObject dependencyObject)
        {
            return (System.Object)dependencyObject.GetValue(DataContextProperty);
        }
        public static void SetDataContext(DependencyObject dependencyObject, System.Object value)
        {
            dependencyObject.SetValue(DataContextProperty, value);
        }
		private static void DataContextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DataContext").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty BindingGroupProperty = DependencyProperty.RegisterAttached( "BindingGroup", typeof(System.Windows.Data.BindingGroup), typeof(d), new PropertyMetadata(new PropertyChangedCallback(BindingGroupChanged)));
        public static System.Windows.Data.BindingGroup GetBindingGroup(DependencyObject dependencyObject)
        {
            return (System.Windows.Data.BindingGroup)dependencyObject.GetValue(BindingGroupProperty);
        }
        public static void SetBindingGroup(DependencyObject dependencyObject, System.Windows.Data.BindingGroup value)
        {
            dependencyObject.SetValue(BindingGroupProperty, value);
        }
		private static void BindingGroupChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("BindingGroup").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty LanguageProperty = DependencyProperty.RegisterAttached( "Language", typeof(System.Windows.Markup.XmlLanguage), typeof(d), new PropertyMetadata(new PropertyChangedCallback(LanguageChanged)));
        public static System.Windows.Markup.XmlLanguage GetLanguage(DependencyObject dependencyObject)
        {
            return (System.Windows.Markup.XmlLanguage)dependencyObject.GetValue(LanguageProperty);
        }
        public static void SetLanguage(DependencyObject dependencyObject, System.Windows.Markup.XmlLanguage value)
        {
            dependencyObject.SetValue(LanguageProperty, value);
        }
		private static void LanguageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Language").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty NameProperty = DependencyProperty.RegisterAttached( "Name", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(NameChanged)));
        public static System.String GetName(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(NameProperty);
        }
        public static void SetName(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(NameProperty, value);
        }
		private static void NameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Name").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TagProperty = DependencyProperty.RegisterAttached( "Tag", typeof(System.Object), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TagChanged)));
        public static System.Object GetTag(DependencyObject dependencyObject)
        {
            return (System.Object)dependencyObject.GetValue(TagProperty);
        }
        public static void SetTag(DependencyObject dependencyObject, System.Object value)
        {
            dependencyObject.SetValue(TagProperty, value);
        }
		private static void TagChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Tag").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty InputScopeProperty = DependencyProperty.RegisterAttached( "InputScope", typeof(System.Windows.Input.InputScope), typeof(d), new PropertyMetadata(new PropertyChangedCallback(InputScopeChanged)));
        public static System.Windows.Input.InputScope GetInputScope(DependencyObject dependencyObject)
        {
            return (System.Windows.Input.InputScope)dependencyObject.GetValue(InputScopeProperty);
        }
        public static void SetInputScope(DependencyObject dependencyObject, System.Windows.Input.InputScope value)
        {
            dependencyObject.SetValue(InputScopeProperty, value);
        }
		private static void InputScopeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("InputScope").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ActualWidthProperty = DependencyProperty.RegisterAttached( "ActualWidth", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ActualWidthChanged)));
        public static System.Double GetActualWidth(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(ActualWidthProperty);
        }
        public static void SetActualWidth(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(ActualWidthProperty, value);
        }
		private static void ActualWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ActualWidth").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ActualHeightProperty = DependencyProperty.RegisterAttached( "ActualHeight", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ActualHeightChanged)));
        public static System.Double GetActualHeight(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(ActualHeightProperty);
        }
        public static void SetActualHeight(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(ActualHeightProperty, value);
        }
		private static void ActualHeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ActualHeight").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty LayoutTransformProperty = DependencyProperty.RegisterAttached( "LayoutTransform", typeof(System.Windows.Media.Transform), typeof(d), new PropertyMetadata(new PropertyChangedCallback(LayoutTransformChanged)));
        public static System.Windows.Media.Transform GetLayoutTransform(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Transform)dependencyObject.GetValue(LayoutTransformProperty);
        }
        public static void SetLayoutTransform(DependencyObject dependencyObject, System.Windows.Media.Transform value)
        {
            dependencyObject.SetValue(LayoutTransformProperty, value);
        }
		private static void LayoutTransformChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("LayoutTransform").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty WidthProperty = DependencyProperty.RegisterAttached( "Width", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(WidthChanged)));
        public static System.Double GetWidth(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(WidthProperty);
        }
        public static void SetWidth(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(WidthProperty, value);
        }
		private static void WidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Width").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty MinWidthProperty = DependencyProperty.RegisterAttached( "MinWidth", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(MinWidthChanged)));
        public static System.Double GetMinWidth(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(MinWidthProperty);
        }
        public static void SetMinWidth(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(MinWidthProperty, value);
        }
		private static void MinWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("MinWidth").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty MaxWidthProperty = DependencyProperty.RegisterAttached( "MaxWidth", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(MaxWidthChanged)));
        public static System.Double GetMaxWidth(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(MaxWidthProperty);
        }
        public static void SetMaxWidth(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(MaxWidthProperty, value);
        }
		private static void MaxWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("MaxWidth").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty HeightProperty = DependencyProperty.RegisterAttached( "Height", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HeightChanged)));
        public static System.Double GetHeight(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(HeightProperty);
        }
        public static void SetHeight(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(HeightProperty, value);
        }
		private static void HeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Height").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty MinHeightProperty = DependencyProperty.RegisterAttached( "MinHeight", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(MinHeightChanged)));
        public static System.Double GetMinHeight(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(MinHeightProperty);
        }
        public static void SetMinHeight(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(MinHeightProperty, value);
        }
		private static void MinHeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("MinHeight").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty MaxHeightProperty = DependencyProperty.RegisterAttached( "MaxHeight", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(MaxHeightChanged)));
        public static System.Double GetMaxHeight(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(MaxHeightProperty);
        }
        public static void SetMaxHeight(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(MaxHeightProperty, value);
        }
		private static void MaxHeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("MaxHeight").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty FlowDirectionProperty = DependencyProperty.RegisterAttached( "FlowDirection", typeof(System.Windows.FlowDirection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(FlowDirectionChanged)));
        public static System.Windows.FlowDirection GetFlowDirection(DependencyObject dependencyObject)
        {
            return (System.Windows.FlowDirection)dependencyObject.GetValue(FlowDirectionProperty);
        }
        public static void SetFlowDirection(DependencyObject dependencyObject, System.Windows.FlowDirection value)
        {
            dependencyObject.SetValue(FlowDirectionProperty, value);
        }
		private static void FlowDirectionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("FlowDirection").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty MarginProperty = DependencyProperty.RegisterAttached( "Margin", typeof(System.Windows.Thickness), typeof(d), new PropertyMetadata(new PropertyChangedCallback(MarginChanged)));
        public static System.Windows.Thickness GetMargin(DependencyObject dependencyObject)
        {
            return (System.Windows.Thickness)dependencyObject.GetValue(MarginProperty);
        }
        public static void SetMargin(DependencyObject dependencyObject, System.Windows.Thickness value)
        {
            dependencyObject.SetValue(MarginProperty, value);
        }
		private static void MarginChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Margin").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty HorizontalAlignmentProperty = DependencyProperty.RegisterAttached( "HorizontalAlignment", typeof(System.Windows.HorizontalAlignment), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HorizontalAlignmentChanged)));
        public static System.Windows.HorizontalAlignment GetHorizontalAlignment(DependencyObject dependencyObject)
        {
            return (System.Windows.HorizontalAlignment)dependencyObject.GetValue(HorizontalAlignmentProperty);
        }
        public static void SetHorizontalAlignment(DependencyObject dependencyObject, System.Windows.HorizontalAlignment value)
        {
            dependencyObject.SetValue(HorizontalAlignmentProperty, value);
        }
		private static void HorizontalAlignmentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("HorizontalAlignment").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty VerticalAlignmentProperty = DependencyProperty.RegisterAttached( "VerticalAlignment", typeof(System.Windows.VerticalAlignment), typeof(d), new PropertyMetadata(new PropertyChangedCallback(VerticalAlignmentChanged)));
        public static System.Windows.VerticalAlignment GetVerticalAlignment(DependencyObject dependencyObject)
        {
            return (System.Windows.VerticalAlignment)dependencyObject.GetValue(VerticalAlignmentProperty);
        }
        public static void SetVerticalAlignment(DependencyObject dependencyObject, System.Windows.VerticalAlignment value)
        {
            dependencyObject.SetValue(VerticalAlignmentProperty, value);
        }
		private static void VerticalAlignmentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("VerticalAlignment").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty FocusVisualStyleProperty = DependencyProperty.RegisterAttached( "FocusVisualStyle", typeof(System.Windows.Style), typeof(d), new PropertyMetadata(new PropertyChangedCallback(FocusVisualStyleChanged)));
        public static System.Windows.Style GetFocusVisualStyle(DependencyObject dependencyObject)
        {
            return (System.Windows.Style)dependencyObject.GetValue(FocusVisualStyleProperty);
        }
        public static void SetFocusVisualStyle(DependencyObject dependencyObject, System.Windows.Style value)
        {
            dependencyObject.SetValue(FocusVisualStyleProperty, value);
        }
		private static void FocusVisualStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("FocusVisualStyle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CursorProperty = DependencyProperty.RegisterAttached( "Cursor", typeof(System.Windows.Input.Cursor), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CursorChanged)));
        public static System.Windows.Input.Cursor GetCursor(DependencyObject dependencyObject)
        {
            return (System.Windows.Input.Cursor)dependencyObject.GetValue(CursorProperty);
        }
        public static void SetCursor(DependencyObject dependencyObject, System.Windows.Input.Cursor value)
        {
            dependencyObject.SetValue(CursorProperty, value);
        }
		private static void CursorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Cursor").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ForceCursorProperty = DependencyProperty.RegisterAttached( "ForceCursor", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ForceCursorChanged)));
        public static System.Boolean GetForceCursor(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(ForceCursorProperty);
        }
        public static void SetForceCursor(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(ForceCursorProperty, value);
        }
		private static void ForceCursorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ForceCursor").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsInitializedProperty = DependencyProperty.RegisterAttached( "IsInitialized", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsInitializedChanged)));
        public static System.Boolean GetIsInitialized(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsInitializedProperty);
        }
        public static void SetIsInitialized(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsInitializedProperty, value);
        }
		private static void IsInitializedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsInitialized").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsLoadedProperty = DependencyProperty.RegisterAttached( "IsLoaded", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsLoadedChanged)));
        public static System.Boolean GetIsLoaded(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsLoadedProperty);
        }
        public static void SetIsLoaded(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsLoadedProperty, value);
        }
		private static void IsLoadedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsLoaded").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ToolTipProperty = DependencyProperty.RegisterAttached( "ToolTip", typeof(System.Object), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ToolTipChanged)));
        public static System.Object GetToolTip(DependencyObject dependencyObject)
        {
            return (System.Object)dependencyObject.GetValue(ToolTipProperty);
        }
        public static void SetToolTip(DependencyObject dependencyObject, System.Object value)
        {
            dependencyObject.SetValue(ToolTipProperty, value);
        }
		private static void ToolTipChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ToolTip").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ContextMenuProperty = DependencyProperty.RegisterAttached( "ContextMenu", typeof(System.Windows.Controls.ContextMenu), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ContextMenuChanged)));
        public static System.Windows.Controls.ContextMenu GetContextMenu(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.ContextMenu)dependencyObject.GetValue(ContextMenuProperty);
        }
        public static void SetContextMenu(DependencyObject dependencyObject, System.Windows.Controls.ContextMenu value)
        {
            dependencyObject.SetValue(ContextMenuProperty, value);
        }
		private static void ContextMenuChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ContextMenu").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ParentProperty = DependencyProperty.RegisterAttached( "Parent", typeof(System.Windows.DependencyObject), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ParentChanged)));
        public static System.Windows.DependencyObject GetParent(DependencyObject dependencyObject)
        {
            return (System.Windows.DependencyObject)dependencyObject.GetValue(ParentProperty);
        }
        public static void SetParent(DependencyObject dependencyObject, System.Windows.DependencyObject value)
        {
            dependencyObject.SetValue(ParentProperty, value);
        }
		private static void ParentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Parent").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AdornedElementProperty = DependencyProperty.RegisterAttached( "AdornedElement", typeof(System.Windows.UIElement), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AdornedElementChanged)));
        public static System.Windows.UIElement GetAdornedElement(DependencyObject dependencyObject)
        {
            return (System.Windows.UIElement)dependencyObject.GetValue(AdornedElementProperty);
        }
        public static void SetAdornedElement(DependencyObject dependencyObject, System.Windows.UIElement value)
        {
            dependencyObject.SetValue(AdornedElementProperty, value);
        }
		private static void AdornedElementChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AdornedElement").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsClipEnabledProperty = DependencyProperty.RegisterAttached( "IsClipEnabled", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsClipEnabledChanged)));
        public static System.Boolean GetIsClipEnabled(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsClipEnabledProperty);
        }
        public static void SetIsClipEnabled(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsClipEnabledProperty, value);
        }
		private static void IsClipEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsClipEnabled").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty StretchProperty = DependencyProperty.RegisterAttached( "Stretch", typeof(System.Windows.Media.Stretch), typeof(d), new PropertyMetadata(new PropertyChangedCallback(StretchChanged)));
        public static System.Windows.Media.Stretch GetStretch(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Stretch)dependencyObject.GetValue(StretchProperty);
        }
        public static void SetStretch(DependencyObject dependencyObject, System.Windows.Media.Stretch value)
        {
            dependencyObject.SetValue(StretchProperty, value);
        }
		private static void StretchChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Stretch").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RenderedGeometryProperty = DependencyProperty.RegisterAttached( "RenderedGeometry", typeof(System.Windows.Media.Geometry), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RenderedGeometryChanged)));
        public static System.Windows.Media.Geometry GetRenderedGeometry(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Geometry)dependencyObject.GetValue(RenderedGeometryProperty);
        }
        public static void SetRenderedGeometry(DependencyObject dependencyObject, System.Windows.Media.Geometry value)
        {
            dependencyObject.SetValue(RenderedGeometryProperty, value);
        }
		private static void RenderedGeometryChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RenderedGeometry").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty GeometryTransformProperty = DependencyProperty.RegisterAttached( "GeometryTransform", typeof(System.Windows.Media.Transform), typeof(d), new PropertyMetadata(new PropertyChangedCallback(GeometryTransformChanged)));
        public static System.Windows.Media.Transform GetGeometryTransform(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Transform)dependencyObject.GetValue(GeometryTransformProperty);
        }
        public static void SetGeometryTransform(DependencyObject dependencyObject, System.Windows.Media.Transform value)
        {
            dependencyObject.SetValue(GeometryTransformProperty, value);
        }
		private static void GeometryTransformChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("GeometryTransform").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty FillProperty = DependencyProperty.RegisterAttached( "Fill", typeof(System.Windows.Media.Brush), typeof(d), new PropertyMetadata(new PropertyChangedCallback(FillChanged)));
        public static System.Windows.Media.Brush GetFill(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Brush)dependencyObject.GetValue(FillProperty);
        }
        public static void SetFill(DependencyObject dependencyObject, System.Windows.Media.Brush value)
        {
            dependencyObject.SetValue(FillProperty, value);
        }
		private static void FillChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Fill").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty StrokeProperty = DependencyProperty.RegisterAttached( "Stroke", typeof(System.Windows.Media.Brush), typeof(d), new PropertyMetadata(new PropertyChangedCallback(StrokeChanged)));
        public static System.Windows.Media.Brush GetStroke(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Brush)dependencyObject.GetValue(StrokeProperty);
        }
        public static void SetStroke(DependencyObject dependencyObject, System.Windows.Media.Brush value)
        {
            dependencyObject.SetValue(StrokeProperty, value);
        }
		private static void StrokeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Stroke").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty StrokeThicknessProperty = DependencyProperty.RegisterAttached( "StrokeThickness", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(StrokeThicknessChanged)));
        public static System.Double GetStrokeThickness(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(StrokeThicknessProperty);
        }
        public static void SetStrokeThickness(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(StrokeThicknessProperty, value);
        }
		private static void StrokeThicknessChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("StrokeThickness").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty StrokeStartLineCapProperty = DependencyProperty.RegisterAttached( "StrokeStartLineCap", typeof(System.Windows.Media.PenLineCap), typeof(d), new PropertyMetadata(new PropertyChangedCallback(StrokeStartLineCapChanged)));
        public static System.Windows.Media.PenLineCap GetStrokeStartLineCap(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.PenLineCap)dependencyObject.GetValue(StrokeStartLineCapProperty);
        }
        public static void SetStrokeStartLineCap(DependencyObject dependencyObject, System.Windows.Media.PenLineCap value)
        {
            dependencyObject.SetValue(StrokeStartLineCapProperty, value);
        }
		private static void StrokeStartLineCapChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("StrokeStartLineCap").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty StrokeEndLineCapProperty = DependencyProperty.RegisterAttached( "StrokeEndLineCap", typeof(System.Windows.Media.PenLineCap), typeof(d), new PropertyMetadata(new PropertyChangedCallback(StrokeEndLineCapChanged)));
        public static System.Windows.Media.PenLineCap GetStrokeEndLineCap(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.PenLineCap)dependencyObject.GetValue(StrokeEndLineCapProperty);
        }
        public static void SetStrokeEndLineCap(DependencyObject dependencyObject, System.Windows.Media.PenLineCap value)
        {
            dependencyObject.SetValue(StrokeEndLineCapProperty, value);
        }
		private static void StrokeEndLineCapChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("StrokeEndLineCap").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty StrokeDashCapProperty = DependencyProperty.RegisterAttached( "StrokeDashCap", typeof(System.Windows.Media.PenLineCap), typeof(d), new PropertyMetadata(new PropertyChangedCallback(StrokeDashCapChanged)));
        public static System.Windows.Media.PenLineCap GetStrokeDashCap(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.PenLineCap)dependencyObject.GetValue(StrokeDashCapProperty);
        }
        public static void SetStrokeDashCap(DependencyObject dependencyObject, System.Windows.Media.PenLineCap value)
        {
            dependencyObject.SetValue(StrokeDashCapProperty, value);
        }
		private static void StrokeDashCapChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("StrokeDashCap").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty StrokeLineJoinProperty = DependencyProperty.RegisterAttached( "StrokeLineJoin", typeof(System.Windows.Media.PenLineJoin), typeof(d), new PropertyMetadata(new PropertyChangedCallback(StrokeLineJoinChanged)));
        public static System.Windows.Media.PenLineJoin GetStrokeLineJoin(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.PenLineJoin)dependencyObject.GetValue(StrokeLineJoinProperty);
        }
        public static void SetStrokeLineJoin(DependencyObject dependencyObject, System.Windows.Media.PenLineJoin value)
        {
            dependencyObject.SetValue(StrokeLineJoinProperty, value);
        }
		private static void StrokeLineJoinChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("StrokeLineJoin").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty StrokeMiterLimitProperty = DependencyProperty.RegisterAttached( "StrokeMiterLimit", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(StrokeMiterLimitChanged)));
        public static System.Double GetStrokeMiterLimit(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(StrokeMiterLimitProperty);
        }
        public static void SetStrokeMiterLimit(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(StrokeMiterLimitProperty, value);
        }
		private static void StrokeMiterLimitChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("StrokeMiterLimit").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty StrokeDashOffsetProperty = DependencyProperty.RegisterAttached( "StrokeDashOffset", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(StrokeDashOffsetChanged)));
        public static System.Double GetStrokeDashOffset(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(StrokeDashOffsetProperty);
        }
        public static void SetStrokeDashOffset(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(StrokeDashOffsetProperty, value);
        }
		private static void StrokeDashOffsetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("StrokeDashOffset").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty StrokeDashArrayProperty = DependencyProperty.RegisterAttached( "StrokeDashArray", typeof(System.Windows.Media.DoubleCollection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(StrokeDashArrayChanged)));
        public static System.Windows.Media.DoubleCollection GetStrokeDashArray(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.DoubleCollection)dependencyObject.GetValue(StrokeDashArrayProperty);
        }
        public static void SetStrokeDashArray(DependencyObject dependencyObject, System.Windows.Media.DoubleCollection value)
        {
            dependencyObject.SetValue(StrokeDashArrayProperty, value);
        }
		private static void StrokeDashArrayChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("StrokeDashArray").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty BackgroundProperty = DependencyProperty.RegisterAttached( "Background", typeof(System.Windows.Media.Brush), typeof(d), new PropertyMetadata(new PropertyChangedCallback(BackgroundChanged)));
        public static System.Windows.Media.Brush GetBackground(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Brush)dependencyObject.GetValue(BackgroundProperty);
        }
        public static void SetBackground(DependencyObject dependencyObject, System.Windows.Media.Brush value)
        {
            dependencyObject.SetValue(BackgroundProperty, value);
        }
		private static void BackgroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Background").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsItemsHostProperty = DependencyProperty.RegisterAttached( "IsItemsHost", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsItemsHostChanged)));
        public static System.Boolean GetIsItemsHost(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsItemsHostProperty);
        }
        public static void SetIsItemsHost(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsItemsHostProperty, value);
        }
		private static void IsItemsHostChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsItemsHost").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty LogicalOrientationPublicProperty = DependencyProperty.RegisterAttached( "LogicalOrientationPublic", typeof(System.Windows.Controls.Orientation), typeof(d), new PropertyMetadata(new PropertyChangedCallback(LogicalOrientationPublicChanged)));
        public static System.Windows.Controls.Orientation GetLogicalOrientationPublic(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.Orientation)dependencyObject.GetValue(LogicalOrientationPublicProperty);
        }
        public static void SetLogicalOrientationPublic(DependencyObject dependencyObject, System.Windows.Controls.Orientation value)
        {
            dependencyObject.SetValue(LogicalOrientationPublicProperty, value);
        }
		private static void LogicalOrientationPublicChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("LogicalOrientationPublic").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty HasLogicalOrientationPublicProperty = DependencyProperty.RegisterAttached( "HasLogicalOrientationPublic", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HasLogicalOrientationPublicChanged)));
        public static System.Boolean GetHasLogicalOrientationPublic(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(HasLogicalOrientationPublicProperty);
        }
        public static void SetHasLogicalOrientationPublic(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(HasLogicalOrientationPublicProperty, value);
        }
		private static void HasLogicalOrientationPublicChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("HasLogicalOrientationPublic").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty BorderBrushProperty = DependencyProperty.RegisterAttached( "BorderBrush", typeof(System.Windows.Media.Brush), typeof(d), new PropertyMetadata(new PropertyChangedCallback(BorderBrushChanged)));
        public static System.Windows.Media.Brush GetBorderBrush(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Brush)dependencyObject.GetValue(BorderBrushProperty);
        }
        public static void SetBorderBrush(DependencyObject dependencyObject, System.Windows.Media.Brush value)
        {
            dependencyObject.SetValue(BorderBrushProperty, value);
        }
		private static void BorderBrushChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("BorderBrush").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty BorderThicknessProperty = DependencyProperty.RegisterAttached( "BorderThickness", typeof(System.Windows.Thickness), typeof(d), new PropertyMetadata(new PropertyChangedCallback(BorderThicknessChanged)));
        public static System.Windows.Thickness GetBorderThickness(DependencyObject dependencyObject)
        {
            return (System.Windows.Thickness)dependencyObject.GetValue(BorderThicknessProperty);
        }
        public static void SetBorderThickness(DependencyObject dependencyObject, System.Windows.Thickness value)
        {
            dependencyObject.SetValue(BorderThicknessProperty, value);
        }
		private static void BorderThicknessChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("BorderThickness").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ForegroundProperty = DependencyProperty.RegisterAttached( "Foreground", typeof(System.Windows.Media.Brush), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ForegroundChanged)));
        public static System.Windows.Media.Brush GetForeground(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Brush)dependencyObject.GetValue(ForegroundProperty);
        }
        public static void SetForeground(DependencyObject dependencyObject, System.Windows.Media.Brush value)
        {
            dependencyObject.SetValue(ForegroundProperty, value);
        }
		private static void ForegroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Foreground").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty FontFamilyProperty = DependencyProperty.RegisterAttached( "FontFamily", typeof(System.Windows.Media.FontFamily), typeof(d), new PropertyMetadata(new PropertyChangedCallback(FontFamilyChanged)));
        public static System.Windows.Media.FontFamily GetFontFamily(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.FontFamily)dependencyObject.GetValue(FontFamilyProperty);
        }
        public static void SetFontFamily(DependencyObject dependencyObject, System.Windows.Media.FontFamily value)
        {
            dependencyObject.SetValue(FontFamilyProperty, value);
        }
		private static void FontFamilyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("FontFamily").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty FontSizeProperty = DependencyProperty.RegisterAttached( "FontSize", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(FontSizeChanged)));
        public static System.Double GetFontSize(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(FontSizeProperty);
        }
        public static void SetFontSize(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(FontSizeProperty, value);
        }
		private static void FontSizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("FontSize").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty FontStretchProperty = DependencyProperty.RegisterAttached( "FontStretch", typeof(System.Windows.FontStretch), typeof(d), new PropertyMetadata(new PropertyChangedCallback(FontStretchChanged)));
        public static System.Windows.FontStretch GetFontStretch(DependencyObject dependencyObject)
        {
            return (System.Windows.FontStretch)dependencyObject.GetValue(FontStretchProperty);
        }
        public static void SetFontStretch(DependencyObject dependencyObject, System.Windows.FontStretch value)
        {
            dependencyObject.SetValue(FontStretchProperty, value);
        }
		private static void FontStretchChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("FontStretch").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty FontStyleProperty = DependencyProperty.RegisterAttached( "FontStyle", typeof(System.Windows.FontStyle), typeof(d), new PropertyMetadata(new PropertyChangedCallback(FontStyleChanged)));
        public static System.Windows.FontStyle GetFontStyle(DependencyObject dependencyObject)
        {
            return (System.Windows.FontStyle)dependencyObject.GetValue(FontStyleProperty);
        }
        public static void SetFontStyle(DependencyObject dependencyObject, System.Windows.FontStyle value)
        {
            dependencyObject.SetValue(FontStyleProperty, value);
        }
		private static void FontStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("FontStyle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty FontWeightProperty = DependencyProperty.RegisterAttached( "FontWeight", typeof(System.Windows.FontWeight), typeof(d), new PropertyMetadata(new PropertyChangedCallback(FontWeightChanged)));
        public static System.Windows.FontWeight GetFontWeight(DependencyObject dependencyObject)
        {
            return (System.Windows.FontWeight)dependencyObject.GetValue(FontWeightProperty);
        }
        public static void SetFontWeight(DependencyObject dependencyObject, System.Windows.FontWeight value)
        {
            dependencyObject.SetValue(FontWeightProperty, value);
        }
		private static void FontWeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("FontWeight").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty HorizontalContentAlignmentProperty = DependencyProperty.RegisterAttached( "HorizontalContentAlignment", typeof(System.Windows.HorizontalAlignment), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HorizontalContentAlignmentChanged)));
        public static System.Windows.HorizontalAlignment GetHorizontalContentAlignment(DependencyObject dependencyObject)
        {
            return (System.Windows.HorizontalAlignment)dependencyObject.GetValue(HorizontalContentAlignmentProperty);
        }
        public static void SetHorizontalContentAlignment(DependencyObject dependencyObject, System.Windows.HorizontalAlignment value)
        {
            dependencyObject.SetValue(HorizontalContentAlignmentProperty, value);
        }
		private static void HorizontalContentAlignmentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("HorizontalContentAlignment").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty VerticalContentAlignmentProperty = DependencyProperty.RegisterAttached( "VerticalContentAlignment", typeof(System.Windows.VerticalAlignment), typeof(d), new PropertyMetadata(new PropertyChangedCallback(VerticalContentAlignmentChanged)));
        public static System.Windows.VerticalAlignment GetVerticalContentAlignment(DependencyObject dependencyObject)
        {
            return (System.Windows.VerticalAlignment)dependencyObject.GetValue(VerticalContentAlignmentProperty);
        }
        public static void SetVerticalContentAlignment(DependencyObject dependencyObject, System.Windows.VerticalAlignment value)
        {
            dependencyObject.SetValue(VerticalContentAlignmentProperty, value);
        }
		private static void VerticalContentAlignmentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("VerticalContentAlignment").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TabIndexProperty = DependencyProperty.RegisterAttached( "TabIndex", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TabIndexChanged)));
        public static System.Int32 GetTabIndex(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(TabIndexProperty);
        }
        public static void SetTabIndex(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(TabIndexProperty, value);
        }
		private static void TabIndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("TabIndex").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsTabStopProperty = DependencyProperty.RegisterAttached( "IsTabStop", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsTabStopChanged)));
        public static System.Boolean GetIsTabStop(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsTabStopProperty);
        }
        public static void SetIsTabStop(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsTabStopProperty, value);
        }
		private static void IsTabStopChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsTabStop").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty PaddingProperty = DependencyProperty.RegisterAttached( "Padding", typeof(System.Windows.Thickness), typeof(d), new PropertyMetadata(new PropertyChangedCallback(PaddingChanged)));
        public static System.Windows.Thickness GetPadding(DependencyObject dependencyObject)
        {
            return (System.Windows.Thickness)dependencyObject.GetValue(PaddingProperty);
        }
        public static void SetPadding(DependencyObject dependencyObject, System.Windows.Thickness value)
        {
            dependencyObject.SetValue(PaddingProperty, value);
        }
		private static void PaddingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Padding").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TemplateProperty = DependencyProperty.RegisterAttached( "Template", typeof(System.Windows.Controls.ControlTemplate), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TemplateChanged)));
        public static System.Windows.Controls.ControlTemplate GetTemplate(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.ControlTemplate)dependencyObject.GetValue(TemplateProperty);
        }
        public static void SetTemplate(DependencyObject dependencyObject, System.Windows.Controls.ControlTemplate value)
        {
            dependencyObject.SetValue(TemplateProperty, value);
        }
		private static void TemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Template").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ContentProperty = DependencyProperty.RegisterAttached( "Content", typeof(System.Object), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ContentChanged)));
        public static System.Object GetContent(DependencyObject dependencyObject)
        {
            return (System.Object)dependencyObject.GetValue(ContentProperty);
        }
        public static void SetContent(DependencyObject dependencyObject, System.Object value)
        {
            dependencyObject.SetValue(ContentProperty, value);
        }
		private static void ContentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Content").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty HasContentProperty = DependencyProperty.RegisterAttached( "HasContent", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HasContentChanged)));
        public static System.Boolean GetHasContent(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(HasContentProperty);
        }
        public static void SetHasContent(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(HasContentProperty, value);
        }
		private static void HasContentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("HasContent").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ContentTemplateProperty = DependencyProperty.RegisterAttached( "ContentTemplate", typeof(System.Windows.DataTemplate), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ContentTemplateChanged)));
        public static System.Windows.DataTemplate GetContentTemplate(DependencyObject dependencyObject)
        {
            return (System.Windows.DataTemplate)dependencyObject.GetValue(ContentTemplateProperty);
        }
        public static void SetContentTemplate(DependencyObject dependencyObject, System.Windows.DataTemplate value)
        {
            dependencyObject.SetValue(ContentTemplateProperty, value);
        }
		private static void ContentTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ContentTemplate").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ContentTemplateSelectorProperty = DependencyProperty.RegisterAttached( "ContentTemplateSelector", typeof(System.Windows.Controls.DataTemplateSelector), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ContentTemplateSelectorChanged)));
        public static System.Windows.Controls.DataTemplateSelector GetContentTemplateSelector(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.DataTemplateSelector)dependencyObject.GetValue(ContentTemplateSelectorProperty);
        }
        public static void SetContentTemplateSelector(DependencyObject dependencyObject, System.Windows.Controls.DataTemplateSelector value)
        {
            dependencyObject.SetValue(ContentTemplateSelectorProperty, value);
        }
		private static void ContentTemplateSelectorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ContentTemplateSelector").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ContentStringFormatProperty = DependencyProperty.RegisterAttached( "ContentStringFormat", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ContentStringFormatChanged)));
        public static System.String GetContentStringFormat(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(ContentStringFormatProperty);
        }
        public static void SetContentStringFormat(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(ContentStringFormatProperty, value);
        }
		private static void ContentStringFormatChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ContentStringFormat").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TaskbarItemInfoProperty = DependencyProperty.RegisterAttached( "TaskbarItemInfo", typeof(System.Windows.Shell.TaskbarItemInfo), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TaskbarItemInfoChanged)));
        public static System.Windows.Shell.TaskbarItemInfo GetTaskbarItemInfo(DependencyObject dependencyObject)
        {
            return (System.Windows.Shell.TaskbarItemInfo)dependencyObject.GetValue(TaskbarItemInfoProperty);
        }
        public static void SetTaskbarItemInfo(DependencyObject dependencyObject, System.Windows.Shell.TaskbarItemInfo value)
        {
            dependencyObject.SetValue(TaskbarItemInfoProperty, value);
        }
		private static void TaskbarItemInfoChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("TaskbarItemInfo").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AllowsTransparencyProperty = DependencyProperty.RegisterAttached( "AllowsTransparency", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AllowsTransparencyChanged)));
        public static System.Boolean GetAllowsTransparency(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(AllowsTransparencyProperty);
        }
        public static void SetAllowsTransparency(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(AllowsTransparencyProperty, value);
        }
		private static void AllowsTransparencyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AllowsTransparency").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TitleProperty = DependencyProperty.RegisterAttached( "Title", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TitleChanged)));
        public static System.String GetTitle(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(TitleProperty);
        }
        public static void SetTitle(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(TitleProperty, value);
        }
		private static void TitleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Title").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SizeToContentProperty = DependencyProperty.RegisterAttached( "SizeToContent", typeof(System.Windows.SizeToContent), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SizeToContentChanged)));
        public static System.Windows.SizeToContent GetSizeToContent(DependencyObject dependencyObject)
        {
            return (System.Windows.SizeToContent)dependencyObject.GetValue(SizeToContentProperty);
        }
        public static void SetSizeToContent(DependencyObject dependencyObject, System.Windows.SizeToContent value)
        {
            dependencyObject.SetValue(SizeToContentProperty, value);
        }
		private static void SizeToContentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SizeToContent").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TopProperty = DependencyProperty.RegisterAttached( "Top", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TopChanged)));
        public static System.Double GetTop(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(TopProperty);
        }
        public static void SetTop(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(TopProperty, value);
        }
		private static void TopChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Top").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty LeftProperty = DependencyProperty.RegisterAttached( "Left", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(LeftChanged)));
        public static System.Double GetLeft(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(LeftProperty);
        }
        public static void SetLeft(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(LeftProperty, value);
        }
		private static void LeftChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Left").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RestoreBoundsProperty = DependencyProperty.RegisterAttached( "RestoreBounds", typeof(System.Windows.Rect), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RestoreBoundsChanged)));
        public static System.Windows.Rect GetRestoreBounds(DependencyObject dependencyObject)
        {
            return (System.Windows.Rect)dependencyObject.GetValue(RestoreBoundsProperty);
        }
        public static void SetRestoreBounds(DependencyObject dependencyObject, System.Windows.Rect value)
        {
            dependencyObject.SetValue(RestoreBoundsProperty, value);
        }
		private static void RestoreBoundsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RestoreBounds").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty WindowStartupLocationProperty = DependencyProperty.RegisterAttached( "WindowStartupLocation", typeof(System.Windows.WindowStartupLocation), typeof(d), new PropertyMetadata(new PropertyChangedCallback(WindowStartupLocationChanged)));
        public static System.Windows.WindowStartupLocation GetWindowStartupLocation(DependencyObject dependencyObject)
        {
            return (System.Windows.WindowStartupLocation)dependencyObject.GetValue(WindowStartupLocationProperty);
        }
        public static void SetWindowStartupLocation(DependencyObject dependencyObject, System.Windows.WindowStartupLocation value)
        {
            dependencyObject.SetValue(WindowStartupLocationProperty, value);
        }
		private static void WindowStartupLocationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("WindowStartupLocation").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ShowInTaskbarProperty = DependencyProperty.RegisterAttached( "ShowInTaskbar", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ShowInTaskbarChanged)));
        public static System.Boolean GetShowInTaskbar(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(ShowInTaskbarProperty);
        }
        public static void SetShowInTaskbar(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(ShowInTaskbarProperty, value);
        }
		private static void ShowInTaskbarChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ShowInTaskbar").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsActiveProperty = DependencyProperty.RegisterAttached( "IsActive", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsActiveChanged)));
        public static System.Boolean GetIsActive(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsActiveProperty);
        }
        public static void SetIsActive(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsActiveProperty, value);
        }
		private static void IsActiveChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsActive").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty OwnerProperty = DependencyProperty.RegisterAttached( "Owner", typeof(System.Windows.Window), typeof(d), new PropertyMetadata(new PropertyChangedCallback(OwnerChanged)));
        public static System.Windows.Window GetOwner(DependencyObject dependencyObject)
        {
            return (System.Windows.Window)dependencyObject.GetValue(OwnerProperty);
        }
        public static void SetOwner(DependencyObject dependencyObject, System.Windows.Window value)
        {
            dependencyObject.SetValue(OwnerProperty, value);
        }
		private static void OwnerChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Owner").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty OwnedWindowsProperty = DependencyProperty.RegisterAttached( "OwnedWindows", typeof(System.Windows.WindowCollection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(OwnedWindowsChanged)));
        public static System.Windows.WindowCollection GetOwnedWindows(DependencyObject dependencyObject)
        {
            return (System.Windows.WindowCollection)dependencyObject.GetValue(OwnedWindowsProperty);
        }
        public static void SetOwnedWindows(DependencyObject dependencyObject, System.Windows.WindowCollection value)
        {
            dependencyObject.SetValue(OwnedWindowsProperty, value);
        }
		private static void OwnedWindowsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("OwnedWindows").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DialogResultProperty = DependencyProperty.RegisterAttached( "DialogResult", typeof(System.Nullable<System.Boolean>), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DialogResultChanged)));
        public static System.Nullable<System.Boolean> GetDialogResult(DependencyObject dependencyObject)
        {
            return (System.Nullable<System.Boolean>)dependencyObject.GetValue(DialogResultProperty);
        }
        public static void SetDialogResult(DependencyObject dependencyObject, System.Nullable<System.Boolean> value)
        {
            dependencyObject.SetValue(DialogResultProperty, value);
        }
		private static void DialogResultChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DialogResult").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty WindowStyleProperty = DependencyProperty.RegisterAttached( "WindowStyle", typeof(System.Windows.WindowStyle), typeof(d), new PropertyMetadata(new PropertyChangedCallback(WindowStyleChanged)));
        public static System.Windows.WindowStyle GetWindowStyle(DependencyObject dependencyObject)
        {
            return (System.Windows.WindowStyle)dependencyObject.GetValue(WindowStyleProperty);
        }
        public static void SetWindowStyle(DependencyObject dependencyObject, System.Windows.WindowStyle value)
        {
            dependencyObject.SetValue(WindowStyleProperty, value);
        }
		private static void WindowStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("WindowStyle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty WindowStateProperty = DependencyProperty.RegisterAttached( "WindowState", typeof(System.Windows.WindowState), typeof(d), new PropertyMetadata(new PropertyChangedCallback(WindowStateChanged)));
        public static System.Windows.WindowState GetWindowState(DependencyObject dependencyObject)
        {
            return (System.Windows.WindowState)dependencyObject.GetValue(WindowStateProperty);
        }
        public static void SetWindowState(DependencyObject dependencyObject, System.Windows.WindowState value)
        {
            dependencyObject.SetValue(WindowStateProperty, value);
        }
		private static void WindowStateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("WindowState").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ResizeModeProperty = DependencyProperty.RegisterAttached( "ResizeMode", typeof(System.Windows.ResizeMode), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ResizeModeChanged)));
        public static System.Windows.ResizeMode GetResizeMode(DependencyObject dependencyObject)
        {
            return (System.Windows.ResizeMode)dependencyObject.GetValue(ResizeModeProperty);
        }
        public static void SetResizeMode(DependencyObject dependencyObject, System.Windows.ResizeMode value)
        {
            dependencyObject.SetValue(ResizeModeProperty, value);
        }
		private static void ResizeModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ResizeMode").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TopmostProperty = DependencyProperty.RegisterAttached( "Topmost", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TopmostChanged)));
        public static System.Boolean GetTopmost(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(TopmostProperty);
        }
        public static void SetTopmost(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(TopmostProperty, value);
        }
		private static void TopmostChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Topmost").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ShowActivatedProperty = DependencyProperty.RegisterAttached( "ShowActivated", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ShowActivatedChanged)));
        public static System.Boolean GetShowActivated(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(ShowActivatedProperty);
        }
        public static void SetShowActivated(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(ShowActivatedProperty, value);
        }
		private static void ShowActivatedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ShowActivated").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SandboxExternalContentProperty = DependencyProperty.RegisterAttached( "SandboxExternalContent", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SandboxExternalContentChanged)));
        public static System.Boolean GetSandboxExternalContent(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(SandboxExternalContentProperty);
        }
        public static void SetSandboxExternalContent(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(SandboxExternalContentProperty, value);
        }
		private static void SandboxExternalContentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SandboxExternalContent").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty NavigationServiceProperty = DependencyProperty.RegisterAttached( "NavigationService", typeof(System.Windows.Navigation.NavigationService), typeof(d), new PropertyMetadata(new PropertyChangedCallback(NavigationServiceChanged)));
        public static System.Windows.Navigation.NavigationService GetNavigationService(DependencyObject dependencyObject)
        {
            return (System.Windows.Navigation.NavigationService)dependencyObject.GetValue(NavigationServiceProperty);
        }
        public static void SetNavigationService(DependencyObject dependencyObject, System.Windows.Navigation.NavigationService value)
        {
            dependencyObject.SetValue(NavigationServiceProperty, value);
        }
		private static void NavigationServiceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("NavigationService").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty BackStackProperty = DependencyProperty.RegisterAttached( "BackStack", typeof(System.Collections.IEnumerable), typeof(d), new PropertyMetadata(new PropertyChangedCallback(BackStackChanged)));
        public static System.Collections.IEnumerable GetBackStack(DependencyObject dependencyObject)
        {
            return (System.Collections.IEnumerable)dependencyObject.GetValue(BackStackProperty);
        }
        public static void SetBackStack(DependencyObject dependencyObject, System.Collections.IEnumerable value)
        {
            dependencyObject.SetValue(BackStackProperty, value);
        }
		private static void BackStackChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("BackStack").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ForwardStackProperty = DependencyProperty.RegisterAttached( "ForwardStack", typeof(System.Collections.IEnumerable), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ForwardStackChanged)));
        public static System.Collections.IEnumerable GetForwardStack(DependencyObject dependencyObject)
        {
            return (System.Collections.IEnumerable)dependencyObject.GetValue(ForwardStackProperty);
        }
        public static void SetForwardStack(DependencyObject dependencyObject, System.Collections.IEnumerable value)
        {
            dependencyObject.SetValue(ForwardStackProperty, value);
        }
		private static void ForwardStackChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ForwardStack").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ShowsNavigationUIProperty = DependencyProperty.RegisterAttached( "ShowsNavigationUI", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ShowsNavigationUIChanged)));
        public static System.Boolean GetShowsNavigationUI(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(ShowsNavigationUIProperty);
        }
        public static void SetShowsNavigationUI(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(ShowsNavigationUIProperty, value);
        }
		private static void ShowsNavigationUIChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ShowsNavigationUI").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CurrentSourceProperty = DependencyProperty.RegisterAttached( "CurrentSource", typeof(System.Uri), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CurrentSourceChanged)));
        public static System.Uri GetCurrentSource(DependencyObject dependencyObject)
        {
            return (System.Uri)dependencyObject.GetValue(CurrentSourceProperty);
        }
        public static void SetCurrentSource(DependencyObject dependencyObject, System.Uri value)
        {
            dependencyObject.SetValue(CurrentSourceProperty, value);
        }
		private static void CurrentSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CurrentSource").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanGoForwardProperty = DependencyProperty.RegisterAttached( "CanGoForward", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanGoForwardChanged)));
        public static System.Boolean GetCanGoForward(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanGoForwardProperty);
        }
        public static void SetCanGoForward(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanGoForwardProperty, value);
        }
		private static void CanGoForwardChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanGoForward").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanGoBackProperty = DependencyProperty.RegisterAttached( "CanGoBack", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanGoBackChanged)));
        public static System.Boolean GetCanGoBack(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanGoBackProperty);
        }
        public static void SetCanGoBack(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanGoBackProperty, value);
        }
		private static void CanGoBackChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanGoBack").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AuthorProperty = DependencyProperty.RegisterAttached( "Author", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AuthorChanged)));
        public static System.String GetAuthor(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(AuthorProperty);
        }
        public static void SetAuthor(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(AuthorProperty, value);
        }
		private static void AuthorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Author").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsExpandedProperty = DependencyProperty.RegisterAttached( "IsExpanded", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsExpandedChanged)));
        public static System.Boolean GetIsExpanded(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsExpandedProperty);
        }
        public static void SetIsExpanded(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsExpandedProperty, value);
        }
		private static void IsExpandedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsExpanded").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsMouseOverAnchorProperty = DependencyProperty.RegisterAttached( "IsMouseOverAnchor", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsMouseOverAnchorChanged)));
        public static System.Boolean GetIsMouseOverAnchor(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsMouseOverAnchorProperty);
        }
        public static void SetIsMouseOverAnchor(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsMouseOverAnchorProperty, value);
        }
		private static void IsMouseOverAnchorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsMouseOverAnchor").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CaptionFontFamilyProperty = DependencyProperty.RegisterAttached( "CaptionFontFamily", typeof(System.Windows.Media.FontFamily), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CaptionFontFamilyChanged)));
        public static System.Windows.Media.FontFamily GetCaptionFontFamily(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.FontFamily)dependencyObject.GetValue(CaptionFontFamilyProperty);
        }
        public static void SetCaptionFontFamily(DependencyObject dependencyObject, System.Windows.Media.FontFamily value)
        {
            dependencyObject.SetValue(CaptionFontFamilyProperty, value);
        }
		private static void CaptionFontFamilyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CaptionFontFamily").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CaptionFontSizeProperty = DependencyProperty.RegisterAttached( "CaptionFontSize", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CaptionFontSizeChanged)));
        public static System.Double GetCaptionFontSize(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(CaptionFontSizeProperty);
        }
        public static void SetCaptionFontSize(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(CaptionFontSizeProperty, value);
        }
		private static void CaptionFontSizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CaptionFontSize").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CaptionFontStretchProperty = DependencyProperty.RegisterAttached( "CaptionFontStretch", typeof(System.Windows.FontStretch), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CaptionFontStretchChanged)));
        public static System.Windows.FontStretch GetCaptionFontStretch(DependencyObject dependencyObject)
        {
            return (System.Windows.FontStretch)dependencyObject.GetValue(CaptionFontStretchProperty);
        }
        public static void SetCaptionFontStretch(DependencyObject dependencyObject, System.Windows.FontStretch value)
        {
            dependencyObject.SetValue(CaptionFontStretchProperty, value);
        }
		private static void CaptionFontStretchChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CaptionFontStretch").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CaptionFontStyleProperty = DependencyProperty.RegisterAttached( "CaptionFontStyle", typeof(System.Windows.FontStyle), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CaptionFontStyleChanged)));
        public static System.Windows.FontStyle GetCaptionFontStyle(DependencyObject dependencyObject)
        {
            return (System.Windows.FontStyle)dependencyObject.GetValue(CaptionFontStyleProperty);
        }
        public static void SetCaptionFontStyle(DependencyObject dependencyObject, System.Windows.FontStyle value)
        {
            dependencyObject.SetValue(CaptionFontStyleProperty, value);
        }
		private static void CaptionFontStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CaptionFontStyle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CaptionFontWeightProperty = DependencyProperty.RegisterAttached( "CaptionFontWeight", typeof(System.Windows.FontWeight), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CaptionFontWeightChanged)));
        public static System.Windows.FontWeight GetCaptionFontWeight(DependencyObject dependencyObject)
        {
            return (System.Windows.FontWeight)dependencyObject.GetValue(CaptionFontWeightProperty);
        }
        public static void SetCaptionFontWeight(DependencyObject dependencyObject, System.Windows.FontWeight value)
        {
            dependencyObject.SetValue(CaptionFontWeightProperty, value);
        }
		private static void CaptionFontWeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CaptionFontWeight").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty PenWidthProperty = DependencyProperty.RegisterAttached( "PenWidth", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(PenWidthChanged)));
        public static System.Double GetPenWidth(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(PenWidthProperty);
        }
        public static void SetPenWidth(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(PenWidthProperty, value);
        }
		private static void PenWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("PenWidth").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty StickyNoteTypeProperty = DependencyProperty.RegisterAttached( "StickyNoteType", typeof(System.Windows.Controls.StickyNoteType), typeof(d), new PropertyMetadata(new PropertyChangedCallback(StickyNoteTypeChanged)));
        public static System.Windows.Controls.StickyNoteType GetStickyNoteType(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.StickyNoteType)dependencyObject.GetValue(StickyNoteTypeProperty);
        }
        public static void SetStickyNoteType(DependencyObject dependencyObject, System.Windows.Controls.StickyNoteType value)
        {
            dependencyObject.SetValue(StickyNoteTypeProperty, value);
        }
		private static void StickyNoteTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("StickyNoteType").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AnchorInfoProperty = DependencyProperty.RegisterAttached( "AnchorInfo", typeof(System.Windows.Annotations.IAnchorInfo), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AnchorInfoChanged)));
        public static System.Windows.Annotations.IAnchorInfo GetAnchorInfo(DependencyObject dependencyObject)
        {
            return (System.Windows.Annotations.IAnchorInfo)dependencyObject.GetValue(AnchorInfoProperty);
        }
        public static void SetAnchorInfo(DependencyObject dependencyObject, System.Windows.Annotations.IAnchorInfo value)
        {
            dependencyObject.SetValue(AnchorInfoProperty, value);
        }
		private static void AnchorInfoChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AnchorInfo").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ItemsProperty = DependencyProperty.RegisterAttached( "Items", typeof(System.Windows.Controls.ItemCollection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ItemsChanged)));
        public static System.Windows.Controls.ItemCollection GetItems(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.ItemCollection)dependencyObject.GetValue(ItemsProperty);
        }
        public static void SetItems(DependencyObject dependencyObject, System.Windows.Controls.ItemCollection value)
        {
            dependencyObject.SetValue(ItemsProperty, value);
        }
		private static void ItemsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Items").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ItemsSourceProperty = DependencyProperty.RegisterAttached( "ItemsSource", typeof(System.Collections.IEnumerable), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ItemsSourceChanged)));
        public static System.Collections.IEnumerable GetItemsSource(DependencyObject dependencyObject)
        {
            return (System.Collections.IEnumerable)dependencyObject.GetValue(ItemsSourceProperty);
        }
        public static void SetItemsSource(DependencyObject dependencyObject, System.Collections.IEnumerable value)
        {
            dependencyObject.SetValue(ItemsSourceProperty, value);
        }
		private static void ItemsSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ItemsSource").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty HasItemsProperty = DependencyProperty.RegisterAttached( "HasItems", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HasItemsChanged)));
        public static System.Boolean GetHasItems(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(HasItemsProperty);
        }
        public static void SetHasItems(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(HasItemsProperty, value);
        }
		private static void HasItemsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("HasItems").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DisplayMemberPathProperty = DependencyProperty.RegisterAttached( "DisplayMemberPath", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DisplayMemberPathChanged)));
        public static System.String GetDisplayMemberPath(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(DisplayMemberPathProperty);
        }
        public static void SetDisplayMemberPath(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(DisplayMemberPathProperty, value);
        }
		private static void DisplayMemberPathChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DisplayMemberPath").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ItemTemplateProperty = DependencyProperty.RegisterAttached( "ItemTemplate", typeof(System.Windows.DataTemplate), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ItemTemplateChanged)));
        public static System.Windows.DataTemplate GetItemTemplate(DependencyObject dependencyObject)
        {
            return (System.Windows.DataTemplate)dependencyObject.GetValue(ItemTemplateProperty);
        }
        public static void SetItemTemplate(DependencyObject dependencyObject, System.Windows.DataTemplate value)
        {
            dependencyObject.SetValue(ItemTemplateProperty, value);
        }
		private static void ItemTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ItemTemplate").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ItemTemplateSelectorProperty = DependencyProperty.RegisterAttached( "ItemTemplateSelector", typeof(System.Windows.Controls.DataTemplateSelector), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ItemTemplateSelectorChanged)));
        public static System.Windows.Controls.DataTemplateSelector GetItemTemplateSelector(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.DataTemplateSelector)dependencyObject.GetValue(ItemTemplateSelectorProperty);
        }
        public static void SetItemTemplateSelector(DependencyObject dependencyObject, System.Windows.Controls.DataTemplateSelector value)
        {
            dependencyObject.SetValue(ItemTemplateSelectorProperty, value);
        }
		private static void ItemTemplateSelectorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ItemTemplateSelector").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ItemStringFormatProperty = DependencyProperty.RegisterAttached( "ItemStringFormat", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ItemStringFormatChanged)));
        public static System.String GetItemStringFormat(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(ItemStringFormatProperty);
        }
        public static void SetItemStringFormat(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(ItemStringFormatProperty, value);
        }
		private static void ItemStringFormatChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ItemStringFormat").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ItemBindingGroupProperty = DependencyProperty.RegisterAttached( "ItemBindingGroup", typeof(System.Windows.Data.BindingGroup), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ItemBindingGroupChanged)));
        public static System.Windows.Data.BindingGroup GetItemBindingGroup(DependencyObject dependencyObject)
        {
            return (System.Windows.Data.BindingGroup)dependencyObject.GetValue(ItemBindingGroupProperty);
        }
        public static void SetItemBindingGroup(DependencyObject dependencyObject, System.Windows.Data.BindingGroup value)
        {
            dependencyObject.SetValue(ItemBindingGroupProperty, value);
        }
		private static void ItemBindingGroupChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ItemBindingGroup").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ItemContainerStyleProperty = DependencyProperty.RegisterAttached( "ItemContainerStyle", typeof(System.Windows.Style), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ItemContainerStyleChanged)));
        public static System.Windows.Style GetItemContainerStyle(DependencyObject dependencyObject)
        {
            return (System.Windows.Style)dependencyObject.GetValue(ItemContainerStyleProperty);
        }
        public static void SetItemContainerStyle(DependencyObject dependencyObject, System.Windows.Style value)
        {
            dependencyObject.SetValue(ItemContainerStyleProperty, value);
        }
		private static void ItemContainerStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ItemContainerStyle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ItemContainerStyleSelectorProperty = DependencyProperty.RegisterAttached( "ItemContainerStyleSelector", typeof(System.Windows.Controls.StyleSelector), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ItemContainerStyleSelectorChanged)));
        public static System.Windows.Controls.StyleSelector GetItemContainerStyleSelector(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.StyleSelector)dependencyObject.GetValue(ItemContainerStyleSelectorProperty);
        }
        public static void SetItemContainerStyleSelector(DependencyObject dependencyObject, System.Windows.Controls.StyleSelector value)
        {
            dependencyObject.SetValue(ItemContainerStyleSelectorProperty, value);
        }
		private static void ItemContainerStyleSelectorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ItemContainerStyleSelector").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ItemsPanelProperty = DependencyProperty.RegisterAttached( "ItemsPanel", typeof(System.Windows.Controls.ItemsPanelTemplate), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ItemsPanelChanged)));
        public static System.Windows.Controls.ItemsPanelTemplate GetItemsPanel(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.ItemsPanelTemplate)dependencyObject.GetValue(ItemsPanelProperty);
        }
        public static void SetItemsPanel(DependencyObject dependencyObject, System.Windows.Controls.ItemsPanelTemplate value)
        {
            dependencyObject.SetValue(ItemsPanelProperty, value);
        }
		private static void ItemsPanelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ItemsPanel").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsGroupingProperty = DependencyProperty.RegisterAttached( "IsGrouping", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsGroupingChanged)));
        public static System.Boolean GetIsGrouping(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsGroupingProperty);
        }
        public static void SetIsGrouping(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsGroupingProperty, value);
        }
		private static void IsGroupingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsGrouping").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty GroupStyleProperty = DependencyProperty.RegisterAttached( "GroupStyle", typeof(System.Collections.ObjectModel.ObservableCollection<System.Windows.Controls.GroupStyle>), typeof(d), new PropertyMetadata(new PropertyChangedCallback(GroupStyleChanged)));
        public static System.Collections.ObjectModel.ObservableCollection<System.Windows.Controls.GroupStyle> GetGroupStyle(DependencyObject dependencyObject)
        {
            return (System.Collections.ObjectModel.ObservableCollection<System.Windows.Controls.GroupStyle>)dependencyObject.GetValue(GroupStyleProperty);
        }
        public static void SetGroupStyle(DependencyObject dependencyObject, System.Collections.ObjectModel.ObservableCollection<System.Windows.Controls.GroupStyle> value)
        {
            dependencyObject.SetValue(GroupStyleProperty, value);
        }
		private static void GroupStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("GroupStyle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty GroupStyleSelectorProperty = DependencyProperty.RegisterAttached( "GroupStyleSelector", typeof(System.Windows.Controls.GroupStyleSelector), typeof(d), new PropertyMetadata(new PropertyChangedCallback(GroupStyleSelectorChanged)));
        public static System.Windows.Controls.GroupStyleSelector GetGroupStyleSelector(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.GroupStyleSelector)dependencyObject.GetValue(GroupStyleSelectorProperty);
        }
        public static void SetGroupStyleSelector(DependencyObject dependencyObject, System.Windows.Controls.GroupStyleSelector value)
        {
            dependencyObject.SetValue(GroupStyleSelectorProperty, value);
        }
		private static void GroupStyleSelectorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("GroupStyleSelector").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AlternationCountProperty = DependencyProperty.RegisterAttached( "AlternationCount", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AlternationCountChanged)));
        public static System.Int32 GetAlternationCount(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(AlternationCountProperty);
        }
        public static void SetAlternationCount(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(AlternationCountProperty, value);
        }
		private static void AlternationCountChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AlternationCount").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsTextSearchEnabledProperty = DependencyProperty.RegisterAttached( "IsTextSearchEnabled", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsTextSearchEnabledChanged)));
        public static System.Boolean GetIsTextSearchEnabled(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsTextSearchEnabledProperty);
        }
        public static void SetIsTextSearchEnabled(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsTextSearchEnabledProperty, value);
        }
		private static void IsTextSearchEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsTextSearchEnabled").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsTextSearchCaseSensitiveProperty = DependencyProperty.RegisterAttached( "IsTextSearchCaseSensitive", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsTextSearchCaseSensitiveChanged)));
        public static System.Boolean GetIsTextSearchCaseSensitive(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsTextSearchCaseSensitiveProperty);
        }
        public static void SetIsTextSearchCaseSensitive(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsTextSearchCaseSensitiveProperty, value);
        }
		private static void IsTextSearchCaseSensitiveChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsTextSearchCaseSensitive").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty UsesItemContainerTemplateProperty = DependencyProperty.RegisterAttached( "UsesItemContainerTemplate", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(UsesItemContainerTemplateChanged)));
        public static System.Boolean GetUsesItemContainerTemplate(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(UsesItemContainerTemplateProperty);
        }
        public static void SetUsesItemContainerTemplate(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(UsesItemContainerTemplateProperty, value);
        }
		private static void UsesItemContainerTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("UsesItemContainerTemplate").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty HorizontalOffsetProperty = DependencyProperty.RegisterAttached( "HorizontalOffset", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HorizontalOffsetChanged)));
        public static System.Double GetHorizontalOffset(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(HorizontalOffsetProperty);
        }
        public static void SetHorizontalOffset(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(HorizontalOffsetProperty, value);
        }
		private static void HorizontalOffsetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("HorizontalOffset").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty VerticalOffsetProperty = DependencyProperty.RegisterAttached( "VerticalOffset", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(VerticalOffsetChanged)));
        public static System.Double GetVerticalOffset(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(VerticalOffsetProperty);
        }
        public static void SetVerticalOffset(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(VerticalOffsetProperty, value);
        }
		private static void VerticalOffsetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("VerticalOffset").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsOpenProperty = DependencyProperty.RegisterAttached( "IsOpen", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsOpenChanged)));
        public static System.Boolean GetIsOpen(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsOpenProperty);
        }
        public static void SetIsOpen(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsOpenProperty, value);
        }
		private static void IsOpenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsOpen").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty PlacementTargetProperty = DependencyProperty.RegisterAttached( "PlacementTarget", typeof(System.Windows.UIElement), typeof(d), new PropertyMetadata(new PropertyChangedCallback(PlacementTargetChanged)));
        public static System.Windows.UIElement GetPlacementTarget(DependencyObject dependencyObject)
        {
            return (System.Windows.UIElement)dependencyObject.GetValue(PlacementTargetProperty);
        }
        public static void SetPlacementTarget(DependencyObject dependencyObject, System.Windows.UIElement value)
        {
            dependencyObject.SetValue(PlacementTargetProperty, value);
        }
		private static void PlacementTargetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("PlacementTarget").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty PlacementRectangleProperty = DependencyProperty.RegisterAttached( "PlacementRectangle", typeof(System.Windows.Rect), typeof(d), new PropertyMetadata(new PropertyChangedCallback(PlacementRectangleChanged)));
        public static System.Windows.Rect GetPlacementRectangle(DependencyObject dependencyObject)
        {
            return (System.Windows.Rect)dependencyObject.GetValue(PlacementRectangleProperty);
        }
        public static void SetPlacementRectangle(DependencyObject dependencyObject, System.Windows.Rect value)
        {
            dependencyObject.SetValue(PlacementRectangleProperty, value);
        }
		private static void PlacementRectangleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("PlacementRectangle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty HasDropShadowProperty = DependencyProperty.RegisterAttached( "HasDropShadow", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HasDropShadowChanged)));
        public static System.Boolean GetHasDropShadow(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(HasDropShadowProperty);
        }
        public static void SetHasDropShadow(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(HasDropShadowProperty, value);
        }
		private static void HasDropShadowChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("HasDropShadow").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CustomPopupPlacementCallbackProperty = DependencyProperty.RegisterAttached( "CustomPopupPlacementCallback", typeof(System.Windows.Controls.Primitives.CustomPopupPlacementCallback), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CustomPopupPlacementCallbackChanged)));
        public static System.Windows.Controls.Primitives.CustomPopupPlacementCallback GetCustomPopupPlacementCallback(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.Primitives.CustomPopupPlacementCallback)dependencyObject.GetValue(CustomPopupPlacementCallbackProperty);
        }
        public static void SetCustomPopupPlacementCallback(DependencyObject dependencyObject, System.Windows.Controls.Primitives.CustomPopupPlacementCallback value)
        {
            dependencyObject.SetValue(CustomPopupPlacementCallbackProperty, value);
        }
		private static void CustomPopupPlacementCallbackChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CustomPopupPlacementCallback").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty StaysOpenProperty = DependencyProperty.RegisterAttached( "StaysOpen", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(StaysOpenChanged)));
        public static System.Boolean GetStaysOpen(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(StaysOpenProperty);
        }
        public static void SetStaysOpen(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(StaysOpenProperty, value);
        }
		private static void StaysOpenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("StaysOpen").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty HeaderProperty = DependencyProperty.RegisterAttached( "Header", typeof(System.Object), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HeaderChanged)));
        public static System.Object GetHeader(DependencyObject dependencyObject)
        {
            return (System.Object)dependencyObject.GetValue(HeaderProperty);
        }
        public static void SetHeader(DependencyObject dependencyObject, System.Object value)
        {
            dependencyObject.SetValue(HeaderProperty, value);
        }
		private static void HeaderChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Header").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty HasHeaderProperty = DependencyProperty.RegisterAttached( "HasHeader", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HasHeaderChanged)));
        public static System.Boolean GetHasHeader(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(HasHeaderProperty);
        }
        public static void SetHasHeader(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(HasHeaderProperty, value);
        }
		private static void HasHeaderChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("HasHeader").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty HeaderTemplateProperty = DependencyProperty.RegisterAttached( "HeaderTemplate", typeof(System.Windows.DataTemplate), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HeaderTemplateChanged)));
        public static System.Windows.DataTemplate GetHeaderTemplate(DependencyObject dependencyObject)
        {
            return (System.Windows.DataTemplate)dependencyObject.GetValue(HeaderTemplateProperty);
        }
        public static void SetHeaderTemplate(DependencyObject dependencyObject, System.Windows.DataTemplate value)
        {
            dependencyObject.SetValue(HeaderTemplateProperty, value);
        }
		private static void HeaderTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("HeaderTemplate").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty HeaderTemplateSelectorProperty = DependencyProperty.RegisterAttached( "HeaderTemplateSelector", typeof(System.Windows.Controls.DataTemplateSelector), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HeaderTemplateSelectorChanged)));
        public static System.Windows.Controls.DataTemplateSelector GetHeaderTemplateSelector(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.DataTemplateSelector)dependencyObject.GetValue(HeaderTemplateSelectorProperty);
        }
        public static void SetHeaderTemplateSelector(DependencyObject dependencyObject, System.Windows.Controls.DataTemplateSelector value)
        {
            dependencyObject.SetValue(HeaderTemplateSelectorProperty, value);
        }
		private static void HeaderTemplateSelectorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("HeaderTemplateSelector").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty HeaderStringFormatProperty = DependencyProperty.RegisterAttached( "HeaderStringFormat", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HeaderStringFormatChanged)));
        public static System.String GetHeaderStringFormat(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(HeaderStringFormatProperty);
        }
        public static void SetHeaderStringFormat(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(HeaderStringFormatProperty, value);
        }
		private static void HeaderStringFormatChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("HeaderStringFormat").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CommandProperty = DependencyProperty.RegisterAttached( "Command", typeof(System.Windows.Input.ICommand), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CommandChanged)));
        public static System.Windows.Input.ICommand GetCommand(DependencyObject dependencyObject)
        {
            return (System.Windows.Input.ICommand)dependencyObject.GetValue(CommandProperty);
        }
        public static void SetCommand(DependencyObject dependencyObject, System.Windows.Input.ICommand value)
        {
            dependencyObject.SetValue(CommandProperty, value);
        }
		private static void CommandChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Command").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CommandParameterProperty = DependencyProperty.RegisterAttached( "CommandParameter", typeof(System.Object), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CommandParameterChanged)));
        public static System.Object GetCommandParameter(DependencyObject dependencyObject)
        {
            return (System.Object)dependencyObject.GetValue(CommandParameterProperty);
        }
        public static void SetCommandParameter(DependencyObject dependencyObject, System.Object value)
        {
            dependencyObject.SetValue(CommandParameterProperty, value);
        }
		private static void CommandParameterChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CommandParameter").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CommandTargetProperty = DependencyProperty.RegisterAttached( "CommandTarget", typeof(System.Windows.IInputElement), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CommandTargetChanged)));
        public static System.Windows.IInputElement GetCommandTarget(DependencyObject dependencyObject)
        {
            return (System.Windows.IInputElement)dependencyObject.GetValue(CommandTargetProperty);
        }
        public static void SetCommandTarget(DependencyObject dependencyObject, System.Windows.IInputElement value)
        {
            dependencyObject.SetValue(CommandTargetProperty, value);
        }
		private static void CommandTargetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CommandTarget").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsSubmenuOpenProperty = DependencyProperty.RegisterAttached( "IsSubmenuOpen", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsSubmenuOpenChanged)));
        public static System.Boolean GetIsSubmenuOpen(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsSubmenuOpenProperty);
        }
        public static void SetIsSubmenuOpen(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsSubmenuOpenProperty, value);
        }
		private static void IsSubmenuOpenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsSubmenuOpen").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsCheckableProperty = DependencyProperty.RegisterAttached( "IsCheckable", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsCheckableChanged)));
        public static System.Boolean GetIsCheckable(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsCheckableProperty);
        }
        public static void SetIsCheckable(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsCheckableProperty, value);
        }
		private static void IsCheckableChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsCheckable").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsPressedProperty = DependencyProperty.RegisterAttached( "IsPressed", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsPressedChanged)));
        public static System.Boolean GetIsPressed(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsPressedProperty);
        }
        public static void SetIsPressed(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsPressedProperty, value);
        }
		private static void IsPressedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsPressed").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsHighlightedProperty = DependencyProperty.RegisterAttached( "IsHighlighted", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsHighlightedChanged)));
        public static System.Boolean GetIsHighlighted(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsHighlightedProperty);
        }
        public static void SetIsHighlighted(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsHighlightedProperty, value);
        }
		private static void IsHighlightedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsHighlighted").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty StaysOpenOnClickProperty = DependencyProperty.RegisterAttached( "StaysOpenOnClick", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(StaysOpenOnClickChanged)));
        public static System.Boolean GetStaysOpenOnClick(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(StaysOpenOnClickProperty);
        }
        public static void SetStaysOpenOnClick(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(StaysOpenOnClickProperty, value);
        }
		private static void StaysOpenOnClickChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("StaysOpenOnClick").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty InputGestureTextProperty = DependencyProperty.RegisterAttached( "InputGestureText", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(InputGestureTextChanged)));
        public static System.String GetInputGestureText(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(InputGestureTextProperty);
        }
        public static void SetInputGestureText(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(InputGestureTextProperty, value);
        }
		private static void InputGestureTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("InputGestureText").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsSuspendingPopupAnimationProperty = DependencyProperty.RegisterAttached( "IsSuspendingPopupAnimation", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsSuspendingPopupAnimationChanged)));
        public static System.Boolean GetIsSuspendingPopupAnimation(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsSuspendingPopupAnimationProperty);
        }
        public static void SetIsSuspendingPopupAnimation(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsSuspendingPopupAnimationProperty, value);
        }
		private static void IsSuspendingPopupAnimationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsSuspendingPopupAnimation").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectionProperty = DependencyProperty.RegisterAttached( "Selection", typeof(System.Windows.Documents.TextSelection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectionChanged)));
        public static System.Windows.Documents.TextSelection GetSelection(DependencyObject dependencyObject)
        {
            return (System.Windows.Documents.TextSelection)dependencyObject.GetValue(SelectionProperty);
        }
        public static void SetSelection(DependencyObject dependencyObject, System.Windows.Documents.TextSelection value)
        {
            dependencyObject.SetValue(SelectionProperty, value);
        }
		private static void SelectionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Selection").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ZoomProperty = DependencyProperty.RegisterAttached( "Zoom", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ZoomChanged)));
        public static System.Double GetZoom(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(ZoomProperty);
        }
        public static void SetZoom(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(ZoomProperty, value);
        }
		private static void ZoomChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Zoom").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty MaxZoomProperty = DependencyProperty.RegisterAttached( "MaxZoom", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(MaxZoomChanged)));
        public static System.Double GetMaxZoom(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(MaxZoomProperty);
        }
        public static void SetMaxZoom(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(MaxZoomProperty, value);
        }
		private static void MaxZoomChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("MaxZoom").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty MinZoomProperty = DependencyProperty.RegisterAttached( "MinZoom", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(MinZoomChanged)));
        public static System.Double GetMinZoom(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(MinZoomProperty);
        }
        public static void SetMinZoom(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(MinZoomProperty, value);
        }
		private static void MinZoomChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("MinZoom").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ZoomIncrementProperty = DependencyProperty.RegisterAttached( "ZoomIncrement", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ZoomIncrementChanged)));
        public static System.Double GetZoomIncrement(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(ZoomIncrementProperty);
        }
        public static void SetZoomIncrement(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(ZoomIncrementProperty, value);
        }
		private static void ZoomIncrementChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ZoomIncrement").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanIncreaseZoomProperty = DependencyProperty.RegisterAttached( "CanIncreaseZoom", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanIncreaseZoomChanged)));
        public static System.Boolean GetCanIncreaseZoom(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanIncreaseZoomProperty);
        }
        public static void SetCanIncreaseZoom(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanIncreaseZoomProperty, value);
        }
		private static void CanIncreaseZoomChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanIncreaseZoom").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanDecreaseZoomProperty = DependencyProperty.RegisterAttached( "CanDecreaseZoom", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanDecreaseZoomChanged)));
        public static System.Boolean GetCanDecreaseZoom(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanDecreaseZoomProperty);
        }
        public static void SetCanDecreaseZoom(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanDecreaseZoomProperty, value);
        }
		private static void CanDecreaseZoomChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanDecreaseZoom").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsSelectionEnabledProperty = DependencyProperty.RegisterAttached( "IsSelectionEnabled", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsSelectionEnabledChanged)));
        public static System.Boolean GetIsSelectionEnabled(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsSelectionEnabledProperty);
        }
        public static void SetIsSelectionEnabled(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsSelectionEnabledProperty, value);
        }
		private static void IsSelectionEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsSelectionEnabled").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsToolBarVisibleProperty = DependencyProperty.RegisterAttached( "IsToolBarVisible", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsToolBarVisibleChanged)));
        public static System.Boolean GetIsToolBarVisible(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsToolBarVisibleProperty);
        }
        public static void SetIsToolBarVisible(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsToolBarVisibleProperty, value);
        }
		private static void IsToolBarVisibleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsToolBarVisible").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty HorizontalScrollBarVisibilityProperty = DependencyProperty.RegisterAttached( "HorizontalScrollBarVisibility", typeof(System.Windows.Controls.ScrollBarVisibility), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HorizontalScrollBarVisibilityChanged)));
        public static System.Windows.Controls.ScrollBarVisibility GetHorizontalScrollBarVisibility(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.ScrollBarVisibility)dependencyObject.GetValue(HorizontalScrollBarVisibilityProperty);
        }
        public static void SetHorizontalScrollBarVisibility(DependencyObject dependencyObject, System.Windows.Controls.ScrollBarVisibility value)
        {
            dependencyObject.SetValue(HorizontalScrollBarVisibilityProperty, value);
        }
		private static void HorizontalScrollBarVisibilityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("HorizontalScrollBarVisibility").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty VerticalScrollBarVisibilityProperty = DependencyProperty.RegisterAttached( "VerticalScrollBarVisibility", typeof(System.Windows.Controls.ScrollBarVisibility), typeof(d), new PropertyMetadata(new PropertyChangedCallback(VerticalScrollBarVisibilityChanged)));
        public static System.Windows.Controls.ScrollBarVisibility GetVerticalScrollBarVisibility(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.ScrollBarVisibility)dependencyObject.GetValue(VerticalScrollBarVisibilityProperty);
        }
        public static void SetVerticalScrollBarVisibility(DependencyObject dependencyObject, System.Windows.Controls.ScrollBarVisibility value)
        {
            dependencyObject.SetValue(VerticalScrollBarVisibilityProperty, value);
        }
		private static void VerticalScrollBarVisibilityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("VerticalScrollBarVisibility").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectionBrushProperty = DependencyProperty.RegisterAttached( "SelectionBrush", typeof(System.Windows.Media.Brush), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectionBrushChanged)));
        public static System.Windows.Media.Brush GetSelectionBrush(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Brush)dependencyObject.GetValue(SelectionBrushProperty);
        }
        public static void SetSelectionBrush(DependencyObject dependencyObject, System.Windows.Media.Brush value)
        {
            dependencyObject.SetValue(SelectionBrushProperty, value);
        }
		private static void SelectionBrushChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectionBrush").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectionOpacityProperty = DependencyProperty.RegisterAttached( "SelectionOpacity", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectionOpacityChanged)));
        public static System.Double GetSelectionOpacity(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(SelectionOpacityProperty);
        }
        public static void SetSelectionOpacity(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(SelectionOpacityProperty, value);
        }
		private static void SelectionOpacityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectionOpacity").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsSelectionActiveProperty = DependencyProperty.RegisterAttached( "IsSelectionActive", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsSelectionActiveChanged)));
        public static System.Boolean GetIsSelectionActive(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsSelectionActiveProperty);
        }
        public static void SetIsSelectionActive(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsSelectionActiveProperty, value);
        }
		private static void IsSelectionActiveChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsSelectionActive").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsInactiveSelectionHighlightEnabledProperty = DependencyProperty.RegisterAttached( "IsInactiveSelectionHighlightEnabled", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsInactiveSelectionHighlightEnabledChanged)));
        public static System.Boolean GetIsInactiveSelectionHighlightEnabled(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsInactiveSelectionHighlightEnabledProperty);
        }
        public static void SetIsInactiveSelectionHighlightEnabled(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsInactiveSelectionHighlightEnabledProperty, value);
        }
		private static void IsInactiveSelectionHighlightEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsInactiveSelectionHighlightEnabled").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty PageCountProperty = DependencyProperty.RegisterAttached( "PageCount", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(PageCountChanged)));
        public static System.Int32 GetPageCount(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(PageCountProperty);
        }
        public static void SetPageCount(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(PageCountProperty, value);
        }
		private static void PageCountChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("PageCount").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty MasterPageNumberProperty = DependencyProperty.RegisterAttached( "MasterPageNumber", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(MasterPageNumberChanged)));
        public static System.Int32 GetMasterPageNumber(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(MasterPageNumberProperty);
        }
        public static void SetMasterPageNumber(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(MasterPageNumberProperty, value);
        }
		private static void MasterPageNumberChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("MasterPageNumber").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanGoToPreviousPageProperty = DependencyProperty.RegisterAttached( "CanGoToPreviousPage", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanGoToPreviousPageChanged)));
        public static System.Boolean GetCanGoToPreviousPage(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanGoToPreviousPageProperty);
        }
        public static void SetCanGoToPreviousPage(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanGoToPreviousPageProperty, value);
        }
		private static void CanGoToPreviousPageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanGoToPreviousPage").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanGoToNextPageProperty = DependencyProperty.RegisterAttached( "CanGoToNextPage", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanGoToNextPageChanged)));
        public static System.Boolean GetCanGoToNextPage(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanGoToNextPageProperty);
        }
        public static void SetCanGoToNextPage(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanGoToNextPageProperty, value);
        }
		private static void CanGoToNextPageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanGoToNextPage").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty PageViewsProperty = DependencyProperty.RegisterAttached( "PageViews", typeof(System.Collections.ObjectModel.ReadOnlyCollection<System.Windows.Controls.Primitives.DocumentPageView>), typeof(d), new PropertyMetadata(new PropertyChangedCallback(PageViewsChanged)));
        public static System.Collections.ObjectModel.ReadOnlyCollection<System.Windows.Controls.Primitives.DocumentPageView> GetPageViews(DependencyObject dependencyObject)
        {
            return (System.Collections.ObjectModel.ReadOnlyCollection<System.Windows.Controls.Primitives.DocumentPageView>)dependencyObject.GetValue(PageViewsProperty);
        }
        public static void SetPageViews(DependencyObject dependencyObject, System.Collections.ObjectModel.ReadOnlyCollection<System.Windows.Controls.Primitives.DocumentPageView> value)
        {
            dependencyObject.SetValue(PageViewsProperty, value);
        }
		private static void PageViewsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("PageViews").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AccessKeyProperty = DependencyProperty.RegisterAttached( "AccessKey", typeof(System.Char), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AccessKeyChanged)));
        public static System.Char GetAccessKey(DependencyObject dependencyObject)
        {
            return (System.Char)dependencyObject.GetValue(AccessKeyProperty);
        }
        public static void SetAccessKey(DependencyObject dependencyObject, System.Char value)
        {
            dependencyObject.SetValue(AccessKeyProperty, value);
        }
		private static void AccessKeyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AccessKey").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TextProperty = DependencyProperty.RegisterAttached( "Text", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TextChanged)));
        public static System.String GetText(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(TextProperty);
        }
        public static void SetText(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(TextProperty, value);
        }
		private static void TextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Text").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TextDecorationsProperty = DependencyProperty.RegisterAttached( "TextDecorations", typeof(System.Windows.TextDecorationCollection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TextDecorationsChanged)));
        public static System.Windows.TextDecorationCollection GetTextDecorations(DependencyObject dependencyObject)
        {
            return (System.Windows.TextDecorationCollection)dependencyObject.GetValue(TextDecorationsProperty);
        }
        public static void SetTextDecorations(DependencyObject dependencyObject, System.Windows.TextDecorationCollection value)
        {
            dependencyObject.SetValue(TextDecorationsProperty, value);
        }
		private static void TextDecorationsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("TextDecorations").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TextEffectsProperty = DependencyProperty.RegisterAttached( "TextEffects", typeof(System.Windows.Media.TextEffectCollection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TextEffectsChanged)));
        public static System.Windows.Media.TextEffectCollection GetTextEffects(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.TextEffectCollection)dependencyObject.GetValue(TextEffectsProperty);
        }
        public static void SetTextEffects(DependencyObject dependencyObject, System.Windows.Media.TextEffectCollection value)
        {
            dependencyObject.SetValue(TextEffectsProperty, value);
        }
		private static void TextEffectsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("TextEffects").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty LineHeightProperty = DependencyProperty.RegisterAttached( "LineHeight", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(LineHeightChanged)));
        public static System.Double GetLineHeight(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(LineHeightProperty);
        }
        public static void SetLineHeight(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(LineHeightProperty, value);
        }
		private static void LineHeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("LineHeight").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty LineStackingStrategyProperty = DependencyProperty.RegisterAttached( "LineStackingStrategy", typeof(System.Windows.LineStackingStrategy), typeof(d), new PropertyMetadata(new PropertyChangedCallback(LineStackingStrategyChanged)));
        public static System.Windows.LineStackingStrategy GetLineStackingStrategy(DependencyObject dependencyObject)
        {
            return (System.Windows.LineStackingStrategy)dependencyObject.GetValue(LineStackingStrategyProperty);
        }
        public static void SetLineStackingStrategy(DependencyObject dependencyObject, System.Windows.LineStackingStrategy value)
        {
            dependencyObject.SetValue(LineStackingStrategyProperty, value);
        }
		private static void LineStackingStrategyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("LineStackingStrategy").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TextAlignmentProperty = DependencyProperty.RegisterAttached( "TextAlignment", typeof(System.Windows.TextAlignment), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TextAlignmentChanged)));
        public static System.Windows.TextAlignment GetTextAlignment(DependencyObject dependencyObject)
        {
            return (System.Windows.TextAlignment)dependencyObject.GetValue(TextAlignmentProperty);
        }
        public static void SetTextAlignment(DependencyObject dependencyObject, System.Windows.TextAlignment value)
        {
            dependencyObject.SetValue(TextAlignmentProperty, value);
        }
		private static void TextAlignmentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("TextAlignment").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TextTrimmingProperty = DependencyProperty.RegisterAttached( "TextTrimming", typeof(System.Windows.TextTrimming), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TextTrimmingChanged)));
        public static System.Windows.TextTrimming GetTextTrimming(DependencyObject dependencyObject)
        {
            return (System.Windows.TextTrimming)dependencyObject.GetValue(TextTrimmingProperty);
        }
        public static void SetTextTrimming(DependencyObject dependencyObject, System.Windows.TextTrimming value)
        {
            dependencyObject.SetValue(TextTrimmingProperty, value);
        }
		private static void TextTrimmingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("TextTrimming").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TextWrappingProperty = DependencyProperty.RegisterAttached( "TextWrapping", typeof(System.Windows.TextWrapping), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TextWrappingChanged)));
        public static System.Windows.TextWrapping GetTextWrapping(DependencyObject dependencyObject)
        {
            return (System.Windows.TextWrapping)dependencyObject.GetValue(TextWrappingProperty);
        }
        public static void SetTextWrapping(DependencyObject dependencyObject, System.Windows.TextWrapping value)
        {
            dependencyObject.SetValue(TextWrappingProperty, value);
        }
		private static void TextWrappingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("TextWrapping").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty BaselineOffsetProperty = DependencyProperty.RegisterAttached( "BaselineOffset", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(BaselineOffsetChanged)));
        public static System.Double GetBaselineOffset(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(BaselineOffsetProperty);
        }
        public static void SetBaselineOffset(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(BaselineOffsetProperty, value);
        }
		private static void BaselineOffsetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("BaselineOffset").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CornerRadiusProperty = DependencyProperty.RegisterAttached( "CornerRadius", typeof(System.Windows.CornerRadius), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CornerRadiusChanged)));
        public static System.Windows.CornerRadius GetCornerRadius(DependencyObject dependencyObject)
        {
            return (System.Windows.CornerRadius)dependencyObject.GetValue(CornerRadiusProperty);
        }
        public static void SetCornerRadius(DependencyObject dependencyObject, System.Windows.CornerRadius value)
        {
            dependencyObject.SetValue(CornerRadiusProperty, value);
        }
		private static void CornerRadiusChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CornerRadius").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ClickModeProperty = DependencyProperty.RegisterAttached( "ClickMode", typeof(System.Windows.Controls.ClickMode), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ClickModeChanged)));
        public static System.Windows.Controls.ClickMode GetClickMode(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.ClickMode)dependencyObject.GetValue(ClickModeProperty);
        }
        public static void SetClickMode(DependencyObject dependencyObject, System.Windows.Controls.ClickMode value)
        {
            dependencyObject.SetValue(ClickModeProperty, value);
        }
		private static void ClickModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ClickMode").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsDefaultProperty = DependencyProperty.RegisterAttached( "IsDefault", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsDefaultChanged)));
        public static System.Boolean GetIsDefault(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsDefaultProperty);
        }
        public static void SetIsDefault(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsDefaultProperty, value);
        }
		private static void IsDefaultChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsDefault").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsCancelProperty = DependencyProperty.RegisterAttached( "IsCancel", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsCancelChanged)));
        public static System.Boolean GetIsCancel(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsCancelProperty);
        }
        public static void SetIsCancel(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsCancelProperty, value);
        }
		private static void IsCancelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsCancel").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsDefaultedProperty = DependencyProperty.RegisterAttached( "IsDefaulted", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsDefaultedChanged)));
        public static System.Boolean GetIsDefaulted(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsDefaultedProperty);
        }
        public static void SetIsDefaulted(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsDefaultedProperty, value);
        }
		private static void IsDefaultedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsDefaulted").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty BlackoutDatesProperty = DependencyProperty.RegisterAttached( "BlackoutDates", typeof(System.Windows.Controls.CalendarBlackoutDatesCollection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(BlackoutDatesChanged)));
        public static System.Windows.Controls.CalendarBlackoutDatesCollection GetBlackoutDates(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.CalendarBlackoutDatesCollection)dependencyObject.GetValue(BlackoutDatesProperty);
        }
        public static void SetBlackoutDates(DependencyObject dependencyObject, System.Windows.Controls.CalendarBlackoutDatesCollection value)
        {
            dependencyObject.SetValue(BlackoutDatesProperty, value);
        }
		private static void BlackoutDatesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("BlackoutDates").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CalendarButtonStyleProperty = DependencyProperty.RegisterAttached( "CalendarButtonStyle", typeof(System.Windows.Style), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CalendarButtonStyleChanged)));
        public static System.Windows.Style GetCalendarButtonStyle(DependencyObject dependencyObject)
        {
            return (System.Windows.Style)dependencyObject.GetValue(CalendarButtonStyleProperty);
        }
        public static void SetCalendarButtonStyle(DependencyObject dependencyObject, System.Windows.Style value)
        {
            dependencyObject.SetValue(CalendarButtonStyleProperty, value);
        }
		private static void CalendarButtonStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CalendarButtonStyle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CalendarDayButtonStyleProperty = DependencyProperty.RegisterAttached( "CalendarDayButtonStyle", typeof(System.Windows.Style), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CalendarDayButtonStyleChanged)));
        public static System.Windows.Style GetCalendarDayButtonStyle(DependencyObject dependencyObject)
        {
            return (System.Windows.Style)dependencyObject.GetValue(CalendarDayButtonStyleProperty);
        }
        public static void SetCalendarDayButtonStyle(DependencyObject dependencyObject, System.Windows.Style value)
        {
            dependencyObject.SetValue(CalendarDayButtonStyleProperty, value);
        }
		private static void CalendarDayButtonStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CalendarDayButtonStyle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CalendarItemStyleProperty = DependencyProperty.RegisterAttached( "CalendarItemStyle", typeof(System.Windows.Style), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CalendarItemStyleChanged)));
        public static System.Windows.Style GetCalendarItemStyle(DependencyObject dependencyObject)
        {
            return (System.Windows.Style)dependencyObject.GetValue(CalendarItemStyleProperty);
        }
        public static void SetCalendarItemStyle(DependencyObject dependencyObject, System.Windows.Style value)
        {
            dependencyObject.SetValue(CalendarItemStyleProperty, value);
        }
		private static void CalendarItemStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CalendarItemStyle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DisplayDateProperty = DependencyProperty.RegisterAttached( "DisplayDate", typeof(System.DateTime), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DisplayDateChanged)));
        public static System.DateTime GetDisplayDate(DependencyObject dependencyObject)
        {
            return (System.DateTime)dependencyObject.GetValue(DisplayDateProperty);
        }
        public static void SetDisplayDate(DependencyObject dependencyObject, System.DateTime value)
        {
            dependencyObject.SetValue(DisplayDateProperty, value);
        }
		private static void DisplayDateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DisplayDate").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DisplayDateEndProperty = DependencyProperty.RegisterAttached( "DisplayDateEnd", typeof(System.Nullable<System.DateTime>), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DisplayDateEndChanged)));
        public static System.Nullable<System.DateTime> GetDisplayDateEnd(DependencyObject dependencyObject)
        {
            return (System.Nullable<System.DateTime>)dependencyObject.GetValue(DisplayDateEndProperty);
        }
        public static void SetDisplayDateEnd(DependencyObject dependencyObject, System.Nullable<System.DateTime> value)
        {
            dependencyObject.SetValue(DisplayDateEndProperty, value);
        }
		private static void DisplayDateEndChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DisplayDateEnd").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DisplayDateStartProperty = DependencyProperty.RegisterAttached( "DisplayDateStart", typeof(System.Nullable<System.DateTime>), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DisplayDateStartChanged)));
        public static System.Nullable<System.DateTime> GetDisplayDateStart(DependencyObject dependencyObject)
        {
            return (System.Nullable<System.DateTime>)dependencyObject.GetValue(DisplayDateStartProperty);
        }
        public static void SetDisplayDateStart(DependencyObject dependencyObject, System.Nullable<System.DateTime> value)
        {
            dependencyObject.SetValue(DisplayDateStartProperty, value);
        }
		private static void DisplayDateStartChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DisplayDateStart").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DisplayModeProperty = DependencyProperty.RegisterAttached( "DisplayMode", typeof(System.Windows.Controls.CalendarMode), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DisplayModeChanged)));
        public static System.Windows.Controls.CalendarMode GetDisplayMode(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.CalendarMode)dependencyObject.GetValue(DisplayModeProperty);
        }
        public static void SetDisplayMode(DependencyObject dependencyObject, System.Windows.Controls.CalendarMode value)
        {
            dependencyObject.SetValue(DisplayModeProperty, value);
        }
		private static void DisplayModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DisplayMode").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty FirstDayOfWeekProperty = DependencyProperty.RegisterAttached( "FirstDayOfWeek", typeof(System.DayOfWeek), typeof(d), new PropertyMetadata(new PropertyChangedCallback(FirstDayOfWeekChanged)));
        public static System.DayOfWeek GetFirstDayOfWeek(DependencyObject dependencyObject)
        {
            return (System.DayOfWeek)dependencyObject.GetValue(FirstDayOfWeekProperty);
        }
        public static void SetFirstDayOfWeek(DependencyObject dependencyObject, System.DayOfWeek value)
        {
            dependencyObject.SetValue(FirstDayOfWeekProperty, value);
        }
		private static void FirstDayOfWeekChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("FirstDayOfWeek").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsTodayHighlightedProperty = DependencyProperty.RegisterAttached( "IsTodayHighlighted", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsTodayHighlightedChanged)));
        public static System.Boolean GetIsTodayHighlighted(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsTodayHighlightedProperty);
        }
        public static void SetIsTodayHighlighted(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsTodayHighlightedProperty, value);
        }
		private static void IsTodayHighlightedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsTodayHighlighted").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectedDateProperty = DependencyProperty.RegisterAttached( "SelectedDate", typeof(System.Nullable<System.DateTime>), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectedDateChanged)));
        public static System.Nullable<System.DateTime> GetSelectedDate(DependencyObject dependencyObject)
        {
            return (System.Nullable<System.DateTime>)dependencyObject.GetValue(SelectedDateProperty);
        }
        public static void SetSelectedDate(DependencyObject dependencyObject, System.Nullable<System.DateTime> value)
        {
            dependencyObject.SetValue(SelectedDateProperty, value);
        }
		private static void SelectedDateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectedDate").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectedDatesProperty = DependencyProperty.RegisterAttached( "SelectedDates", typeof(System.Windows.Controls.SelectedDatesCollection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectedDatesChanged)));
        public static System.Windows.Controls.SelectedDatesCollection GetSelectedDates(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.SelectedDatesCollection)dependencyObject.GetValue(SelectedDatesProperty);
        }
        public static void SetSelectedDates(DependencyObject dependencyObject, System.Windows.Controls.SelectedDatesCollection value)
        {
            dependencyObject.SetValue(SelectedDatesProperty, value);
        }
		private static void SelectedDatesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectedDates").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsThreeStateProperty = DependencyProperty.RegisterAttached( "IsThreeState", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsThreeStateChanged)));
        public static System.Boolean GetIsThreeState(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsThreeStateProperty);
        }
        public static void SetIsThreeState(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsThreeStateProperty, value);
        }
		private static void IsThreeStateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsThreeState").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsSynchronizedWithCurrentItemProperty = DependencyProperty.RegisterAttached( "IsSynchronizedWithCurrentItem", typeof(System.Nullable<System.Boolean>), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsSynchronizedWithCurrentItemChanged)));
        public static System.Nullable<System.Boolean> GetIsSynchronizedWithCurrentItem(DependencyObject dependencyObject)
        {
            return (System.Nullable<System.Boolean>)dependencyObject.GetValue(IsSynchronizedWithCurrentItemProperty);
        }
        public static void SetIsSynchronizedWithCurrentItem(DependencyObject dependencyObject, System.Nullable<System.Boolean> value)
        {
            dependencyObject.SetValue(IsSynchronizedWithCurrentItemProperty, value);
        }
		private static void IsSynchronizedWithCurrentItemChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsSynchronizedWithCurrentItem").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectedIndexProperty = DependencyProperty.RegisterAttached( "SelectedIndex", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectedIndexChanged)));
        public static System.Int32 GetSelectedIndex(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(SelectedIndexProperty);
        }
        public static void SetSelectedIndex(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(SelectedIndexProperty, value);
        }
		private static void SelectedIndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectedIndex").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectedItemProperty = DependencyProperty.RegisterAttached( "SelectedItem", typeof(System.Object), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectedItemChanged)));
        public static System.Object GetSelectedItem(DependencyObject dependencyObject)
        {
            return (System.Object)dependencyObject.GetValue(SelectedItemProperty);
        }
        public static void SetSelectedItem(DependencyObject dependencyObject, System.Object value)
        {
            dependencyObject.SetValue(SelectedItemProperty, value);
        }
		private static void SelectedItemChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectedItem").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectedValueProperty = DependencyProperty.RegisterAttached( "SelectedValue", typeof(System.Object), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectedValueChanged)));
        public static System.Object GetSelectedValue(DependencyObject dependencyObject)
        {
            return (System.Object)dependencyObject.GetValue(SelectedValueProperty);
        }
        public static void SetSelectedValue(DependencyObject dependencyObject, System.Object value)
        {
            dependencyObject.SetValue(SelectedValueProperty, value);
        }
		private static void SelectedValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectedValue").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectedValuePathProperty = DependencyProperty.RegisterAttached( "SelectedValuePath", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectedValuePathChanged)));
        public static System.String GetSelectedValuePath(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(SelectedValuePathProperty);
        }
        public static void SetSelectedValuePath(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(SelectedValuePathProperty, value);
        }
		private static void SelectedValuePathChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectedValuePath").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty MaxDropDownHeightProperty = DependencyProperty.RegisterAttached( "MaxDropDownHeight", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(MaxDropDownHeightChanged)));
        public static System.Double GetMaxDropDownHeight(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(MaxDropDownHeightProperty);
        }
        public static void SetMaxDropDownHeight(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(MaxDropDownHeightProperty, value);
        }
		private static void MaxDropDownHeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("MaxDropDownHeight").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsDropDownOpenProperty = DependencyProperty.RegisterAttached( "IsDropDownOpen", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsDropDownOpenChanged)));
        public static System.Boolean GetIsDropDownOpen(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsDropDownOpenProperty);
        }
        public static void SetIsDropDownOpen(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsDropDownOpenProperty, value);
        }
		private static void IsDropDownOpenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsDropDownOpen").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ShouldPreserveUserEnteredPrefixProperty = DependencyProperty.RegisterAttached( "ShouldPreserveUserEnteredPrefix", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ShouldPreserveUserEnteredPrefixChanged)));
        public static System.Boolean GetShouldPreserveUserEnteredPrefix(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(ShouldPreserveUserEnteredPrefixProperty);
        }
        public static void SetShouldPreserveUserEnteredPrefix(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(ShouldPreserveUserEnteredPrefixProperty, value);
        }
		private static void ShouldPreserveUserEnteredPrefixChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ShouldPreserveUserEnteredPrefix").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsEditableProperty = DependencyProperty.RegisterAttached( "IsEditable", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsEditableChanged)));
        public static System.Boolean GetIsEditable(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsEditableProperty);
        }
        public static void SetIsEditable(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsEditableProperty, value);
        }
		private static void IsEditableChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsEditable").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsReadOnlyProperty = DependencyProperty.RegisterAttached( "IsReadOnly", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsReadOnlyChanged)));
        public static System.Boolean GetIsReadOnly(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsReadOnlyProperty);
        }
        public static void SetIsReadOnly(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsReadOnlyProperty, value);
        }
		private static void IsReadOnlyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsReadOnly").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectionBoxItemProperty = DependencyProperty.RegisterAttached( "SelectionBoxItem", typeof(System.Object), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectionBoxItemChanged)));
        public static System.Object GetSelectionBoxItem(DependencyObject dependencyObject)
        {
            return (System.Object)dependencyObject.GetValue(SelectionBoxItemProperty);
        }
        public static void SetSelectionBoxItem(DependencyObject dependencyObject, System.Object value)
        {
            dependencyObject.SetValue(SelectionBoxItemProperty, value);
        }
		private static void SelectionBoxItemChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectionBoxItem").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectionBoxItemTemplateProperty = DependencyProperty.RegisterAttached( "SelectionBoxItemTemplate", typeof(System.Windows.DataTemplate), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectionBoxItemTemplateChanged)));
        public static System.Windows.DataTemplate GetSelectionBoxItemTemplate(DependencyObject dependencyObject)
        {
            return (System.Windows.DataTemplate)dependencyObject.GetValue(SelectionBoxItemTemplateProperty);
        }
        public static void SetSelectionBoxItemTemplate(DependencyObject dependencyObject, System.Windows.DataTemplate value)
        {
            dependencyObject.SetValue(SelectionBoxItemTemplateProperty, value);
        }
		private static void SelectionBoxItemTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectionBoxItemTemplate").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectionBoxItemStringFormatProperty = DependencyProperty.RegisterAttached( "SelectionBoxItemStringFormat", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectionBoxItemStringFormatChanged)));
        public static System.String GetSelectionBoxItemStringFormat(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(SelectionBoxItemStringFormatProperty);
        }
        public static void SetSelectionBoxItemStringFormat(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(SelectionBoxItemStringFormatProperty, value);
        }
		private static void SelectionBoxItemStringFormatChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectionBoxItemStringFormat").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty StaysOpenOnEditProperty = DependencyProperty.RegisterAttached( "StaysOpenOnEdit", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(StaysOpenOnEditChanged)));
        public static System.Boolean GetStaysOpenOnEdit(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(StaysOpenOnEditProperty);
        }
        public static void SetStaysOpenOnEdit(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(StaysOpenOnEditProperty, value);
        }
		private static void StaysOpenOnEditChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("StaysOpenOnEdit").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsSelectionBoxHighlightedProperty = DependencyProperty.RegisterAttached( "IsSelectionBoxHighlighted", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsSelectionBoxHighlightedChanged)));
        public static System.Boolean GetIsSelectionBoxHighlighted(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsSelectionBoxHighlightedProperty);
        }
        public static void SetIsSelectionBoxHighlighted(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsSelectionBoxHighlightedProperty, value);
        }
		private static void IsSelectionBoxHighlightedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsSelectionBoxHighlighted").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsSelectedProperty = DependencyProperty.RegisterAttached( "IsSelected", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsSelectedChanged)));
        public static System.Boolean GetIsSelected(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsSelectedProperty);
        }
        public static void SetIsSelected(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsSelectedProperty, value);
        }
		private static void IsSelectedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsSelected").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RecognizesAccessKeyProperty = DependencyProperty.RegisterAttached( "RecognizesAccessKey", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RecognizesAccessKeyChanged)));
        public static System.Boolean GetRecognizesAccessKey(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(RecognizesAccessKeyProperty);
        }
        public static void SetRecognizesAccessKey(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(RecognizesAccessKeyProperty, value);
        }
		private static void RecognizesAccessKeyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RecognizesAccessKey").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ContentSourceProperty = DependencyProperty.RegisterAttached( "ContentSource", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ContentSourceChanged)));
        public static System.String GetContentSource(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(ContentSourceProperty);
        }
        public static void SetContentSource(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(ContentSourceProperty, value);
        }
		private static void ContentSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ContentSource").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectedItemsProperty = DependencyProperty.RegisterAttached( "SelectedItems", typeof(System.Collections.IList), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectedItemsChanged)));
        public static System.Collections.IList GetSelectedItems(DependencyObject dependencyObject)
        {
            return (System.Collections.IList)dependencyObject.GetValue(SelectedItemsProperty);
        }
        public static void SetSelectedItems(DependencyObject dependencyObject, System.Collections.IList value)
        {
            dependencyObject.SetValue(SelectedItemsProperty, value);
        }
		private static void SelectedItemsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectedItems").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanUserResizeColumnsProperty = DependencyProperty.RegisterAttached( "CanUserResizeColumns", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanUserResizeColumnsChanged)));
        public static System.Boolean GetCanUserResizeColumns(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanUserResizeColumnsProperty);
        }
        public static void SetCanUserResizeColumns(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanUserResizeColumnsProperty, value);
        }
		private static void CanUserResizeColumnsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanUserResizeColumns").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ColumnWidthProperty = DependencyProperty.RegisterAttached( "ColumnWidth", typeof(System.Windows.Controls.DataGridLength), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ColumnWidthChanged)));
        public static System.Windows.Controls.DataGridLength GetColumnWidth(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.DataGridLength)dependencyObject.GetValue(ColumnWidthProperty);
        }
        public static void SetColumnWidth(DependencyObject dependencyObject, System.Windows.Controls.DataGridLength value)
        {
            dependencyObject.SetValue(ColumnWidthProperty, value);
        }
		private static void ColumnWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ColumnWidth").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty MinColumnWidthProperty = DependencyProperty.RegisterAttached( "MinColumnWidth", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(MinColumnWidthChanged)));
        public static System.Double GetMinColumnWidth(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(MinColumnWidthProperty);
        }
        public static void SetMinColumnWidth(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(MinColumnWidthProperty, value);
        }
		private static void MinColumnWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("MinColumnWidth").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty MaxColumnWidthProperty = DependencyProperty.RegisterAttached( "MaxColumnWidth", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(MaxColumnWidthChanged)));
        public static System.Double GetMaxColumnWidth(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(MaxColumnWidthProperty);
        }
        public static void SetMaxColumnWidth(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(MaxColumnWidthProperty, value);
        }
		private static void MaxColumnWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("MaxColumnWidth").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty GridLinesVisibilityProperty = DependencyProperty.RegisterAttached( "GridLinesVisibility", typeof(System.Windows.Controls.DataGridGridLinesVisibility), typeof(d), new PropertyMetadata(new PropertyChangedCallback(GridLinesVisibilityChanged)));
        public static System.Windows.Controls.DataGridGridLinesVisibility GetGridLinesVisibility(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.DataGridGridLinesVisibility)dependencyObject.GetValue(GridLinesVisibilityProperty);
        }
        public static void SetGridLinesVisibility(DependencyObject dependencyObject, System.Windows.Controls.DataGridGridLinesVisibility value)
        {
            dependencyObject.SetValue(GridLinesVisibilityProperty, value);
        }
		private static void GridLinesVisibilityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("GridLinesVisibility").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty HorizontalGridLinesBrushProperty = DependencyProperty.RegisterAttached( "HorizontalGridLinesBrush", typeof(System.Windows.Media.Brush), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HorizontalGridLinesBrushChanged)));
        public static System.Windows.Media.Brush GetHorizontalGridLinesBrush(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Brush)dependencyObject.GetValue(HorizontalGridLinesBrushProperty);
        }
        public static void SetHorizontalGridLinesBrush(DependencyObject dependencyObject, System.Windows.Media.Brush value)
        {
            dependencyObject.SetValue(HorizontalGridLinesBrushProperty, value);
        }
		private static void HorizontalGridLinesBrushChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("HorizontalGridLinesBrush").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty VerticalGridLinesBrushProperty = DependencyProperty.RegisterAttached( "VerticalGridLinesBrush", typeof(System.Windows.Media.Brush), typeof(d), new PropertyMetadata(new PropertyChangedCallback(VerticalGridLinesBrushChanged)));
        public static System.Windows.Media.Brush GetVerticalGridLinesBrush(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Brush)dependencyObject.GetValue(VerticalGridLinesBrushProperty);
        }
        public static void SetVerticalGridLinesBrush(DependencyObject dependencyObject, System.Windows.Media.Brush value)
        {
            dependencyObject.SetValue(VerticalGridLinesBrushProperty, value);
        }
		private static void VerticalGridLinesBrushChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("VerticalGridLinesBrush").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RowStyleProperty = DependencyProperty.RegisterAttached( "RowStyle", typeof(System.Windows.Style), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RowStyleChanged)));
        public static System.Windows.Style GetRowStyle(DependencyObject dependencyObject)
        {
            return (System.Windows.Style)dependencyObject.GetValue(RowStyleProperty);
        }
        public static void SetRowStyle(DependencyObject dependencyObject, System.Windows.Style value)
        {
            dependencyObject.SetValue(RowStyleProperty, value);
        }
		private static void RowStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RowStyle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RowValidationErrorTemplateProperty = DependencyProperty.RegisterAttached( "RowValidationErrorTemplate", typeof(System.Windows.Controls.ControlTemplate), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RowValidationErrorTemplateChanged)));
        public static System.Windows.Controls.ControlTemplate GetRowValidationErrorTemplate(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.ControlTemplate)dependencyObject.GetValue(RowValidationErrorTemplateProperty);
        }
        public static void SetRowValidationErrorTemplate(DependencyObject dependencyObject, System.Windows.Controls.ControlTemplate value)
        {
            dependencyObject.SetValue(RowValidationErrorTemplateProperty, value);
        }
		private static void RowValidationErrorTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RowValidationErrorTemplate").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RowValidationRulesProperty = DependencyProperty.RegisterAttached( "RowValidationRules", typeof(System.Collections.ObjectModel.ObservableCollection<System.Windows.Controls.ValidationRule>), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RowValidationRulesChanged)));
        public static System.Collections.ObjectModel.ObservableCollection<System.Windows.Controls.ValidationRule> GetRowValidationRules(DependencyObject dependencyObject)
        {
            return (System.Collections.ObjectModel.ObservableCollection<System.Windows.Controls.ValidationRule>)dependencyObject.GetValue(RowValidationRulesProperty);
        }
        public static void SetRowValidationRules(DependencyObject dependencyObject, System.Collections.ObjectModel.ObservableCollection<System.Windows.Controls.ValidationRule> value)
        {
            dependencyObject.SetValue(RowValidationRulesProperty, value);
        }
		private static void RowValidationRulesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RowValidationRules").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RowStyleSelectorProperty = DependencyProperty.RegisterAttached( "RowStyleSelector", typeof(System.Windows.Controls.StyleSelector), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RowStyleSelectorChanged)));
        public static System.Windows.Controls.StyleSelector GetRowStyleSelector(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.StyleSelector)dependencyObject.GetValue(RowStyleSelectorProperty);
        }
        public static void SetRowStyleSelector(DependencyObject dependencyObject, System.Windows.Controls.StyleSelector value)
        {
            dependencyObject.SetValue(RowStyleSelectorProperty, value);
        }
		private static void RowStyleSelectorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RowStyleSelector").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RowBackgroundProperty = DependencyProperty.RegisterAttached( "RowBackground", typeof(System.Windows.Media.Brush), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RowBackgroundChanged)));
        public static System.Windows.Media.Brush GetRowBackground(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Brush)dependencyObject.GetValue(RowBackgroundProperty);
        }
        public static void SetRowBackground(DependencyObject dependencyObject, System.Windows.Media.Brush value)
        {
            dependencyObject.SetValue(RowBackgroundProperty, value);
        }
		private static void RowBackgroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RowBackground").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AlternatingRowBackgroundProperty = DependencyProperty.RegisterAttached( "AlternatingRowBackground", typeof(System.Windows.Media.Brush), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AlternatingRowBackgroundChanged)));
        public static System.Windows.Media.Brush GetAlternatingRowBackground(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Brush)dependencyObject.GetValue(AlternatingRowBackgroundProperty);
        }
        public static void SetAlternatingRowBackground(DependencyObject dependencyObject, System.Windows.Media.Brush value)
        {
            dependencyObject.SetValue(AlternatingRowBackgroundProperty, value);
        }
		private static void AlternatingRowBackgroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AlternatingRowBackground").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RowHeightProperty = DependencyProperty.RegisterAttached( "RowHeight", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RowHeightChanged)));
        public static System.Double GetRowHeight(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(RowHeightProperty);
        }
        public static void SetRowHeight(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(RowHeightProperty, value);
        }
		private static void RowHeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RowHeight").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty MinRowHeightProperty = DependencyProperty.RegisterAttached( "MinRowHeight", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(MinRowHeightChanged)));
        public static System.Double GetMinRowHeight(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(MinRowHeightProperty);
        }
        public static void SetMinRowHeight(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(MinRowHeightProperty, value);
        }
		private static void MinRowHeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("MinRowHeight").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RowHeaderWidthProperty = DependencyProperty.RegisterAttached( "RowHeaderWidth", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RowHeaderWidthChanged)));
        public static System.Double GetRowHeaderWidth(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(RowHeaderWidthProperty);
        }
        public static void SetRowHeaderWidth(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(RowHeaderWidthProperty, value);
        }
		private static void RowHeaderWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RowHeaderWidth").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RowHeaderActualWidthProperty = DependencyProperty.RegisterAttached( "RowHeaderActualWidth", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RowHeaderActualWidthChanged)));
        public static System.Double GetRowHeaderActualWidth(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(RowHeaderActualWidthProperty);
        }
        public static void SetRowHeaderActualWidth(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(RowHeaderActualWidthProperty, value);
        }
		private static void RowHeaderActualWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RowHeaderActualWidth").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ColumnHeaderHeightProperty = DependencyProperty.RegisterAttached( "ColumnHeaderHeight", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ColumnHeaderHeightChanged)));
        public static System.Double GetColumnHeaderHeight(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(ColumnHeaderHeightProperty);
        }
        public static void SetColumnHeaderHeight(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(ColumnHeaderHeightProperty, value);
        }
		private static void ColumnHeaderHeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ColumnHeaderHeight").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty HeadersVisibilityProperty = DependencyProperty.RegisterAttached( "HeadersVisibility", typeof(System.Windows.Controls.DataGridHeadersVisibility), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HeadersVisibilityChanged)));
        public static System.Windows.Controls.DataGridHeadersVisibility GetHeadersVisibility(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.DataGridHeadersVisibility)dependencyObject.GetValue(HeadersVisibilityProperty);
        }
        public static void SetHeadersVisibility(DependencyObject dependencyObject, System.Windows.Controls.DataGridHeadersVisibility value)
        {
            dependencyObject.SetValue(HeadersVisibilityProperty, value);
        }
		private static void HeadersVisibilityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("HeadersVisibility").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CellStyleProperty = DependencyProperty.RegisterAttached( "CellStyle", typeof(System.Windows.Style), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CellStyleChanged)));
        public static System.Windows.Style GetCellStyle(DependencyObject dependencyObject)
        {
            return (System.Windows.Style)dependencyObject.GetValue(CellStyleProperty);
        }
        public static void SetCellStyle(DependencyObject dependencyObject, System.Windows.Style value)
        {
            dependencyObject.SetValue(CellStyleProperty, value);
        }
		private static void CellStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CellStyle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ColumnHeaderStyleProperty = DependencyProperty.RegisterAttached( "ColumnHeaderStyle", typeof(System.Windows.Style), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ColumnHeaderStyleChanged)));
        public static System.Windows.Style GetColumnHeaderStyle(DependencyObject dependencyObject)
        {
            return (System.Windows.Style)dependencyObject.GetValue(ColumnHeaderStyleProperty);
        }
        public static void SetColumnHeaderStyle(DependencyObject dependencyObject, System.Windows.Style value)
        {
            dependencyObject.SetValue(ColumnHeaderStyleProperty, value);
        }
		private static void ColumnHeaderStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ColumnHeaderStyle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RowHeaderStyleProperty = DependencyProperty.RegisterAttached( "RowHeaderStyle", typeof(System.Windows.Style), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RowHeaderStyleChanged)));
        public static System.Windows.Style GetRowHeaderStyle(DependencyObject dependencyObject)
        {
            return (System.Windows.Style)dependencyObject.GetValue(RowHeaderStyleProperty);
        }
        public static void SetRowHeaderStyle(DependencyObject dependencyObject, System.Windows.Style value)
        {
            dependencyObject.SetValue(RowHeaderStyleProperty, value);
        }
		private static void RowHeaderStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RowHeaderStyle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RowHeaderTemplateProperty = DependencyProperty.RegisterAttached( "RowHeaderTemplate", typeof(System.Windows.DataTemplate), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RowHeaderTemplateChanged)));
        public static System.Windows.DataTemplate GetRowHeaderTemplate(DependencyObject dependencyObject)
        {
            return (System.Windows.DataTemplate)dependencyObject.GetValue(RowHeaderTemplateProperty);
        }
        public static void SetRowHeaderTemplate(DependencyObject dependencyObject, System.Windows.DataTemplate value)
        {
            dependencyObject.SetValue(RowHeaderTemplateProperty, value);
        }
		private static void RowHeaderTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RowHeaderTemplate").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RowHeaderTemplateSelectorProperty = DependencyProperty.RegisterAttached( "RowHeaderTemplateSelector", typeof(System.Windows.Controls.DataTemplateSelector), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RowHeaderTemplateSelectorChanged)));
        public static System.Windows.Controls.DataTemplateSelector GetRowHeaderTemplateSelector(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.DataTemplateSelector)dependencyObject.GetValue(RowHeaderTemplateSelectorProperty);
        }
        public static void SetRowHeaderTemplateSelector(DependencyObject dependencyObject, System.Windows.Controls.DataTemplateSelector value)
        {
            dependencyObject.SetValue(RowHeaderTemplateSelectorProperty, value);
        }
		private static void RowHeaderTemplateSelectorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RowHeaderTemplateSelector").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CurrentItemProperty = DependencyProperty.RegisterAttached( "CurrentItem", typeof(System.Object), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CurrentItemChanged)));
        public static System.Object GetCurrentItem(DependencyObject dependencyObject)
        {
            return (System.Object)dependencyObject.GetValue(CurrentItemProperty);
        }
        public static void SetCurrentItem(DependencyObject dependencyObject, System.Object value)
        {
            dependencyObject.SetValue(CurrentItemProperty, value);
        }
		private static void CurrentItemChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CurrentItem").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CurrentColumnProperty = DependencyProperty.RegisterAttached( "CurrentColumn", typeof(System.Windows.Controls.DataGridColumn), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CurrentColumnChanged)));
        public static System.Windows.Controls.DataGridColumn GetCurrentColumn(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.DataGridColumn)dependencyObject.GetValue(CurrentColumnProperty);
        }
        public static void SetCurrentColumn(DependencyObject dependencyObject, System.Windows.Controls.DataGridColumn value)
        {
            dependencyObject.SetValue(CurrentColumnProperty, value);
        }
		private static void CurrentColumnChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CurrentColumn").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CurrentCellProperty = DependencyProperty.RegisterAttached( "CurrentCell", typeof(System.Windows.Controls.DataGridCellInfo), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CurrentCellChanged)));
        public static System.Windows.Controls.DataGridCellInfo GetCurrentCell(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.DataGridCellInfo)dependencyObject.GetValue(CurrentCellProperty);
        }
        public static void SetCurrentCell(DependencyObject dependencyObject, System.Windows.Controls.DataGridCellInfo value)
        {
            dependencyObject.SetValue(CurrentCellProperty, value);
        }
		private static void CurrentCellChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CurrentCell").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanUserAddRowsProperty = DependencyProperty.RegisterAttached( "CanUserAddRows", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanUserAddRowsChanged)));
        public static System.Boolean GetCanUserAddRows(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanUserAddRowsProperty);
        }
        public static void SetCanUserAddRows(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanUserAddRowsProperty, value);
        }
		private static void CanUserAddRowsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanUserAddRows").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanUserDeleteRowsProperty = DependencyProperty.RegisterAttached( "CanUserDeleteRows", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanUserDeleteRowsChanged)));
        public static System.Boolean GetCanUserDeleteRows(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanUserDeleteRowsProperty);
        }
        public static void SetCanUserDeleteRows(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanUserDeleteRowsProperty, value);
        }
		private static void CanUserDeleteRowsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanUserDeleteRows").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RowDetailsVisibilityModeProperty = DependencyProperty.RegisterAttached( "RowDetailsVisibilityMode", typeof(System.Windows.Controls.DataGridRowDetailsVisibilityMode), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RowDetailsVisibilityModeChanged)));
        public static System.Windows.Controls.DataGridRowDetailsVisibilityMode GetRowDetailsVisibilityMode(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.DataGridRowDetailsVisibilityMode)dependencyObject.GetValue(RowDetailsVisibilityModeProperty);
        }
        public static void SetRowDetailsVisibilityMode(DependencyObject dependencyObject, System.Windows.Controls.DataGridRowDetailsVisibilityMode value)
        {
            dependencyObject.SetValue(RowDetailsVisibilityModeProperty, value);
        }
		private static void RowDetailsVisibilityModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RowDetailsVisibilityMode").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AreRowDetailsFrozenProperty = DependencyProperty.RegisterAttached( "AreRowDetailsFrozen", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AreRowDetailsFrozenChanged)));
        public static System.Boolean GetAreRowDetailsFrozen(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(AreRowDetailsFrozenProperty);
        }
        public static void SetAreRowDetailsFrozen(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(AreRowDetailsFrozenProperty, value);
        }
		private static void AreRowDetailsFrozenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AreRowDetailsFrozen").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RowDetailsTemplateProperty = DependencyProperty.RegisterAttached( "RowDetailsTemplate", typeof(System.Windows.DataTemplate), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RowDetailsTemplateChanged)));
        public static System.Windows.DataTemplate GetRowDetailsTemplate(DependencyObject dependencyObject)
        {
            return (System.Windows.DataTemplate)dependencyObject.GetValue(RowDetailsTemplateProperty);
        }
        public static void SetRowDetailsTemplate(DependencyObject dependencyObject, System.Windows.DataTemplate value)
        {
            dependencyObject.SetValue(RowDetailsTemplateProperty, value);
        }
		private static void RowDetailsTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RowDetailsTemplate").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RowDetailsTemplateSelectorProperty = DependencyProperty.RegisterAttached( "RowDetailsTemplateSelector", typeof(System.Windows.Controls.DataTemplateSelector), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RowDetailsTemplateSelectorChanged)));
        public static System.Windows.Controls.DataTemplateSelector GetRowDetailsTemplateSelector(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.DataTemplateSelector)dependencyObject.GetValue(RowDetailsTemplateSelectorProperty);
        }
        public static void SetRowDetailsTemplateSelector(DependencyObject dependencyObject, System.Windows.Controls.DataTemplateSelector value)
        {
            dependencyObject.SetValue(RowDetailsTemplateSelectorProperty, value);
        }
		private static void RowDetailsTemplateSelectorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RowDetailsTemplateSelector").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanUserResizeRowsProperty = DependencyProperty.RegisterAttached( "CanUserResizeRows", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanUserResizeRowsChanged)));
        public static System.Boolean GetCanUserResizeRows(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanUserResizeRowsProperty);
        }
        public static void SetCanUserResizeRows(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanUserResizeRowsProperty, value);
        }
		private static void CanUserResizeRowsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanUserResizeRows").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty NewItemMarginProperty = DependencyProperty.RegisterAttached( "NewItemMargin", typeof(System.Windows.Thickness), typeof(d), new PropertyMetadata(new PropertyChangedCallback(NewItemMarginChanged)));
        public static System.Windows.Thickness GetNewItemMargin(DependencyObject dependencyObject)
        {
            return (System.Windows.Thickness)dependencyObject.GetValue(NewItemMarginProperty);
        }
        public static void SetNewItemMargin(DependencyObject dependencyObject, System.Windows.Thickness value)
        {
            dependencyObject.SetValue(NewItemMarginProperty, value);
        }
		private static void NewItemMarginChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("NewItemMargin").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectedCellsProperty = DependencyProperty.RegisterAttached( "SelectedCells", typeof(System.Collections.Generic.IList<System.Windows.Controls.DataGridCellInfo>), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectedCellsChanged)));
        public static System.Collections.Generic.IList<System.Windows.Controls.DataGridCellInfo> GetSelectedCells(DependencyObject dependencyObject)
        {
            return (System.Collections.Generic.IList<System.Windows.Controls.DataGridCellInfo>)dependencyObject.GetValue(SelectedCellsProperty);
        }
        public static void SetSelectedCells(DependencyObject dependencyObject, System.Collections.Generic.IList<System.Windows.Controls.DataGridCellInfo> value)
        {
            dependencyObject.SetValue(SelectedCellsProperty, value);
        }
		private static void SelectedCellsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectedCells").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectionUnitProperty = DependencyProperty.RegisterAttached( "SelectionUnit", typeof(System.Windows.Controls.DataGridSelectionUnit), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectionUnitChanged)));
        public static System.Windows.Controls.DataGridSelectionUnit GetSelectionUnit(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.DataGridSelectionUnit)dependencyObject.GetValue(SelectionUnitProperty);
        }
        public static void SetSelectionUnit(DependencyObject dependencyObject, System.Windows.Controls.DataGridSelectionUnit value)
        {
            dependencyObject.SetValue(SelectionUnitProperty, value);
        }
		private static void SelectionUnitChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectionUnit").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanUserSortColumnsProperty = DependencyProperty.RegisterAttached( "CanUserSortColumns", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanUserSortColumnsChanged)));
        public static System.Boolean GetCanUserSortColumns(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanUserSortColumnsProperty);
        }
        public static void SetCanUserSortColumns(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanUserSortColumnsProperty, value);
        }
		private static void CanUserSortColumnsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanUserSortColumns").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AutoGenerateColumnsProperty = DependencyProperty.RegisterAttached( "AutoGenerateColumns", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AutoGenerateColumnsChanged)));
        public static System.Boolean GetAutoGenerateColumns(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(AutoGenerateColumnsProperty);
        }
        public static void SetAutoGenerateColumns(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(AutoGenerateColumnsProperty, value);
        }
		private static void AutoGenerateColumnsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AutoGenerateColumns").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty FrozenColumnCountProperty = DependencyProperty.RegisterAttached( "FrozenColumnCount", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(FrozenColumnCountChanged)));
        public static System.Int32 GetFrozenColumnCount(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(FrozenColumnCountProperty);
        }
        public static void SetFrozenColumnCount(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(FrozenColumnCountProperty, value);
        }
		private static void FrozenColumnCountChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("FrozenColumnCount").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty NonFrozenColumnsViewportHorizontalOffsetProperty = DependencyProperty.RegisterAttached( "NonFrozenColumnsViewportHorizontalOffset", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(NonFrozenColumnsViewportHorizontalOffsetChanged)));
        public static System.Double GetNonFrozenColumnsViewportHorizontalOffset(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(NonFrozenColumnsViewportHorizontalOffsetProperty);
        }
        public static void SetNonFrozenColumnsViewportHorizontalOffset(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(NonFrozenColumnsViewportHorizontalOffsetProperty, value);
        }
		private static void NonFrozenColumnsViewportHorizontalOffsetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("NonFrozenColumnsViewportHorizontalOffset").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty EnableRowVirtualizationProperty = DependencyProperty.RegisterAttached( "EnableRowVirtualization", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(EnableRowVirtualizationChanged)));
        public static System.Boolean GetEnableRowVirtualization(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(EnableRowVirtualizationProperty);
        }
        public static void SetEnableRowVirtualization(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(EnableRowVirtualizationProperty, value);
        }
		private static void EnableRowVirtualizationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("EnableRowVirtualization").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty EnableColumnVirtualizationProperty = DependencyProperty.RegisterAttached( "EnableColumnVirtualization", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(EnableColumnVirtualizationChanged)));
        public static System.Boolean GetEnableColumnVirtualization(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(EnableColumnVirtualizationProperty);
        }
        public static void SetEnableColumnVirtualization(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(EnableColumnVirtualizationProperty, value);
        }
		private static void EnableColumnVirtualizationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("EnableColumnVirtualization").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanUserReorderColumnsProperty = DependencyProperty.RegisterAttached( "CanUserReorderColumns", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanUserReorderColumnsChanged)));
        public static System.Boolean GetCanUserReorderColumns(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanUserReorderColumnsProperty);
        }
        public static void SetCanUserReorderColumns(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanUserReorderColumnsProperty, value);
        }
		private static void CanUserReorderColumnsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanUserReorderColumns").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DragIndicatorStyleProperty = DependencyProperty.RegisterAttached( "DragIndicatorStyle", typeof(System.Windows.Style), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DragIndicatorStyleChanged)));
        public static System.Windows.Style GetDragIndicatorStyle(DependencyObject dependencyObject)
        {
            return (System.Windows.Style)dependencyObject.GetValue(DragIndicatorStyleProperty);
        }
        public static void SetDragIndicatorStyle(DependencyObject dependencyObject, System.Windows.Style value)
        {
            dependencyObject.SetValue(DragIndicatorStyleProperty, value);
        }
		private static void DragIndicatorStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DragIndicatorStyle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DropLocationIndicatorStyleProperty = DependencyProperty.RegisterAttached( "DropLocationIndicatorStyle", typeof(System.Windows.Style), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DropLocationIndicatorStyleChanged)));
        public static System.Windows.Style GetDropLocationIndicatorStyle(DependencyObject dependencyObject)
        {
            return (System.Windows.Style)dependencyObject.GetValue(DropLocationIndicatorStyleProperty);
        }
        public static void SetDropLocationIndicatorStyle(DependencyObject dependencyObject, System.Windows.Style value)
        {
            dependencyObject.SetValue(DropLocationIndicatorStyleProperty, value);
        }
		private static void DropLocationIndicatorStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DropLocationIndicatorStyle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ClipboardCopyModeProperty = DependencyProperty.RegisterAttached( "ClipboardCopyMode", typeof(System.Windows.Controls.DataGridClipboardCopyMode), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ClipboardCopyModeChanged)));
        public static System.Windows.Controls.DataGridClipboardCopyMode GetClipboardCopyMode(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.DataGridClipboardCopyMode)dependencyObject.GetValue(ClipboardCopyModeProperty);
        }
        public static void SetClipboardCopyMode(DependencyObject dependencyObject, System.Windows.Controls.DataGridClipboardCopyMode value)
        {
            dependencyObject.SetValue(ClipboardCopyModeProperty, value);
        }
		private static void ClipboardCopyModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ClipboardCopyMode").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CellsPanelHorizontalOffsetProperty = DependencyProperty.RegisterAttached( "CellsPanelHorizontalOffset", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CellsPanelHorizontalOffsetChanged)));
        public static System.Double GetCellsPanelHorizontalOffset(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(CellsPanelHorizontalOffsetProperty);
        }
        public static void SetCellsPanelHorizontalOffset(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(CellsPanelHorizontalOffsetProperty, value);
        }
		private static void CellsPanelHorizontalOffsetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CellsPanelHorizontalOffset").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsEditingProperty = DependencyProperty.RegisterAttached( "IsEditing", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsEditingChanged)));
        public static System.Boolean GetIsEditing(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsEditingProperty);
        }
        public static void SetIsEditing(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsEditingProperty, value);
        }
		private static void IsEditingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsEditing").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanHierarchicallyScrollAndVirtualizeProperty = DependencyProperty.RegisterAttached( "CanHierarchicallyScrollAndVirtualize", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanHierarchicallyScrollAndVirtualizeChanged)));
        public static System.Boolean GetCanHierarchicallyScrollAndVirtualize(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanHierarchicallyScrollAndVirtualizeProperty);
        }
        public static void SetCanHierarchicallyScrollAndVirtualize(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanHierarchicallyScrollAndVirtualizeProperty, value);
        }
		private static void CanHierarchicallyScrollAndVirtualizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanHierarchicallyScrollAndVirtualize").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ItemProperty = DependencyProperty.RegisterAttached( "Item", typeof(System.Object), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ItemChanged)));
        public static System.Object GetItem(DependencyObject dependencyObject)
        {
            return (System.Object)dependencyObject.GetValue(ItemProperty);
        }
        public static void SetItem(DependencyObject dependencyObject, System.Object value)
        {
            dependencyObject.SetValue(ItemProperty, value);
        }
		private static void ItemChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Item").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty HeaderStyleProperty = DependencyProperty.RegisterAttached( "HeaderStyle", typeof(System.Windows.Style), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HeaderStyleChanged)));
        public static System.Windows.Style GetHeaderStyle(DependencyObject dependencyObject)
        {
            return (System.Windows.Style)dependencyObject.GetValue(HeaderStyleProperty);
        }
        public static void SetHeaderStyle(DependencyObject dependencyObject, System.Windows.Style value)
        {
            dependencyObject.SetValue(HeaderStyleProperty, value);
        }
		private static void HeaderStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("HeaderStyle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ValidationErrorTemplateProperty = DependencyProperty.RegisterAttached( "ValidationErrorTemplate", typeof(System.Windows.Controls.ControlTemplate), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ValidationErrorTemplateChanged)));
        public static System.Windows.Controls.ControlTemplate GetValidationErrorTemplate(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.ControlTemplate)dependencyObject.GetValue(ValidationErrorTemplateProperty);
        }
        public static void SetValidationErrorTemplate(DependencyObject dependencyObject, System.Windows.Controls.ControlTemplate value)
        {
            dependencyObject.SetValue(ValidationErrorTemplateProperty, value);
        }
		private static void ValidationErrorTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ValidationErrorTemplate").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DetailsTemplateProperty = DependencyProperty.RegisterAttached( "DetailsTemplate", typeof(System.Windows.DataTemplate), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DetailsTemplateChanged)));
        public static System.Windows.DataTemplate GetDetailsTemplate(DependencyObject dependencyObject)
        {
            return (System.Windows.DataTemplate)dependencyObject.GetValue(DetailsTemplateProperty);
        }
        public static void SetDetailsTemplate(DependencyObject dependencyObject, System.Windows.DataTemplate value)
        {
            dependencyObject.SetValue(DetailsTemplateProperty, value);
        }
		private static void DetailsTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DetailsTemplate").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DetailsTemplateSelectorProperty = DependencyProperty.RegisterAttached( "DetailsTemplateSelector", typeof(System.Windows.Controls.DataTemplateSelector), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DetailsTemplateSelectorChanged)));
        public static System.Windows.Controls.DataTemplateSelector GetDetailsTemplateSelector(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.DataTemplateSelector)dependencyObject.GetValue(DetailsTemplateSelectorProperty);
        }
        public static void SetDetailsTemplateSelector(DependencyObject dependencyObject, System.Windows.Controls.DataTemplateSelector value)
        {
            dependencyObject.SetValue(DetailsTemplateSelectorProperty, value);
        }
		private static void DetailsTemplateSelectorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DetailsTemplateSelector").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DetailsVisibilityProperty = DependencyProperty.RegisterAttached( "DetailsVisibility", typeof(System.Windows.Visibility), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DetailsVisibilityChanged)));
        public static System.Windows.Visibility GetDetailsVisibility(DependencyObject dependencyObject)
        {
            return (System.Windows.Visibility)dependencyObject.GetValue(DetailsVisibilityProperty);
        }
        public static void SetDetailsVisibility(DependencyObject dependencyObject, System.Windows.Visibility value)
        {
            dependencyObject.SetValue(DetailsVisibilityProperty, value);
        }
		private static void DetailsVisibilityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DetailsVisibility").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AlternationIndexProperty = DependencyProperty.RegisterAttached( "AlternationIndex", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AlternationIndexChanged)));
        public static System.Int32 GetAlternationIndex(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(AlternationIndexProperty);
        }
        public static void SetAlternationIndex(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(AlternationIndexProperty, value);
        }
		private static void AlternationIndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AlternationIndex").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsNewItemProperty = DependencyProperty.RegisterAttached( "IsNewItem", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsNewItemChanged)));
        public static System.Boolean GetIsNewItem(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsNewItemProperty);
        }
        public static void SetIsNewItem(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsNewItemProperty, value);
        }
		private static void IsNewItemChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsNewItem").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CalendarStyleProperty = DependencyProperty.RegisterAttached( "CalendarStyle", typeof(System.Windows.Style), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CalendarStyleChanged)));
        public static System.Windows.Style GetCalendarStyle(DependencyObject dependencyObject)
        {
            return (System.Windows.Style)dependencyObject.GetValue(CalendarStyleProperty);
        }
        public static void SetCalendarStyle(DependencyObject dependencyObject, System.Windows.Style value)
        {
            dependencyObject.SetValue(CalendarStyleProperty, value);
        }
		private static void CalendarStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CalendarStyle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectedDateFormatProperty = DependencyProperty.RegisterAttached( "SelectedDateFormat", typeof(System.Windows.Controls.DatePickerFormat), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectedDateFormatChanged)));
        public static System.Windows.Controls.DatePickerFormat GetSelectedDateFormat(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.DatePickerFormat)dependencyObject.GetValue(SelectedDateFormatProperty);
        }
        public static void SetSelectedDateFormat(DependencyObject dependencyObject, System.Windows.Controls.DatePickerFormat value)
        {
            dependencyObject.SetValue(SelectedDateFormatProperty, value);
        }
		private static void SelectedDateFormatChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectedDateFormat").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty LastChildFillProperty = DependencyProperty.RegisterAttached( "LastChildFill", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(LastChildFillChanged)));
        public static System.Boolean GetLastChildFill(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(LastChildFillProperty);
        }
        public static void SetLastChildFill(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(LastChildFillProperty, value);
        }
		private static void LastChildFillChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("LastChildFill").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ExtentWidthProperty = DependencyProperty.RegisterAttached( "ExtentWidth", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ExtentWidthChanged)));
        public static System.Double GetExtentWidth(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(ExtentWidthProperty);
        }
        public static void SetExtentWidth(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(ExtentWidthProperty, value);
        }
		private static void ExtentWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ExtentWidth").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ExtentHeightProperty = DependencyProperty.RegisterAttached( "ExtentHeight", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ExtentHeightChanged)));
        public static System.Double GetExtentHeight(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(ExtentHeightProperty);
        }
        public static void SetExtentHeight(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(ExtentHeightProperty, value);
        }
		private static void ExtentHeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ExtentHeight").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ViewportWidthProperty = DependencyProperty.RegisterAttached( "ViewportWidth", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ViewportWidthChanged)));
        public static System.Double GetViewportWidth(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(ViewportWidthProperty);
        }
        public static void SetViewportWidth(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(ViewportWidthProperty, value);
        }
		private static void ViewportWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ViewportWidth").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ViewportHeightProperty = DependencyProperty.RegisterAttached( "ViewportHeight", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ViewportHeightChanged)));
        public static System.Double GetViewportHeight(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(ViewportHeightProperty);
        }
        public static void SetViewportHeight(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(ViewportHeightProperty, value);
        }
		private static void ViewportHeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ViewportHeight").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ShowPageBordersProperty = DependencyProperty.RegisterAttached( "ShowPageBorders", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ShowPageBordersChanged)));
        public static System.Boolean GetShowPageBorders(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(ShowPageBordersProperty);
        }
        public static void SetShowPageBorders(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(ShowPageBordersProperty, value);
        }
		private static void ShowPageBordersChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ShowPageBorders").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty MaxPagesAcrossProperty = DependencyProperty.RegisterAttached( "MaxPagesAcross", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(MaxPagesAcrossChanged)));
        public static System.Int32 GetMaxPagesAcross(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(MaxPagesAcrossProperty);
        }
        public static void SetMaxPagesAcross(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(MaxPagesAcrossProperty, value);
        }
		private static void MaxPagesAcrossChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("MaxPagesAcross").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty VerticalPageSpacingProperty = DependencyProperty.RegisterAttached( "VerticalPageSpacing", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(VerticalPageSpacingChanged)));
        public static System.Double GetVerticalPageSpacing(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(VerticalPageSpacingProperty);
        }
        public static void SetVerticalPageSpacing(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(VerticalPageSpacingProperty, value);
        }
		private static void VerticalPageSpacingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("VerticalPageSpacing").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty HorizontalPageSpacingProperty = DependencyProperty.RegisterAttached( "HorizontalPageSpacing", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HorizontalPageSpacingChanged)));
        public static System.Double GetHorizontalPageSpacing(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(HorizontalPageSpacingProperty);
        }
        public static void SetHorizontalPageSpacing(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(HorizontalPageSpacingProperty, value);
        }
		private static void HorizontalPageSpacingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("HorizontalPageSpacing").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanMoveUpProperty = DependencyProperty.RegisterAttached( "CanMoveUp", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanMoveUpChanged)));
        public static System.Boolean GetCanMoveUp(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanMoveUpProperty);
        }
        public static void SetCanMoveUp(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanMoveUpProperty, value);
        }
		private static void CanMoveUpChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanMoveUp").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanMoveDownProperty = DependencyProperty.RegisterAttached( "CanMoveDown", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanMoveDownChanged)));
        public static System.Boolean GetCanMoveDown(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanMoveDownProperty);
        }
        public static void SetCanMoveDown(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanMoveDownProperty, value);
        }
		private static void CanMoveDownChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanMoveDown").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanMoveLeftProperty = DependencyProperty.RegisterAttached( "CanMoveLeft", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanMoveLeftChanged)));
        public static System.Boolean GetCanMoveLeft(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanMoveLeftProperty);
        }
        public static void SetCanMoveLeft(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanMoveLeftProperty, value);
        }
		private static void CanMoveLeftChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanMoveLeft").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanMoveRightProperty = DependencyProperty.RegisterAttached( "CanMoveRight", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanMoveRightChanged)));
        public static System.Boolean GetCanMoveRight(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanMoveRightProperty);
        }
        public static void SetCanMoveRight(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanMoveRightProperty, value);
        }
		private static void CanMoveRightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanMoveRight").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ExpandDirectionProperty = DependencyProperty.RegisterAttached( "ExpandDirection", typeof(System.Windows.Controls.ExpandDirection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ExpandDirectionChanged)));
        public static System.Windows.Controls.ExpandDirection GetExpandDirection(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.ExpandDirection)dependencyObject.GetValue(ExpandDirectionProperty);
        }
        public static void SetExpandDirection(DependencyObject dependencyObject, System.Windows.Controls.ExpandDirection value)
        {
            dependencyObject.SetValue(ExpandDirectionProperty, value);
        }
		private static void ExpandDirectionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ExpandDirection").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ViewingModeProperty = DependencyProperty.RegisterAttached( "ViewingMode", typeof(System.Windows.Controls.FlowDocumentReaderViewingMode), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ViewingModeChanged)));
        public static System.Windows.Controls.FlowDocumentReaderViewingMode GetViewingMode(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.FlowDocumentReaderViewingMode)dependencyObject.GetValue(ViewingModeProperty);
        }
        public static void SetViewingMode(DependencyObject dependencyObject, System.Windows.Controls.FlowDocumentReaderViewingMode value)
        {
            dependencyObject.SetValue(ViewingModeProperty, value);
        }
		private static void ViewingModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ViewingMode").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsPageViewEnabledProperty = DependencyProperty.RegisterAttached( "IsPageViewEnabled", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsPageViewEnabledChanged)));
        public static System.Boolean GetIsPageViewEnabled(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsPageViewEnabledProperty);
        }
        public static void SetIsPageViewEnabled(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsPageViewEnabledProperty, value);
        }
		private static void IsPageViewEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsPageViewEnabled").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsTwoPageViewEnabledProperty = DependencyProperty.RegisterAttached( "IsTwoPageViewEnabled", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsTwoPageViewEnabledChanged)));
        public static System.Boolean GetIsTwoPageViewEnabled(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsTwoPageViewEnabledProperty);
        }
        public static void SetIsTwoPageViewEnabled(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsTwoPageViewEnabledProperty, value);
        }
		private static void IsTwoPageViewEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsTwoPageViewEnabled").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsScrollViewEnabledProperty = DependencyProperty.RegisterAttached( "IsScrollViewEnabled", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsScrollViewEnabledChanged)));
        public static System.Boolean GetIsScrollViewEnabled(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsScrollViewEnabledProperty);
        }
        public static void SetIsScrollViewEnabled(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsScrollViewEnabledProperty, value);
        }
		private static void IsScrollViewEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsScrollViewEnabled").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty PageNumberProperty = DependencyProperty.RegisterAttached( "PageNumber", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(PageNumberChanged)));
        public static System.Int32 GetPageNumber(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(PageNumberProperty);
        }
        public static void SetPageNumber(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(PageNumberProperty, value);
        }
		private static void PageNumberChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("PageNumber").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsFindEnabledProperty = DependencyProperty.RegisterAttached( "IsFindEnabled", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsFindEnabledChanged)));
        public static System.Boolean GetIsFindEnabled(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsFindEnabledProperty);
        }
        public static void SetIsFindEnabled(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsFindEnabledProperty, value);
        }
		private static void IsFindEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsFindEnabled").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsPrintEnabledProperty = DependencyProperty.RegisterAttached( "IsPrintEnabled", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsPrintEnabledChanged)));
        public static System.Boolean GetIsPrintEnabled(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsPrintEnabledProperty);
        }
        public static void SetIsPrintEnabled(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsPrintEnabledProperty, value);
        }
		private static void IsPrintEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsPrintEnabled").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty NavigationUIVisibilityProperty = DependencyProperty.RegisterAttached( "NavigationUIVisibility", typeof(System.Windows.Navigation.NavigationUIVisibility), typeof(d), new PropertyMetadata(new PropertyChangedCallback(NavigationUIVisibilityChanged)));
        public static System.Windows.Navigation.NavigationUIVisibility GetNavigationUIVisibility(DependencyObject dependencyObject)
        {
            return (System.Windows.Navigation.NavigationUIVisibility)dependencyObject.GetValue(NavigationUIVisibilityProperty);
        }
        public static void SetNavigationUIVisibility(DependencyObject dependencyObject, System.Windows.Navigation.NavigationUIVisibility value)
        {
            dependencyObject.SetValue(NavigationUIVisibilityProperty, value);
        }
		private static void NavigationUIVisibilityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("NavigationUIVisibility").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty JournalOwnershipProperty = DependencyProperty.RegisterAttached( "JournalOwnership", typeof(System.Windows.Navigation.JournalOwnership), typeof(d), new PropertyMetadata(new PropertyChangedCallback(JournalOwnershipChanged)));
        public static System.Windows.Navigation.JournalOwnership GetJournalOwnership(DependencyObject dependencyObject)
        {
            return (System.Windows.Navigation.JournalOwnership)dependencyObject.GetValue(JournalOwnershipProperty);
        }
        public static void SetJournalOwnership(DependencyObject dependencyObject, System.Windows.Navigation.JournalOwnership value)
        {
            dependencyObject.SetValue(JournalOwnershipProperty, value);
        }
		private static void JournalOwnershipChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("JournalOwnership").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ShowGridLinesProperty = DependencyProperty.RegisterAttached( "ShowGridLines", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ShowGridLinesChanged)));
        public static System.Boolean GetShowGridLines(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(ShowGridLinesProperty);
        }
        public static void SetShowGridLines(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(ShowGridLinesProperty, value);
        }
		private static void ShowGridLinesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ShowGridLines").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ColumnDefinitionsProperty = DependencyProperty.RegisterAttached( "ColumnDefinitions", typeof(System.Windows.Controls.ColumnDefinitionCollection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ColumnDefinitionsChanged)));
        public static System.Windows.Controls.ColumnDefinitionCollection GetColumnDefinitions(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.ColumnDefinitionCollection)dependencyObject.GetValue(ColumnDefinitionsProperty);
        }
        public static void SetColumnDefinitions(DependencyObject dependencyObject, System.Windows.Controls.ColumnDefinitionCollection value)
        {
            dependencyObject.SetValue(ColumnDefinitionsProperty, value);
        }
		private static void ColumnDefinitionsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ColumnDefinitions").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RowDefinitionsProperty = DependencyProperty.RegisterAttached( "RowDefinitions", typeof(System.Windows.Controls.RowDefinitionCollection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RowDefinitionsChanged)));
        public static System.Windows.Controls.RowDefinitionCollection GetRowDefinitions(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.RowDefinitionCollection)dependencyObject.GetValue(RowDefinitionsProperty);
        }
        public static void SetRowDefinitions(DependencyObject dependencyObject, System.Windows.Controls.RowDefinitionCollection value)
        {
            dependencyObject.SetValue(RowDefinitionsProperty, value);
        }
		private static void RowDefinitionsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RowDefinitions").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ColumnHeaderContainerStyleProperty = DependencyProperty.RegisterAttached( "ColumnHeaderContainerStyle", typeof(System.Windows.Style), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ColumnHeaderContainerStyleChanged)));
        public static System.Windows.Style GetColumnHeaderContainerStyle(DependencyObject dependencyObject)
        {
            return (System.Windows.Style)dependencyObject.GetValue(ColumnHeaderContainerStyleProperty);
        }
        public static void SetColumnHeaderContainerStyle(DependencyObject dependencyObject, System.Windows.Style value)
        {
            dependencyObject.SetValue(ColumnHeaderContainerStyleProperty, value);
        }
		private static void ColumnHeaderContainerStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ColumnHeaderContainerStyle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ColumnHeaderTemplateProperty = DependencyProperty.RegisterAttached( "ColumnHeaderTemplate", typeof(System.Windows.DataTemplate), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ColumnHeaderTemplateChanged)));
        public static System.Windows.DataTemplate GetColumnHeaderTemplate(DependencyObject dependencyObject)
        {
            return (System.Windows.DataTemplate)dependencyObject.GetValue(ColumnHeaderTemplateProperty);
        }
        public static void SetColumnHeaderTemplate(DependencyObject dependencyObject, System.Windows.DataTemplate value)
        {
            dependencyObject.SetValue(ColumnHeaderTemplateProperty, value);
        }
		private static void ColumnHeaderTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ColumnHeaderTemplate").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ColumnHeaderTemplateSelectorProperty = DependencyProperty.RegisterAttached( "ColumnHeaderTemplateSelector", typeof(System.Windows.Controls.DataTemplateSelector), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ColumnHeaderTemplateSelectorChanged)));
        public static System.Windows.Controls.DataTemplateSelector GetColumnHeaderTemplateSelector(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.DataTemplateSelector)dependencyObject.GetValue(ColumnHeaderTemplateSelectorProperty);
        }
        public static void SetColumnHeaderTemplateSelector(DependencyObject dependencyObject, System.Windows.Controls.DataTemplateSelector value)
        {
            dependencyObject.SetValue(ColumnHeaderTemplateSelectorProperty, value);
        }
		private static void ColumnHeaderTemplateSelectorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ColumnHeaderTemplateSelector").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ColumnHeaderStringFormatProperty = DependencyProperty.RegisterAttached( "ColumnHeaderStringFormat", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ColumnHeaderStringFormatChanged)));
        public static System.String GetColumnHeaderStringFormat(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(ColumnHeaderStringFormatProperty);
        }
        public static void SetColumnHeaderStringFormat(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(ColumnHeaderStringFormatProperty, value);
        }
		private static void ColumnHeaderStringFormatChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ColumnHeaderStringFormat").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AllowsColumnReorderProperty = DependencyProperty.RegisterAttached( "AllowsColumnReorder", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AllowsColumnReorderChanged)));
        public static System.Boolean GetAllowsColumnReorder(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(AllowsColumnReorderProperty);
        }
        public static void SetAllowsColumnReorder(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(AllowsColumnReorderProperty, value);
        }
		private static void AllowsColumnReorderChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AllowsColumnReorder").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ColumnHeaderContextMenuProperty = DependencyProperty.RegisterAttached( "ColumnHeaderContextMenu", typeof(System.Windows.Controls.ContextMenu), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ColumnHeaderContextMenuChanged)));
        public static System.Windows.Controls.ContextMenu GetColumnHeaderContextMenu(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.ContextMenu)dependencyObject.GetValue(ColumnHeaderContextMenuProperty);
        }
        public static void SetColumnHeaderContextMenu(DependencyObject dependencyObject, System.Windows.Controls.ContextMenu value)
        {
            dependencyObject.SetValue(ColumnHeaderContextMenuProperty, value);
        }
		private static void ColumnHeaderContextMenuChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ColumnHeaderContextMenu").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ColumnHeaderToolTipProperty = DependencyProperty.RegisterAttached( "ColumnHeaderToolTip", typeof(System.Object), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ColumnHeaderToolTipChanged)));
        public static System.Object GetColumnHeaderToolTip(DependencyObject dependencyObject)
        {
            return (System.Object)dependencyObject.GetValue(ColumnHeaderToolTipProperty);
        }
        public static void SetColumnHeaderToolTip(DependencyObject dependencyObject, System.Object value)
        {
            dependencyObject.SetValue(ColumnHeaderToolTipProperty, value);
        }
		private static void ColumnHeaderToolTipChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ColumnHeaderToolTip").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsDraggingProperty = DependencyProperty.RegisterAttached( "IsDragging", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsDraggingChanged)));
        public static System.Boolean GetIsDragging(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsDraggingProperty);
        }
        public static void SetIsDragging(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsDraggingProperty, value);
        }
		private static void IsDraggingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsDragging").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ResizeDirectionProperty = DependencyProperty.RegisterAttached( "ResizeDirection", typeof(System.Windows.Controls.GridResizeDirection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ResizeDirectionChanged)));
        public static System.Windows.Controls.GridResizeDirection GetResizeDirection(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.GridResizeDirection)dependencyObject.GetValue(ResizeDirectionProperty);
        }
        public static void SetResizeDirection(DependencyObject dependencyObject, System.Windows.Controls.GridResizeDirection value)
        {
            dependencyObject.SetValue(ResizeDirectionProperty, value);
        }
		private static void ResizeDirectionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ResizeDirection").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ResizeBehaviorProperty = DependencyProperty.RegisterAttached( "ResizeBehavior", typeof(System.Windows.Controls.GridResizeBehavior), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ResizeBehaviorChanged)));
        public static System.Windows.Controls.GridResizeBehavior GetResizeBehavior(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.GridResizeBehavior)dependencyObject.GetValue(ResizeBehaviorProperty);
        }
        public static void SetResizeBehavior(DependencyObject dependencyObject, System.Windows.Controls.GridResizeBehavior value)
        {
            dependencyObject.SetValue(ResizeBehaviorProperty, value);
        }
		private static void ResizeBehaviorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ResizeBehavior").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ShowsPreviewProperty = DependencyProperty.RegisterAttached( "ShowsPreview", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ShowsPreviewChanged)));
        public static System.Boolean GetShowsPreview(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(ShowsPreviewProperty);
        }
        public static void SetShowsPreview(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(ShowsPreviewProperty, value);
        }
		private static void ShowsPreviewChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ShowsPreview").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty PreviewStyleProperty = DependencyProperty.RegisterAttached( "PreviewStyle", typeof(System.Windows.Style), typeof(d), new PropertyMetadata(new PropertyChangedCallback(PreviewStyleChanged)));
        public static System.Windows.Style GetPreviewStyle(DependencyObject dependencyObject)
        {
            return (System.Windows.Style)dependencyObject.GetValue(PreviewStyleProperty);
        }
        public static void SetPreviewStyle(DependencyObject dependencyObject, System.Windows.Style value)
        {
            dependencyObject.SetValue(PreviewStyleProperty, value);
        }
		private static void PreviewStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("PreviewStyle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty KeyboardIncrementProperty = DependencyProperty.RegisterAttached( "KeyboardIncrement", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(KeyboardIncrementChanged)));
        public static System.Double GetKeyboardIncrement(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(KeyboardIncrementProperty);
        }
        public static void SetKeyboardIncrement(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(KeyboardIncrementProperty, value);
        }
		private static void KeyboardIncrementChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("KeyboardIncrement").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DragIncrementProperty = DependencyProperty.RegisterAttached( "DragIncrement", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DragIncrementChanged)));
        public static System.Double GetDragIncrement(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(DragIncrementProperty);
        }
        public static void SetDragIncrement(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(DragIncrementProperty, value);
        }
		private static void DragIncrementChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DragIncrement").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty StretchDirectionProperty = DependencyProperty.RegisterAttached( "StretchDirection", typeof(System.Windows.Controls.StretchDirection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(StretchDirectionChanged)));
        public static System.Windows.Controls.StretchDirection GetStretchDirection(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.StretchDirection)dependencyObject.GetValue(StretchDirectionProperty);
        }
        public static void SetStretchDirection(DependencyObject dependencyObject, System.Windows.Controls.StretchDirection value)
        {
            dependencyObject.SetValue(StretchDirectionProperty, value);
        }
		private static void StretchDirectionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("StretchDirection").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty StrokesProperty = DependencyProperty.RegisterAttached( "Strokes", typeof(System.Windows.Ink.StrokeCollection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(StrokesChanged)));
        public static System.Windows.Ink.StrokeCollection GetStrokes(DependencyObject dependencyObject)
        {
            return (System.Windows.Ink.StrokeCollection)dependencyObject.GetValue(StrokesProperty);
        }
        public static void SetStrokes(DependencyObject dependencyObject, System.Windows.Ink.StrokeCollection value)
        {
            dependencyObject.SetValue(StrokesProperty, value);
        }
		private static void StrokesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Strokes").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsGestureRecognizerAvailableProperty = DependencyProperty.RegisterAttached( "IsGestureRecognizerAvailable", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsGestureRecognizerAvailableChanged)));
        public static System.Boolean GetIsGestureRecognizerAvailable(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsGestureRecognizerAvailableProperty);
        }
        public static void SetIsGestureRecognizerAvailable(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsGestureRecognizerAvailableProperty, value);
        }
		private static void IsGestureRecognizerAvailableChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsGestureRecognizerAvailable").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DefaultDrawingAttributesProperty = DependencyProperty.RegisterAttached( "DefaultDrawingAttributes", typeof(System.Windows.Ink.DrawingAttributes), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DefaultDrawingAttributesChanged)));
        public static System.Windows.Ink.DrawingAttributes GetDefaultDrawingAttributes(DependencyObject dependencyObject)
        {
            return (System.Windows.Ink.DrawingAttributes)dependencyObject.GetValue(DefaultDrawingAttributesProperty);
        }
        public static void SetDefaultDrawingAttributes(DependencyObject dependencyObject, System.Windows.Ink.DrawingAttributes value)
        {
            dependencyObject.SetValue(DefaultDrawingAttributesProperty, value);
        }
		private static void DefaultDrawingAttributesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DefaultDrawingAttributes").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty EraserShapeProperty = DependencyProperty.RegisterAttached( "EraserShape", typeof(System.Windows.Ink.StylusShape), typeof(d), new PropertyMetadata(new PropertyChangedCallback(EraserShapeChanged)));
        public static System.Windows.Ink.StylusShape GetEraserShape(DependencyObject dependencyObject)
        {
            return (System.Windows.Ink.StylusShape)dependencyObject.GetValue(EraserShapeProperty);
        }
        public static void SetEraserShape(DependencyObject dependencyObject, System.Windows.Ink.StylusShape value)
        {
            dependencyObject.SetValue(EraserShapeProperty, value);
        }
		private static void EraserShapeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("EraserShape").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ActiveEditingModeProperty = DependencyProperty.RegisterAttached( "ActiveEditingMode", typeof(System.Windows.Controls.InkCanvasEditingMode), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ActiveEditingModeChanged)));
        public static System.Windows.Controls.InkCanvasEditingMode GetActiveEditingMode(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.InkCanvasEditingMode)dependencyObject.GetValue(ActiveEditingModeProperty);
        }
        public static void SetActiveEditingMode(DependencyObject dependencyObject, System.Windows.Controls.InkCanvasEditingMode value)
        {
            dependencyObject.SetValue(ActiveEditingModeProperty, value);
        }
		private static void ActiveEditingModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ActiveEditingMode").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty EditingModeProperty = DependencyProperty.RegisterAttached( "EditingMode", typeof(System.Windows.Controls.InkCanvasEditingMode), typeof(d), new PropertyMetadata(new PropertyChangedCallback(EditingModeChanged)));
        public static System.Windows.Controls.InkCanvasEditingMode GetEditingMode(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.InkCanvasEditingMode)dependencyObject.GetValue(EditingModeProperty);
        }
        public static void SetEditingMode(DependencyObject dependencyObject, System.Windows.Controls.InkCanvasEditingMode value)
        {
            dependencyObject.SetValue(EditingModeProperty, value);
        }
		private static void EditingModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("EditingMode").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty EditingModeInvertedProperty = DependencyProperty.RegisterAttached( "EditingModeInverted", typeof(System.Windows.Controls.InkCanvasEditingMode), typeof(d), new PropertyMetadata(new PropertyChangedCallback(EditingModeInvertedChanged)));
        public static System.Windows.Controls.InkCanvasEditingMode GetEditingModeInverted(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.InkCanvasEditingMode)dependencyObject.GetValue(EditingModeInvertedProperty);
        }
        public static void SetEditingModeInverted(DependencyObject dependencyObject, System.Windows.Controls.InkCanvasEditingMode value)
        {
            dependencyObject.SetValue(EditingModeInvertedProperty, value);
        }
		private static void EditingModeInvertedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("EditingModeInverted").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty UseCustomCursorProperty = DependencyProperty.RegisterAttached( "UseCustomCursor", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(UseCustomCursorChanged)));
        public static System.Boolean GetUseCustomCursor(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(UseCustomCursorProperty);
        }
        public static void SetUseCustomCursor(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(UseCustomCursorProperty, value);
        }
		private static void UseCustomCursorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("UseCustomCursor").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty MoveEnabledProperty = DependencyProperty.RegisterAttached( "MoveEnabled", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(MoveEnabledChanged)));
        public static System.Boolean GetMoveEnabled(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(MoveEnabledProperty);
        }
        public static void SetMoveEnabled(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(MoveEnabledProperty, value);
        }
		private static void MoveEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("MoveEnabled").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ResizeEnabledProperty = DependencyProperty.RegisterAttached( "ResizeEnabled", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ResizeEnabledChanged)));
        public static System.Boolean GetResizeEnabled(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(ResizeEnabledProperty);
        }
        public static void SetResizeEnabled(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(ResizeEnabledProperty, value);
        }
		private static void ResizeEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ResizeEnabled").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DefaultStylusPointDescriptionProperty = DependencyProperty.RegisterAttached( "DefaultStylusPointDescription", typeof(System.Windows.Input.StylusPointDescription), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DefaultStylusPointDescriptionChanged)));
        public static System.Windows.Input.StylusPointDescription GetDefaultStylusPointDescription(DependencyObject dependencyObject)
        {
            return (System.Windows.Input.StylusPointDescription)dependencyObject.GetValue(DefaultStylusPointDescriptionProperty);
        }
        public static void SetDefaultStylusPointDescription(DependencyObject dependencyObject, System.Windows.Input.StylusPointDescription value)
        {
            dependencyObject.SetValue(DefaultStylusPointDescriptionProperty, value);
        }
		private static void DefaultStylusPointDescriptionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DefaultStylusPointDescription").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty PreferredPasteFormatsProperty = DependencyProperty.RegisterAttached( "PreferredPasteFormats", typeof(System.Collections.Generic.IEnumerable<System.Windows.Controls.InkCanvasClipboardFormat>), typeof(d), new PropertyMetadata(new PropertyChangedCallback(PreferredPasteFormatsChanged)));
        public static System.Collections.Generic.IEnumerable<System.Windows.Controls.InkCanvasClipboardFormat> GetPreferredPasteFormats(DependencyObject dependencyObject)
        {
            return (System.Collections.Generic.IEnumerable<System.Windows.Controls.InkCanvasClipboardFormat>)dependencyObject.GetValue(PreferredPasteFormatsProperty);
        }
        public static void SetPreferredPasteFormats(DependencyObject dependencyObject, System.Collections.Generic.IEnumerable<System.Windows.Controls.InkCanvasClipboardFormat> value)
        {
            dependencyObject.SetValue(PreferredPasteFormatsProperty, value);
        }
		private static void PreferredPasteFormatsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("PreferredPasteFormats").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TargetProperty = DependencyProperty.RegisterAttached( "Target", typeof(System.Windows.UIElement), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TargetChanged)));
        public static System.Windows.UIElement GetTarget(DependencyObject dependencyObject)
        {
            return (System.Windows.UIElement)dependencyObject.GetValue(TargetProperty);
        }
        public static void SetTarget(DependencyObject dependencyObject, System.Windows.UIElement value)
        {
            dependencyObject.SetValue(TargetProperty, value);
        }
		private static void TargetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Target").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ViewProperty = DependencyProperty.RegisterAttached( "View", typeof(System.Windows.Controls.ViewBase), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ViewChanged)));
        public static System.Windows.Controls.ViewBase GetView(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.ViewBase)dependencyObject.GetValue(ViewProperty);
        }
        public static void SetView(DependencyObject dependencyObject, System.Windows.Controls.ViewBase value)
        {
            dependencyObject.SetValue(ViewProperty, value);
        }
		private static void ViewChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("View").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ClockProperty = DependencyProperty.RegisterAttached( "Clock", typeof(System.Windows.Media.MediaClock), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ClockChanged)));
        public static System.Windows.Media.MediaClock GetClock(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.MediaClock)dependencyObject.GetValue(ClockProperty);
        }
        public static void SetClock(DependencyObject dependencyObject, System.Windows.Media.MediaClock value)
        {
            dependencyObject.SetValue(ClockProperty, value);
        }
		private static void ClockChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Clock").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty VolumeProperty = DependencyProperty.RegisterAttached( "Volume", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(VolumeChanged)));
        public static System.Double GetVolume(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(VolumeProperty);
        }
        public static void SetVolume(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(VolumeProperty, value);
        }
		private static void VolumeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Volume").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty BalanceProperty = DependencyProperty.RegisterAttached( "Balance", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(BalanceChanged)));
        public static System.Double GetBalance(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(BalanceProperty);
        }
        public static void SetBalance(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(BalanceProperty, value);
        }
		private static void BalanceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Balance").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsMutedProperty = DependencyProperty.RegisterAttached( "IsMuted", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsMutedChanged)));
        public static System.Boolean GetIsMuted(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsMutedProperty);
        }
        public static void SetIsMuted(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsMutedProperty, value);
        }
		private static void IsMutedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsMuted").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ScrubbingEnabledProperty = DependencyProperty.RegisterAttached( "ScrubbingEnabled", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ScrubbingEnabledChanged)));
        public static System.Boolean GetScrubbingEnabled(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(ScrubbingEnabledProperty);
        }
        public static void SetScrubbingEnabled(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(ScrubbingEnabledProperty, value);
        }
		private static void ScrubbingEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ScrubbingEnabled").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty UnloadedBehaviorProperty = DependencyProperty.RegisterAttached( "UnloadedBehavior", typeof(System.Windows.Controls.MediaState), typeof(d), new PropertyMetadata(new PropertyChangedCallback(UnloadedBehaviorChanged)));
        public static System.Windows.Controls.MediaState GetUnloadedBehavior(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.MediaState)dependencyObject.GetValue(UnloadedBehaviorProperty);
        }
        public static void SetUnloadedBehavior(DependencyObject dependencyObject, System.Windows.Controls.MediaState value)
        {
            dependencyObject.SetValue(UnloadedBehaviorProperty, value);
        }
		private static void UnloadedBehaviorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("UnloadedBehavior").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty LoadedBehaviorProperty = DependencyProperty.RegisterAttached( "LoadedBehavior", typeof(System.Windows.Controls.MediaState), typeof(d), new PropertyMetadata(new PropertyChangedCallback(LoadedBehaviorChanged)));
        public static System.Windows.Controls.MediaState GetLoadedBehavior(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.MediaState)dependencyObject.GetValue(LoadedBehaviorProperty);
        }
        public static void SetLoadedBehavior(DependencyObject dependencyObject, System.Windows.Controls.MediaState value)
        {
            dependencyObject.SetValue(LoadedBehaviorProperty, value);
        }
		private static void LoadedBehaviorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("LoadedBehavior").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanPauseProperty = DependencyProperty.RegisterAttached( "CanPause", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanPauseChanged)));
        public static System.Boolean GetCanPause(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanPauseProperty);
        }
        public static void SetCanPause(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanPauseProperty, value);
        }
		private static void CanPauseChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanPause").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsBufferingProperty = DependencyProperty.RegisterAttached( "IsBuffering", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsBufferingChanged)));
        public static System.Boolean GetIsBuffering(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsBufferingProperty);
        }
        public static void SetIsBuffering(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsBufferingProperty, value);
        }
		private static void IsBufferingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsBuffering").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DownloadProgressProperty = DependencyProperty.RegisterAttached( "DownloadProgress", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DownloadProgressChanged)));
        public static System.Double GetDownloadProgress(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(DownloadProgressProperty);
        }
        public static void SetDownloadProgress(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(DownloadProgressProperty, value);
        }
		private static void DownloadProgressChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DownloadProgress").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty BufferingProgressProperty = DependencyProperty.RegisterAttached( "BufferingProgress", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(BufferingProgressChanged)));
        public static System.Double GetBufferingProgress(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(BufferingProgressProperty);
        }
        public static void SetBufferingProgress(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(BufferingProgressProperty, value);
        }
		private static void BufferingProgressChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("BufferingProgress").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty NaturalVideoHeightProperty = DependencyProperty.RegisterAttached( "NaturalVideoHeight", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(NaturalVideoHeightChanged)));
        public static System.Int32 GetNaturalVideoHeight(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(NaturalVideoHeightProperty);
        }
        public static void SetNaturalVideoHeight(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(NaturalVideoHeightProperty, value);
        }
		private static void NaturalVideoHeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("NaturalVideoHeight").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty NaturalVideoWidthProperty = DependencyProperty.RegisterAttached( "NaturalVideoWidth", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(NaturalVideoWidthChanged)));
        public static System.Int32 GetNaturalVideoWidth(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(NaturalVideoWidthProperty);
        }
        public static void SetNaturalVideoWidth(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(NaturalVideoWidthProperty, value);
        }
		private static void NaturalVideoWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("NaturalVideoWidth").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty HasAudioProperty = DependencyProperty.RegisterAttached( "HasAudio", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HasAudioChanged)));
        public static System.Boolean GetHasAudio(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(HasAudioProperty);
        }
        public static void SetHasAudio(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(HasAudioProperty, value);
        }
		private static void HasAudioChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("HasAudio").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty HasVideoProperty = DependencyProperty.RegisterAttached( "HasVideo", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HasVideoChanged)));
        public static System.Boolean GetHasVideo(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(HasVideoProperty);
        }
        public static void SetHasVideo(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(HasVideoProperty, value);
        }
		private static void HasVideoChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("HasVideo").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty NaturalDurationProperty = DependencyProperty.RegisterAttached( "NaturalDuration", typeof(System.Windows.Duration), typeof(d), new PropertyMetadata(new PropertyChangedCallback(NaturalDurationChanged)));
        public static System.Windows.Duration GetNaturalDuration(DependencyObject dependencyObject)
        {
            return (System.Windows.Duration)dependencyObject.GetValue(NaturalDurationProperty);
        }
        public static void SetNaturalDuration(DependencyObject dependencyObject, System.Windows.Duration value)
        {
            dependencyObject.SetValue(NaturalDurationProperty, value);
        }
		private static void NaturalDurationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("NaturalDuration").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty PositionProperty = DependencyProperty.RegisterAttached( "Position", typeof(System.TimeSpan), typeof(d), new PropertyMetadata(new PropertyChangedCallback(PositionChanged)));
        public static System.TimeSpan GetPosition(DependencyObject dependencyObject)
        {
            return (System.TimeSpan)dependencyObject.GetValue(PositionProperty);
        }
        public static void SetPosition(DependencyObject dependencyObject, System.TimeSpan value)
        {
            dependencyObject.SetValue(PositionProperty, value);
        }
		private static void PositionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Position").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SpeedRatioProperty = DependencyProperty.RegisterAttached( "SpeedRatio", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SpeedRatioChanged)));
        public static System.Double GetSpeedRatio(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(SpeedRatioProperty);
        }
        public static void SetSpeedRatio(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(SpeedRatioProperty, value);
        }
		private static void SpeedRatioChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SpeedRatio").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsMainMenuProperty = DependencyProperty.RegisterAttached( "IsMainMenu", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsMainMenuChanged)));
        public static System.Boolean GetIsMainMenu(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsMainMenuProperty);
        }
        public static void SetIsMainMenu(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsMainMenuProperty, value);
        }
		private static void IsMainMenuChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsMainMenu").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty WindowTitleProperty = DependencyProperty.RegisterAttached( "WindowTitle", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(WindowTitleChanged)));
        public static System.String GetWindowTitle(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(WindowTitleProperty);
        }
        public static void SetWindowTitle(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(WindowTitleProperty, value);
        }
		private static void WindowTitleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("WindowTitle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty WindowHeightProperty = DependencyProperty.RegisterAttached( "WindowHeight", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(WindowHeightChanged)));
        public static System.Double GetWindowHeight(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(WindowHeightProperty);
        }
        public static void SetWindowHeight(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(WindowHeightProperty, value);
        }
		private static void WindowHeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("WindowHeight").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty WindowWidthProperty = DependencyProperty.RegisterAttached( "WindowWidth", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(WindowWidthChanged)));
        public static System.Double GetWindowWidth(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(WindowWidthProperty);
        }
        public static void SetWindowWidth(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(WindowWidthProperty, value);
        }
		private static void WindowWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("WindowWidth").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty KeepAliveProperty = DependencyProperty.RegisterAttached( "KeepAlive", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(KeepAliveChanged)));
        public static System.Boolean GetKeepAlive(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(KeepAliveProperty);
        }
        public static void SetKeepAlive(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(KeepAliveProperty, value);
        }
		private static void KeepAliveChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("KeepAlive").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty PasswordProperty = DependencyProperty.RegisterAttached( "Password", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(PasswordChanged)));
        public static System.String GetPassword(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(PasswordProperty);
        }
        public static void SetPassword(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(PasswordProperty, value);
        }
		private static void PasswordChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Password").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SecurePasswordProperty = DependencyProperty.RegisterAttached( "SecurePassword", typeof(System.Security.SecureString), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SecurePasswordChanged)));
        public static System.Security.SecureString GetSecurePassword(DependencyObject dependencyObject)
        {
            return (System.Security.SecureString)dependencyObject.GetValue(SecurePasswordProperty);
        }
        public static void SetSecurePassword(DependencyObject dependencyObject, System.Security.SecureString value)
        {
            dependencyObject.SetValue(SecurePasswordProperty, value);
        }
		private static void SecurePasswordChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SecurePassword").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty PasswordCharProperty = DependencyProperty.RegisterAttached( "PasswordChar", typeof(System.Char), typeof(d), new PropertyMetadata(new PropertyChangedCallback(PasswordCharChanged)));
        public static System.Char GetPasswordChar(DependencyObject dependencyObject)
        {
            return (System.Char)dependencyObject.GetValue(PasswordCharProperty);
        }
        public static void SetPasswordChar(DependencyObject dependencyObject, System.Char value)
        {
            dependencyObject.SetValue(PasswordCharProperty, value);
        }
		private static void PasswordCharChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("PasswordChar").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty MaxLengthProperty = DependencyProperty.RegisterAttached( "MaxLength", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(MaxLengthChanged)));
        public static System.Int32 GetMaxLength(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(MaxLengthProperty);
        }
        public static void SetMaxLength(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(MaxLengthProperty, value);
        }
		private static void MaxLengthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("MaxLength").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CaretBrushProperty = DependencyProperty.RegisterAttached( "CaretBrush", typeof(System.Windows.Media.Brush), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CaretBrushChanged)));
        public static System.Windows.Media.Brush GetCaretBrush(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Brush)dependencyObject.GetValue(CaretBrushProperty);
        }
        public static void SetCaretBrush(DependencyObject dependencyObject, System.Windows.Media.Brush value)
        {
            dependencyObject.SetValue(CaretBrushProperty, value);
        }
		private static void CaretBrushChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CaretBrush").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty BulletProperty = DependencyProperty.RegisterAttached( "Bullet", typeof(System.Windows.UIElement), typeof(d), new PropertyMetadata(new PropertyChangedCallback(BulletChanged)));
        public static System.Windows.UIElement GetBullet(DependencyObject dependencyObject)
        {
            return (System.Windows.UIElement)dependencyObject.GetValue(BulletProperty);
        }
        public static void SetBullet(DependencyObject dependencyObject, System.Windows.UIElement value)
        {
            dependencyObject.SetValue(BulletProperty, value);
        }
		private static void BulletChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Bullet").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty HasSelectedDaysProperty = DependencyProperty.RegisterAttached( "HasSelectedDays", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HasSelectedDaysChanged)));
        public static System.Boolean GetHasSelectedDays(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(HasSelectedDaysProperty);
        }
        public static void SetHasSelectedDays(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(HasSelectedDaysProperty, value);
        }
		private static void HasSelectedDaysChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("HasSelectedDays").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsInactiveProperty = DependencyProperty.RegisterAttached( "IsInactive", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsInactiveChanged)));
        public static System.Boolean GetIsInactive(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsInactiveProperty);
        }
        public static void SetIsInactive(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsInactiveProperty, value);
        }
		private static void IsInactiveChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsInactive").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsTodayProperty = DependencyProperty.RegisterAttached( "IsToday", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsTodayChanged)));
        public static System.Boolean GetIsToday(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsTodayProperty);
        }
        public static void SetIsToday(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsTodayProperty, value);
        }
		private static void IsTodayChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsToday").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsBlackedOutProperty = DependencyProperty.RegisterAttached( "IsBlackedOut", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsBlackedOutChanged)));
        public static System.Boolean GetIsBlackedOut(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsBlackedOutProperty);
        }
        public static void SetIsBlackedOut(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsBlackedOutProperty, value);
        }
		private static void IsBlackedOutChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsBlackedOut").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SeparatorBrushProperty = DependencyProperty.RegisterAttached( "SeparatorBrush", typeof(System.Windows.Media.Brush), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SeparatorBrushChanged)));
        public static System.Windows.Media.Brush GetSeparatorBrush(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Brush)dependencyObject.GetValue(SeparatorBrushProperty);
        }
        public static void SetSeparatorBrush(DependencyObject dependencyObject, System.Windows.Media.Brush value)
        {
            dependencyObject.SetValue(SeparatorBrushProperty, value);
        }
		private static void SeparatorBrushChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SeparatorBrush").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SeparatorVisibilityProperty = DependencyProperty.RegisterAttached( "SeparatorVisibility", typeof(System.Windows.Visibility), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SeparatorVisibilityChanged)));
        public static System.Windows.Visibility GetSeparatorVisibility(DependencyObject dependencyObject)
        {
            return (System.Windows.Visibility)dependencyObject.GetValue(SeparatorVisibilityProperty);
        }
        public static void SetSeparatorVisibility(DependencyObject dependencyObject, System.Windows.Visibility value)
        {
            dependencyObject.SetValue(SeparatorVisibilityProperty, value);
        }
		private static void SeparatorVisibilityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SeparatorVisibility").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DisplayIndexProperty = DependencyProperty.RegisterAttached( "DisplayIndex", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DisplayIndexChanged)));
        public static System.Int32 GetDisplayIndex(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(DisplayIndexProperty);
        }
        public static void SetDisplayIndex(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(DisplayIndexProperty, value);
        }
		private static void DisplayIndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DisplayIndex").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanUserSortProperty = DependencyProperty.RegisterAttached( "CanUserSort", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanUserSortChanged)));
        public static System.Boolean GetCanUserSort(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanUserSortProperty);
        }
        public static void SetCanUserSort(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanUserSortProperty, value);
        }
		private static void CanUserSortChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanUserSort").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SortDirectionProperty = DependencyProperty.RegisterAttached( "SortDirection", typeof(System.Nullable<System.ComponentModel.ListSortDirection>), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SortDirectionChanged)));
        public static System.Nullable<System.ComponentModel.ListSortDirection> GetSortDirection(DependencyObject dependencyObject)
        {
            return (System.Nullable<System.ComponentModel.ListSortDirection>)dependencyObject.GetValue(SortDirectionProperty);
        }
        public static void SetSortDirection(DependencyObject dependencyObject, System.Nullable<System.ComponentModel.ListSortDirection> value)
        {
            dependencyObject.SetValue(SortDirectionProperty, value);
        }
		private static void SortDirectionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SortDirection").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsFrozenProperty = DependencyProperty.RegisterAttached( "IsFrozen", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsFrozenChanged)));
        public static System.Boolean GetIsFrozen(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsFrozenProperty);
        }
        public static void SetIsFrozen(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsFrozenProperty, value);
        }
		private static void IsFrozenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsFrozen").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsRowSelectedProperty = DependencyProperty.RegisterAttached( "IsRowSelected", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsRowSelectedChanged)));
        public static System.Boolean GetIsRowSelected(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsRowSelectedProperty);
        }
        public static void SetIsRowSelected(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsRowSelectedProperty, value);
        }
		private static void IsRowSelectedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsRowSelected").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty OrientationProperty = DependencyProperty.RegisterAttached( "Orientation", typeof(System.Windows.Controls.Orientation), typeof(d), new PropertyMetadata(new PropertyChangedCallback(OrientationChanged)));
        public static System.Windows.Controls.Orientation GetOrientation(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.Orientation)dependencyObject.GetValue(OrientationProperty);
        }
        public static void SetOrientation(DependencyObject dependencyObject, System.Windows.Controls.Orientation value)
        {
            dependencyObject.SetValue(OrientationProperty, value);
        }
		private static void OrientationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Orientation").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanHorizontallyScrollProperty = DependencyProperty.RegisterAttached( "CanHorizontallyScroll", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanHorizontallyScrollChanged)));
        public static System.Boolean GetCanHorizontallyScroll(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanHorizontallyScrollProperty);
        }
        public static void SetCanHorizontallyScroll(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanHorizontallyScrollProperty, value);
        }
		private static void CanHorizontallyScrollChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanHorizontallyScroll").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanVerticallyScrollProperty = DependencyProperty.RegisterAttached( "CanVerticallyScroll", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanVerticallyScrollChanged)));
        public static System.Boolean GetCanVerticallyScroll(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanVerticallyScrollProperty);
        }
        public static void SetCanVerticallyScroll(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanVerticallyScrollProperty, value);
        }
		private static void CanVerticallyScrollChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanVerticallyScroll").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ScrollOwnerProperty = DependencyProperty.RegisterAttached( "ScrollOwner", typeof(System.Windows.Controls.ScrollViewer), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ScrollOwnerChanged)));
        public static System.Windows.Controls.ScrollViewer GetScrollOwner(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.ScrollViewer)dependencyObject.GetValue(ScrollOwnerProperty);
        }
        public static void SetScrollOwner(DependencyObject dependencyObject, System.Windows.Controls.ScrollViewer value)
        {
            dependencyObject.SetValue(ScrollOwnerProperty, value);
        }
		private static void ScrollOwnerChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ScrollOwner").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsReadOnlyCaretVisibleProperty = DependencyProperty.RegisterAttached( "IsReadOnlyCaretVisible", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsReadOnlyCaretVisibleChanged)));
        public static System.Boolean GetIsReadOnlyCaretVisible(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsReadOnlyCaretVisibleProperty);
        }
        public static void SetIsReadOnlyCaretVisible(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsReadOnlyCaretVisibleProperty, value);
        }
		private static void IsReadOnlyCaretVisibleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsReadOnlyCaretVisible").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AcceptsReturnProperty = DependencyProperty.RegisterAttached( "AcceptsReturn", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AcceptsReturnChanged)));
        public static System.Boolean GetAcceptsReturn(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(AcceptsReturnProperty);
        }
        public static void SetAcceptsReturn(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(AcceptsReturnProperty, value);
        }
		private static void AcceptsReturnChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AcceptsReturn").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AcceptsTabProperty = DependencyProperty.RegisterAttached( "AcceptsTab", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AcceptsTabChanged)));
        public static System.Boolean GetAcceptsTab(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(AcceptsTabProperty);
        }
        public static void SetAcceptsTab(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(AcceptsTabProperty, value);
        }
		private static void AcceptsTabChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AcceptsTab").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SpellCheckProperty = DependencyProperty.RegisterAttached( "SpellCheck", typeof(System.Windows.Controls.SpellCheck), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SpellCheckChanged)));
        public static System.Windows.Controls.SpellCheck GetSpellCheck(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.SpellCheck)dependencyObject.GetValue(SpellCheckProperty);
        }
        public static void SetSpellCheck(DependencyObject dependencyObject, System.Windows.Controls.SpellCheck value)
        {
            dependencyObject.SetValue(SpellCheckProperty, value);
        }
		private static void SpellCheckChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SpellCheck").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanUndoProperty = DependencyProperty.RegisterAttached( "CanUndo", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanUndoChanged)));
        public static System.Boolean GetCanUndo(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanUndoProperty);
        }
        public static void SetCanUndo(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanUndoProperty, value);
        }
		private static void CanUndoChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanUndo").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanRedoProperty = DependencyProperty.RegisterAttached( "CanRedo", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanRedoChanged)));
        public static System.Boolean GetCanRedo(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanRedoProperty);
        }
        public static void SetCanRedo(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanRedoProperty, value);
        }
		private static void CanRedoChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanRedo").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsUndoEnabledProperty = DependencyProperty.RegisterAttached( "IsUndoEnabled", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsUndoEnabledChanged)));
        public static System.Boolean GetIsUndoEnabled(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsUndoEnabledProperty);
        }
        public static void SetIsUndoEnabled(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsUndoEnabledProperty, value);
        }
		private static void IsUndoEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsUndoEnabled").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty UndoLimitProperty = DependencyProperty.RegisterAttached( "UndoLimit", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(UndoLimitChanged)));
        public static System.Int32 GetUndoLimit(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(UndoLimitProperty);
        }
        public static void SetUndoLimit(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(UndoLimitProperty, value);
        }
		private static void UndoLimitChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("UndoLimit").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AutoWordSelectionProperty = DependencyProperty.RegisterAttached( "AutoWordSelection", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AutoWordSelectionChanged)));
        public static System.Boolean GetAutoWordSelection(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(AutoWordSelectionProperty);
        }
        public static void SetAutoWordSelection(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(AutoWordSelectionProperty, value);
        }
		private static void AutoWordSelectionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AutoWordSelection").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty MinLinesProperty = DependencyProperty.RegisterAttached( "MinLines", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(MinLinesChanged)));
        public static System.Int32 GetMinLines(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(MinLinesProperty);
        }
        public static void SetMinLines(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(MinLinesProperty, value);
        }
		private static void MinLinesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("MinLines").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty MaxLinesProperty = DependencyProperty.RegisterAttached( "MaxLines", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(MaxLinesChanged)));
        public static System.Int32 GetMaxLines(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(MaxLinesProperty);
        }
        public static void SetMaxLines(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(MaxLinesProperty, value);
        }
		private static void MaxLinesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("MaxLines").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CharacterCasingProperty = DependencyProperty.RegisterAttached( "CharacterCasing", typeof(System.Windows.Controls.CharacterCasing), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CharacterCasingChanged)));
        public static System.Windows.Controls.CharacterCasing GetCharacterCasing(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.CharacterCasing)dependencyObject.GetValue(CharacterCasingProperty);
        }
        public static void SetCharacterCasing(DependencyObject dependencyObject, System.Windows.Controls.CharacterCasing value)
        {
            dependencyObject.SetValue(CharacterCasingProperty, value);
        }
		private static void CharacterCasingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CharacterCasing").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectedTextProperty = DependencyProperty.RegisterAttached( "SelectedText", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectedTextChanged)));
        public static System.String GetSelectedText(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(SelectedTextProperty);
        }
        public static void SetSelectedText(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(SelectedTextProperty, value);
        }
		private static void SelectedTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectedText").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectionLengthProperty = DependencyProperty.RegisterAttached( "SelectionLength", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectionLengthChanged)));
        public static System.Int32 GetSelectionLength(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(SelectionLengthProperty);
        }
        public static void SetSelectionLength(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(SelectionLengthProperty, value);
        }
		private static void SelectionLengthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectionLength").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CaretIndexProperty = DependencyProperty.RegisterAttached( "CaretIndex", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CaretIndexChanged)));
        public static System.Int32 GetCaretIndex(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(CaretIndexProperty);
        }
        public static void SetCaretIndex(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(CaretIndexProperty, value);
        }
		private static void CaretIndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CaretIndex").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty LineCountProperty = DependencyProperty.RegisterAttached( "LineCount", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(LineCountChanged)));
        public static System.Int32 GetLineCount(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(LineCountProperty);
        }
        public static void SetLineCount(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(LineCountProperty, value);
        }
		private static void LineCountChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("LineCount").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TypographyProperty = DependencyProperty.RegisterAttached( "Typography", typeof(System.Windows.Documents.Typography), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TypographyChanged)));
        public static System.Windows.Documents.Typography GetTypography(DependencyObject dependencyObject)
        {
            return (System.Windows.Documents.Typography)dependencyObject.GetValue(TypographyProperty);
        }
        public static void SetTypography(DependencyObject dependencyObject, System.Windows.Documents.Typography value)
        {
            dependencyObject.SetValue(TypographyProperty, value);
        }
		private static void TypographyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Typography").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DocumentPaginatorProperty = DependencyProperty.RegisterAttached( "DocumentPaginator", typeof(System.Windows.Documents.DocumentPaginator), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DocumentPaginatorChanged)));
        public static System.Windows.Documents.DocumentPaginator GetDocumentPaginator(DependencyObject dependencyObject)
        {
            return (System.Windows.Documents.DocumentPaginator)dependencyObject.GetValue(DocumentPaginatorProperty);
        }
        public static void SetDocumentPaginator(DependencyObject dependencyObject, System.Windows.Documents.DocumentPaginator value)
        {
            dependencyObject.SetValue(DocumentPaginatorProperty, value);
        }
		private static void DocumentPaginatorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DocumentPaginator").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DocumentPageProperty = DependencyProperty.RegisterAttached( "DocumentPage", typeof(System.Windows.Documents.DocumentPage), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DocumentPageChanged)));
        public static System.Windows.Documents.DocumentPage GetDocumentPage(DependencyObject dependencyObject)
        {
            return (System.Windows.Documents.DocumentPage)dependencyObject.GetValue(DocumentPageProperty);
        }
        public static void SetDocumentPage(DependencyObject dependencyObject, System.Windows.Documents.DocumentPage value)
        {
            dependencyObject.SetValue(DocumentPageProperty, value);
        }
		private static void DocumentPageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DocumentPage").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty PopupAnimationProperty = DependencyProperty.RegisterAttached( "PopupAnimation", typeof(System.Windows.Controls.Primitives.PopupAnimation), typeof(d), new PropertyMetadata(new PropertyChangedCallback(PopupAnimationChanged)));
        public static System.Windows.Controls.Primitives.PopupAnimation GetPopupAnimation(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.Primitives.PopupAnimation)dependencyObject.GetValue(PopupAnimationProperty);
        }
        public static void SetPopupAnimation(DependencyObject dependencyObject, System.Windows.Controls.Primitives.PopupAnimation value)
        {
            dependencyObject.SetValue(PopupAnimationProperty, value);
        }
		private static void PopupAnimationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("PopupAnimation").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty MinimumProperty = DependencyProperty.RegisterAttached( "Minimum", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(MinimumChanged)));
        public static System.Double GetMinimum(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(MinimumProperty);
        }
        public static void SetMinimum(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(MinimumProperty, value);
        }
		private static void MinimumChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Minimum").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty MaximumProperty = DependencyProperty.RegisterAttached( "Maximum", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(MaximumChanged)));
        public static System.Double GetMaximum(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(MaximumProperty);
        }
        public static void SetMaximum(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(MaximumProperty, value);
        }
		private static void MaximumChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Maximum").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ValueProperty = DependencyProperty.RegisterAttached( "Value", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ValueChanged)));
        public static System.Double GetValue(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(ValueProperty);
        }
        public static void SetValue(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(ValueProperty, value);
        }
		private static void ValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Value").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty LargeChangeProperty = DependencyProperty.RegisterAttached( "LargeChange", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(LargeChangeChanged)));
        public static System.Double GetLargeChange(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(LargeChangeProperty);
        }
        public static void SetLargeChange(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(LargeChangeProperty, value);
        }
		private static void LargeChangeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("LargeChange").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SmallChangeProperty = DependencyProperty.RegisterAttached( "SmallChange", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SmallChangeChanged)));
        public static System.Double GetSmallChange(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(SmallChangeProperty);
        }
        public static void SetSmallChange(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(SmallChangeProperty, value);
        }
		private static void SmallChangeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SmallChange").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DelayProperty = DependencyProperty.RegisterAttached( "Delay", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DelayChanged)));
        public static System.Int32 GetDelay(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(DelayProperty);
        }
        public static void SetDelay(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(DelayProperty, value);
        }
		private static void DelayChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Delay").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IntervalProperty = DependencyProperty.RegisterAttached( "Interval", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IntervalChanged)));
        public static System.Int32 GetInterval(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(IntervalProperty);
        }
        public static void SetInterval(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(IntervalProperty, value);
        }
		private static void IntervalChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Interval").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ViewportSizeProperty = DependencyProperty.RegisterAttached( "ViewportSize", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ViewportSizeChanged)));
        public static System.Double GetViewportSize(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(ViewportSizeProperty);
        }
        public static void SetViewportSize(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(ViewportSizeProperty, value);
        }
		private static void ViewportSizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ViewportSize").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TrackProperty = DependencyProperty.RegisterAttached( "Track", typeof(System.Windows.Controls.Primitives.Track), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TrackChanged)));
        public static System.Windows.Controls.Primitives.Track GetTrack(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.Primitives.Track)dependencyObject.GetValue(TrackProperty);
        }
        public static void SetTrack(DependencyObject dependencyObject, System.Windows.Controls.Primitives.Track value)
        {
            dependencyObject.SetValue(TrackProperty, value);
        }
		private static void TrackChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Track").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AdornerLayerProperty = DependencyProperty.RegisterAttached( "AdornerLayer", typeof(System.Windows.Documents.AdornerLayer), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AdornerLayerChanged)));
        public static System.Windows.Documents.AdornerLayer GetAdornerLayer(DependencyObject dependencyObject)
        {
            return (System.Windows.Documents.AdornerLayer)dependencyObject.GetValue(AdornerLayerProperty);
        }
        public static void SetAdornerLayer(DependencyObject dependencyObject, System.Windows.Documents.AdornerLayer value)
        {
            dependencyObject.SetValue(AdornerLayerProperty, value);
        }
		private static void AdornerLayerChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AdornerLayer").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanContentScrollProperty = DependencyProperty.RegisterAttached( "CanContentScroll", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanContentScrollChanged)));
        public static System.Boolean GetCanContentScroll(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanContentScrollProperty);
        }
        public static void SetCanContentScroll(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanContentScrollProperty, value);
        }
		private static void CanContentScrollChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanContentScroll").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectionEndProperty = DependencyProperty.RegisterAttached( "SelectionEnd", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectionEndChanged)));
        public static System.Double GetSelectionEnd(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(SelectionEndProperty);
        }
        public static void SetSelectionEnd(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(SelectionEndProperty, value);
        }
		private static void SelectionEndChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectionEnd").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsSelectionRangeEnabledProperty = DependencyProperty.RegisterAttached( "IsSelectionRangeEnabled", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsSelectionRangeEnabledChanged)));
        public static System.Boolean GetIsSelectionRangeEnabled(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsSelectionRangeEnabledProperty);
        }
        public static void SetIsSelectionRangeEnabled(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsSelectionRangeEnabledProperty, value);
        }
		private static void IsSelectionRangeEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsSelectionRangeEnabled").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TickFrequencyProperty = DependencyProperty.RegisterAttached( "TickFrequency", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TickFrequencyChanged)));
        public static System.Double GetTickFrequency(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(TickFrequencyProperty);
        }
        public static void SetTickFrequency(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(TickFrequencyProperty, value);
        }
		private static void TickFrequencyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("TickFrequency").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TicksProperty = DependencyProperty.RegisterAttached( "Ticks", typeof(System.Windows.Media.DoubleCollection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TicksChanged)));
        public static System.Windows.Media.DoubleCollection GetTicks(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.DoubleCollection)dependencyObject.GetValue(TicksProperty);
        }
        public static void SetTicks(DependencyObject dependencyObject, System.Windows.Media.DoubleCollection value)
        {
            dependencyObject.SetValue(TicksProperty, value);
        }
		private static void TicksChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Ticks").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsDirectionReversedProperty = DependencyProperty.RegisterAttached( "IsDirectionReversed", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsDirectionReversedChanged)));
        public static System.Boolean GetIsDirectionReversed(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsDirectionReversedProperty);
        }
        public static void SetIsDirectionReversed(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsDirectionReversedProperty, value);
        }
		private static void IsDirectionReversedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsDirectionReversed").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ReservedSpaceProperty = DependencyProperty.RegisterAttached( "ReservedSpace", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ReservedSpaceChanged)));
        public static System.Double GetReservedSpace(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(ReservedSpaceProperty);
        }
        public static void SetReservedSpace(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(ReservedSpaceProperty, value);
        }
		private static void ReservedSpaceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ReservedSpace").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty WrapWidthProperty = DependencyProperty.RegisterAttached( "WrapWidth", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(WrapWidthChanged)));
        public static System.Double GetWrapWidth(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(WrapWidthProperty);
        }
        public static void SetWrapWidth(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(WrapWidthProperty, value);
        }
		private static void WrapWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("WrapWidth").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DecreaseRepeatButtonProperty = DependencyProperty.RegisterAttached( "DecreaseRepeatButton", typeof(System.Windows.Controls.Primitives.RepeatButton), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DecreaseRepeatButtonChanged)));
        public static System.Windows.Controls.Primitives.RepeatButton GetDecreaseRepeatButton(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.Primitives.RepeatButton)dependencyObject.GetValue(DecreaseRepeatButtonProperty);
        }
        public static void SetDecreaseRepeatButton(DependencyObject dependencyObject, System.Windows.Controls.Primitives.RepeatButton value)
        {
            dependencyObject.SetValue(DecreaseRepeatButtonProperty, value);
        }
		private static void DecreaseRepeatButtonChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DecreaseRepeatButton").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ThumbProperty = DependencyProperty.RegisterAttached( "Thumb", typeof(System.Windows.Controls.Primitives.Thumb), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ThumbChanged)));
        public static System.Windows.Controls.Primitives.Thumb GetThumb(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.Primitives.Thumb)dependencyObject.GetValue(ThumbProperty);
        }
        public static void SetThumb(DependencyObject dependencyObject, System.Windows.Controls.Primitives.Thumb value)
        {
            dependencyObject.SetValue(ThumbProperty, value);
        }
		private static void ThumbChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Thumb").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IncreaseRepeatButtonProperty = DependencyProperty.RegisterAttached( "IncreaseRepeatButton", typeof(System.Windows.Controls.Primitives.RepeatButton), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IncreaseRepeatButtonChanged)));
        public static System.Windows.Controls.Primitives.RepeatButton GetIncreaseRepeatButton(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.Primitives.RepeatButton)dependencyObject.GetValue(IncreaseRepeatButtonProperty);
        }
        public static void SetIncreaseRepeatButton(DependencyObject dependencyObject, System.Windows.Controls.Primitives.RepeatButton value)
        {
            dependencyObject.SetValue(IncreaseRepeatButtonProperty, value);
        }
		private static void IncreaseRepeatButtonChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IncreaseRepeatButton").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty FirstColumnProperty = DependencyProperty.RegisterAttached( "FirstColumn", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(FirstColumnChanged)));
        public static System.Int32 GetFirstColumn(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(FirstColumnProperty);
        }
        public static void SetFirstColumn(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(FirstColumnProperty, value);
        }
		private static void FirstColumnChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("FirstColumn").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RowsProperty = DependencyProperty.RegisterAttached( "Rows", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RowsChanged)));
        public static System.Int32 GetRows(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(RowsProperty);
        }
        public static void SetRows(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(RowsProperty, value);
        }
		private static void RowsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Rows").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsIndeterminateProperty = DependencyProperty.RegisterAttached( "IsIndeterminate", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsIndeterminateChanged)));
        public static System.Boolean GetIsIndeterminate(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsIndeterminateProperty);
        }
        public static void SetIsIndeterminate(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsIndeterminateProperty, value);
        }
		private static void IsIndeterminateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsIndeterminate").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty GroupNameProperty = DependencyProperty.RegisterAttached( "GroupName", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(GroupNameChanged)));
        public static System.String GetGroupName(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(GroupNameProperty);
        }
        public static void SetGroupName(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(GroupNameProperty, value);
        }
		private static void GroupNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("GroupName").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsDocumentEnabledProperty = DependencyProperty.RegisterAttached( "IsDocumentEnabled", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsDocumentEnabledChanged)));
        public static System.Boolean GetIsDocumentEnabled(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsDocumentEnabledProperty);
        }
        public static void SetIsDocumentEnabled(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsDocumentEnabledProperty, value);
        }
		private static void IsDocumentEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsDocumentEnabled").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CaretPositionProperty = DependencyProperty.RegisterAttached( "CaretPosition", typeof(System.Windows.Documents.TextPointer), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CaretPositionChanged)));
        public static System.Windows.Documents.TextPointer GetCaretPosition(DependencyObject dependencyObject)
        {
            return (System.Windows.Documents.TextPointer)dependencyObject.GetValue(CaretPositionProperty);
        }
        public static void SetCaretPosition(DependencyObject dependencyObject, System.Windows.Documents.TextPointer value)
        {
            dependencyObject.SetValue(CaretPositionProperty, value);
        }
		private static void CaretPositionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CaretPosition").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ComputedHorizontalScrollBarVisibilityProperty = DependencyProperty.RegisterAttached( "ComputedHorizontalScrollBarVisibility", typeof(System.Windows.Visibility), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ComputedHorizontalScrollBarVisibilityChanged)));
        public static System.Windows.Visibility GetComputedHorizontalScrollBarVisibility(DependencyObject dependencyObject)
        {
            return (System.Windows.Visibility)dependencyObject.GetValue(ComputedHorizontalScrollBarVisibilityProperty);
        }
        public static void SetComputedHorizontalScrollBarVisibility(DependencyObject dependencyObject, System.Windows.Visibility value)
        {
            dependencyObject.SetValue(ComputedHorizontalScrollBarVisibilityProperty, value);
        }
		private static void ComputedHorizontalScrollBarVisibilityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ComputedHorizontalScrollBarVisibility").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ComputedVerticalScrollBarVisibilityProperty = DependencyProperty.RegisterAttached( "ComputedVerticalScrollBarVisibility", typeof(System.Windows.Visibility), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ComputedVerticalScrollBarVisibilityChanged)));
        public static System.Windows.Visibility GetComputedVerticalScrollBarVisibility(DependencyObject dependencyObject)
        {
            return (System.Windows.Visibility)dependencyObject.GetValue(ComputedVerticalScrollBarVisibilityProperty);
        }
        public static void SetComputedVerticalScrollBarVisibility(DependencyObject dependencyObject, System.Windows.Visibility value)
        {
            dependencyObject.SetValue(ComputedVerticalScrollBarVisibilityProperty, value);
        }
		private static void ComputedVerticalScrollBarVisibilityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ComputedVerticalScrollBarVisibility").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ScrollableWidthProperty = DependencyProperty.RegisterAttached( "ScrollableWidth", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ScrollableWidthChanged)));
        public static System.Double GetScrollableWidth(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(ScrollableWidthProperty);
        }
        public static void SetScrollableWidth(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(ScrollableWidthProperty, value);
        }
		private static void ScrollableWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ScrollableWidth").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ScrollableHeightProperty = DependencyProperty.RegisterAttached( "ScrollableHeight", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ScrollableHeightChanged)));
        public static System.Double GetScrollableHeight(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(ScrollableHeightProperty);
        }
        public static void SetScrollableHeight(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(ScrollableHeightProperty, value);
        }
		private static void ScrollableHeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ScrollableHeight").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ContentVerticalOffsetProperty = DependencyProperty.RegisterAttached( "ContentVerticalOffset", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ContentVerticalOffsetChanged)));
        public static System.Double GetContentVerticalOffset(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(ContentVerticalOffsetProperty);
        }
        public static void SetContentVerticalOffset(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(ContentVerticalOffsetProperty, value);
        }
		private static void ContentVerticalOffsetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ContentVerticalOffset").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ContentHorizontalOffsetProperty = DependencyProperty.RegisterAttached( "ContentHorizontalOffset", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ContentHorizontalOffsetChanged)));
        public static System.Double GetContentHorizontalOffset(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(ContentHorizontalOffsetProperty);
        }
        public static void SetContentHorizontalOffset(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(ContentHorizontalOffsetProperty, value);
        }
		private static void ContentHorizontalOffsetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ContentHorizontalOffset").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsDeferredScrollingEnabledProperty = DependencyProperty.RegisterAttached( "IsDeferredScrollingEnabled", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsDeferredScrollingEnabledChanged)));
        public static System.Boolean GetIsDeferredScrollingEnabled(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsDeferredScrollingEnabledProperty);
        }
        public static void SetIsDeferredScrollingEnabled(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsDeferredScrollingEnabledProperty, value);
        }
		private static void IsDeferredScrollingEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsDeferredScrollingEnabled").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty PanningModeProperty = DependencyProperty.RegisterAttached( "PanningMode", typeof(System.Windows.Controls.PanningMode), typeof(d), new PropertyMetadata(new PropertyChangedCallback(PanningModeChanged)));
        public static System.Windows.Controls.PanningMode GetPanningMode(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.PanningMode)dependencyObject.GetValue(PanningModeProperty);
        }
        public static void SetPanningMode(DependencyObject dependencyObject, System.Windows.Controls.PanningMode value)
        {
            dependencyObject.SetValue(PanningModeProperty, value);
        }
		private static void PanningModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("PanningMode").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty PanningDecelerationProperty = DependencyProperty.RegisterAttached( "PanningDeceleration", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(PanningDecelerationChanged)));
        public static System.Double GetPanningDeceleration(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(PanningDecelerationProperty);
        }
        public static void SetPanningDeceleration(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(PanningDecelerationProperty, value);
        }
		private static void PanningDecelerationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("PanningDeceleration").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty PanningRatioProperty = DependencyProperty.RegisterAttached( "PanningRatio", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(PanningRatioChanged)));
        public static System.Double GetPanningRatio(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(PanningRatioProperty);
        }
        public static void SetPanningRatio(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(PanningRatioProperty, value);
        }
		private static void PanningRatioChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("PanningRatio").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AutoToolTipPlacementProperty = DependencyProperty.RegisterAttached( "AutoToolTipPlacement", typeof(System.Windows.Controls.Primitives.AutoToolTipPlacement), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AutoToolTipPlacementChanged)));
        public static System.Windows.Controls.Primitives.AutoToolTipPlacement GetAutoToolTipPlacement(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.Primitives.AutoToolTipPlacement)dependencyObject.GetValue(AutoToolTipPlacementProperty);
        }
        public static void SetAutoToolTipPlacement(DependencyObject dependencyObject, System.Windows.Controls.Primitives.AutoToolTipPlacement value)
        {
            dependencyObject.SetValue(AutoToolTipPlacementProperty, value);
        }
		private static void AutoToolTipPlacementChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AutoToolTipPlacement").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AutoToolTipPrecisionProperty = DependencyProperty.RegisterAttached( "AutoToolTipPrecision", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AutoToolTipPrecisionChanged)));
        public static System.Int32 GetAutoToolTipPrecision(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(AutoToolTipPrecisionProperty);
        }
        public static void SetAutoToolTipPrecision(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(AutoToolTipPrecisionProperty, value);
        }
		private static void AutoToolTipPrecisionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AutoToolTipPrecision").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsSnapToTickEnabledProperty = DependencyProperty.RegisterAttached( "IsSnapToTickEnabled", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsSnapToTickEnabledChanged)));
        public static System.Boolean GetIsSnapToTickEnabled(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsSnapToTickEnabledProperty);
        }
        public static void SetIsSnapToTickEnabled(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsSnapToTickEnabledProperty, value);
        }
		private static void IsSnapToTickEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsSnapToTickEnabled").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TickPlacementProperty = DependencyProperty.RegisterAttached( "TickPlacement", typeof(System.Windows.Controls.Primitives.TickPlacement), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TickPlacementChanged)));
        public static System.Windows.Controls.Primitives.TickPlacement GetTickPlacement(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.Primitives.TickPlacement)dependencyObject.GetValue(TickPlacementProperty);
        }
        public static void SetTickPlacement(DependencyObject dependencyObject, System.Windows.Controls.Primitives.TickPlacement value)
        {
            dependencyObject.SetValue(TickPlacementProperty, value);
        }
		private static void TickPlacementChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("TickPlacement").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsMoveToPointEnabledProperty = DependencyProperty.RegisterAttached( "IsMoveToPointEnabled", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsMoveToPointEnabledChanged)));
        public static System.Boolean GetIsMoveToPointEnabled(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsMoveToPointEnabledProperty);
        }
        public static void SetIsMoveToPointEnabled(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsMoveToPointEnabledProperty, value);
        }
		private static void IsMoveToPointEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsMoveToPointEnabled").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TabStripPlacementProperty = DependencyProperty.RegisterAttached( "TabStripPlacement", typeof(System.Windows.Controls.Dock), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TabStripPlacementChanged)));
        public static System.Windows.Controls.Dock GetTabStripPlacement(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.Dock)dependencyObject.GetValue(TabStripPlacementProperty);
        }
        public static void SetTabStripPlacement(DependencyObject dependencyObject, System.Windows.Controls.Dock value)
        {
            dependencyObject.SetValue(TabStripPlacementProperty, value);
        }
		private static void TabStripPlacementChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("TabStripPlacement").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectedContentProperty = DependencyProperty.RegisterAttached( "SelectedContent", typeof(System.Object), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectedContentChanged)));
        public static System.Object GetSelectedContent(DependencyObject dependencyObject)
        {
            return (System.Object)dependencyObject.GetValue(SelectedContentProperty);
        }
        public static void SetSelectedContent(DependencyObject dependencyObject, System.Object value)
        {
            dependencyObject.SetValue(SelectedContentProperty, value);
        }
		private static void SelectedContentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectedContent").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectedContentTemplateProperty = DependencyProperty.RegisterAttached( "SelectedContentTemplate", typeof(System.Windows.DataTemplate), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectedContentTemplateChanged)));
        public static System.Windows.DataTemplate GetSelectedContentTemplate(DependencyObject dependencyObject)
        {
            return (System.Windows.DataTemplate)dependencyObject.GetValue(SelectedContentTemplateProperty);
        }
        public static void SetSelectedContentTemplate(DependencyObject dependencyObject, System.Windows.DataTemplate value)
        {
            dependencyObject.SetValue(SelectedContentTemplateProperty, value);
        }
		private static void SelectedContentTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectedContentTemplate").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectedContentTemplateSelectorProperty = DependencyProperty.RegisterAttached( "SelectedContentTemplateSelector", typeof(System.Windows.Controls.DataTemplateSelector), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectedContentTemplateSelectorChanged)));
        public static System.Windows.Controls.DataTemplateSelector GetSelectedContentTemplateSelector(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.DataTemplateSelector)dependencyObject.GetValue(SelectedContentTemplateSelectorProperty);
        }
        public static void SetSelectedContentTemplateSelector(DependencyObject dependencyObject, System.Windows.Controls.DataTemplateSelector value)
        {
            dependencyObject.SetValue(SelectedContentTemplateSelectorProperty, value);
        }
		private static void SelectedContentTemplateSelectorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectedContentTemplateSelector").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectedContentStringFormatProperty = DependencyProperty.RegisterAttached( "SelectedContentStringFormat", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectedContentStringFormatChanged)));
        public static System.String GetSelectedContentStringFormat(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(SelectedContentStringFormatProperty);
        }
        public static void SetSelectedContentStringFormat(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(SelectedContentStringFormatProperty, value);
        }
		private static void SelectedContentStringFormatChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectedContentStringFormat").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty InlinesProperty = DependencyProperty.RegisterAttached( "Inlines", typeof(System.Windows.Documents.InlineCollection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(InlinesChanged)));
        public static System.Windows.Documents.InlineCollection GetInlines(DependencyObject dependencyObject)
        {
            return (System.Windows.Documents.InlineCollection)dependencyObject.GetValue(InlinesProperty);
        }
        public static void SetInlines(DependencyObject dependencyObject, System.Windows.Documents.InlineCollection value)
        {
            dependencyObject.SetValue(InlinesProperty, value);
        }
		private static void InlinesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Inlines").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ContentStartProperty = DependencyProperty.RegisterAttached( "ContentStart", typeof(System.Windows.Documents.TextPointer), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ContentStartChanged)));
        public static System.Windows.Documents.TextPointer GetContentStart(DependencyObject dependencyObject)
        {
            return (System.Windows.Documents.TextPointer)dependencyObject.GetValue(ContentStartProperty);
        }
        public static void SetContentStart(DependencyObject dependencyObject, System.Windows.Documents.TextPointer value)
        {
            dependencyObject.SetValue(ContentStartProperty, value);
        }
		private static void ContentStartChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ContentStart").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ContentEndProperty = DependencyProperty.RegisterAttached( "ContentEnd", typeof(System.Windows.Documents.TextPointer), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ContentEndChanged)));
        public static System.Windows.Documents.TextPointer GetContentEnd(DependencyObject dependencyObject)
        {
            return (System.Windows.Documents.TextPointer)dependencyObject.GetValue(ContentEndProperty);
        }
        public static void SetContentEnd(DependencyObject dependencyObject, System.Windows.Documents.TextPointer value)
        {
            dependencyObject.SetValue(ContentEndProperty, value);
        }
		private static void ContentEndChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ContentEnd").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty BreakBeforeProperty = DependencyProperty.RegisterAttached( "BreakBefore", typeof(System.Windows.LineBreakCondition), typeof(d), new PropertyMetadata(new PropertyChangedCallback(BreakBeforeChanged)));
        public static System.Windows.LineBreakCondition GetBreakBefore(DependencyObject dependencyObject)
        {
            return (System.Windows.LineBreakCondition)dependencyObject.GetValue(BreakBeforeProperty);
        }
        public static void SetBreakBefore(DependencyObject dependencyObject, System.Windows.LineBreakCondition value)
        {
            dependencyObject.SetValue(BreakBeforeProperty, value);
        }
		private static void BreakBeforeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("BreakBefore").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty BreakAfterProperty = DependencyProperty.RegisterAttached( "BreakAfter", typeof(System.Windows.LineBreakCondition), typeof(d), new PropertyMetadata(new PropertyChangedCallback(BreakAfterChanged)));
        public static System.Windows.LineBreakCondition GetBreakAfter(DependencyObject dependencyObject)
        {
            return (System.Windows.LineBreakCondition)dependencyObject.GetValue(BreakAfterProperty);
        }
        public static void SetBreakAfter(DependencyObject dependencyObject, System.Windows.LineBreakCondition value)
        {
            dependencyObject.SetValue(BreakAfterProperty, value);
        }
		private static void BreakAfterChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("BreakAfter").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsHyphenationEnabledProperty = DependencyProperty.RegisterAttached( "IsHyphenationEnabled", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsHyphenationEnabledChanged)));
        public static System.Boolean GetIsHyphenationEnabled(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsHyphenationEnabledProperty);
        }
        public static void SetIsHyphenationEnabled(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsHyphenationEnabledProperty, value);
        }
		private static void IsHyphenationEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsHyphenationEnabled").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty BandProperty = DependencyProperty.RegisterAttached( "Band", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(BandChanged)));
        public static System.Int32 GetBand(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(BandProperty);
        }
        public static void SetBand(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(BandProperty, value);
        }
		private static void BandChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Band").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty BandIndexProperty = DependencyProperty.RegisterAttached( "BandIndex", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(BandIndexChanged)));
        public static System.Int32 GetBandIndex(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(BandIndexProperty);
        }
        public static void SetBandIndex(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(BandIndexProperty, value);
        }
		private static void BandIndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("BandIndex").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsOverflowOpenProperty = DependencyProperty.RegisterAttached( "IsOverflowOpen", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsOverflowOpenChanged)));
        public static System.Boolean GetIsOverflowOpen(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsOverflowOpenProperty);
        }
        public static void SetIsOverflowOpen(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsOverflowOpenProperty, value);
        }
		private static void IsOverflowOpenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsOverflowOpen").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty HasOverflowItemsProperty = DependencyProperty.RegisterAttached( "HasOverflowItems", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HasOverflowItemsChanged)));
        public static System.Boolean GetHasOverflowItems(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(HasOverflowItemsProperty);
        }
        public static void SetHasOverflowItems(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(HasOverflowItemsProperty, value);
        }
		private static void HasOverflowItemsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("HasOverflowItems").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsLockedProperty = DependencyProperty.RegisterAttached( "IsLocked", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsLockedChanged)));
        public static System.Boolean GetIsLocked(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsLockedProperty);
        }
        public static void SetIsLocked(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsLockedProperty, value);
        }
		private static void IsLockedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsLocked").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ToolBarsProperty = DependencyProperty.RegisterAttached( "ToolBars", typeof(System.Collections.ObjectModel.Collection<System.Windows.Controls.ToolBar>), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ToolBarsChanged)));
        public static System.Collections.ObjectModel.Collection<System.Windows.Controls.ToolBar> GetToolBars(DependencyObject dependencyObject)
        {
            return (System.Collections.ObjectModel.Collection<System.Windows.Controls.ToolBar>)dependencyObject.GetValue(ToolBarsProperty);
        }
        public static void SetToolBars(DependencyObject dependencyObject, System.Collections.ObjectModel.Collection<System.Windows.Controls.ToolBar> value)
        {
            dependencyObject.SetValue(ToolBarsProperty, value);
        }
		private static void ToolBarsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ToolBars").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CameraProperty = DependencyProperty.RegisterAttached( "Camera", typeof(System.Windows.Media.Media3D.Camera), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CameraChanged)));
        public static System.Windows.Media.Media3D.Camera GetCamera(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Media3D.Camera)dependencyObject.GetValue(CameraProperty);
        }
        public static void SetCamera(DependencyObject dependencyObject, System.Windows.Media.Media3D.Camera value)
        {
            dependencyObject.SetValue(CameraProperty, value);
        }
		private static void CameraChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Camera").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty HandleProperty = DependencyProperty.RegisterAttached( "Handle", typeof(System.IntPtr), typeof(d), new PropertyMetadata(new PropertyChangedCallback(HandleChanged)));
        public static System.IntPtr GetHandle(DependencyObject dependencyObject)
        {
            return (System.IntPtr)dependencyObject.GetValue(HandleProperty);
        }
        public static void SetHandle(DependencyObject dependencyObject, System.IntPtr value)
        {
            dependencyObject.SetValue(HandleProperty, value);
        }
		private static void HandleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Handle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ObjectForScriptingProperty = DependencyProperty.RegisterAttached( "ObjectForScripting", typeof(System.Object), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ObjectForScriptingChanged)));
        public static System.Object GetObjectForScripting(DependencyObject dependencyObject)
        {
            return (System.Object)dependencyObject.GetValue(ObjectForScriptingProperty);
        }
        public static void SetObjectForScripting(DependencyObject dependencyObject, System.Object value)
        {
            dependencyObject.SetValue(ObjectForScriptingProperty, value);
        }
		private static void ObjectForScriptingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ObjectForScripting").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ItemWidthProperty = DependencyProperty.RegisterAttached( "ItemWidth", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ItemWidthChanged)));
        public static System.Double GetItemWidth(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(ItemWidthProperty);
        }
        public static void SetItemWidth(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(ItemWidthProperty, value);
        }
		private static void ItemWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ItemWidth").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ItemHeightProperty = DependencyProperty.RegisterAttached( "ItemHeight", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ItemHeightChanged)));
        public static System.Double GetItemHeight(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(ItemHeightProperty);
        }
        public static void SetItemHeight(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(ItemHeightProperty, value);
        }
		private static void ItemHeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ItemHeight").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty PrintTicketProperty = DependencyProperty.RegisterAttached( "PrintTicket", typeof(System.Object), typeof(d), new PropertyMetadata(new PropertyChangedCallback(PrintTicketChanged)));
        public static System.Object GetPrintTicket(DependencyObject dependencyObject)
        {
            return (System.Object)dependencyObject.GetValue(PrintTicketProperty);
        }
        public static void SetPrintTicket(DependencyObject dependencyObject, System.Object value)
        {
            dependencyObject.SetValue(PrintTicketProperty, value);
        }
		private static void PrintTicketChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("PrintTicket").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ContentBoxProperty = DependencyProperty.RegisterAttached( "ContentBox", typeof(System.Windows.Rect), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ContentBoxChanged)));
        public static System.Windows.Rect GetContentBox(DependencyObject dependencyObject)
        {
            return (System.Windows.Rect)dependencyObject.GetValue(ContentBoxProperty);
        }
        public static void SetContentBox(DependencyObject dependencyObject, System.Windows.Rect value)
        {
            dependencyObject.SetValue(ContentBoxProperty, value);
        }
		private static void ContentBoxChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ContentBox").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty BleedBoxProperty = DependencyProperty.RegisterAttached( "BleedBox", typeof(System.Windows.Rect), typeof(d), new PropertyMetadata(new PropertyChangedCallback(BleedBoxChanged)));
        public static System.Windows.Rect GetBleedBox(DependencyObject dependencyObject)
        {
            return (System.Windows.Rect)dependencyObject.GetValue(BleedBoxProperty);
        }
        public static void SetBleedBox(DependencyObject dependencyObject, System.Windows.Rect value)
        {
            dependencyObject.SetValue(BleedBoxProperty, value);
        }
		private static void BleedBoxChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("BleedBox").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IndicesProperty = DependencyProperty.RegisterAttached( "Indices", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IndicesChanged)));
        public static System.String GetIndices(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(IndicesProperty);
        }
        public static void SetIndices(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(IndicesProperty, value);
        }
		private static void IndicesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Indices").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty UnicodeStringProperty = DependencyProperty.RegisterAttached( "UnicodeString", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(UnicodeStringChanged)));
        public static System.String GetUnicodeString(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(UnicodeStringProperty);
        }
        public static void SetUnicodeString(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(UnicodeStringProperty, value);
        }
		private static void UnicodeStringChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("UnicodeString").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CaretStopsProperty = DependencyProperty.RegisterAttached( "CaretStops", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CaretStopsChanged)));
        public static System.String GetCaretStops(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(CaretStopsProperty);
        }
        public static void SetCaretStops(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(CaretStopsProperty, value);
        }
		private static void CaretStopsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CaretStops").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty FontRenderingEmSizeProperty = DependencyProperty.RegisterAttached( "FontRenderingEmSize", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(FontRenderingEmSizeChanged)));
        public static System.Double GetFontRenderingEmSize(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(FontRenderingEmSizeProperty);
        }
        public static void SetFontRenderingEmSize(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(FontRenderingEmSizeProperty, value);
        }
		private static void FontRenderingEmSizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("FontRenderingEmSize").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty OriginXProperty = DependencyProperty.RegisterAttached( "OriginX", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(OriginXChanged)));
        public static System.Double GetOriginX(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(OriginXProperty);
        }
        public static void SetOriginX(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(OriginXProperty, value);
        }
		private static void OriginXChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("OriginX").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty OriginYProperty = DependencyProperty.RegisterAttached( "OriginY", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(OriginYChanged)));
        public static System.Double GetOriginY(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(OriginYProperty);
        }
        public static void SetOriginY(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(OriginYProperty, value);
        }
		private static void OriginYChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("OriginY").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty FontUriProperty = DependencyProperty.RegisterAttached( "FontUri", typeof(System.Uri), typeof(d), new PropertyMetadata(new PropertyChangedCallback(FontUriChanged)));
        public static System.Uri GetFontUri(DependencyObject dependencyObject)
        {
            return (System.Uri)dependencyObject.GetValue(FontUriProperty);
        }
        public static void SetFontUri(DependencyObject dependencyObject, System.Uri value)
        {
            dependencyObject.SetValue(FontUriProperty, value);
        }
		private static void FontUriChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("FontUri").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty StyleSimulationsProperty = DependencyProperty.RegisterAttached( "StyleSimulations", typeof(System.Windows.Media.StyleSimulations), typeof(d), new PropertyMetadata(new PropertyChangedCallback(StyleSimulationsChanged)));
        public static System.Windows.Media.StyleSimulations GetStyleSimulations(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.StyleSimulations)dependencyObject.GetValue(StyleSimulationsProperty);
        }
        public static void SetStyleSimulations(DependencyObject dependencyObject, System.Windows.Media.StyleSimulations value)
        {
            dependencyObject.SetValue(StyleSimulationsProperty, value);
        }
		private static void StyleSimulationsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("StyleSimulations").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsSidewaysProperty = DependencyProperty.RegisterAttached( "IsSideways", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsSidewaysChanged)));
        public static System.Boolean GetIsSideways(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsSidewaysProperty);
        }
        public static void SetIsSideways(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsSidewaysProperty, value);
        }
		private static void IsSidewaysChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsSideways").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty BidiLevelProperty = DependencyProperty.RegisterAttached( "BidiLevel", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(BidiLevelChanged)));
        public static System.Int32 GetBidiLevel(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(BidiLevelProperty);
        }
        public static void SetBidiLevel(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(BidiLevelProperty, value);
        }
		private static void BidiLevelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("BidiLevel").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DeviceFontNameProperty = DependencyProperty.RegisterAttached( "DeviceFontName", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DeviceFontNameChanged)));
        public static System.String GetDeviceFontName(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(DeviceFontNameProperty);
        }
        public static void SetDeviceFontName(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(DeviceFontNameProperty, value);
        }
		private static void DeviceFontNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DeviceFontName").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty LinkTargetsProperty = DependencyProperty.RegisterAttached( "LinkTargets", typeof(System.Windows.Documents.LinkTargetCollection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(LinkTargetsChanged)));
        public static System.Windows.Documents.LinkTargetCollection GetLinkTargets(DependencyObject dependencyObject)
        {
            return (System.Windows.Documents.LinkTargetCollection)dependencyObject.GetValue(LinkTargetsProperty);
        }
        public static void SetLinkTargets(DependencyObject dependencyObject, System.Windows.Documents.LinkTargetCollection value)
        {
            dependencyObject.SetValue(LinkTargetsProperty, value);
        }
		private static void LinkTargetsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("LinkTargets").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RemoveFromJournalProperty = DependencyProperty.RegisterAttached( "RemoveFromJournal", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RemoveFromJournalChanged)));
        public static System.Boolean GetRemoveFromJournal(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(RemoveFromJournalProperty);
        }
        public static void SetRemoveFromJournal(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(RemoveFromJournalProperty, value);
        }
		private static void RemoveFromJournalChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RemoveFromJournal").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty X1Property = DependencyProperty.RegisterAttached( "X1", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(X1Changed)));
        public static System.Double GetX1(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(X1Property);
        }
        public static void SetX1(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(X1Property, value);
        }
		private static void X1Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("X1").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty Y1Property = DependencyProperty.RegisterAttached( "Y1", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(Y1Changed)));
        public static System.Double GetY1(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(Y1Property);
        }
        public static void SetY1(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(Y1Property, value);
        }
		private static void Y1Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Y1").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty X2Property = DependencyProperty.RegisterAttached( "X2", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(X2Changed)));
        public static System.Double GetX2(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(X2Property);
        }
        public static void SetX2(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(X2Property, value);
        }
		private static void X2Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("X2").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty Y2Property = DependencyProperty.RegisterAttached( "Y2", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(Y2Changed)));
        public static System.Double GetY2(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(Y2Property);
        }
        public static void SetY2(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(Y2Property, value);
        }
		private static void Y2Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Y2").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DataProperty = DependencyProperty.RegisterAttached( "Data", typeof(System.Windows.Media.Geometry), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DataChanged)));
        public static System.Windows.Media.Geometry GetData(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Geometry)dependencyObject.GetValue(DataProperty);
        }
        public static void SetData(DependencyObject dependencyObject, System.Windows.Media.Geometry value)
        {
            dependencyObject.SetValue(DataProperty, value);
        }
		private static void DataChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Data").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty PointsProperty = DependencyProperty.RegisterAttached( "Points", typeof(System.Windows.Media.PointCollection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(PointsChanged)));
        public static System.Windows.Media.PointCollection GetPoints(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.PointCollection)dependencyObject.GetValue(PointsProperty);
        }
        public static void SetPoints(DependencyObject dependencyObject, System.Windows.Media.PointCollection value)
        {
            dependencyObject.SetValue(PointsProperty, value);
        }
		private static void PointsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Points").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty FillRuleProperty = DependencyProperty.RegisterAttached( "FillRule", typeof(System.Windows.Media.FillRule), typeof(d), new PropertyMetadata(new PropertyChangedCallback(FillRuleChanged)));
        public static System.Windows.Media.FillRule GetFillRule(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.FillRule)dependencyObject.GetValue(FillRuleProperty);
        }
        public static void SetFillRule(DependencyObject dependencyObject, System.Windows.Media.FillRule value)
        {
            dependencyObject.SetValue(FillRuleProperty, value);
        }
		private static void FillRuleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("FillRule").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RadiusXProperty = DependencyProperty.RegisterAttached( "RadiusX", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RadiusXChanged)));
        public static System.Double GetRadiusX(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(RadiusXProperty);
        }
        public static void SetRadiusX(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(RadiusXProperty, value);
        }
		private static void RadiusXChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RadiusX").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RadiusYProperty = DependencyProperty.RegisterAttached( "RadiusY", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RadiusYChanged)));
        public static System.Double GetRadiusY(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(RadiusYProperty);
        }
        public static void SetRadiusY(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(RadiusYProperty, value);
        }
		private static void RadiusYChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RadiusY").SetValue(d, e.NewValue, null);
        }

	}
}

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
                    inDesignMode = DesignerProperties.IsInDesignTool;
                }

                return inDesignMode.GetValueOrDefault(false);
            }
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
		
		public static DependencyProperty ProjectionProperty = DependencyProperty.RegisterAttached( "Projection", typeof(System.Windows.Media.Projection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ProjectionChanged)));
        public static System.Windows.Media.Projection GetProjection(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Projection)dependencyObject.GetValue(ProjectionProperty);
        }
        public static void SetProjection(DependencyObject dependencyObject, System.Windows.Media.Projection value)
        {
            dependencyObject.SetValue(ProjectionProperty, value);
        }
		private static void ProjectionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Projection").SetValue(d, e.NewValue, null);
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
		
		public static DependencyProperty FontSourceProperty = DependencyProperty.RegisterAttached( "FontSource", typeof(System.Windows.Documents.FontSource), typeof(d), new PropertyMetadata(new PropertyChangedCallback(FontSourceChanged)));
        public static System.Windows.Documents.FontSource GetFontSource(DependencyObject dependencyObject)
        {
            return (System.Windows.Documents.FontSource)dependencyObject.GetValue(FontSourceProperty);
        }
        public static void SetFontSource(DependencyObject dependencyObject, System.Windows.Documents.FontSource value)
        {
            dependencyObject.SetValue(FontSourceProperty, value);
        }
		private static void FontSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("FontSource").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty ChildrenProperty = DependencyProperty.RegisterAttached( "Children", typeof(System.Windows.Controls.UIElementCollection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ChildrenChanged)));
        public static System.Windows.Controls.UIElementCollection GetChildren(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.UIElementCollection)dependencyObject.GetValue(ChildrenProperty);
        }
        public static void SetChildren(DependencyObject dependencyObject, System.Windows.Controls.UIElementCollection value)
        {
            dependencyObject.SetValue(ChildrenProperty, value);
        }
		private static void ChildrenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Children").SetValue(d, e.NewValue, null);
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
		
		public static DependencyProperty AutoPlayProperty = DependencyProperty.RegisterAttached( "AutoPlay", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AutoPlayChanged)));
        public static System.Boolean GetAutoPlay(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(AutoPlayProperty);
        }
        public static void SetAutoPlay(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(AutoPlayProperty, value);
        }
		private static void AutoPlayChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AutoPlay").SetValue(d, e.NewValue, null);
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
		
		public static DependencyProperty DownloadProgressOffsetProperty = DependencyProperty.RegisterAttached( "DownloadProgressOffset", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DownloadProgressOffsetChanged)));
        public static System.Double GetDownloadProgressOffset(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(DownloadProgressOffsetProperty);
        }
        public static void SetDownloadProgressOffset(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(DownloadProgressOffsetProperty, value);
        }
		private static void DownloadProgressOffsetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DownloadProgressOffset").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CurrentStateProperty = DependencyProperty.RegisterAttached( "CurrentState", typeof(System.Windows.Media.MediaElementState), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CurrentStateChanged)));
        public static System.Windows.Media.MediaElementState GetCurrentState(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.MediaElementState)dependencyObject.GetValue(CurrentStateProperty);
        }
        public static void SetCurrentState(DependencyObject dependencyObject, System.Windows.Media.MediaElementState value)
        {
            dependencyObject.SetValue(CurrentStateProperty, value);
        }
		private static void CurrentStateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CurrentState").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty BufferingTimeProperty = DependencyProperty.RegisterAttached( "BufferingTime", typeof(System.TimeSpan), typeof(d), new PropertyMetadata(new PropertyChangedCallback(BufferingTimeChanged)));
        public static System.TimeSpan GetBufferingTime(DependencyObject dependencyObject)
        {
            return (System.TimeSpan)dependencyObject.GetValue(BufferingTimeProperty);
        }
        public static void SetBufferingTime(DependencyObject dependencyObject, System.TimeSpan value)
        {
            dependencyObject.SetValue(BufferingTimeProperty, value);
        }
		private static void BufferingTimeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("BufferingTime").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty MarkersProperty = DependencyProperty.RegisterAttached( "Markers", typeof(System.Windows.Media.TimelineMarkerCollection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(MarkersChanged)));
        public static System.Windows.Media.TimelineMarkerCollection GetMarkers(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.TimelineMarkerCollection)dependencyObject.GetValue(MarkersProperty);
        }
        public static void SetMarkers(DependencyObject dependencyObject, System.Windows.Media.TimelineMarkerCollection value)
        {
            dependencyObject.SetValue(MarkersProperty, value);
        }
		private static void MarkersChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Markers").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty CanSeekProperty = DependencyProperty.RegisterAttached( "CanSeek", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(CanSeekChanged)));
        public static System.Boolean GetCanSeek(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(CanSeekProperty);
        }
        public static void SetCanSeek(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(CanSeekProperty, value);
        }
		private static void CanSeekChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("CanSeek").SetValue(d, e.NewValue, null);
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
		
		public static DependencyProperty AudioStreamCountProperty = DependencyProperty.RegisterAttached( "AudioStreamCount", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AudioStreamCountChanged)));
        public static System.Int32 GetAudioStreamCount(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(AudioStreamCountProperty);
        }
        public static void SetAudioStreamCount(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(AudioStreamCountProperty, value);
        }
		private static void AudioStreamCountChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AudioStreamCount").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AudioStreamIndexProperty = DependencyProperty.RegisterAttached( "AudioStreamIndex", typeof(System.Nullable<System.Int32>), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AudioStreamIndexChanged)));
        public static System.Nullable<System.Int32> GetAudioStreamIndex(DependencyObject dependencyObject)
        {
            return (System.Nullable<System.Int32>)dependencyObject.GetValue(AudioStreamIndexProperty);
        }
        public static void SetAudioStreamIndex(DependencyObject dependencyObject, System.Nullable<System.Int32> value)
        {
            dependencyObject.SetValue(AudioStreamIndexProperty, value);
        }
		private static void AudioStreamIndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AudioStreamIndex").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty RenderedFramesPerSecondProperty = DependencyProperty.RegisterAttached( "RenderedFramesPerSecond", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(RenderedFramesPerSecondChanged)));
        public static System.Double GetRenderedFramesPerSecond(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(RenderedFramesPerSecondProperty);
        }
        public static void SetRenderedFramesPerSecond(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(RenderedFramesPerSecondProperty, value);
        }
		private static void RenderedFramesPerSecondChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("RenderedFramesPerSecond").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty DroppedFramesPerSecondProperty = DependencyProperty.RegisterAttached( "DroppedFramesPerSecond", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(DroppedFramesPerSecondChanged)));
        public static System.Double GetDroppedFramesPerSecond(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(DroppedFramesPerSecondProperty);
        }
        public static void SetDroppedFramesPerSecond(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(DroppedFramesPerSecondProperty, value);
        }
		private static void DroppedFramesPerSecondChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("DroppedFramesPerSecond").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AttributesProperty = DependencyProperty.RegisterAttached( "Attributes", typeof(System.Collections.Generic.Dictionary<System.String,System.String>), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AttributesChanged)));
        public static System.Collections.Generic.Dictionary<System.String,System.String> GetAttributes(DependencyObject dependencyObject)
        {
            return (System.Collections.Generic.Dictionary<System.String,System.String>)dependencyObject.GetValue(AttributesProperty);
        }
        public static void SetAttributes(DependencyObject dependencyObject, System.Collections.Generic.Dictionary<System.String,System.String> value)
        {
            dependencyObject.SetValue(AttributesProperty, value);
        }
		private static void AttributesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Attributes").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty LicenseAcquirerProperty = DependencyProperty.RegisterAttached( "LicenseAcquirer", typeof(System.Windows.Media.LicenseAcquirer), typeof(d), new PropertyMetadata(new PropertyChangedCallback(LicenseAcquirerChanged)));
        public static System.Windows.Media.LicenseAcquirer GetLicenseAcquirer(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.LicenseAcquirer)dependencyObject.GetValue(LicenseAcquirerProperty);
        }
        public static void SetLicenseAcquirer(DependencyObject dependencyObject, System.Windows.Media.LicenseAcquirer value)
        {
            dependencyObject.SetValue(LicenseAcquirerProperty, value);
        }
		private static void LicenseAcquirerChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("LicenseAcquirer").SetValue(d, e.NewValue, null);
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
		
		public static DependencyProperty ViewportOriginProperty = DependencyProperty.RegisterAttached( "ViewportOrigin", typeof(System.Windows.Point), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ViewportOriginChanged)));
        public static System.Windows.Point GetViewportOrigin(DependencyObject dependencyObject)
        {
            return (System.Windows.Point)dependencyObject.GetValue(ViewportOriginProperty);
        }
        public static void SetViewportOrigin(DependencyObject dependencyObject, System.Windows.Point value)
        {
            dependencyObject.SetValue(ViewportOriginProperty, value);
        }
		private static void ViewportOriginChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("ViewportOrigin").SetValue(d, e.NewValue, null);
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
		
		public static DependencyProperty SkipLevelsProperty = DependencyProperty.RegisterAttached( "SkipLevels", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SkipLevelsChanged)));
        public static System.Int32 GetSkipLevels(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(SkipLevelsProperty);
        }
        public static void SetSkipLevels(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(SkipLevelsProperty, value);
        }
		private static void SkipLevelsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SkipLevels").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AspectRatioProperty = DependencyProperty.RegisterAttached( "AspectRatio", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AspectRatioChanged)));
        public static System.Double GetAspectRatio(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(AspectRatioProperty);
        }
        public static void SetAspectRatio(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(AspectRatioProperty, value);
        }
		private static void AspectRatioChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AspectRatio").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty UseSpringsProperty = DependencyProperty.RegisterAttached( "UseSprings", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(UseSpringsChanged)));
        public static System.Boolean GetUseSprings(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(UseSpringsProperty);
        }
        public static void SetUseSprings(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(UseSpringsProperty, value);
        }
		private static void UseSpringsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("UseSprings").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsDownloadingProperty = DependencyProperty.RegisterAttached( "IsDownloading", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsDownloadingChanged)));
        public static System.Boolean GetIsDownloading(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsDownloadingProperty);
        }
        public static void SetIsDownloading(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsDownloadingProperty, value);
        }
		private static void IsDownloadingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsDownloading").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty AllowDownloadingProperty = DependencyProperty.RegisterAttached( "AllowDownloading", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(AllowDownloadingChanged)));
        public static System.Boolean GetAllowDownloading(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(AllowDownloadingProperty);
        }
        public static void SetAllowDownloading(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(AllowDownloadingProperty, value);
        }
		private static void AllowDownloadingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("AllowDownloading").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty BlurFactorProperty = DependencyProperty.RegisterAttached( "BlurFactor", typeof(System.Double), typeof(d), new PropertyMetadata(new PropertyChangedCallback(BlurFactorChanged)));
        public static System.Double GetBlurFactor(DependencyObject dependencyObject)
        {
            return (System.Double)dependencyObject.GetValue(BlurFactorProperty);
        }
        public static void SetBlurFactor(DependencyObject dependencyObject, System.Double value)
        {
            dependencyObject.SetValue(BlurFactorProperty, value);
        }
		private static void BlurFactorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("BlurFactor").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty IsIdleProperty = DependencyProperty.RegisterAttached( "IsIdle", typeof(System.Boolean), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsIdleChanged)));
        public static System.Boolean GetIsIdle(DependencyObject dependencyObject)
        {
            return (System.Boolean)dependencyObject.GetValue(IsIdleProperty);
        }
        public static void SetIsIdle(DependencyObject dependencyObject, System.Boolean value)
        {
            dependencyObject.SetValue(IsIdleProperty, value);
        }
		private static void IsIdleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsIdle").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SubImagesProperty = DependencyProperty.RegisterAttached( "SubImages", typeof(System.Collections.ObjectModel.ReadOnlyCollection<System.Windows.Controls.MultiScaleSubImage>), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SubImagesChanged)));
        public static System.Collections.ObjectModel.ReadOnlyCollection<System.Windows.Controls.MultiScaleSubImage> GetSubImages(DependencyObject dependencyObject)
        {
            return (System.Collections.ObjectModel.ReadOnlyCollection<System.Windows.Controls.MultiScaleSubImage>)dependencyObject.GetValue(SubImagesProperty);
        }
        public static void SetSubImages(DependencyObject dependencyObject, System.Collections.ObjectModel.ReadOnlyCollection<System.Windows.Controls.MultiScaleSubImage> value)
        {
            dependencyObject.SetValue(SubImagesProperty, value);
        }
		private static void SubImagesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SubImages").SetValue(d, e.NewValue, null);
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
		
		public static DependencyProperty TabNavigationProperty = DependencyProperty.RegisterAttached( "TabNavigation", typeof(System.Windows.Input.KeyboardNavigationMode), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TabNavigationChanged)));
        public static System.Windows.Input.KeyboardNavigationMode GetTabNavigation(DependencyObject dependencyObject)
        {
            return (System.Windows.Input.KeyboardNavigationMode)dependencyObject.GetValue(TabNavigationProperty);
        }
        public static void SetTabNavigation(DependencyObject dependencyObject, System.Windows.Input.KeyboardNavigationMode value)
        {
            dependencyObject.SetValue(TabNavigationProperty, value);
        }
		private static void TabNavigationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("TabNavigation").SetValue(d, e.NewValue, null);
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
		
		public static DependencyProperty SelectionBackgroundProperty = DependencyProperty.RegisterAttached( "SelectionBackground", typeof(System.Windows.Media.Brush), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectionBackgroundChanged)));
        public static System.Windows.Media.Brush GetSelectionBackground(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Brush)dependencyObject.GetValue(SelectionBackgroundProperty);
        }
        public static void SetSelectionBackground(DependencyObject dependencyObject, System.Windows.Media.Brush value)
        {
            dependencyObject.SetValue(SelectionBackgroundProperty, value);
        }
		private static void SelectionBackgroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectionBackground").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectionForegroundProperty = DependencyProperty.RegisterAttached( "SelectionForeground", typeof(System.Windows.Media.Brush), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectionForegroundChanged)));
        public static System.Windows.Media.Brush GetSelectionForeground(DependencyObject dependencyObject)
        {
            return (System.Windows.Media.Brush)dependencyObject.GetValue(SelectionForegroundProperty);
        }
        public static void SetSelectionForeground(DependencyObject dependencyObject, System.Windows.Media.Brush value)
        {
            dependencyObject.SetValue(SelectionForegroundProperty, value);
        }
		private static void SelectionForegroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectionForeground").SetValue(d, e.NewValue, null);
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
		
		public static DependencyProperty WatermarkProperty = DependencyProperty.RegisterAttached( "Watermark", typeof(System.Object), typeof(d), new PropertyMetadata(new PropertyChangedCallback(WatermarkChanged)));
        public static System.Object GetWatermark(DependencyObject dependencyObject)
        {
            return (System.Object)dependencyObject.GetValue(WatermarkProperty);
        }
        public static void SetWatermark(DependencyObject dependencyObject, System.Object value)
        {
            dependencyObject.SetValue(WatermarkProperty, value);
        }
		private static void WatermarkChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Watermark").SetValue(d, e.NewValue, null);
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
		
		public static DependencyProperty SelectionStartProperty = DependencyProperty.RegisterAttached( "SelectionStart", typeof(System.Int32), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectionStartChanged)));
        public static System.Int32 GetSelectionStart(DependencyObject dependencyObject)
        {
            return (System.Int32)dependencyObject.GetValue(SelectionStartProperty);
        }
        public static void SetSelectionStart(DependencyObject dependencyObject, System.Int32 value)
        {
            dependencyObject.SetValue(SelectionStartProperty, value);
        }
		private static void SelectionStartChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectionStart").SetValue(d, e.NewValue, null);
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
		
		public static DependencyProperty BlocksProperty = DependencyProperty.RegisterAttached( "Blocks", typeof(System.Windows.Documents.BlockCollection), typeof(d), new PropertyMetadata(new PropertyChangedCallback(BlocksChanged)));
        public static System.Windows.Documents.BlockCollection GetBlocks(DependencyObject dependencyObject)
        {
            return (System.Windows.Documents.BlockCollection)dependencyObject.GetValue(BlocksProperty);
        }
        public static void SetBlocks(DependencyObject dependencyObject, System.Windows.Documents.BlockCollection value)
        {
            dependencyObject.SetValue(BlocksProperty, value);
        }
		private static void BlocksChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Blocks").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty XamlProperty = DependencyProperty.RegisterAttached( "Xaml", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(XamlChanged)));
        public static System.String GetXaml(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(XamlProperty);
        }
        public static void SetXaml(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(XamlProperty, value);
        }
		private static void XamlChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Xaml").SetValue(d, e.NewValue, null);
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
		
		public static DependencyProperty ChildProperty = DependencyProperty.RegisterAttached( "Child", typeof(System.Windows.UIElement), typeof(d), new PropertyMetadata(new PropertyChangedCallback(ChildChanged)));
        public static System.Windows.UIElement GetChild(DependencyObject dependencyObject)
        {
            return (System.Windows.UIElement)dependencyObject.GetValue(ChildProperty);
        }
        public static void SetChild(DependencyObject dependencyObject, System.Windows.UIElement value)
        {
            dependencyObject.SetValue(ChildProperty, value);
        }
		private static void ChildChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Child").SetValue(d, e.NewValue, null);
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
		
		public static DependencyProperty IsCheckedProperty = DependencyProperty.RegisterAttached( "IsChecked", typeof(System.Nullable<System.Boolean>), typeof(d), new PropertyMetadata(new PropertyChangedCallback(IsCheckedChanged)));
        public static System.Nullable<System.Boolean> GetIsChecked(DependencyObject dependencyObject)
        {
            return (System.Nullable<System.Boolean>)dependencyObject.GetValue(IsCheckedProperty);
        }
        public static void SetIsChecked(DependencyObject dependencyObject, System.Nullable<System.Boolean> value)
        {
            dependencyObject.SetValue(IsCheckedProperty, value);
        }
		private static void IsCheckedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("IsChecked").SetValue(d, e.NewValue, null);
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
		
		public static DependencyProperty NavigateUriProperty = DependencyProperty.RegisterAttached( "NavigateUri", typeof(System.Uri), typeof(d), new PropertyMetadata(new PropertyChangedCallback(NavigateUriChanged)));
        public static System.Uri GetNavigateUri(DependencyObject dependencyObject)
        {
            return (System.Uri)dependencyObject.GetValue(NavigateUriProperty);
        }
        public static void SetNavigateUri(DependencyObject dependencyObject, System.Uri value)
        {
            dependencyObject.SetValue(NavigateUriProperty, value);
        }
		private static void NavigateUriChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("NavigateUri").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty TargetNameProperty = DependencyProperty.RegisterAttached( "TargetName", typeof(System.String), typeof(d), new PropertyMetadata(new PropertyChangedCallback(TargetNameChanged)));
        public static System.String GetTargetName(DependencyObject dependencyObject)
        {
            return (System.String)dependencyObject.GetValue(TargetNameProperty);
        }
        public static void SetTargetName(DependencyObject dependencyObject, System.String value)
        {
            dependencyObject.SetValue(TargetNameProperty, value);
        }
		private static void TargetNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("TargetName").SetValue(d, e.NewValue, null);
        }
		
		public static DependencyProperty SelectionModeProperty = DependencyProperty.RegisterAttached( "SelectionMode", typeof(System.Windows.Controls.SelectionMode), typeof(d), new PropertyMetadata(new PropertyChangedCallback(SelectionModeChanged)));
        public static System.Windows.Controls.SelectionMode GetSelectionMode(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.SelectionMode)dependencyObject.GetValue(SelectionModeProperty);
        }
        public static void SetSelectionMode(DependencyObject dependencyObject, System.Windows.Controls.SelectionMode value)
        {
            dependencyObject.SetValue(SelectionModeProperty, value);
        }
		private static void SelectionModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("SelectionMode").SetValue(d, e.NewValue, null);
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
		
		public static DependencyProperty PlacementProperty = DependencyProperty.RegisterAttached( "Placement", typeof(System.Windows.Controls.Primitives.PlacementMode), typeof(d), new PropertyMetadata(new PropertyChangedCallback(PlacementChanged)));
        public static System.Windows.Controls.Primitives.PlacementMode GetPlacement(DependencyObject dependencyObject)
        {
            return (System.Windows.Controls.Primitives.PlacementMode)dependencyObject.GetValue(PlacementProperty);
        }
        public static void SetPlacement(DependencyObject dependencyObject, System.Windows.Controls.Primitives.PlacementMode value)
        {
            dependencyObject.SetValue(PlacementProperty, value);
        }
		private static void PlacementChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!InDesignMode)
                return;

            d.GetType().GetProperty("Placement").SetValue(d, e.NewValue, null);
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
	}
}

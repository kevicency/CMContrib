using System;

namespace Caliburn.Micro.Contrib
{
    [Flags]
    public enum MessageSyntaxes
    {
        /// <summary>
        ///   Diablea all extra syntax
        /// </summary>
        None = 0x00,
        /// <summary>
        ///   Allows you to pass a binding as a parameter, i.e. {Binding Foo, Element=Bar}
        /// </summary>
        XamlBinding = 0x01,
        /// <summary>
        ///   Allows you to pass a property of a special value as a parameter, i.e. $eventArgs.Foo
        /// </summary>
        SpecialValueProperty = 0x02
    }
}
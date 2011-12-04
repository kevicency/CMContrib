using Caliburn.Micro;
using Caliburn.Micro.Contrib;
using Machine.Specifications;
using Moq;
using It = Machine.Specifications.It;

namespace CMContrib.Spec
{
    [Subject(typeof (SingleResultEnumerator))]
    [SetupForEachSpecification]
    public class SingleResultEnumerator_Spec
    {
        Establish that = () =>
        {
            var mock = new Mock<IResult>();
            mock.Setup(x => x.Execute(Moq.It.IsAny<ActionExecutionContext>()))
                .Raises(result => result.Completed += null);

            Result = mock.Object;
            Sut = new SingleResultEnumerator(Result);
        };

        protected static IResult Result;
        protected static SingleResultEnumerator Sut;
    }

    public class when_created : SingleResultEnumerator_Spec
    {
        It can_move_next = () => Sut.MoveNext().ShouldBeTrue();
        It has_no_current_item = () => Sut.Current.ShouldBeNull();
    }

    public class when_moved_next_once : SingleResultEnumerator_Spec
    {
        Because of = () => Sut.MoveNext();

        It cannot_move_next = () => Sut.MoveNext().ShouldBeFalse();
        It has_result_as_current_item = () => Sut.Current.ShouldEqual(Result);
    }

    public class when_resetted_after_moved_next_once : SingleResultEnumerator_Spec
    {
        Because of = () =>
        {
            Sut.MoveNext();
            Sut.Reset();
        };

        It can_move_next = () => Sut.MoveNext().ShouldBeTrue();
        It has_no_current_item = () => Sut.Current.ShouldBeNull();
    }
}
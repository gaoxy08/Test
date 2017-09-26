using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenter;

namespace NUnit.Tests
{
    [TestFixture]
    public class EventRelatedTests
    {
        [Test]
        public void ctor_WhenViewIsLoaded_CallsViewRender()
        {
            var mockView = Substitute.For<IView>();

            Presenter.Presenter p = new Presenter.Presenter(mockView);
            mockView.Loaded += Raise.Event<Action>();

            mockView.Received().Render(Arg.Is<string>(s => s.Contains("Hello World")));
        }
    }

}

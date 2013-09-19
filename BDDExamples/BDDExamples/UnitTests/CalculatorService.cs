using BDDExamples.Interfaces;
using BDDExamples.Services;
using NBehave.Spec.NUnit;
using NUnit.Framework;

namespace BDDExamples.UnitTests
{
    public class when_working_with_the_calculator_service : SpecBase
    {
        protected ICalculatorService _CalculatorService;

        protected override void Establish_context()
        {
            _CalculatorService = new CalculatorService();
        }

        protected override void Cleanup()
        {
            base.Cleanup();
            _CalculatorService = null;
        }
    }

    public class and_adding_10_and_14_together : when_working_with_the_calculator_service
    {
        private int _resultShouldBe = 24;
        private int _actualResult = 0;

        protected override void Because_of()
        {
            _actualResult = _CalculatorService.Add(10, 14);
        }

        [Test]
        public void then_result_should_be_14()
        {
            _actualResult.ShouldEqual(_resultShouldBe);
        }
    }

    public class and_subtracting_23_from_89 : when_working_with_the_calculator_service
    {
        private int _resultShouldBe = 66;
        private int _actualResult = 0;

        protected override void Because_of()
        {
            _actualResult = _CalculatorService.Subtract(23, 89);
        }

        [Test]
        public void then_result_should_be_66()
        {
            _actualResult.ShouldEqual(_resultShouldBe);
        }
    }

    public class and_multiplying_23_by_89 : when_working_with_the_calculator_service
    {
        private int _resultShouldBe = 5005;
        private int _actualResult = 0;

        protected override void Because_of()
        {
            _actualResult = _CalculatorService.Multiply(23, 89);
        }

        [Test]
        public void then_result_should_be_5005()
        {
            _actualResult.ShouldEqual(_resultShouldBe);
        }
    }
}

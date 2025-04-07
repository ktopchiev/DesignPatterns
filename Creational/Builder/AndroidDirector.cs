using Creational.Builder.Contracts;

namespace Creational.Builder
{
    public class AndroidDirector
    {
        private readonly IBuilder _builder;

        public AndroidDirector(IBuilder builder)
        {
            _builder = builder;
            _builder.BuildHead();
            _builder.BuildTorso();
            _builder.BuildArms();
            _builder.BuildLegs();
            _builder.BuildProcessor();
            _builder.BuildSensors();
        }

        public IBuilder Builder { get => _builder; }
    }
}

    public class MemberBuilder
    {
        private string _name = "Fred";
        private State _state = State.Wa;
        private DateTime _dob = new DateTime(1970, 1, 1);

        public MemberBuilder InState(State state)
        {
            _state = state;
            return this;
        }

        public MemberBuilder WithDateOfBirth(DateTime dob)
        {
            _dob = dob;
            return this;
        }

        public MemberBuilder WithAge(int age, DateTime now)
        {
            _dob = now.AddYears(-age);
            return this;
        }

        public Member Build()
        {
            return new Member(_name, _state, _dob);
        }
    }

...


        [Test]
        [Combinatorial]
        public void GivenDemographicForMinimumAge_WhenCheckingIfTheDemographicApplies_ThenReturnTrueOnlyIfMemberIsMinAgeOrOlder
            ([Range(1, 25)] int memberAge, [Range(1, 25)] int minimumAge)
        {
            var member = new MemberBuilder().WithAge(memberAge, _now).Build();
            var demographic = new DemographicBuilder().WithMinimumAge(minimumAge).Build();

            var applies = demographic.Contains(member, _now);

            Assert.That(applies, Is.EqualTo(memberAge >= minimumAge));
        }


    static class ObjectMother
    {
        public static class Demographics
        {
            public static DemographicBuilder Blank
            {
                get { return new DemographicBuilder(); }
            }

            public static DemographicBuilder AllMembers
            {
                get { return new DemographicBuilder().ForAllMembers(); }
            }

            // No WA18And19YearOlds - too specific; unlikely to be reused

            ...
        }

        ...
    }

...


        [Test]
        [Combinatorial]
        public void GivenDemographicForMinimumAge_WhenCheckingIfTheDemographicApplies_ThenReturnTrueOnlyIfMemberIsMinAgeOrOlder
            ([Range(1, 25)] int memberAge, [Range(1, 25)] int minimumAge)
        {
            var member = ObjectMother.Members.Fred.WithAge(memberAge, _now).Build();
            var demographic = ObjectMother.Demographics.Blank.WithMinimumAge(minimumAge).Build();

            var applies = demographic.Contains(member, _now);

            Assert.That(applies, Is.EqualTo(memberAge >= minimumAge));
        }


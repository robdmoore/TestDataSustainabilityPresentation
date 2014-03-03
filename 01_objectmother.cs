    static class ObjectMother
    {
        public static class Demographics
        {
            public static Demographic AllMembers
            {
                get { return Demographic.AllMembers; }
            }

            public static Demographic WA18And19YearOlds
            {
                get { return new Demographic(State.Wa, 18, 19); }
            }

            ...
        }

        public static class Members
        {
            public static Member Fred
            {
                get { return new Member("Fred", State.Wa, new DateTime(1970, 1, 1)); }
            }

            public static Member WA18YearOld(DateTime now)
            {
                return new Member("18-Year-Old-in-WA", State.Wa, now.AddYears(-18));
            }

            ...
        }

        ...
    }

...


        [Test]
        public void GivenDemographicForAllMembers_WhenCheckingIfTheDemographicAppliesToAMember_ThenReturnTrue()
        {
            var member = ObjectMother.Members.Fred;
            var demographic = ObjectMother.Demographics.AllMembers;

            var applies = demographic.Contains(member, _now);

            Assert.That(applies, Is.True);
        }


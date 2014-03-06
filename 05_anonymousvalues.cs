﻿ 
        [Test]
        public void GivenPlatinumMember_WhenCalculatingDiscount_Return15PercentOfTotal()
        {
            const decimal anonymousSaleTotal = 200;
            const decimal expectedDiscount = anonymousSaleTotal * 0.15;
            var sale = ObjectMother.Sales.Default
                .WithTotal(anonymousSaleTotal)
                .ForMember(ObjectMother.Members.Platinum)
                .Build();
    
            var discount = new DiscountCalculator().Calculate(sale);

            Assert.That(discount, Is.EqualTo(expectedDiscount));
        }


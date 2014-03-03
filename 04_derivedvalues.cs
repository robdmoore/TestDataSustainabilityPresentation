 
        [Test]
        public void GivenPlatinumMember_WhenCalculatingDiscount_Return15PercentOfTotal()
        {
            var sale = ObjectMother.Sales.Default
                .WithTotal(200)
                .ForMember(ObjectMother.Members.Platinum)
                .Build();
    
            var discount = new DiscountCalculator().Calculate(sale);

            Assert.That(discount, Is.EqualTo(30));
        }


        vs


        [Test]
        public void GivenPlatinumMember_WhenCalculatingDiscount_Return15PercentOfTotal()
        {
            const decimal saleTotal = 200;
            const decimal expectedDiscount = saleTotal * 0.15;
            var sale = ObjectMother.Sales.Default
                .WithTotal(saleTotal)
                .ForMember(ObjectMother.Members.Platinum)
                .Build();
    
            var discount = new DiscountCalculator().Calculate(sale);

            Assert.That(discount, Is.EqualTo(expectedDiscount));
        }

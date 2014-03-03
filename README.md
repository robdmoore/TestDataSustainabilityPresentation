TestWest Presentation: Test Data re-usability and sustainability
================================================================

Overview
--------

It's fair to say that most line of business applications involve the capture, retrieval and/or manipulation of data. When testing these applications subtle variations in this data needs to be generated and specified in order to exercise the different business rules we need to implement and test. As an application grows in complexity being able to specify this data in a sustainable, understandable and maintainable manner becomes harder and requires diligence.

There are a number of useful techniques that can be leveraged to structure automated tests to keep a focus on the important parts of the data for a given test (keeping tests readable and maintainable), as well as providing a mechanism to generate data sustainably in a way that can be reused for unit tests, integration tests, automated UI tests as well as data-seeding for focussed manual testing.

The main focus of the presentation will be to demonstrate practical examples to generate object-oriented data and suggested practices for structuring tests using that data and will look into various patterns like object mother, test data builder, derived values and equivalence classes / anonymous values.

Further Reading
---------------

* [http://robdmoore.id.au/blog/2014/01/23/test-naming-automated-testing-series/](http://robdmoore.id.au/blog/2014/01/23/test-naming-automated-testing-series/)
* [http://robdmoore.id.au/blog/2013/05/26/test-data-generation-the-right-way-object-mother-test-data-builders-nsubstitute-nbuilder/](http://robdmoore.id.au/blog/2013/05/26/test-data-generation-the-right-way-object-mother-test-data-builders-nsubstitute-nbuilder/)
* [http://blog.ploeh.dk/2009/01/28/Zero-FrictionTDD/](http://blog.ploeh.dk/2009/01/28/Zero-FrictionTDD/)

Presentation
------------

This presentation was given to the [TestWest Conference](http://www.bankwest.com.au/testwest) held by [BankWest](http://www.bankwest.com.au/) on March 12 2014 at Perth Convention and Exhibition Centre.

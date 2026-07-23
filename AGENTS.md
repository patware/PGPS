Generate unit tests for this code using MSTest, FluentAssertions, and NSubstitute.

Requirements:
- Use MSTest attributes: [TestClass] and [TestMethod].
- Use FluentAssertions for assertions; avoid Assert.AreEqual/IsTrue/etc. unless unavoidable.
- Use NSubstitute for mocks/substitutes; do not use Moq.
- Follow Arrange / Act / Assert structure.
- Use clear test names in the form MethodName_WhenCondition_ReturnsExpectedResult.
- Cover the happy path, important edge cases, and failure/negative cases.
- Keep tests deterministic, isolated, and fast.
- Do not use real databases, file systems, network calls, clocks, or external services.
- If dependencies are hard to mock, identify the design issue before changing production code.
- Add any missing NuGet package references needed for MSTest, FluentAssertions, NSubstitute, and coverage.
- Ensure the tests run with dotnet test and Visual Studio Test Explorer.

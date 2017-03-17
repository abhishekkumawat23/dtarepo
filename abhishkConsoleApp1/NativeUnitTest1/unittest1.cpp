#include "stdafx.h"
#include "CppUnitTest.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace NativeUnitTest1
{		
	TEST_CLASS(UnitTest1)
	{
	public:
		
		TEST_METHOD(NativeAddTest)
		{
			int x = 4;
			int y = 5;
			int expectedResult = 9;

			Assert::AreEqual(x+y, expectedResult);
		}

	};
}
Feature: Calling a rescue coroutine when results complete with an error
	As a programmer
	In order to handle errors in completed results efficiently
	I want to execute a coroutine as a rescue

Scenario: The rescue coroutine is not invoked when the result completes normal
	Given an arbitrary result which completes normal
		* I want to rescue all errors with a coroutine
	When the result is executed
	Then the rescue coroutine is not invoked
		* the result does not get cancelled

Scenario: The rescue coroutine is not invoked when the result is cancelled
	Given an arbitrary result which gets cancelled
		* I want to rescue all errors with a coroutine	
	When the result is executed
	Then the rescue coroutine is not invoked
		* the result gets cancelled

Scenario: The rescue coroutine for all errors is invoked when the results completes with an error
	Given an arbitrary result which completes with an arbitrary error
		* I want to rescue all errors with a coroutine	
	When the result is executed
	Then the rescue coroutine is invoked on the arbitrary exception
		* the result gets cancelled
		
Scenario: The rescue coroutine for a specific error is invoked when the result completes with the specific error
	Given an arbitrary result which completes with an ArgumentException
		* I want to rescue ArgumentException errors with a coroutine
	When the result is executed
	Then the rescue coroutine is invoked on the ArgumentException
		* the result gets cancelled
		* the result completes without an error

Scenario: The rescue coroutine for a specific error is not invoked when the result completes with another error
	Given an arbitrary result which completes with an arbitrary error
		* I want to rescue ArgumentException errors with a coroutine
	When the result is executed
	Then the rescue coroutine is not invoked
		* the result does not get cancelled
		* the result completes with the arbitrary error

Scenario: When a rescue coroutine is executed, the result completes with the same error as the rescue coroutine
	Given an arbitrary result which completes with an arbitrary error
		* I want to rescue all errors with a coroutine that completes with an error
	When the result is executed
	Then the result completes with the same error as the coroutine
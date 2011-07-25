Feature: Calling a rescue action when results complete with an error
	As a programmer
	In order to handle errors in completed results efficiently
	I want to invoke an action as a rescue

Scenario: The rescue action is not invoked when the result completes
	Given an arbitrary result which completes
		* I want to rescue all errors with an action	
	When the result is executed
	Then the rescue action is not invoked
		* the result does not get cancelled

Scenario: The rescue action is not invoked when the result is cancelled
	Given an arbitrary result which gets cancelled
		* I want to rescue all errors with an action	
	When the result is executed
	Then the rescue action is not invoked
		* the result gets cancelled

Scenario: The rescue action for all errors is invoked when the results completes with an error
	Given an arbitrary result which completes with an arbitrary error
		* I want to rescue all errors with an action	
	When the result is executed
	Then the rescue action is invoked on the arbitrary exception
		* the result gets cancelled
		
Scenario: The rescue action for a specific error is invoked when the result completes with the specific error
	Given an arbitrary result which completes with an ArgumentException
		* I want to rescue ArgumentException errors with an action	
	When the result is executed
	Then the rescue action is invoked on the ArgumentException
		* the result gets cancelled
		* the result completes without an error

Scenario: The rescue action for a specific error is not invoked when the result completes with another error
	Given an arbitrary result which completes with an arbitrary error
		* I want to rescue ArgumentException errors with an action	
	When the result is executed
	Then the rescue action is not invoked
		* the result does not get cancelled
		* the result completes with the arbitrary error
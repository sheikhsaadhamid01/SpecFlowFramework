Feature: Search Testing

This feature helps to check the search functionality


Scenario: 01 Search Beta Testing
	Given User is on the page "https://www.yahoo.com"
	When User save value "Alfa Testing" with key "Testing"
	And User provides "Testing" to locator "//input[@id='ybar-sbq']"
	And User clicks object "//button[@type='submit']"


Scenario: 02 Search based on key
	Given User is on the page "https://www.yahoo.com"
	When User save value "Beta Testing" with key "Testing"
	And User fetch value of key "Testing" and enter to locator "//input[@id='yschsp']"
	And User clicks object "//input[@id='sbq-submit']"
	Then User close the browser


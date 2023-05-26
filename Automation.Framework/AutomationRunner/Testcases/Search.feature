Feature: Search

This feature helps to check the search functionality


Scenario: Search Automation testing
	Given User is on the page "https://www.yahoo.com"
	When User save value "QATesting" with key "Testing"
	And User provides "Automation Testing" to locator "//input[@id='ybar-sbq']"
	And User clicks object "//button[@type='submit']"


Scenario: Search based on key
	Given User is on the page "https://www.yahoo.com"
	When User save value "QATesting" with key "Testing"
	And User fetch value of key "Testing" and enter to locator "//input[@id='yschsp']"
	And User clicks object "//input[@id='sbq-submit']"
	Then User close the browser


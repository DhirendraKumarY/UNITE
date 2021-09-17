Feature: SearchLetter
	Search typed words on google chrome

@mytag
Scenario: Search words on google 
	Given Launch Google Chrome 
	And Navigate Google URL
	When Typed for search letter 
	Then Google has searced and quit
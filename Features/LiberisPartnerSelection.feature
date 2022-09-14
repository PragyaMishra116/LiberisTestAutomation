Feature: LiberisPartnerSelection
	On navigating to the URl, Get A Demo Page should be displayed.
	Partner Selection Page should be displayed on clicking Get A Demo button
	Expected Partners options should be displayed as radio button.
	I should not be able to click on Get A Demo button, without selecting a partner
	Expected error message should be displayed if partner is not selected.
	If I select a partner then respected Partner Type Page should be displayed on clicking Get A Demo button.



@PartnerSelectionPageNavigationAndPartnerTypeVerification
Scenario Outline: Three types of partners should be displayed in Partner Selection Page			
	Given I navigate to Liberis App
	And I am in Home Page 
	When I click on Get A Demo button
	Then Partner Selection Page should be displayed 
	And Three Types of partners should be displayed
	And Partners Types should be displayed as expected "<partnerTypes>"

Examples: 
	| partnerTypes |
	| I'm a Broker,I'm an ISO,I'm a Strategic Partner |


@NegativeTest
Scenario Outline: Expected error message should be displayed if partner is not selected.
	Given I am on Partner Selection Page
	When I click on Get A Demo button from Partner Selection Page
	Then Error message should be displayed as expected "<errorMsg>"
	

Examples: 
	| errorMsg |
	| Please select a type of partner |	


@PositiveTest
Scenario Outline: When I select any partner and click on Get A Demo button then I should be navigated to the expected page
	Given I am on Partner Selection Page
	When I select a partner "<partnerType>"
	And I click on Get A Demo button from Partner Selection Page
	Then Partnership Page should be displayed with correct heading "<pageHeading>"
	

Examples: 
	| partnerType | pageHeading                 |
	| ISO  | Partnership Opportunities |
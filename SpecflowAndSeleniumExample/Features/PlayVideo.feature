Feature: PlayVideo

@mytag

	Scenario: Play a video in youtube - Chrome
	Given I navigate to youtube on following enviroment
	| Browser | BrowserVersion | OS |
	| Chrome|  101.0.4951.54 | Windows 10|
	And I search for a video
	When I click the video 
	Then The video should be played
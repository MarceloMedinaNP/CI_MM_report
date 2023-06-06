Feature: Get posts

A short summary of the feature

@positive @smoke @regression @integration @JIRA-7777 
Scenario: Get by id 
	Given I have an id with value 17
	When I send a get request
	Then I expected a valid code response


@tag1 @smoke @Jira-5455
Scenario: Get all post
	Given I need verified ALL posts
	When I send a get ALL request
	Then I expected a valid get ALL code response


@tag1 @smoke @Jira-5455
Scenario: Get POST post
	Given I need verified POST posts
	When I send a get POST request
	Then I expected a valid get POST code response


@tag1 @smoke @Jira-5455
Scenario: Get PUT post
	Given I need verified PUT posts
	When I send a get PUT request
	Then I expected a valid get PUT code response



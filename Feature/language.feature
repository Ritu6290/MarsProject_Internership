Feature: Manage Languages
  As a user
  I want to add, edit, delete and cancel languages
  So that my profile is updated

  Scenario: 1. Add a new language
    Given I am logged into the application for languages
    When I add a new language "<language>" with level "<level>"
    Then the language should be added successfully

Examples: 
	| language         | level       |
	| English          | Basic       |
	

  Scenario: 2. Edit an existing language
    Given I am logged into the application for languages
    When I edit a language
    Then the language should be updated successfully

  Scenario: 3. Delete a language
    Given I am logged into the application for languages
    When I delete a language
    Then the language should be removed successfully

  Scenario: 4. Cancel a language
    Given I am logged into the application for languages
    When I Cancel a language
    Then the language should not be updated successfully

Feature: Manage skills
  As a user
  I want to add, edit, delete and cancel skills
  So that my profile is updated

  Scenario: 1. Add a new skill
    Given I am logged into the application for skills
    When I add a new skill
    Then the skill should be added successfully

  Scenario: 2. Edit an existing skill
    Given I am logged into the application for skills
    When I edit a skill
    Then the skill should be updated successfully

  Scenario: 3. Delete a skill
    Given I am logged into the application for skills
    When I delete a skill
    Then the skill should be removed successfully

  Scenario: 4. Cancel a skill
    Given I am logged into the application for skills
    When I cancel a skill
    Then the skill should not be updated successfully

Feature: Manage Languages
  As a user
  I want to add, edit, delete and cancel languages
  So that my profile is updated

  Scenario Outline: 1. Add language Validation
    Given I am logged into the application for languages
    When I add a new language "<language>" with level "<level>"
    Then I should see "<expectedMessage>"

Examples: 
    | language   | level            | expectedMessage                   |
    | English    | Basic            | added                             |
    | Marathi    | Conversational   | added                             |
    | Hindi      | Fluent           | added                             |
    | English    | Basic            | This language is already exist in your language list.|
    | English    | Conversational   | Duplicated data                   |
    | @@@@       | Basic            | added                             |# invalid character should fail but language gets added
    | 12345      | Conversational   | added                             |# invalid character should fail but language gets added
    | Spanish    | Native/Bilingual | added                             |
    | Language   | Basic            | maximum of 4 languages            |

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




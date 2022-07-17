Feature: HotlineTest

Background: Pre-Conditions
Given User go to 'HotLineEnv'

Scenario: User login on hotline resource 
	When User login with 'TestUserHotLine@gmail.com' email and 'TestUser' password
	Then User sees 'TestUser12' nickname instead of 'login' button

Scenario: User search any product
	When User set 'iqos' text to 'search bar'
	Then User check that 'iqos' product that added to personal list is displayed

Scenario: User select any filters for the found products
	When User set 'iqos' text to 'search bar'
	When User select 'IQOS' manufacturer
	When User select 'Електронні цигарки' sub-category
	When User select 'POD-система' filter for product
	And User select '900 і меньше' filter for product

Scenario: User add item to personal list 
	When User set 'iqos' text to 'search bar'
	When User clicks 'IQOS 3 DUO, The We Edition (DK000555.00)' product from 'search result' page
	When User add selected product to 'personal list'
	When User select 'Закладки' option from 'bookmark-list' dropdown
	When User clicks 'Зберегти' button in modal window
	When User go to 'personal list' from modal window
	Then User check that 'IQOS 3 DUO, The We Edition (DK000555.00)' product that added to personal list is displayed

Scenario:  User add items to compare 
	When User set 'iqos' text to 'search bar'
	When User select 'Електронні цигарки' sub-category
	When User add 'IQOS VEEV, Синий (DF001496.00)' product to 'compare'
	And User add 'IQOS VEEV, Графитовый (DF001497.00)' product to 'compare'
	When User clicks button by identifier '-compare'
	When User select 'Системи нагрівання тютюну' option from dropdown by dropdown class '-compare'
	Then User check that 'IQOS VEEV, Синий (DF001496.00)' product that added to comparison is displayed
	And User check that 'IQOS VEEV, Графитовый (DF001497.00)' product that added to comparison is displayed

Scenario: User sorts list of the found product
	When User set 'iqos' text to 'search bar'
	When User select 'Системи нагрівання тютюну' sub-category
	When User select 'новизною' option from 'select' dropdown
	Then User sees 'новизною' option for sorting selected previously

Scenario: User compare price for product in diffrent store 
	When User set 'iqos' text to 'search bar'
	When User clicks 'IQOS 3 DUO, черный (DK000495.00)' product from 'search result' page
	When User clicks 'compare price' button
	Then User sees list of the market with prices for selected product

Scenario: User search any category
	When User go to 'all categories'
	When User select 'Системи нагрівання тютюну' category by 'тютюн' item name from autocomplete
	Then User sees category header

Scenario: User check 'viewed product'
	When User set 'iqos' text to 'search bar'
	When User clicks 'IQOS 3 DUO, черный (DK000495.00)' product from 'search result' page
	When User clicks button by identifier '-listing'
	When User select 'Переглянуті товари' option from dropdown by dropdown class '-listings'
	Then User check that 'IQOS 3 DUO, черный (DK000495.00)' product that added to personal list is displayed

Scenario: User select another city
	When User clicks 'select city' button
	When User set 'Харків' city name to search bar
	When User select 'Харків,' city
	Then User sees 'Харків' city in geo tag
